(function () {
    var data,
        id,
        newName,
        addButton = document.getElementById('addCountryBtn'),
        editButton = document.getElementById('editCountryBtn'),
        deleteButton = document.getElementById('deleteCountryBtn');

    addButton.addEventListener('click', addCountry);
    editButton.addEventListener('click', editCountry);
    deleteButton.addEventListener('click', deleteCountry);

    function addCountry() {
        countryName = document.getElementById('addCountryInput').value;
        data = '{' + '"name"' + ':"' + countryName + '"}';
        httpRequest.make({
            url: 'https://baas.kinvey.com/appdata/kid_SynD60iI/country',
            type: 'POST',
            contentType: 'application/json',
            accept: 'application/json',
            data: data
        })
    }

    function editCountry() {    
        countryName = document.getElementById('editCountryOldName').value;
        newName = document.getElementById('editCountryNewName').value;
        data = '{' + '"name"' + ':"' + newName + '"}';
        for (var index in countryNamesArr) {
            if (countryNamesArr[index] === countryName) {
                id = countryIDsArr[index];
                break;
            }
        }

        httpRequest.make({
            url: 'https://baas.kinvey.com/appdata/kid_SynD60iI/country/' + id,
            type: 'PUT',
            contentType: 'application/json',
            data: data,
        });
    }

    function deleteCountry() {
        countryName = document.getElementById('deleteCountryName').value;
        for (var index in countryNamesArr) {
            if (countryNamesArr[index] === countryName) {
                id = countryIDsArr[index];
                break;
            }
        }

        httpRequest.make({
            url: 'https://baas.kinvey.com/appdata/kid_SynD60iI/country/' + id,
            type: 'DELETE',
            contentType: 'application/json'
        });
    }
})();