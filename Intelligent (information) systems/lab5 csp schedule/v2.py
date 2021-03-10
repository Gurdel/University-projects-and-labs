from collections import namedtuple, defaultdict
from typing import List
from time import time as get_cur_time
from random import randint, shuffle
from copy import copy

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
DomainEl = namedtuple("DomainEl", "day time room")

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
    Lesson(teachers[0], subjects[0], groups[0:2], False, 1),
    Lesson(teachers[1], subjects[1], groups[0:6], True, 1),
    Lesson(teachers[1], subjects[1], groups[0:2], False, 1),
    Lesson(teachers[2], subjects[2], groups[0:2], True, 2),
    Lesson(teachers[2], subjects[2], groups[0:2], True, 1),
    Lesson(teachers[3], subjects[3], groups[0:2], True, 3),
    Lesson(teachers[3], subjects[3], groups[0:2], True, 2),
    Lesson(teachers[3], subjects[3], groups[0:2], True, 1),
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
    Lesson(teachers[8], subjects[7], groups[2:4], False, 1),
    Lesson(teachers[1], subjects[1], groups[2:4], False, 1),
    Lesson(teachers[11], subjects[8], groups[2:4], True, 2),
    Lesson(teachers[11], subjects[8], groups[2:4], True, 1),
    Lesson(teachers[12], subjects[9], groups[2:4], True, 2),
    Lesson(teachers[12], subjects[9], groups[2:4], True, 1),
    Lesson(teachers[10], subjects[10], groups[2:4], True, 2),
    Lesson(teachers[10], subjects[10], groups[2:4], True, 1),
    Lesson(teachers[7], subjects[5], groups[2], False, 1),
    Lesson(teachers[9], subjects[6], groups[3], False, 1),
    #  TK
    Lesson(teachers[13], subjects[11], groups[4:6], False, 1),
    Lesson(teachers[16], subjects[11], groups[4:6], True, 1),
    Lesson(teachers[1], subjects[1], groups[4:6], False, 1),
    Lesson(teachers[5], subjects[4], groups[4], False, 1),
    Lesson(teachers[6], subjects[4], groups[5], False, 1),
    Lesson(teachers[14], subjects[12], groups[4:6], True, 2),
    Lesson(teachers[14], subjects[12], groups[4:6], True, 1),
    Lesson(teachers[15], subjects[13], groups[4:6], False, 2),
    Lesson(teachers[15], subjects[13], groups[4:6], False, 1),
    Lesson(teachers[17], subjects[14], groups[4:6], True, 1),
    Lesson(teachers[7], subjects[5], groups[4], False, 1),
    Lesson(teachers[9], subjects[6], groups[5], False, 1),
]

#################################################################
def initialize_domains():
    domain = {}
    buf = []
    buf_lecture = []
    for day in weekdays.keys():
        for time in times.keys():
            for room in classrooms:
                buf.append(DomainEl(day, time, room))
                if room.is_big:
                    buf_lecture.append(DomainEl(day, time, room))
    for i in range(len(lessons)):
        if lessons[i].is_lecture:
            domain[i] = copy(buf_lecture)
        else:
            domain[i] = copy(buf)
    return domain

def mrv(domain):
    min_len = len(weekdays) * len(classrooms) * len(times) * 2
    ind = list(domain.keys())[0]
    for key, value in domain.items():
        if len(value) < min_len:
            min_len = len(value)
            ind = key
    return ind

def degree(domain):
    counts = {}
    for key in domain:
        counts[key] = 0 if lessons[key].is_lecture else 1
        for i in domain:
            if i == key:
                continue
            if lessons[key].teacher == lessons[i].teacher:
                counts[key] += 1
            counts[key] += len(set(map(str, lessons[key].group)) & set(map(str, lessons[i].group)))

    ind = list(counts.keys())[0]
    max = 0
    for key, value in counts.items():
        if value > max:
            max = value
            ind = key
    return ind

def lcv(domain):
    counts = {}
    for i in domain:
        counts[i] = 0
        for key in domain:
            if i == key:
                continue
            
            for d in domain[key]:
                if not (d.day==domain[i][0].day and d.time==domain[i][0].time and d.room==domain[i][0].room) and \
                    not (d.day==domain[i][0].day and d.time==domain[i][0].time and (lessons[key].teacher==lessons[i].teacher or \
                        set(map(str, lessons[key].group)) & set(map(str, lessons[i].group)))):
                    counts[i] += 1
    
    ind = list(counts.keys())[0]
    max = 0
    for key, value in counts.items():
        if value > max:
            max = value
            ind = key
    return ind

def forward_checking(domain):
    return list(domain.keys())[0]

def constraint_propagation(domain):
    for key in domain:
        if len(domain[key]) == 1:
            return key
    while True:
        i = randint(0, len(domain)-1)
        j = randint(0, len(domain)-1)

        i = list(domain.keys())[i]
        j = list(domain.keys())[j]

        if (lessons[i].teacher==lessons[j].teacher or \
            set(map(str, lessons[i].group)) & set(map(str, lessons[j].group))):
            #d_l = [len(x) for x in domain.values()]
            #print(*d_l, end='\n\n')
            if not len(domain[i]):
                return -1
            k = randint(0, len(domain[i])-1)
            if domain[i][k] in domain[j]:
                del domain[i][k]
            if len(domain[i]) == 1:
                return i

def backtrack(heuristic, domain, schedule):
    if not domain:
        return schedule
    ind = heuristic(domain)
    if ind == -1:
        return None
    for d in domain[ind]:
        sch_copy = copy(schedule)
        sch_copy.times.append(Time(d.day, d.time))
        sch_copy.classrooms.append(d.room)
        sch_copy.lessons.append(lessons[ind])
        
        dom_copy = copy(domain)
        dom_copy.pop(ind)
        dom_copy = update_domain(dom_copy, lessons[ind], d.day, d.time, d.room)

        res = backtrack(heuristic, dom_copy, sch_copy)
        if res:
            return res

    return None

def update_domain(domain, lesson, day, time, room):
    for key in domain:
        buf = []
        for d in domain[key]:
            if not (d.day==day and d.time==time and d.room==room) and \
                not (d.day==day and d.time==time and (lessons[key].teacher==lesson.teacher or \
                    set(map(str, lessons[key].group)) & set(map(str, lesson.group)))):
                buf.append(d)
        domain[key] = buf


    return domain

#################################################################
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

def test():
    #  Minimum Remaining Values
    start_time = get_cur_time()
    schedule = backtrack(mrv, initialize_domains(), Gene([], [], []))
    print(f"MRV: {get_cur_time()-start_time}")
    #  print_schedule(schedule)

    #  Least Constraining Value
    start_time = get_cur_time()
    schedule = backtrack(lcv, initialize_domains(), Gene([], [], []))
    print(f"LCV: {get_cur_time()-start_time}")
    #  print_schedule(schedule)

    #  Degree heuristic
    start_time = get_cur_time()
    schedule = backtrack(degree, initialize_domains(), Gene([], [], []))
    print(f"Degree: {get_cur_time()-start_time}")
    #  print_schedule(schedule)

    #  Forward checking
    start_time = get_cur_time()
    schedule = backtrack(forward_checking, initialize_domains(), Gene([], [], []))
    print(f"Forward: {get_cur_time()-start_time}")
    #  print_schedule(schedule)

    #  Constraint propagation
    start_time = get_cur_time()
    schedule = backtrack(constraint_propagation, initialize_domains(), Gene([], [], []))
    print(f"Constraint: {get_cur_time()-start_time}")
    #  print_schedule(schedule)

test()

