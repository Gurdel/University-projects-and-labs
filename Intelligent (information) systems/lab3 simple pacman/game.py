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
        print(f'\n\nResult:', *self.pacman.dfs(self.field, self.target), sep=' > ')


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



def read_field(inp):
    with open(inp) as sr:
        x = sr.read().splitlines()
    field = [[s for s in line] for line in x]
    return Game(field)

game = read_field('test_field.txt')
print(*game.field, game.X, game.Y, sep='\n')
game.play()