def validatePassword(password, givenrange):
    string_password = str(password)

    if len(string_password) != 6:
        return False;

    if not (givenrange[0] < password < givenrange[1]):
        return False;

    if any(string_password[i] > string_password[i + 1] for i in range(5)):
        return False;

    if not any(string_password[i] == string_password[i + 1] for i in range(5)):
        return False;

    return True;


def validatePasswordPartTwo(password, given_range):
    string_password = str(password)

    if not (validatePassword(password, given_range)):
        return False

    matches = [string_password.count(characterSet) for characterSet in set(string_password)]

    if not any(match == 2 for match in matches):
        return False

    return True;


