function solve() {
    function isStringValid(str, minLength, maxLength) {
        return typeof (str) === 'string' || str.length >= minLength ||
            str.length <= maxLength;
    }

    var player = {
        init: function (name) {
            return this;
        },
        addPlaylist: function (playlist) {

        },
        getPlaylistById: function (id) {

        },
        removePlaylist: function (id) {

        },
        listPlaylists: function (page, size) {

        }
    };

    var playlist = function () {
        var lastId = 0;
            var playlist = {
                init: function (name) {
                    this.id = lastId += 1;
                    this._name = name;
                    this.playables = [];
                    return this;
                },
                addPlayable: function (playable) {
                    this.playables.push(playable);
                    return this;
                },
                getPlayableById: function (id) {
                  if (typeof(playable.id) === 'undefined' || !this.title) {
                      throw {
                          name: 'InvalidPlayableError',
                          message: 'Message'
                      };
                      var i,
                      len;
                    //   for(playable of this.playables) {
                    //        if (this.playables[i].id === id) {
                    //           return this.playables[i];
                    //       }
                    //   }

                      for (i = 0, len = this.playables.length; i < len; i += 1) {
                          if (this.playables[i].id === id) {
                              return this.playables[i];
                          }
                      }
                  }
                  return null;
                },
                removePlayable: function (id) {
                    if(id === 'undefined') {
                        throw {
                            name: 'InvalidIdError',
                            message: '!'
                        }
                    }
                    if(typeof(id) !== 'number') {
                        id = id.id;
                    }
                    // 1:29:35
                },
                listPlayables: function (page, size) {

                }
            };
        
        return playlist;
    } ();
    var playable = function () {
        var lastId = 0,
            playable = {
                init: function (title, author) {

                    this.id = lastId += 1;
                    this._title = title;
                    this._author = author;
                    return this;
                },
                get title() {
                    return this._title;
                },
                set title(newTitle) {
                    if (!isStringValid(newTitle, 3, 25)) {
                        throw {
                            name: 'InvalidTitleError',
                            message: 'Title must be longer thatn 3 and.. yea 25',
                        }
                    };
                    this._title = newTitle;
                },
                get author() {
                    return this._author;
                },
                set author(newAuthor) {
                    if (!isStringValid(newAuthor, 3, 25)) {
                        throw {
                            name: 'InvalidTitleError',
                            message: 'Title must be longer thatn 3 and.. yea 25',
                        }
                    };
                    this._author = newAuthor;
                },

                play: function () {
                    return `${this.id}. ${this.title} - ${this.author}`;
                }
            };
        return playable;
    } ();

    var audio = function (parent) {
        var audio = Object.create(parent); //nasledqwane

        audio.init = function (title, author, length) {
            parent.init.call(this, title, author); //nasledqwane na konstruktora
            this.length = length;
            return this;
        };

        audio.play = function () {
            return parent.play.call(this) + ' - ' + this.length;
        };

        // tuk prawim prowerka za walidaciqta na propyrtitata na klasa naslednik
        Object.defineProperty(audio, 'length', {
            get: function () {
                return this._length;
            },
            set: function (newLength) {
                if (typeof newLength !== 'number' || newLength <= 0) {
                    throw {
                        name: '',
                        messaeg: '',
                    };
                }

                this._length = newLength;
            }
        });

        return audio;
    } (playable); //nasledqwane

    var video = function (parent) {
        var video = Object.create(parent); //nasledqwane

        video.init = function (title, author, imdbRating) {
            parent.init.call(this, title, author); //nasledqwane na konstruktora
            this.imdbRating = imdbRating;
            return this;
        };

        video.play = function () {
            return parent.play.call(this) + ' - ' + this.imdbRating;
        };

        //tuk prawim prowerka za walidaciqta na propyrtitata na klasa naslednik
        Object.defineProperty(video, 'imdbRating', {
            get: function () {
                return this._imdbRating;
            },
            set: function (newImdbRating) {
                if (typeof newImdbRating !== 'number' || newImdbRating < 1 ||
                    newImdbRating > 5) {
                    throw {
                        name: '',
                        messaeg: '',
                    }
                }

                this._imdbRating = newImdbRating;
            }
        })

        return video;
    } (playable); //nasledqwane

    var module = {
        getPlayer: function (name) {
            return Object.create(player)
                .init(name);
        },
        getPlayelist: function (name) {
            return Object.create(playlist)
                .init(name);
        },
        getAudio: function (title, author, length) {
            return Object.create(audio)
                .init(title, author, length);
        },
        getVideo: function (title, author, imdbRating) {
            return Object.create(video)
                .init(title, author, imdbRating);
        }
    };
    return module;
};

var module = solve();
console.log(module.getVideo('car luv', 'elton john', 4)
    .play());

module.exports = solve;