from src.distancecalc import manhattan_distance
from src.wirepathprocessor import find_intersections, get_list_of_points_from_wire_path


def findClosestIntersection(instructionSets):
    processedSets = []

    for instructionSet in instructionSets:
        processedSets.append(get_list_of_points_from_wire_path(instructionSet.split(',')))

    intersections = find_intersections(processedSets[0][1:], processedSets[1][1:])

    return min(map(lambda x: manhattan_distance((0, 0), x), intersections))


def findEarliestIntersection(instructionSets):
    processedSets = []

    for instructionSet in instructionSets:
        processedSets.append(get_list_of_points_from_wire_path(instructionSet.split(',')))

    intersections = find_intersections(processedSets[0][1:], processedSets[1][1:])

    return min(map(lambda x: sum(map(lambda y: y.index(x), processedSets)), intersections))
