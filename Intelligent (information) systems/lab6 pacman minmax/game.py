from time import sleep
import random
from tkinter import Tk, Canvas

SCORE_FOR_POINT = 100
BLOCK_SIZE = 20
PAC_SIZE = 3
ANIMATION_SPEED = 1
DEEP = 10
POINTS_COUNT = 0
field = []
X, Y = 21, 27
levels = [
    'level_1_0.txt',
    'level_1_1.txt',
    'level_1_2.txt',
    'level_1_3.txt',
]
pacman = (0, 0)
spirits = []

tk = Tk()
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

    for sp in sprts:
        canvas.create_arc( #малюємо привида
            sp[0]*BLOCK_SIZE + PAC_SIZE, sp[1]*BLOCK_SIZE + PAC_SIZE,
            (sp[0]+1)*BLOCK_SIZE - PAC_SIZE, (sp[1]+1)*BLOCK_SIZE - PAC_SIZE,
            start=200, extent=300, fill='blue', outline='blue'
        )

    tk.update()
    sleep(ANIMATION_SPEED)

#пошук у ширину
def bfs(spirit, trgt):
    paths = [[(spirit[0], spirit[1])]] #шляхи, по яких проходимо
    visited = [(spirit[0], spirit[1])] #відвідані вершини

    while paths:
        buf_paths = []
        
        #якщо на якомусь шляху потрапляємо в шукану вершину, повертаємо цей шлях
        for path in paths:
            if path[-1] == trgt:
                return path

        #інакше для кожного шляху переглядаємо всі досяжні вершини
        for path in paths:
            #досяжні вершини цього шляху
            next_node = [(path[-1][0]+1, path[-1][1]), (path[-1][0]-1, path[-1][1]),
                (path[-1][0], path[-1][1]+1), (path[-1][0], path[-1][1]-1)]
            
            #перевірка, чи можемо зайти в цю вершину
            for node in next_node:
                if node in visited:
                    continue
                if field[node[1]][node[0]] == 'X':
                    continue
                #якщо не відвідували та вершина доступна
                visited += [node] #позначаємо вершину відвіданою
                buf_paths.append(path+[node]) #додаємо шлях із новою вершиною
        
        paths = buf_paths
        #консольний вивід для дебагу
        #print('**********************************************************************')
        #print(*paths, sep='\n')

    return spirit #якщо дійшли сюди, то побудувати шлях не вийшло

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
    paths = [[point]]
    for _ in range(DEEP):
        buf_paths = []
        for path in paths:
            #досяжні вершини цього шляху
            next_nodes = [(path[-1][0]+1, path[-1][1]), (path[-1][0]-1, path[-1][1]),
                (path[-1][0], path[-1][1]+1), (path[-1][0], path[-1][1]-1)]
            
            #перевірка, чи можемо зайти в цю вершину
            for node in next_nodes:
                if field[node[1]][node[0]] == 'X':
                    continue
                buf_paths.append(path+[node]) #додаємо шлях із новою вершиною
            
            paths = buf_paths
    return [tuple(p) for p in paths]

def make_move():
    pacman_possible_moves = possible_moves(pacman)
    spirits_possible_moves = [possible_moves(spirit) for spirit in spirits]

    pac_benefit = {}
    for path in pacman_possible_moves:
        pac_benefit[path] = 0
        for point in path:
            if field[point[1]][point[0]] == '1':
                pac_benefit[path] += SCORE_FOR_POINT
        
        for spirit_possible_moves in spirits_possible_moves:
            for sp_path in spirit_possible_moves:
                die = False
                badleness = 0
                for i in range(len(sp_path)):
                    if path[i] == sp_path[i] or die:
                        die = True
                        badleness -= 1
                        pac_benefit[path] += badleness
                die = False
                badleness = 0
                for i in range(1, len(sp_path)):
                    if (path[i]==sp_path[i-1] and path[i-1]==sp_path[i]) or die:
                        die = True
                        badleness -= 1
                        pac_benefit[path] += badleness
    pacman_next = max(pac_benefit.keys(), key=lambda x: pac_benefit[x])

    spirits_next = []
    use_different_strategy = False
    for spirit_possible_moves in spirits_possible_moves:
        spirit_benefit = {}
        use_different_strategy = False if use_different_strategy else True
        if use_different_strategy:
            for path in spirit_possible_moves:
                spirit_benefit[path] = 0
                for pac_path in pacman_possible_moves:
                    eat = False
                    profit = 0
                    for i in range(len(pac_path)):
                        if path[i] == pac_path[i] or eat:
                            eat = True
                            profit += 1
                            spirit_benefit[path] += profit
                    eat = False
                    profit = 0
                    for i in range(1, len(pac_path)):
                        if (path[i]==pac_path[i-1] and path[i-1]==pac_path[i]) or eat:
                            eat = True
                            profit += 1
                            spirit_benefit[path] += profit
            max_profit = max(spirit_benefit.values())
            best_strategies = list(filter(lambda x: spirit_benefit[x]==max_profit, spirit_benefit.keys()))
            spirits_next.append(random.choice(best_strategies)[1])
        else:
            spirits_next.append(bfs(spirit_possible_moves[0][0], pacman)[1])

    return pacman_next[1], spirits_next


#######################################################################################

for level in levels:
    read_field(level)
    find_elems()
    PAC_ALIVE = True
    eated_points = 0

    if not PAC_ALIVE:
        sleep(2)
        break
    
    visual_move(pacman, spirits)
    while PAC_ALIVE:
        pacman_next, spirits_next = make_move()
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

