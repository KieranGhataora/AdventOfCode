def validatePassword(password, givenrange):
    stringPassword = str(password)

    if len(stringPassword) != 6:
        return False;

    if not (givenrange[0] < password < givenrange[1]):
        return False;

    if any(stringPassword[i] > stringPassword[i+1] for i in range(5)):
        return False;

    if not any(stringPassword[i] == stringPassword[i+1] for i in range(5)):
        return False;

    return True;
