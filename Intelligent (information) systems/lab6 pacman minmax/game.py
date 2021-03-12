from time import time, sleep
import tracemalloc
from tkinter import Tk, Canvas

BLOCK_SIZE = 20
PAC_SIZE = 3
ANIMATION_SPEED = 0.1
DEEP = 5
POINTS_COUNT = 0
field = []
X, Y = 0, 0
levels = [
    'level_1_0.txt',
]
pacman = (0, 0)
spirits = []

def visual_path(path):
    tk = Tk()
    tk.title('Path visualization')
    tk.resizable(0, 0) #заборона зміни розміру
    tk.wm_attributes('-topmost', 1) #розміщуємо вікно зверху
    canvas = Canvas(tk, width=X*BLOCK_SIZE, height=Y*BLOCK_SIZE, highlightthickness=0)
    canvas.pack()
    tk.update()

    for point in path:
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
                else:
                    pass

        canvas.create_arc( #малюємо пакмена
            point[0]*BLOCK_SIZE + PAC_SIZE, point[1]*BLOCK_SIZE + PAC_SIZE,
            (point[0]+1)*BLOCK_SIZE - PAC_SIZE, (point[1]+1)*BLOCK_SIZE - PAC_SIZE,
            start=30, extent=300, fill='yellow', outline='yellow'
        )
                    
        canvas.create_oval( #малюємо ціль
            path[-1][0]*BLOCK_SIZE + 2*PAC_SIZE, path[-1][1]*BLOCK_SIZE + 2*PAC_SIZE,
            (path[-1][0]+1)*BLOCK_SIZE - 2*PAC_SIZE, (path[-1][1]+1)*BLOCK_SIZE - 2*PAC_SIZE,
            fill='orange', outline='green'
        )        

        tk.update()
        sleep(ANIMATION_SPEED)

#пошук у ширину
def bfs(self, field, target):
    iter_count = 0
    print('bfs') #консольний вивід для дебагу

    trgt = (target.x, target.y) #координати цілі
    paths = [[(self.x, self.y)]] #шляхи, по яких проходимо
    visited = [(self.x, self.y)] #відвідані вершини

    while paths:
        buf_paths = []
        
        #якщо на якомусь шляху потрапляємо в шукану вершину, повертаємо цей шлях
        for path in paths:
            if path[-1] == trgt:
                print(f'iterations count: {iter_count}')
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
                iter_count += 1
                visited += [node] #позначаємо вершину відвіданою
                buf_paths.append(path+[node]) #додаємо шлях із новою вершиною
        
        paths = buf_paths
        #консольний вивід для дебагу
        #print('**********************************************************************')
        #print(*paths, sep='\n')

    return False #якщо дійшли сюди, то побудувати шлях не вийшло

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
                pac_benefit[path] += 1
        
        for spirit_possible_moves in spirits_possible_moves:
            for sp_path in spirit_possible_moves:
                die = False
                badleness = -1
                for i in range(len(sp_path)):
                    if path[i] == sp_path[i] or die:
                        die = True
                        badleness -= 1
                        pac_benefit[path] += badleness
                die = False
                for i in range(1, len(sp_path)):
                    if path[i] == sp_path[i-1] or die:
                        die = True
                        badleness -= 1
                        pac_benefit[path] += badleness

    pacman_next = max(pac_benefit.keys(), key=lambda x: pac_benefit[x])

    #for spirit_possible_moves in spirits_possible_moves:


    return pacman_next[0], []


#######################################################################################

for level in levels:
    read_field(level)
    find_elems()
    PAC_ALIVE = True

    while PAC_ALIVE:
        pac_next, spirits_next = make_move()