Object.prototype.extend = function (properties) {
    function f() { };
    f.prototype = Object.create(this);
    for (var prop in properties) {
        f.prototype[prop] = properties[prop];
    }
    f.prototype._super = this;
    return new f();
}

var shapeModule = (function () {
	var Shape = {
		init: function init(x, y, color) {
			this._x = x;
			this._y = y;
			this._color = color;
		}
	}
	
	var Circle = Shape.extend({
		init: function init(x, y, color, r) {
			this._super.init(x, y, color);
			this._r = r;
			
			return this;
		},
		toString: function() {
			var string = 'Circle: ';
			string += 'O(' + this._x + ', ' + this._y + '); ';
			string += 'Color = ' + this._color;
			
			return string;
		}
	});
	
	var Rectangle = Shape.extend({
		init: function init(x, y, color, width, height) {
			this._super.init(x, y, color);
			this._width = width;
			this._height = height;
			
			return this;
		},
		toString: function () {
			var string = 'Rectangle: ';
			string += 'A(' + this._x + ', ' + this._y + '); ';
			string += 'Width = ' + this._width + ' Height = ' + this._height;
			string += '; Color = ' + this._color;
			
			return string;
		}
	});
	
	var Triangle = Shape.extend({
		init: function init(aX, aY, color, bX, bY, cX, cY) {
			this._super.init(aX, aY, color);
			this._bX = bX;
			this._bY = bY;
			this._cX = cX;
			this._cY = cY;
			
			return this;
		},
		toString: function () {
			var string = 'Triangle: ';
			string += 'A(' + this._x + ', ' + this._y + '), ';
			string += 'B(' + this._bX + ', ' + this._bY + '), ';
			string += 'C(' + this._cX + ', ' + this._cY + '); ';
			string += 'Color = ' + this._color;
			
			return string;
		}		
	});
	
	var Line = Shape.extend({
		init: function init(aX, aY, color, bX, bY) {
			this._super.init(aX, aY, color);
			this._bX = bX;
			this._bY = bY;
			
			return this;
		},
		toString: function () {
			var string = 'Line: ';
			string += 'A(' + this._x + ', ' + this._y + '), ';
			string += 'B(' + this._bX + ', ' + this._bY + '), ';
			string += 'Color = ' + this._color;
			
			return string;
		}
	});
	
	var Segment = Shape.extend({
		init: function init(aX, aY, color, bX, bY) {
			this._super.init(aX, aY, color);
			this._bX = bX;
			this._bY = bY;
			
			return this;
		},
		toString: function () {
			var string = 'Segment: ';
			string += 'A(' + this._x + ', ' + this._y + '), ';
			string += 'B(' + this._bX + ', ' + this._bY + '), ';
			string += 'Color = ' + this._color;
			
			return string;
		}
	});
	
	return {
		Circle: Circle,
		Rectangle: Rectangle,
		Triangle: Triangle,
		Line: Line,
		Segment: Segment
	}
})();

var circle = Object.create(shapeModule.Circle);
circle.init(8, 10, '#00F', 5);
console.log(circle.toString());

var rectangle = Object.create(shapeModule.Rectangle);
rectangle.init(12, 15, '#F00', 10, 12);
console.log(rectangle.toString());

var triangle = Object.create(shapeModule.Triangle);
triangle.init(10, 13, '#FFF', 15, 18, 8, 11);
console.log(triangle.toString());

var line = Object.create(shapeModule.Line);
line.init(5, 5, '#FF4540', 20, 20);
console.log(line.toString());

var segment = Object.create(shapeModule.Segment);
segment.init(5, 11, '#CCC', 23, 18);
console.log(segment.toString());
