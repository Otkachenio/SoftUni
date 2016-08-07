(function () {
    var form = $('#form');
    var button = $('#button');
    var input = $('#nameField');
    var name;

    if (!localStorage['visitCount']) {
        localStorage.setItem('visitCount', 0);
    }

    if (!sessionStorage['visitCount']) {
        sessionStorage.setItem('visitCount', 0);
    }

    localStorage['visitCount']++;
    sessionStorage['visitCount']++;

    if (localStorage['name']) {
        form.hide();
        $('#greeting').text('Hello ' + localStorage['name']);
        
    } else {
        button.on('click', function () {
            name = input.val();
            localStorage.setItem('name', name);
        });
    }

    $('<div>').text('Local visits: ' + localStorage['visitCount']).appendTo('body');
    $('<div>').text('Session visits: ' + sessionStorage['visitCount']).appendTo('body');
})();