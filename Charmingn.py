print("AI test 1. type: quiz")

score = 0

q1 = input("What keyword is used to define a function in Python? ")
if q1.lower() == "def":
    score += 1
    print("Correct!")
else:
    print("Wrong. It is 'def'.")

q2 = input("What does AI stand for? ")
if q2.lower() == "artificial intelligence":
    score += 1
    print("Correct!")
else:
    print("Wrong. It is 'Artificial Intelligence'.")

q3 = input("In Python, what symbol is used for comments? ")
if q3 == "#":
    score += 1
    print("Correct!")
else:
    print("Wrong. It is '#'.")

q4 = input("What data type is used for True or False values? ")
if q4.lower() == "bool" or q4.lower() == "boolean":
    score += 1
    print("Correct!")
else:
    print("Wrong. It is 'bool'.")

q5 = input("If I say 'write a prompt', what am I asking you to do? ")
if "instruction" in q5.lower() or "question" in q5.lower():
    score += 1
    print("Correct!")
else:
    print("Not quite. A prompt is an instruction or question for an AI.")

print("Your final score is:", score, "/ 5")
if score == 5:
    print("Excellent!")
elif score >= 3:
    print("Good job!")
else:
    print("Keep practicing!")
