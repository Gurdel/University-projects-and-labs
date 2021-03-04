from collections import namedtuple
from random import choice, choices, randrange
from copy import deepcopy
from typing import List

START_POPULATION = 100
ELITE_POPULATION = 10
CHILDREN_PER_GENE = (START_POPULATION - ELITE_POPULATION) // ELITE_POPULATION
MAX_STEPS = 200

weekdays = {1: "Monday", 2: "Tuesday", 3: "Wednesday", 4: "Thursday", 5: "Friday"}
times = {1: "8:40-10:15", 2: "10:35-12:10", 3: "12:20-13:55", }

#  Main data classes
Classroom = namedtuple("Classroom", "room is_big")
Time = namedtuple("Time", "weekday time")
Teacher = namedtuple("Teacher", "name")
Subject = namedtuple("Subject", "name")
Group = namedtuple("Group", "name")
Lesson = namedtuple("Lesson", "teacher subject group is_lecture per_week")
Gene = namedtuple("Gene", "lessons classrooms times")

Classroom.__repr__ = lambda c: f"{c.room} ({'big' if c.is_big else 'small'})"
Teacher.__repr__ = lambda t: f"{t.name.split()[1]}"
Subject.__repr__ = lambda s: f"{s.name.split()[1]}"
Group.__repr__ = lambda g: f"{g.name}"
Lesson.__repr__ = lambda l: f"{l.teacher} | {l.subject} | {l.group} | " \
                            f"{'Lecture' if l.is_lecture else 'Seminar'} {l.per_week}/week"

def gen_repr(g: Gene):
    output = ""
    for i in range(len(g.lessons)):
        output += f"{g.lessons[i]},   {g.classrooms[i]},   {g.times[i]}\n"
    return output
Gene.__repr__ = lambda g: gen_repr(g)

#  Sample data for schedule
classrooms = [
    Classroom(43, True),
    Classroom(42, True),
    Classroom(41, True),
    Classroom(228, False),
    Classroom(217, False),
    Classroom(206, False),
    #  Classroom(205, False),
]

schedule = [Time(w, n) for w in range(1, len(weekdays.keys()) + 1)
            for n in range(1, len(times.keys()) + 1)]

teachers = [Teacher(name) for name in
            ("0 Kulyabko", "1 Bohdan", "2 Derev'yanchenko", "3 Ryabokon", "4 Glibovec", "5 Fedorus",
             "6 Taranuha", "7 Zarembovskyi", "8 Tymashov", "9 Vergunova", "10 Tkachenko", "11 Panchenko",
             "12 Shishatska", "13 Kondratyuk", "14 Trohimchuk", "15 Koval", "16 Pashko", "17 Krak", )]

subjects = [Subject(name) for name in
            ("0 Refactoring", "1 Pravo", "2 Paralelne", "3 ML", "4 IS", "5 Telecommunication",
             "6 Management", "7 Korektnist", "8 Rozrobka", "9 Specifikaciya", "10 SQL", "11 Neuronni",
             "12 Rozpiznavannya", "13 OS", "14 Interface", )]

groups = [Group(name) for name in
          ("MI-1", "MI-2", "TTP-1", "TTP-2", "TK-1", "TK-2", )]

