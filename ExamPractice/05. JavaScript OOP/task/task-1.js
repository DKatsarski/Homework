function solve() {
    var player = {
        init: function(name) {
            return this;
        }, 
        addPlaylist: function(playlist) {

        },
        getPlaylistById: function(id) {

        },
        removePlaylist: function(id) {

        },
        listPlaylists(page, size) {
            
        }
    };

    var playlist = {

    };

    var playable = {

    };

    var audio = {

    };

    var video = {

    };

    var module = {
        getPlayer: function(name) {
            return Object.create(player)
            .init(name);
        },
        getPlayelist: function(name) {
              return Object.create(playlist)
            .init(name);
        },
        getAudio: function(title, author, length) {
             return Object.create(audio)
            .init(title, author, length);
        },
        getVideo: function(title, author, imdbRating) {
             return Object.create(video)
            .init(title, author, imdbRating);
        }
};
    return module; 
};
