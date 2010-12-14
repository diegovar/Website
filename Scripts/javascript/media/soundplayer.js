/// <reference path="../lib/jquery-1.4.4-vsdoc.js" />

$(document).ready(function () {
    var inst = $('#music_player');
    $(".music_player", inst).jPlayer({
        ready: function () {
            var playlistItems = $('.jp-playlist li');
            if (playlistItems.length) {
                this.element.jPlayer("setFile", playlistItems.attr('data-url'));
            }
            this.element.jPlayer('play');
        }
    });
    $('.playlist_collapse', inst).click(function () {
        $('jp-playlist ul').toggle('fast');
        this.toggleClass('open', 'closed');
    });
});
