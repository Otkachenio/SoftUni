var countryNamesArr = [];
var countryIDsArr = [];

httpRequest.make({
    url: "https://baas.kinvey.com/appdata/kid_SynD60iI/country",
    contentType: 'application/json',
    accept: 'application/json',
    success: function (data) {
        var list,
            i,
            len,
            country,
            jsonData,
            item,
            link;
        list = document.createElement('ul');
        jsonData = JSON.parse(data);
        len = jsonData.length;
        for (i = 0; i < len; i++) {
            country = jsonData[i];
            item = document.createElement('li');
            link = document.createElement('a');
            link.innerHTML = country.name;
            link.href = '#';
            item.appendChild(link);
            list.appendChild(item);
            countryNamesArr.push(country.name);
            countryIDsArr.push(country._id);
        }

        document.getElementById('countries').appendChild(list);
    },
    error: function (err) {
        document.getElementById('countries').innerHTML = '<h2 style="color:red">ERROR</h2>';
    }
});