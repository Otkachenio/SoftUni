(function (imdb) {
    var genres;

	imdb.generateData();
	genres = imdb.getGenres();

	imdb.loadHtml('#genres', genres);
}(imdb));