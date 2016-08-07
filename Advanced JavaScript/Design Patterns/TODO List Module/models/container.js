var models = models || {};

(function (scope) {
    function Container(title) {
        this.title = title;
        this._sections = [];
    }

    Container.prototype.addSection = function addSection(section) {
        this._sections.push(section);
    }

    Container.prototype.getSection = function getSection(section) {
        return this._sections;
    }

    Container.prototype.addToDOM = function getSection(selector) {
        var wrapper = document.querySelector(selector);
        var container = document.createElement('div');
        container.setAttribute('id', 'container');
        var title = document.createElement('h1');
        title.innerHTML = this.title;
        container.appendChild(title);

        var divSection = document.createElement('div');
        divSection.setAttribute('id', 'sections');
        container.appendChild(divSection);

        //Add section
        this._sections.forEach(function () {
            section.addToDOM('#sections');
        });

        var footer = document.createElement('footer');
        var sectionInput = document.createElement('input');
        sectionInput.setAttribute('type', 'text');
        sectionInput.setAttribute('id', 'section-input');

        sectionButton = document.createElement('button');
        sectionButton.setAttribute('id', 'section-button');
        sectionButton.innerHTML = 'Add Section';

        footer.appendChild(sectionInput);
        footer.appendChild(sectionButton);
        container.appendChild(footer);

        wrapper.appendChild(container);

        var _this = this;
        sectionButton.addEventListener('click', function () {
            var sectionTitle = document.getElementById('section-input').value;
            var section = new scope.Section(sectionTitle);
            _this.addSection(section);
            section.addToDOM('#sections');
        });

        wrapper.addEventListener('change', function (ev) {
            if (ev.target.checked) {
                ev.target.parentElement.style.backgroundColor = '#99ff66';
            } else {
                ev.target.parentElement.style.backgroundColor = '#FFF';
            }                  
        });
    }

    scope.Container = Container;
})(models);