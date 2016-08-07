$.get('template.html', function (template) {
    (function () {
        var request;
        request = new XMLHttpRequest();

        request.open('GET', 'https://baas.kinvey.com/appdata/kid_r1ywmyuv/Peoples', true);
        request.setRequestHeader('Authorization', 'Basic T3RrYWNoZW5pbzoxMjM0NQ==');
        request.setRequestHeader('Content-Type', 'application/json');
        request.setRequestHeader('Accept', 'application/json');

        request.onreadystatechange = function () {
            if (request.readyState === 4) {
                switch (Math.floor(request.status / 100)) {
                    case 2:
                        success(request.responseText, template);
                        break;
                    default:
                        error(request.responseText);
                        break;
                }
            }
        }

        request.send();
    })();
});

function success(data, template) {
    var dataArr = JSON.parse(data);
    var peoplesArr = [];
    for (var i in dataArr) {
        peoplesArr.push({
            'Name': dataArr[i].Name,
            'Job Title': dataArr[i]['Job Title'],
            'Website': dataArr[i].Website
        });
    }

    var peoples = {
        "peoples": peoplesArr
    }

    var outputHtml = Mustache.render(template, peoples);
    $('#wrapper').html(outputHtml);
}

function error(err) {
    console.error(err);
}