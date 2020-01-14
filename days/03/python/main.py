from src.circuitsolver import findClosestIntersection, findEarliestIntersection

with open(r'../input.txt', 'r') as f:
    instructionSets = list(map(lambda x: x, f.readlines()))

print(findClosestIntersection(instructionSets))
print(findEarliestIntersection(instructionSets))
