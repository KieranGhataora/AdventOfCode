require("./layer-parser")

test('parses layers correctly', () => {
    expect(parseLayers("123456789012", 3, 2)).toStrictEqual(["123456", "789012"])
});

test('zero counter', () => {
    expect(countDigit("089493849040930843048904808340", 0)).toBe(8)
});

test('decodes layers properly', () => {
    expect(decodeLayers(["0222", "1122", "2212", "0000"])).toBe("0110")
})

