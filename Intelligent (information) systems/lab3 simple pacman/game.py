from time import time, sleep
import tracemalloc
from tkinter import Tk, Canvas

BLOCK_SIZE = 20
PAC_SIZE = 3
ANIMATION_SPEED = 0.1

def run_alg(func, arg={}):
    tracemalloc.start()
    func(**arg) if arg else func()
    snapshot = tracemalloc.take_snapshot()
    stats = snapshot.statistics('lineno')
    total = sum([s.size for s in stats])
    print(f"\tTotal memory usage: {total/10**3}MB")
    tracemalloc.stop()

class Game:
    def __init__(self, field):
        self.X = len(field[0])
        self.Y = len(field)
        self.field = field
        self.find_elems()

    def visual_path(self, path):
        tk = Tk()
        tk.title('Path visualization')
        tk.resizable(0, 0) #заборона зміни розміру
        tk.wm_attributes('-topmost', 1) #розміщуємо вікно зверху
        canvas = Canvas(tk, width=self.X*BLOCK_SIZE, height=self.Y*BLOCK_SIZE, highlightthickness=0)
        canvas.pack()
        tk.update()

        for point in path:
            canvas.delete("all")
            canvas.create_rectangle( #заливаємо повністю поверхню
                0, 0, self.X*BLOCK_SIZE, self.Y*BLOCK_SIZE,
                outline='#fb0', fill='#f50'
            )
            for x in range(self.X):
                for y in range(self.Y):
                    if self.field[y][x] == '.': #порожня клітинка
                        canvas.create_rectangle(
                            x*BLOCK_SIZE, y*BLOCK_SIZE, (x+1)*BLOCK_SIZE, (y+1)*BLOCK_SIZE,
                            fill='#4d443f', outline='black'
                        )
                    elif self.field[y][x] == 'X': #малюємо стіну
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

        #input()
        return True

    def test_visual(self):
        self.visual_path(self.pacman.bfs(self.field, self.target))
        self.visual_path(self.pacman.dfs(self.field, self.target))
        self.visual_path(self.pacman.Astar(self.field, self.target))
        self.visual_path(self.pacman.greedy(self.field, self.target))
    
    def find_elems(self):
        for x in range(self.X):
            for y in range(self.Y):
                if self.field[y][x] == 'P':
                    self.pacman = Pacman(x, y)
                    self.field[y][x] = '.'
                elif self.field[y][x] == '1':
                    self.field[y][x] = '.'
                    self.target = Target(x, y)

    def test_search(self):
        time_start = time()
        print(f'Result:', *self.pacman.bfs(self.field, self.target), sep=' > ')
        print(f'time: {time()-time_start}\n')
        time_start = time()
        print(f'Result:', *self.pacman.dfs(self.field, self.target), sep=' > ')
        print(f'time: {time()-time_start}\n')
        time_start = time()
        print(f'Result:', *self.pacman.Astar(self.field, self.target), sep=' > ')
        print(f'time: {time()-time_start}\n')
        time_start = time()
        print(f'Result:', *self.pacman.greedy(self.field, self.target), sep=' > ')
        print(f'time: {time()-time_start}\n')
        
    
    def test_memory(self):
        run_alg(self.pacman.bfs, {'field': self.field, 'target': self.target})
        run_alg(self.pacman.dfs, {'field': self.field, 'target': self.target})
        run_alg(self.pacman.Astar, {'field': self.field, 'target': self.target})
        run_alg(self.pacman.greedy, {'field': self.field, 'target': self.target})


class Target:
    def __init__(self, x, y):
        self.x = x
        self.y = y
        #print(f'Target x={x} y={y}') #консольний вивід для дебагу

