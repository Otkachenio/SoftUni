var imdb = imdb || {};

(function (scope) {
    function loadHtml(selector, data) {
		var container = document.querySelector(selector),
			moviesContainer = document.getElementById('movies'),
			detailsContainer = document.getElementById('details'),
			genresUl = loadGenres(data);

		container.appendChild(genresUl);

		genresUl.addEventListener('click', function (ev) {
			if (ev.target.tagName === 'LI') {
				var genreId,
					genre,
					moviesHtml;

				genreId = parseInt(ev.target.getAttribute('data-id'));
				genre = data.filter(function (genre) {
					return genre._id === genreId;
				})[0];

				moviesHtml = loadMovies(genre.getMovies());
				moviesContainer.innerHTML = moviesHtml.outerHTML;
				moviesContainer.setAttribute('data-genre-id', genreId);
			}
		});	

        // Task 2 - Add event listener for movies boxes
		container.addEventListener('click', showInfo);

		function showInfo() {		    
		    var liBtns = document.querySelectorAll('#movies ul li');
		    for (var index = 0; index < liBtns.length; index++) {
		        liBtns[index].addEventListener('click', function () {
		            var thisMovie;
		            var id = Number(this.parentNode.parentNode.getAttribute('data-genre-id'));		            
		            var genre = data.filter(function (genre) {
		                return genre._id === id;
		            })[0];
		            var movies = genre.getMovies();
		            var movieID = Number(this.getAttribute('data-id'));

		            movies.forEach(function (movie) {
		                if (movie._id === movieID) {
		                    thisMovie = movie;
		                }
		            });

		            var getDiv = document.getElementById('actorsDiv');
		            if (getDiv) {
		                getDiv.remove();
		            }
		            var actorsDiv = document.createElement('div');
		            actorsDiv.id = 'actorsDiv';
		            actorsDiv.innerHTML = '<h1>Actors</h1>';
		            actorsDiv.innerHTML += '<ul>';
		            for (var index in thisMovie._actors) {
		                if (thisMovie._actors[index].name.length > 5) {
		                    actorsDiv.innerHTML += '<li style="margin-left: 50px; margin-top: 10px;">' + thisMovie._actors[index].name + '</li>';
		                    actorsDiv.innerHTML += '<p style="margin: 0 50px; font-size: 12px;";>' + '<strong>Bio: </strong>' +
                                thisMovie._actors[index].bio + '</p>';
		                    actorsDiv.innerHTML += '<p style="margin: 0 50px; font-size: 12px;";>' + '<strong>Born: </strong>' +
                                thisMovie._actors[index].born + '</p>';
		                }
		            }
		            actorsDiv.innerHTML += '</ul>';

		            var getDiv2 = document.getElementById('reviewDiv');
		            if (getDiv2) {
		                getDiv2.remove();
		            }
		            var reviewDiv = document.createElement('div');
		            reviewDiv.id = 'reviewDiv';
		            reviewDiv.innerHTML = '<h1>Reviews</h1>';
		            reviewDiv.innerHTML += '<ul>';
		            for (var index = 0; index < thisMovie._reviews.length; index++) {
		                if (thisMovie._reviews[index].author.length > 5) {
		                    reviewDiv.innerHTML += '<li style="margin-left: 50px; margin-top: 10px;">' + thisMovie._reviews[index].author + '</li>';
		                    reviewDiv.innerHTML += '<p style="margin: 0 50px; font-size: 12px;";>' + '<strong>Comment: </strong>' +
                                thisMovie._reviews[index].content + '</p>';
		                    reviewDiv.innerHTML += '<p style="margin: 0 50px; font-size: 12px;";>' + '<strong>Date: </strong>' +
                                thisMovie._reviews[index].date + '</p>';
		                }
		            }
		            reviewDiv.innerHTML += '</ul>';
		           
		            document.body.appendChild(actorsDiv);
		            document.body.appendChild(reviewDiv);
		            actorsDiv.style.padding = '0 50px';
		            reviewDiv.style.padding = '0 50px';

		            
		        });
		    }
            
		    // Task 3 - Add event listener for all delete buttons
		    var btn = document.getElementsByClassName('deleteMovieBtn');
		    for (var index = 0; index < btn.length; index++) {
		        btn[index].addEventListener('click', deleteMovie);
		    }

		    function deleteMovie() {
		        var movieID = this.parentNode.getAttribute('data-id');
		        var id = Number(this.parentNode.parentNode.parentNode.getAttribute('data-genre-id'));
		        var genre = data.filter(function (genre) {
		            return genre._id === id;
		        })[0];

		        genre.removeMovieById(movieID);		        
		        this.parentNode.remove();
		    }
		}	
	}

	function loadGenres(genres) {
		var genresUl = document.createElement('ul');
		genresUl.setAttribute('class', 'nav navbar-nav');
		genres.forEach(function (genre) {
			var liGenre = document.createElement('li');
			liGenre.innerHTML = genre.name;
			liGenre.setAttribute('data-id', genre._id);
			genresUl.appendChild(liGenre);
		});

		return genresUl;
	}

	function loadMovies(movies) {
		var moviesUl = document.createElement('ul');
		movies.forEach(function (movie) {
			var liMovie = document.createElement('li');
			liMovie.setAttribute('data-id', movie._id);

			liMovie.innerHTML = '<h3>' + movie.title + '</h3>';
			liMovie.innerHTML += '<div>Country: ' + movie.country + '</div>';
			liMovie.innerHTML += '<div>Time: ' + movie.length + '</div>';
			liMovie.innerHTML += '<div>Rating: ' + movie.rating + '</div>';
			liMovie.innerHTML += '<div>Actors: ' + movie._actors.length + '</div>';
			liMovie.innerHTML += '<div>Reviews: ' + movie._reviews.length + '</div>';
			liMovie.innerHTML += '<button class="deleteMovieBtn">Delete movie</button>';
			
			moviesUl.appendChild(liMovie);
		});

		return moviesUl;
	}

	scope.loadHtml = loadHtml;
}(imdb));