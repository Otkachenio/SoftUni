setTimeout(function () {
    var index,
        len,
        countriesDiv = document.getElementById('countries'),
        countriesArr = countriesDiv.getElementsByTagName('a');

    len = countriesArr.length;
    for (index = 0; index < len; index++) {
        countriesArr[index].addEventListener('click', listTowns);
    }
    
    function listTowns() {
        document.getElementById('towns').innerHTML = '';
        var that = this;
        httpRequest.make({
            url: "https://baas.kinvey.com/appdata/kid_SynD60iI/town",
            contentType: 'application/json',
            accept: 'application/json',
            success: function (data) {
                var list,
                    i,
                    len,
                    town,
                    jsonData,
                    item;
                list = document.createElement('ul');
                jsonData = JSON.parse(data);
                len = jsonData.length;
                for (i = 0; i < len; i++) {
                    town = jsonData[i];
                    if (town.country === that.text) {
                        item = document.createElement('li');
                        item.innerHTML = town.name;
                        list.appendChild(item);

                        var button = document.createElement('button');
                        button.innerHTML = 'Delete Town';
                        button.id = town._id;
                        button.addEventListener('click', function () {
                            httpRequest.make({
                                url: 'https://baas.kinvey.com/appdata/kid_SynD60iI/town/' + this.id,
                                type: 'DELETE',
                                contentType: 'application/json'
                            });
                        });

                        list.appendChild(button)
                    }
                }

                document.getElementById('towns').appendChild(list);
            },
            error: function (err) {
                document.getElementById('towns').innerHTML = '<h2 style="color:red">ERROR</h2>';
            }
        });
    }
}, 1000);