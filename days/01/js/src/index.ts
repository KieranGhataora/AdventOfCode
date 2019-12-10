import * as fs from "fs";

import {calculateFuel, calculateFuelWithFuelWeighting} from "./fuel-calculator/";

let inputs = fs.readFileSync('../input.txt', "utf8").split("\n").map(l => +l);

const partOne = (inputs: Array<number>): number =>
    inputs.map(calculateFuel).reduce((previous, curr) => curr + previous);


const partTwo = (inputs: Array<number>): number =>
    inputs.map(calculateFuelWithFuelWeighting)
        .reduce((previous, curr) => curr + previous);

console.log(partOne(inputs));
console.log(partTwo(inputs));

