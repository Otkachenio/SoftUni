(function () {
    var router = Sammy(function () {
        var selector = '#div';

        this.get('#/', function () {
            $(selector).html('Home');
        });

        this.get('#/Pesho', function () {
            $(selector).html('Pesho');
            hello('Pesho');
            console.log(this);
        });

        this.get('#/Gosho', function () {
            $(selector).html('Gosho');
            hello('Gosho');
        });

        this.get('#/Martin', function () {
            $(selector).html('Martin');
            hello('Martin');
        });
    });

    function hello(name) {
        $('#div').append($('<h2>Hello ' + name + '</h2>'));
    }

    router.run('/#');
})();