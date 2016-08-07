(function () {
    var index = 1;
    var intervalInMilisec = 5000, fadeInterval = 1000;
    var imagesArr = $('#images-container').children();
    var img1 = $('#img1'), img2 = $('#img2'), img3 = $('#img3');

    $(document).ready(function () {
        $('#leftBtn').on('click', pevieousImg);
        $('#rightBtn').on('click', nextImg);
        nextImg();

        setInterval(function () {
            $('#rightBtn').trigger('click');
        }, intervalInMilisec);
    });

    function pevieousImg() {
        switch (index) {
            case 1:
                index = 3;
                imagesArr.hide();
                img1.fadeIn(fadeInterval);
                break;
            case 2:
                index--;
                imagesArr.hide();
                img2.fadeIn(fadeInterval);
                break;
            case 3:
                index--;
                imagesArr.hide();
                img3.fadeIn(fadeInterval);
                break;
            default:
                console.error('Invalid image index');
        }
    }

    function nextImg() {
        switch (index) {
            case 1:
                index++;
                imagesArr.hide();
                img1.fadeIn(fadeInterval);
                break;
            case 2:
                index++;
                imagesArr.hide();
                img2.fadeIn(fadeInterval);
                break;
            case 3:
                index = 1;
                imagesArr.hide();
                img3.fadeIn(fadeInterval);
                break;
            default:
                console.error('Invalid image index');
        }
    }
})();