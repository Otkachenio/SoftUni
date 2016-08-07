(function () {
    var className, color;
    var button = $('#paintBtn');

    button.on('click', paint);

    function paint() {
        color = $('#colorPicker').val();
        className = '.' + $('#className').val()

        $(className).css('background-color', color);
    }
})();