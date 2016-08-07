(function () {
    $(function () {
        init();
        setTimer('#timer');

        $('input[name="question1"]').on('click', function () {
            localStorage.setItem('question1', $(this).attr('id'));
        });

        $('input[name="question2"]').on('click', function () {
            localStorage.setItem('question2', $(this).attr('id'));
        });

        $('input[name="question3"]').on('click', function () {
            localStorage.setItem('question3', $(this).attr('id'));
        });

        $('#button').on('click', showResults);
    });

    function setTimer(selector) {
        var timer,
            minutes,
            secondsStr,
            timeInSec = 300,
            secondsInAMinute = 60;

        timer = setInterval(function () {
            timeInSec--;
            secondsInAMinute--;
            minutes = Math.floor(timeInSec / 60);
            secondsStr = secondsInAMinute;
            if (secondsInAMinute < 10) {
                secondsStr = '0' + secondsInAMinute;
            }

            $(selector).text(minutes + ':' + secondsInAMinute);

            if (secondsInAMinute === 0) {
                secondsInAMinute = 60;
            }
            if (timeInSec === 0) {
                clearInterval(timer);
                timeOut();
            }

        }, 1000);
    }

    function timeOut() {
        localStorage.clear();
        $('#button').hide();
        $('#wrapper').append($('<h2>').text('Time is up.'));
        showResults();
    }

    function showResults() {
        $('#button').hide();
        var answer1 = $('input[name="question1"]:checked').val();
        var answer2 = $('input[name="question2"]:checked').val();
        var answer3 = $('input[name="question3"]:checked').val();

        $('#result').find('#result-answer1').text(answer1);
        $('#result').find('#result-answer2').text(answer2);
        $('#result').find('#result-answer3').text(answer3);
    }

    function makeChecked(id) {
        var answer = '#' + id;
        $(answer).attr('checked', 'checked');
    }
    
    function init() {
        if (localStorage['question1']) {
            makeChecked(localStorage['question1']);
        }
        if (localStorage['question2']) {
            makeChecked(localStorage['question2']);
        }
        if (localStorage['question3']) {
            makeChecked(localStorage['question3']);
        }
    }
})();