(function () {
    function insertBefore() {
        var newLi = $('<li>New LI inseted before</li>');
        $('#unorderedList').prepend(newLi);
    }

    function insertAfter() {
        var newLi = $('<li>New LI inserted after</li>');
        $('#unorderedList').append(newLi);
    }

    insertBefore();
    insertAfter();
})();