from src.passwordvalidator import validatePassword, validatePasswordPartTwo

totalPartOne = 0
totalPartTwo = 0

for i in range(146810, 612564):
    if validatePassword(i, (14810, 612564)):
        totalPartOne += 1
    if validatePasswordPartTwo(i, (14810, 612564)):
        totalPartTwo += 1

print(totalPartOne)
print(totalPartTwo)

