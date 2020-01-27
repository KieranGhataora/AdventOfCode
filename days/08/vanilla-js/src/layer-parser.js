parseLayers = (layers, width, height) => layers.match(new RegExp(`.{1,${width * height}}`, "g"))

countDigit = (layer, digit) => layer.match(new RegExp(`${digit}`, "g")).length

decodeLayers = (layers) => {
    let size = layers[0].length
    // Create a blank array
    let decodedImage = Array.apply(null, Array(size)).map(function () {})

    for(let i = 0; i < decodedImage.length; i ++)
    {
        for(let j = 0; j < layers.length; j++)
        {
            if(layers[j].charAt(i) != 2)
            {
                decodedImage[i] = layers[j].charAt(i);
                break;
            }
        }
    }

    return decodedImage.toString().replace(/,/g,'');
}