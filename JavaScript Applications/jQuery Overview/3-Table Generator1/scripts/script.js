function generateTabler(jsonStr) {
    var index, i;
    var headers = [];
    var items = [];
    var counter = 0;

    for (index = 0; index < jsonStr.length; index++) {
        var row = jsonStr[index];
        for (var key in row) {
            counter++;
            if (headers.indexOf(key) === -1) {
                headers.push(key);
            }       
            
            items.push(row[key]);
        }

        counter = 0;
    }

    var wrapper = $('#wrapper');
    var table = $('<table>');
    var tr = $('<tr>');
    var th;
    var td
    var tableLength = headers.length;
  
    for(index in headers) {
        th = '<th>' + headers[index] + '</th>';
        tr.append($(th));
    }
    table.append(tr);

    for (i = 0; i < items.length; i++) {
        td += '<td>' + items[i] + '</td>';

        if((i + 1) % tableLength === 0) {
            tr = '<tr>' + td + '</tr>';
            table.append($(tr));
            td = '';
        }
    }

    wrapper.append(table);
    console.log(items);
}

generateTabler([{ "manufacturer": "BMW", "model": "E92 320i", "year": 2011, "price": 50000, "class": "Family" },
{ "manufacturer": "Porsche", "model": "Panamera", "year": 2012, "price": 100000, "class": "Sport" },
{ "manufacturer": "Peugeot", "model": "305", "year": 1978, "price": 1000, "class": "Family" }]);