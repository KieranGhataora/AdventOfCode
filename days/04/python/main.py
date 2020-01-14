from src.passwordvalidator import validatePassword

total = 0

for i in range(146810, 612564):
    if validatePassword(i, (14810, 612564)):
        total += 1

print(total)