class Pacman:
    def __init__(self, x, y):
        self.x = x
        self.y = y
        #print(f'Pacman x={x} y={y}') #консольний вивід для дебагу
    
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

    #пошук у глибину
    def dfs(self, field, target):
        iter_count = 0
        print('dfs') #консольний вивід для дебагу
        
        trgt = (target.x, target.y) #координати цілі
        path = [(self.x, self.y)] #шлях, по якому проходимо
        visited = [(self.x, self.y)] #відвідані вершини

        while path:
            #повертаємо шлях, якщо потрапили в шукану вершину
            if path[-1] == trgt:
                print(f'iterations count: {iter_count}')
                return path
            
            #шукаємо наступну досяжну вершину
            next_nodes =  [(path[-1][0]+1, path[-1][1]), (path[-1][0]-1, path[-1][1]),
                (path[-1][0], path[-1][1]+1), (path[-1][0], path[-1][1]-1)]
            for node in next_nodes:
                #якщо не були в цій вершині та вона доступна
                if node not in visited and field[node[1]][node[0]] != 'X':
                    visited += [node] #відмічаємо вершину відвіданою
                    path.append(node) #переходимо в неї
                    iter_count += 1
                    break #завершуємо ітерацію
            else:
                #якщо з теперішньої вершини не можемо перейти в наступну, то повертаємося назад
                path.pop()
                
            #консольний вивід для дебагу
            #print(*path, sep=' > ')
        
        return False #якщо дійшли сюди, то побудувати шлях не вийшло

    #евристика для А*
    def h(self, start, end):
        return ((start[0]-end[0])**2 + (start[1]-end[1])**2) ** 0.5
    #A*
    def Astar(self, field, target):

        iter_count = 0
        print('A*') #консольний вивід для дебагу

        trgt = (target.x, target.y) #координати цілі
        start = (self.x, self.y) #початкова вершина
        closed = [] #досліджені вершини
        open = [start] #відомі вершини
        route = {} #з якої вершини перейшли
        g = {start: 0} #ціна переходу
        f = {start: g[start] + self.h(start, trgt)} #ф-ція ціни маршруту

        while open:
            cur = min(open, key=lambda x: f[x]) #обираємо вершину з найменшим f
            #print(cur, f[cur]) #консольний вивід для дебагу

            if cur == trgt: #якщо потрапили в шукану вершину, відновлюємо шлях
                res = [trgt]
                while res[-1] != start:
                    res.append(route[res[-1]])
                print(f'iterations count: {iter_count}')
                return res[::-1]
            
            open.remove(cur)
            closed.append(cur)

            #досліджуємо всіх сусідів
            neighbours = [(cur[0]+1, cur[1]), (cur[0]-1, cur[1]), (cur[0], cur[1]+1), (cur[0], cur[1]-1)]
            for neighbour in neighbours:
                if field[neighbour[1]][neighbour[0]] == 'X': #не можемо перейти у вершину
                    continue
                if neighbour in closed: #вершина вже досліджена
                    continue

                #вартість переходу до нащадка
                temp_g = g[cur] + 1 #dist(cur, neigbour) == const == 1
                #якщо нащадок не відомий або шлях до нього через теперішню вершину дешевший
                #змінюємо маршрут
                if (neighbour not in open) or (temp_g < g[neighbour]):
                    route[neighbour] = cur
                    g[neighbour] = temp_g
                    f[neighbour] = g[neighbour] + self.h(neighbour, trgt)
                    iter_count += 1
                if neighbour not in open: #додаємо вершину до відомих
                    open.append(neighbour)

        return False #якщо дійшли сюди, то побудувати шлях не вийшло

    #жадібний алгоритм Дейкстрим
    def greedy(self, field, target):
        iter_count = 0
        print('greedy') #консольний вивід для дебагу

        trgt = (target.x, target.y) #координати цілі
        start = (self.x, self.y) #початкова вершина
        enable = {start} #вершини з вартістю переходу в них <inf
        visited = set()
        route = {} #з якої вершини перейшли
        d = {start: 0} #ціна шляху у вершину

        while enable:
            cur = min(enable-visited, key=lambda x: d[x]) #обираємо вершину, у якій ще не були, з найменшим d
            visited.add(cur)

            if cur == trgt: #якщо потрапили в шукану вершину, відновлюємо шлях
                res = [trgt]
                while res[-1] != start:
                    res.append(route[res[-1]])
                print(f'iterations count: {iter_count}')
                return res[::-1]

            #досліджуємо всіх сусідів
            neighbours = [(cur[0]+1, cur[1]), (cur[0]-1, cur[1]), (cur[0], cur[1]+1), (cur[0], cur[1]-1)]
            for neighbour in neighbours:
                #не можемо перейти у вершину
                if field[neighbour[1]][neighbour[0]] == 'X':
                    continue

                #вартість переходу до нащадка
                temp_d = d[cur] + 1 #dist(cur, neigbour) == const == 1
                #якщо шлях до нащадка через теперішню вершину дешевший
                #змінюємо маршрут
                #neighbour not in enable <=> d[neighbour]==inf
                if (neighbour not in enable) or (temp_d < d[neighbour]):
                    route[neighbour] = cur
                    d[neighbour] = temp_d
                    enable.add(neighbour)
                    iter_count += 1

        return False #якщо дійшли сюди, то побудувати шлях не вийшло





def read_field(inp):
    with open(inp) as sr:
        x = sr.read().splitlines()
    field = [[s for s in line] for line in x]
    return Game(field)

if __name__ == '__main__':
    game = read_field('big_field.txt')
    #print(*game.field, game.X, game.Y, sep='\n')
    game.test_memory()
    game.test_search()
    game.test_visual()