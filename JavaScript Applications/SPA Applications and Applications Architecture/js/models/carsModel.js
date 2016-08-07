var app = app || {};

app.carsModel = (function () {
    function CarsModel(requester) {
        this.requester = requester;
        this.serviceUrl = requester.baseUrl +
            'appdata/' +
            this.requester.appId +
            '/cars'
    }

    CarsModel.prototype.getAllCars = function () {
        return this.requester.get(this.serviceUrl, true);
    };

    CarsModel.prototype.addNewCar = function (data) {
        return this.requester.post(this.serviceUrl, data, true);
    };

    return {
        load: function (requester) {
            return new CarsModel(requester);
        }
    }
})();