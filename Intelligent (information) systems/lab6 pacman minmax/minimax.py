from time import sleep
import random
from tkinter import Tk, Canvas

SCORE_FOR_POINT = 5    #    Винагорода за з'їдену ціль
RANDOM_MOVE = 5    #    К-сть ходів привидів перед рандомним ходом одного з них
BADLENESS = 9    #    Штраф за смерть пакмена
SPIRIT_PROFIT = 2    #    Винагорода за з'їденого пакмена
INF = 99999999999999999999999999999999999999999999999
BLOCK_SIZE = 20    #    Розмір блоку для візуалізації
PAC_SIZE = 3    #    На скільки пікселів пакмен менший блоків
ANIMATION_SPEED = 0.5    #    Час затримки між кроками
DEEP = 10    #    Глибина пошуку стратегій
POINTS_COUNT = 0    #    К-сть точок на рівні, які треба з'їсти
eated_points = 0    #    К-сть з'їдених точок
random_move_counter = 0    #    К-сть зроблених кроків привидами
field = []    #    Поле
X, Y = 21, 27    #    Розміри поля
levels = [
    'level_1_0.txt',
    #'level_1_1.txt',    #    На цьому рівні пакмен точно програє
    'level_1_2.txt',
    'level_1_3.txt',
    'level_2_0.txt',
    'level_2_1.txt',
    'level_2_2.txt',
]
pacman = (0, 0)    #    Координати пакмена
spirits = []    #    Координати привидів

tk = Tk()    #    Діч для графіки
tk.title('Pacman')
tk.resizable(0, 0) #заборона зміни розміру
tk.wm_attributes('-topmost', 1) #розміщуємо вікно зверху
canvas = Canvas(tk, width=X*BLOCK_SIZE, height=Y*BLOCK_SIZE, highlightthickness=0)
canvas.pack()
tk.update()

def visual_move(pcmn, sprts):
    canvas.delete("all")
    canvas.create_rectangle( #заливаємо повністю поверхню
        0, 0, X*BLOCK_SIZE, Y*BLOCK_SIZE,
        outline='#fb0', fill='#f50'
    )
    for x in range(X):
        for y in range(Y):
            if field[y][x] == '.': #порожня клітинка
                canvas.create_rectangle(
                    x*BLOCK_SIZE, y*BLOCK_SIZE, (x+1)*BLOCK_SIZE, (y+1)*BLOCK_SIZE,
                    fill='#4d443f', outline='black'
                )
            elif field[y][x] == 'X': #малюємо стіну
                canvas.create_rectangle(
                    x*BLOCK_SIZE, y*BLOCK_SIZE, (x+1)*BLOCK_SIZE, (y+1)*BLOCK_SIZE,
                    fill='black', outline='blue'
                )
            elif field[y][x] == '1':                
                canvas.create_oval( #малюємо ціль
                    x*BLOCK_SIZE + 2*PAC_SIZE, y*BLOCK_SIZE + 2*PAC_SIZE,
                    (x+1)*BLOCK_SIZE - 2*PAC_SIZE, (y+1)*BLOCK_SIZE - 2*PAC_SIZE,
                    fill='orange', outline='green'
                )
            else:
                pass

    canvas.create_arc( #малюємо пакмена
        pcmn[0]*BLOCK_SIZE + PAC_SIZE, pcmn[1]*BLOCK_SIZE + PAC_SIZE,
        (pcmn[0]+1)*BLOCK_SIZE - PAC_SIZE, (pcmn[1]+1)*BLOCK_SIZE - PAC_SIZE,
        start=30, extent=300, fill='yellow', outline='yellow'
    )

    colors = ['blue', 'pink', 'gray', ]
    for i in range(len(sprts)):
        canvas.create_arc( #малюємо привида
            sprts[i][0]*BLOCK_SIZE + PAC_SIZE, sprts[i][1]*BLOCK_SIZE + PAC_SIZE,
            (sprts[i][0]+1)*BLOCK_SIZE - PAC_SIZE, (sprts[i][1]+1)*BLOCK_SIZE - PAC_SIZE,
            start=300, extent=300, fill=colors[i], outline=colors[i]
        )

    tk.update()
    sleep(ANIMATION_SPEED)

def read_field(inp):
    global field
    global X
    global Y

    with open(inp) as sr:
        x = sr.read().splitlines()
    field = [[s for s in line] for line in x]
    
    X = len(field[0])
    Y = len(field)

def find_elems():
    global pacman
    global spirits
    global POINTS_COUNT

    POINTS_COUNT = 0
    spirits = []

    for x in range(X):
        for y in range(Y):
            if field[y][x] == 'P':
                pacman = (x, y)
                field[y][x] = '.'
            elif field[y][x] == '1':
                POINTS_COUNT += 1
            elif field[y][x] == 'S':
                field[y][x] = '.'
                spirits.append((x, y))

def possible_moves(point):
    #досяжні вершини цього шляху
    next_nodes = [(point[0]+1, point[1]), (point[0]-1, point[1]),
        (point[0], point[1]+1), (point[0], point[1]-1)]
    return [node for node in next_nodes if field[node[1]][node[0]]!='X']

