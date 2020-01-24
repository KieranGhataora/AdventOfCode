import json


class Planet:
    def __init__(self, name, planets):
        self.name = name,
        self.planets = planets
        self.root = True

    def toJSON(self):
        return json.dumps(self, default=lambda o: o.__dict__,
                          sort_keys=True, indent=4)
