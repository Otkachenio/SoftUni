var app = app || {};

(function () {
    app.router = $.sammy(function () {
        var requester = app.requester.config('kid_r1ywmyuv', 'a8b7152fa0ad4f30b20a41e7034cf5ba');
        var selector = '#wrapper';

        var carModel = app.carsModel.load(requester);
        var carViewBag = app.carsView.load();
        var carController = app.carsController.load(carModel, carViewBag);

        this.get('#/', function () {
            carController.getAllCars(selector);
        });
    });

    app.router.run('#/');
})();
