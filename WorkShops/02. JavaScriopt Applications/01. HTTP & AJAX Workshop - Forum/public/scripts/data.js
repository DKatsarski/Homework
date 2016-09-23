var data = (function () {
  const USERNAME_STORAGE_KEY = 'username-key',
   AUTH_KEY_STORAGE_KEY = 'auth-key-key';

  // start users
  function userLogin(user) {
    localStorage.setItem(USERNAME_STORAGE_KEY, user);
    return Promise.resolve(user);
  }

  function userLogout() {
    localStorage.removeItem(USERNAME_STORAGE_KEY)
    return Promise.resolve();
  }

  function userGetCurrent() {
    return Promise.resolve(localStorage.getItem(USERNAME_STORAGE_KEY));
  }
  // end users

  // start threads
  function threadsGet() {
    return new Promise((resolve, reject) => {
      $.getJSON('api/threads')
        .done(resolve)
        .fail(reject);
    })
  }

  function threadsAdd(title) {
    var p = new Promise(function (resolve, reject) {
      var body = {
        title
      };


      $.ajax({
        url: 'api/threads',
        method: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(body),
        success: function (res) {
          resolve(res);
        }
      });
    });
    return p;
  }

  function threadById(id) {
    var q = new Promise(function (resolve, reject) {
      $.getJSON(`api/threads/${id}`, function (res) {
        resolve(res);
      });
    });
    return q;
  }

  function threadsAddMessage(threadId, content) {
  var qpromise = new Promise(function(resolve, reject) {
      $.ajax({
        url: `api/threads/${threadId}/messages`,
        method: 'POST',
        data: JSON.stringify(message),
        contentType: 'application/json',
        headers: {
          'x-authkey': localStorage.getItem(AUTH_KEY_STORAGE_KEY)
        },
        success: function(res) {
          resolve(res);
        }
      });
    });
    return qpromise
    }
  // end threads

  // start gallery
  function galleryGet() {
        const REDDIT_URL = `https://www.reddit.com/r/aww.json?jsonp=?`;

      }
  // end gallery

  return {
      users: {
        login: userLogin,
        logout: userLogout,
        current: userGetCurrent
      },
      threads: {
        get: threadsGet,
        add: threadsAdd,
        getById: threadById,
        addMessage: threadsAddMessage
      },
      gallery: {
        get: galleryGet,
      }
    }
  })();