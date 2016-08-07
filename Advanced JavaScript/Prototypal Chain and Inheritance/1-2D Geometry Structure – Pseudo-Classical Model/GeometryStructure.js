var Shape = (function () {
	function Shape(x, y, color) {
		this._x = x;
		this._y = y;
		this._color = color;
	}	
	
	var Circle = (function () {
		function Circle(x, y, color, radius) {
			Shape.call(this, x, y, color);
			this._radius = radius;
		}
		
		return Circle;
	})();
	
	Circle.prototype.toString = function () {
		var string = 'Circle: ';
		string += 'O(' + this._x + ', ' + this._y + ') ';
		string += 'r = ' + this._radius;
		string += ' Color: ' + this._color;
		
		return string;
	}
	
	var Rectangle = (function () {
		function Rectangle(x, y, color, width, height) {
			Shape.call(this, x, y, color);
			this._width = width;
			this._height = height;
		}
		
		return Rectangle;
	})();
	
	Rectangle.prototype.toString = function () {
		var string = 'Rectangle: ';
		string += 'A(' + this._x + ', ' + this._y + ') ';
		string += 'width = ' + this._width + '; height = ' + this._height;
		string += ' Color: ' + this._color;
		
		return string;
	}
	
	var Triangle = (function () {
		function Triangle(x, y, color, bX, bY, cX, cY) {
			Shape.call(this, x, y, color);
			this._bX = bX;
			this._bY = bY;
			this._cX = cX;
			this._cY = cY;
		}
		
		return Triangle;
	})();
	
	Triangle.prototype.toString = function () {
		var string = 'Triangle: ';
		string += 'A(' + this._x + ', ' + this._y + ') ';
		string += 'B(' + this._bX + ', ' + this._bY + ') ';
		string += 'C(' + this._cX + ', ' + this._cY + ') ';
		string += ' Color: ' + this._color;
		
		return string;
	}
	
	var Line = (function () {
		function Line(x, y, color, bX, bY) {
			Shape.call(this, x, y, color);
			this._bX = bX;
			this._bY = bY;
		}
		
		return Line;
	})();
	
	Line.prototype.toString = function () {
		var string = 'Line: ';
		string += 'A(' + this._x + ', ' + this._y + ') ';
		string += 'B(' + this._bX + ', ' + this._bY + ') ';
		string += ' Color: ' + this._color;
		
		return string;
	}
	
	var Segment = (function () {
		function Segment(x, y, color, bX, bY) {
			Shape.call(this, x, y, color);
			this._bX = bX;
			this._bY = bY;
		}
		
		return Segment;
	})();
	
	Segment.prototype.toString = function () {
		var string = 'Segment: ';
		string += 'A(' + this._x + ', ' + this._y + ') ';
		string += 'B(' + this._bX + ', ' + this._bY + ') ';
		string += ' Color: ' + this._color;
		
		return string;
	}
	
	return {
		Circle: Circle,
		Rectangle: Rectangle,
		Triangle: Triangle,
		Line: Line,
		Segment: Segment
	}
})();

var circle = new Shape.Circle(9, 10, "#00FF00", 8);
console.log(circle.toString());

var rectangle = new Shape.Rectangle(0, 0, "#AAA", 2, 4);
console.log(rectangle.toString());

var triangle = new Shape.Triangle(0, 0, "#ABC", 1, 1, 5, 8);
console.log(triangle.toString());

var line = new Shape.Line(0, 0, "#000", 1, 1);
console.log(line.toString());

var segment = new Shape.Segment(0, 1, "#F00", 2, 3);
console.log(segment.toString());