import time

BLOCK_SIZE = 20

class Game:
    def __init__(self, field):
        self.X = len(field[0])
        self.Y = len(field)
        self.field = field
        self.find_elems()
    
    def find_elems(self):
        for x in range(self.X):
            for y in range(self.Y):
                if self.field[y][x] == 'P':
                    self.pacman = Pacman(x, y)
                elif self.field[y][x] == '1':
                    self.target = Target(x, y)

    def play(self):
        #print(f'\n\nResult:', *self.pacman.bfs(self.field, self.target), sep=' > ')
        print(f'\n\nResult:', *self.pacman.Astar(self.field, self.target), sep=' > ')


class Target:
    def __init__(self, x, y):
        self.x = x
        self.y = y
        print(f'Target x={x} y={y}')

class Pacman:
    def __init__(self, x, y):
        self.x = x
        self.y = y
        print(f'Pacman x={x} y={y}')
    
    #пошук у ширину
    def bfs(self, field, target):
        trgt = (target.x, target.y) #координати цілі
        paths = [[(self.x, self.y)]] #шляхи, по яких проходимо
        visited = [(self.x, self.y)] #відвідані вершини

        while True:
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
            print('**********************************************************************')
            print(*paths, sep='\n')

    #пошук у глибину
    def dfs(self, field, target):
        trgt = (target.x, target.y) #координати цілі
        path = [(self.x, self.y)] #шлях, по якому проходимо
        visited = [(self.x, self.y)] #відвідані вершини

        while True:
            #повертаємо шлях, якщо потрапили в шукану вершину
            if path[-1] == trgt:
                return path
            
            #шукаємо наступну досяжну вершину
            next_nodes =  [(path[-1][0]+1, path[-1][1]), (path[-1][0]-1, path[-1][1]),
                (path[-1][0], path[-1][1]+1), (path[-1][0], path[-1][1]-1)]
            for node in next_nodes:
                #якщо не були в цій вершині та вона доступна
                if node not in visited and field[node[1]][node[0]] != 'X':
                    visited += [node] #відмічаємо вершину відвіданою
                    path.append(node) #переходимо в неї
                    break #завершуємо ітерацію
            else:
                #якщо з теперішньої вершини не можемо перейти в наступну, то повертаємося назад
                path.pop()
                
            #консольний вивід для дебагу
            print(*path, sep=' > ')

    #евристика для А*
    def h(self, start, end):
        return (start[0]-end[0])**2 + (start[1]-end[1])**2
    #A*
    def Astar(self, field, target):
        trgt = (target.x, target.y) #координати цілі
        start = (self.x, self.y) #початкова вершина
        closed = [] #досліджені вершини
        open = [start] #відомі вершини
        route = {} #з якої вершини перейшли
        g = {start: 0} #ціна переходу
        f = {start: g[start] + self.h(start, trgt)} #ф-ція ціни маршруту

        while open:
            cur = min(open, key=lambda x: f[x]) #обираємо вершину з найменшим f

            if cur == trgt: #якщо потрапили в шукану вершину, відновлюємо шлях
                res = [trgt]
                while res[-1] != start:
                    res.append(route[res[-1]])
                return reversed(res)
            
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
                if neighbour not in open: #додаємо вершину до відомих
                    open.append(neighbour)

        return False #якщо дійшли сюди, то побудувати шлях не вийшло





def read_field(inp):
    with open(inp) as sr:
        x = sr.read().splitlines()
    field = [[s for s in line] for line in x]
    return Game(field)

game = read_field('test_field.txt')
print(*game.field, game.X, game.Y, sep='\n')
game.play()