var imdb = imdb || {};

(function (scope) {
    var id = 1;

    function Genre(name) {
        this.name = name;
        this._movies = [];
        this._id = id++;
    }

    Genre.prototype.addMovie = function (movie) {
        this._movies.push(movie);
    }

    Genre.prototype.removeMovie = function (movie) {
        var index = this._movies.indexOf(movie);
        this._movies.splice(index, 1);
    }

    Genre.prototype.removeMovieById = function (id) {
        for (var index in this._movies) {
            if (Number(this._movies[index]._id) === Number(id)) {
                this._movies.splice(index, 1);
                return;
            }
        }

        console.warn('Movie with ID (' + id + ') was not found');
    }

    Genre.prototype.getMovies = function () {
        return this._movies;
    }

    scope.getGenre = function (name) {
        return new Genre(name);
    }
})(imdb);