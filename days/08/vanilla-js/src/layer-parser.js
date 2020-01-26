parseLayers = (layers, width, height) => layers.match(new RegExp(`.{1,${width * height}}`, "g"))


countDigit = (layer, digit) => layer.match(new RegExp(`${digit}`, "g")).length