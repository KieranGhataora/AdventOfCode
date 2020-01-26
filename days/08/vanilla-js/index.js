require("./src/layer-parser")
let fs = require('fs');
let width= 25;
let height = 6;

let input = fs.readFileSync('../input.txt').toString();

let layers = parseLayers(input, width, height);

let sortedLayers = layers.sort((x, y) => countDigit(x, 0) - countDigit(y, 0))

console.log(countDigit(sortedLayers[0], 1)*countDigit(sortedLayers[0], 2));