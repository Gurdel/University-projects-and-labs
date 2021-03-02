from collections import namedtuple
from typing import List
import time

weekdays = {1: "Monday", 2: "Tuesday", 3: "Wednesday", 4: "Thursday", }
times = {1: "8:40-10:15", 2: "10:35-12:10", 3: "12:20-13:55", }

# Main data classes
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
Group.__repr__ = lambda g: f"{g.name.split()[1]}"
Lesson.__repr__ = lambda l: f"{l.teacher} | {l.subject} | {l.group} | " \
                            f"{'Lecture' if l.is_lecture else 'Seminar'} {l.per_week}/week"

def gen_repr(g: Gene):
    output = ""
    for i in range(len(g.lessons)):
        output += f"{g.lessons[i]},   {g.classrooms[i]},   {g.times[i]}\n"
    return output
Gene.__repr__ = lambda g: gen_repr(g)

# Semple data for schedule
classrooms = [
    Classroom(43, True),
    Classroom(42, True),
    Classroom(41, True),
    Classroom(228, False),
    Classroom(217, False),
    Classroom(206, False),
    #Classroom(205, False),
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
          ("0 MI-1", "1 MI-2", "2 TTP-1", "3 TTP-2", "4 TK-1", "5 TK-2", )]

lessons = [
    #MI
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
    #TTP
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
    #TK
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

#############################################################
def mrv(pool: List[Lesson]) -> Gene:
    """Minimum Ramaining Value"""
    schedule = Gene([], [], [])

    for lesson in pool:
        found = False
        for day in weekdays:
            if found: break
            for time in times:
                if found: break
                for room in classrooms:
                    duplicate = False
                    for i in range(len(schedule.lessons)):
                        # if room is booked at this time or teacher is busy
                        if (schedule.times[i].weekday == day and schedule.times[i].time == time) and \
                                (schedule.classrooms[i].room == room.room or schedule.lessons[i].teacher.name == lesson.teacher.name):
                            duplicate = True
                    if duplicate: continue
                    if found: break
                    if not lesson.is_lecture or room.is_big:
                        chosen_time = Time(day, time)
                        classroom = Classroom(room.room, room.is_big)
                        found = True
                        schedule.times.append(chosen_time)
                        schedule.classrooms.append(classroom)
                        schedule.lessons.append(lesson)

    assert len(pool) == len(schedule.lessons)
    return schedule

def test():
    lessons.sort(key=lambda l: 0 if l.is_lecture else 1)

    #  MRV
    time_start = time.time()
    schedule = mrv(lessons)
    print(f"MRV: {time.time()-time_start}")
    #  print_schedule(schedule)

test()

