import random
import re

greetings = [
    'Hi!',
    'Hello!',
    'Nice to meet you!',
    'What\'s up, bro?',
    'How are you?',
]

answers = [
    'IDK',
    'Ask something else...',
    'Sorry, i\'m bot...',
    'Google this!',
]

standart = [
    '...',
    'omg',
    'Let\'s talk about something else',
    'Interesting!',
]

#.format(subj, verb, obj)
paraphrase = [
    'Why {0} {1} {2}?',
    '{0} really {1} {2}?',
]

def change(mess):
    mess = re.sub(r'\byour\b', 'my', mess)
    mess = re.sub(r'\byou\b', 'me', mess)
    mess = re.sub(r'\bi\b', 'you', mess)
    mess = re.sub(r'\bwe\b', 'you', mess)
    return mess

def parse(mess):
    #remove punctuation
    is_question = True if '?' in mess else False
    mess = mess.lower().strip()
    mess = re.sub(r'\W+', ' ', mess)

    #greeting
    if re.match(
        r'hi|hello|what s up|how are you|greetings|good',
        mess):
        return greetings[random.randrange(0, len(greetings))]
    
    #question
    if is_question or re.match(
        r'what|who|whom|whose|when|where|why|which',
        mess):
        return answers[random.randrange(0, len(answers))]

    parsed = re.match(r'(\w+)\s+(am|is|do|does|likes?|loves?|wants?)\s+(.+)', mess)
    if parsed:
        subj = change(parsed.group(1))
        obj = change(parsed.group(3))
        verb = 'are' if parsed.group(2)=='am' else parsed.group(2) if parsed.group(1) =='i' or parsed.group(1)=='we' else parsed.group(2)[:-1]
        if verb in 'is|was|were|will|should|must|shall|does|did|do|are':
            return paraphrase[random.randrange(0, len(paraphrase))].format(subj, verb, obj)
        else:
            aux = 'do' if subj == 'you' else 'does'
            return paraphrase[random.randrange(0, len(paraphrase))].format(aux+' '+subj, verb, obj)
    
    return standart[random.randrange(0, len(standart))]

#################################
while True:
    mess = input('User: ')
    if mess == "exit":
        break
    print('Bot:', parse(mess))
