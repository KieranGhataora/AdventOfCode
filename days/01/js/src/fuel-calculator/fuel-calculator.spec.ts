import { calculateFuel, calculateFuelWithFuelWeighting} from "./fuel-calculator";

const calculateFuelTestInput = [[12, 2], [14, 2], [1969, 654], [100756, 33583]];
const calculateFuelForFuelTestInput = [[14, 2], [1969, 966], [100756, 50346]];

describe("calculateFuel should", () => {
    test.each(calculateFuelTestInput)("given %p return %p", (input, expected) => {
        expect(calculateFuel(input)).toEqual(expected);
    })
})

describe("calculateFuelForFuel should", () => {
    test.each(calculateFuelForFuelTestInput)("given %p return %p", (input, expected) => {
        expect(calculateFuelWithFuelWeighting(input)).toEqual(expected);
    })
})