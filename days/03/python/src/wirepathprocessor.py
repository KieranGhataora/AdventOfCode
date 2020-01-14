def get_list_of_points_from_wire_path(wirepath):
    list_of_points = [(0, 0)]
    for i in range(0, len(wirepath)):
        previouspoint = list_of_points[len(list_of_points) - 1]
        instruction = wirepath[i]
        direction = instruction[0]
        distance = int(instruction[1:]) + 1
        if direction == "R":
            for j in range(1, distance):
                list_of_points.append((previouspoint[0], previouspoint[1] + j))
        elif direction == "L":
            for j in range(1, distance):
                list_of_points.append((previouspoint[0], previouspoint[1] - j))
        elif direction == "U":
            for j in range(1, distance):
                list_of_points.append((previouspoint[0] + j, previouspoint[1]))
        elif direction == "D":
            for j in range(1, distance):
                list_of_points.append((previouspoint[0] - j, previouspoint[1]))
    return list_of_points


def find_intersections(pointsa, pointsb):
    intersections = []
    for i in pointsa:
        for j in pointsb:
            if i == j:
                intersections.append(i)
    return intersections
