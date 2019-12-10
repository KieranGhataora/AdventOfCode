const calculateFuelRec = (fuel: number): number =>
    fuel <= 0 ? 0 : fuel + calculateFuelRec(Math.floor((fuel / 3) - 2));

export const calculateFuel = (fuel: number): number => Math.floor(fuel / 3) - 2;

export const calculateFuelWithFuelWeighting = (fuel: number): number =>
    calculateFuelRec(calculateFuel(fuel));






