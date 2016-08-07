var models = models || {};

(function (scope) {
    function Section(title) {
        this.title = title;
        this._items = [];
    }

    Section.prototype.addItem = function addItem(item) {
        this._items.push(item);
    }

    Section.prototype.getItem = function getItem() {
        return this._items;
    }

    Section.prototype.addToDOM = function getItem(selector) {
        var _this = this;
        var sectionWrapper = document.querySelector(selector);
        var section = document.createElement('section');
        var sectionTitle = document.createElement('h2');
        sectionTitle.innerHTML = this.title;
        section.appendChild(sectionTitle);

        var ul = document.createElement('ul');
        section.appendChild(ul);
        this._items.forEach(function (item) {
            item.addToDOM(ul);
        });

        var itemInput = document.createElement('input');
        itemInput.setAttribute('type', 'text');
        itemInput.setAttribute('class', 'item-input');

        var itemButton = document.createElement('button');
        itemButton.setAttribute('id', 'item-button');
        itemButton.innerHTML = '+';

        section.appendChild(itemInput);
        section.appendChild(itemButton);

        sectionWrapper.appendChild(section);

        itemButton.addEventListener('click', function () {
            var content = this.parentElement.getElementsByClassName('item-input')[0].value;
            var item = new scope.Item(content);
            _this.addItem(item);
            var ul = this.parentElement.getElementsByTagName('ul')[0];
            item.addToDOM(ul);
        });
    }

    scope.Section = Section;
})(models);