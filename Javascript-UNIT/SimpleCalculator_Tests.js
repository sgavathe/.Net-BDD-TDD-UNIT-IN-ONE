/// <reference path="../jasmine/jasmine.js" />
/// <reference path="SimpleCalculator.js" />
describe("SimpleMath_Test", function () {
	var sc = new SimpleCalculator();

	it("sum_test", function () {
		var num1 = 5;
		var num2 = 6;
		var expected = 14;
		var actual = sc.sum(num1, num2);
		expect(actual).toBe(expected);
	});

	it("square_test", function () {
		var num1 = 5;
		var expected = 25;
		var actual = sc.square(num1);
		expect(actual).toBe(expected);
	});
});