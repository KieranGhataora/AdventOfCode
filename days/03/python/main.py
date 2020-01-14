from src.distancecalc import manhattan_distance
from src.wirepathprocessor import get_list_of_points_from_wire_path, find_intersections


def run(instructionSets):
    processedSets = []

    for instructionSet in instructionSets:
        processedSets.append(get_list_of_points_from_wire_path(instructionSet.split(',')))

    intersections = find_intersections(processedSets[0][1:], processedSets[1][1:])

    # intersections = map(lambda a: list(filter(lambda b: b != (0, 0), a)), intersections)

    return min(map(lambda x: manhattan_distance((0, 0), x), intersections))


with open(r'../input.txt', 'r') as f:
    instructionSets = map(lambda x: x, f.readlines())

print(run(instructionSets))