def minimax(position, depth=0, maximizing=True, score=0, prev_pos=()):
    stop_game = False
    if prev_pos and depth%2==0:
        for i in range(len(position[1])):
            if position[1][i] == position[0] or \
                    (position[1][i]==prev_pos[0] and prev_pos[1][i]==position[0]):
                stop_game = True
                score -= BADLENESS**(DEEP-depth)

    if depth % 2 == 0:
        prev_pos = position
    
    if field[position[0][1]][position[0][0]] == '1':
        score += SCORE_FOR_POINT
        if eated_points + score//SCORE_FOR_POINT >= POINTS_COUNT:
            score += SCORE_FOR_POINT**(DEEP-depth)
            stop_game = True

    if depth==DEEP or stop_game:
        return (score, position[0], position[1])

    if maximizing:  #   This is pacman's move
        pac_benefit = {move: minimax((move, position[1]), depth+1, False, score, prev_pos)[0] \
            for move in possible_moves(position[0])}
        max_benefit = max(pac_benefit.values())
        best_strategies = list(filter(lambda x: pac_benefit[x]==max_benefit, pac_benefit.keys()))
        pacman_next = random.choice(best_strategies)
        return (max_benefit, pacman_next, position[1])
    else:   #   This is spirits move
        sp_pos_moves = [[]]
        for spirit in position[1]:
            buf = []
            for move in possible_moves(spirit):
                buf += [m+[move] for m in sp_pos_moves]
            sp_pos_moves = buf
        sp_benefit = {tuple(move): minimax((position[0], move), depth+1, True, score, prev_pos)[0] \
            for move in sp_pos_moves}
        min_benefit = min(sp_benefit.values())
        best_strategies = list(filter(lambda x: sp_benefit[x]==min_benefit, sp_benefit.keys()))
        sp_next = random.choice(best_strategies)
        return (min_benefit, position[0], sp_next)
    return (score, pacman, spirits)

def alpha_beta(position, depth=0, maximizing=True, score=0, prev_pos=(), alpha=-INF, beta=INF):
    stop_game = False
    if prev_pos and depth%2==0:
        for i in range(len(position[1])):
            if position[1][i] == position[0] or \
                    (position[1][i]==prev_pos[0] and prev_pos[1][i]==position[0]):
                stop_game = True
                score -= BADLENESS**(DEEP-depth)

    if depth % 2 == 0:
        prev_pos = position
    
    if field[position[0][1]][position[0][0]] == '1':
        score += SCORE_FOR_POINT
        if eated_points + score//SCORE_FOR_POINT >= POINTS_COUNT:
            score += SCORE_FOR_POINT**(DEEP-depth)
            stop_game = True

    if depth==DEEP or stop_game:
        return (score, position[0], position[1])

    if maximizing:  #   This is pacman's move
        max_eval = -INF
        pac_benefit = {}
        for move in possible_moves(position[0]):
            ev = alpha_beta((move, position[1]), depth+1, False, score, prev_pos, alpha, beta)[0]
            pac_benefit[move] = ev
            max_eval = max(max_eval, ev)
            alpha = max(alpha, ev)
            if beta <= alpha:
                break
        
        max_benefit = max(pac_benefit.values())
        best_strategies = list(filter(lambda x: pac_benefit[x]==max_benefit, pac_benefit.keys()))
        pacman_next = best_strategies[0] if len(best_strategies)!=len(pac_benefit) else random.choice(best_strategies)
        return (max_eval, pacman_next, position[1])
    
    else:   #   This is spirits move
        sp_pos_moves = [[]]
        for spirit in position[1]:
            buf = []
            for move in possible_moves(spirit):
                buf += [m+[move] for m in sp_pos_moves]
            sp_pos_moves = buf
        
        min_eval = INF
        sp_benefit = {}
        for move in sp_pos_moves:
            ev = alpha_beta((position[0], move), depth+1, True, score, prev_pos, alpha, beta)[0]
            sp_benefit[tuple(move)] = ev
            min_eval = min(min_eval, ev)
            beta = min(beta, ev)
            if beta <= alpha:
                break
        
        min_benefit = min(sp_benefit.values())
        best_strategies = list(filter(lambda x: sp_benefit[x]==min_benefit, sp_benefit.keys()))
        sp_next = best_strategies[0] if len(best_strategies)!=len(sp_benefit) else random.choice(best_strategies)
        return (min_eval, position[0], sp_next)
    return (score, pacman, spirits)

#######################################################################################  
PAC_ALIVE = True
for level in levels:
    read_field(level)
    find_elems()
    eated_points = 0

    if not PAC_ALIVE:
        sleep(2)
        break
    
    visual_move(pacman, spirits)
    while PAC_ALIVE:
        f = alpha_beta
        pacman_next = f((pacman, spirits))[1]
        spirits_next = f((pacman, spirits), maximizing=False)[2]

        if field[pacman_next[1]][pacman_next[0]] == '1':
            eated_points += 1
            field[pacman_next[1]][pacman_next[0]] = '.'
            if eated_points >= POINTS_COUNT:
                visual_move(pacman_next, spirits)
                sleep(2)
                break
        
        for i in range(len(spirits_next)):
            if pacman_next == spirits_next[i] or \
                (pacman_next==spirits[i] and pacman==spirits_next[i]):
                PAC_ALIVE = False

        pacman = pacman_next
        spirits = spirits_next
        visual_move(pacman_next, spirits_next)