lessons = [
    #  MI
    Lesson(teachers[0], subjects[0], groups[0:2], False, 2),
    Lesson(teachers[0], subjects[0], groups[0:2], False, 2),
    Lesson(teachers[1], subjects[1], groups[0:6], True, 1),
    Lesson(teachers[1], subjects[1], groups[0:2], False, 1),
    Lesson(teachers[2], subjects[2], groups[0:2], True, 2),
    Lesson(teachers[2], subjects[2], groups[0:2], True, 2),
    Lesson(teachers[3], subjects[3], groups[0:2], True, 3),
    Lesson(teachers[3], subjects[3], groups[0:2], True, 3),
    Lesson(teachers[3], subjects[3], groups[0:2], True, 3),
    Lesson(teachers[4], subjects[4], groups[0:6], True, 1),
    Lesson(teachers[5], subjects[4], groups[0], False, 1),
    Lesson(teachers[6], subjects[4], groups[1], False, 1),
    Lesson(teachers[7], subjects[5], groups[0:6:2], True, 1),
    Lesson(teachers[7], subjects[5], groups[0], False, 1),
    Lesson(teachers[8], subjects[6], groups[1:6:2], True, 1),
    Lesson(teachers[9], subjects[6], groups[1], False, 1),
    #  TTP
    Lesson(teachers[5], subjects[4], groups[2], False, 1),
    Lesson(teachers[5], subjects[4], groups[3], False, 1),
    Lesson(teachers[8], subjects[7], groups[2:4], False, 2),
    Lesson(teachers[8], subjects[7], groups[2:4], False, 2),
    Lesson(teachers[1], subjects[1], groups[2:4], False, 1),
    Lesson(teachers[11], subjects[8], groups[2:4], True, 2),
    Lesson(teachers[11], subjects[8], groups[2:4], True, 2),
    Lesson(teachers[12], subjects[9], groups[2:4], True, 2),
    Lesson(teachers[12], subjects[9], groups[2:4], True, 2),
    Lesson(teachers[10], subjects[10], groups[2:4], True, 2),
    Lesson(teachers[10], subjects[10], groups[2:4], True, 2),
    Lesson(teachers[7], subjects[5], groups[2], False, 1),
    Lesson(teachers[9], subjects[6], groups[3], False, 1),
    #  TK
    Lesson(teachers[13], subjects[11], groups[4:6], False, 1),
    Lesson(teachers[16], subjects[11], groups[4:6], True, 1),
    Lesson(teachers[1], subjects[1], groups[4:6], False, 1),
    Lesson(teachers[5], subjects[4], groups[4], False, 1),
    Lesson(teachers[6], subjects[4], groups[5], False, 1),
    Lesson(teachers[14], subjects[12], groups[4:6], True, 2),
    Lesson(teachers[14], subjects[12], groups[4:6], True, 2),
    Lesson(teachers[15], subjects[13], groups[4:6], False, 2),
    Lesson(teachers[15], subjects[13], groups[4:6], False, 2),
    Lesson(teachers[17], subjects[14], groups[4:6], True, 1),
    Lesson(teachers[7], subjects[5], groups[4], False, 1),
    Lesson(teachers[9], subjects[6], groups[5], False, 1),
]

###############################################################################################

def create_population(lessons_: List[Lesson], classrooms_: List[Classroom], times: List[Time]) -> List[Gene]:
    """Create starting population."""
    population = []
    for _ in range(START_POPULATION):
        g_rooms = choices(classrooms_, k=len(lessons_))
        g_times = choices(times, k=len(lessons_))
        population.append(Gene(lessons_, g_rooms, g_times))

    return population

GROUP_LESSONS_COUNT = sum([len(lesson.group) for lesson in lessons]) #  80
def heuristic(gene: Gene) -> int:
    """Value function for gene."""
    output = 0
    booked_rooms = set()
    teacher_times = set()
    group_time = set()
    for i in range(len(gene.lessons)):
        if gene.lessons[i].is_lecture and not gene.classrooms[i].is_big:
            output += 1
        teacher_times.add((gene.lessons[i].teacher, gene.times[i]))
        booked_rooms.add((gene.classrooms[i], gene.times[i]))
        group_time.update([(str(gr), gene.times[i]) for gr in gene.lessons[i].group])
    output += (len(gene.lessons) - len(booked_rooms))
    output += (len(gene.lessons) - len(teacher_times))
    output += GROUP_LESSONS_COUNT - len(group_time)
    return output


def mutate(gene: Gene, classrooms_: List[Classroom], times: List[Time]) -> Gene:
    """Make random mutations."""
    gene = deepcopy(gene)
    rand_class = randrange(0, len(gene.lessons))
    rand_time = randrange(0, len(gene.lessons))
    gene.classrooms[rand_class] = choice(classrooms_)
    gene.times[rand_time] = choice(times)
    return gene


def children(gens: List[Gene], classrooms_, times):
    new_pop = []
    for g in gens:
        for _ in range(CHILDREN_PER_GENE):
            new_pop.append(mutate(g, classrooms_, times))
    return new_pop

def print_schedule(solution: Gene, ):
    for day in weekdays:
        print('\n' + '=' * 100)
        print(f"{weekdays[day].upper()}")
        for time in times:
            print('\n\n' + times[time])
            for c in classrooms:
                print(f'\n{c}', end='\t\t')
                for i in range(len(solution.lessons)):
                    if solution.times[i].weekday == day and solution.times[i].time == time and \
                            solution.classrooms[i].room == c.room:
                        print(solution.lessons[i], end='')
                        
population = create_population(lessons, classrooms, schedule)

steps = 0
while heuristic(population[0]) and MAX_STEPS-steps:
    population.sort(key=heuristic)
    population = population[:ELITE_POPULATION]
    population += children(population, classrooms, schedule)
    steps += 1
    print(steps)

solution = population[0]
print_schedule(solution)

print(f'\n((((((((((((((((((((((((((((((((((((((({heuristic(solution)}))))))))))))))))))))))))))))))))))))))))))))))))')