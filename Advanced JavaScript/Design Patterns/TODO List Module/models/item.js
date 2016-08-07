var models = models || {};

(function (scope) {
    function Item(content) {
        this.content = content;
        this.isComplete = false;
    }

    Item.prototype.changeStatus = function () {
        this.isComplete = !this.isComplete;
    }

    Item.prototype.addToDOM = function (ul) {
        var item = document.createElement('li');
        item.innerHTML = '<input class="tick" type="checkbox" />';
        item.innerHTML += '<span>' + this.content + '</span>';
        ul.appendChild(item);
    }

    scope.Item = Item;
})(models);