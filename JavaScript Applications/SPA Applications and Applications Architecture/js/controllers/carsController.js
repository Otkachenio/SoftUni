var app = app || {};

app.carsController = (function () {
    function CarsController(model, viewBag) {
        this._model = model;
        this._viewBag = viewBag;
    }

    CarsController.prototype.getAllCars = function (selector) {
        var _this = this;
        this._model.getAllCars()
            .then(function (cars) {
                var result = {
                    cars: []
                };

                cars.forEach(function (car) {
                    result.cars.push(new CarInputModel(car.brand, car.model, car.year));
                });

                _this._viewBag.showCars(selector, result);
            }).done();
    };

    CarsController.prototype.addNewCar = function (data) {
        var _this = this,
            carOutputModel = {
                brand: data.brand,
                model: data.model,
                year: data.year
            };

        this._model.addNewCar(carOutputModel)
            .then(function () {
                _this.getAllCars();
            });
    };

    return {
        load: function (model, viewBag) {
            return new CarsController(model, viewBag);
        }
    }
})();