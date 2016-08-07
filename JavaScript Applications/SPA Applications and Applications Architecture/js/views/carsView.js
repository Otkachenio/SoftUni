var app = app || {};

app.carsView = (function () {
    function showCars(selector, data) {
        $.get('templates/cars.html', function (templ) {
            var rendered = Mustache.render(templ, data);
            $(selector).html(rendered);
        });
    }

    return {
        load: function () {
            return {
                showCars: showCars
            }
        }
    }
})();