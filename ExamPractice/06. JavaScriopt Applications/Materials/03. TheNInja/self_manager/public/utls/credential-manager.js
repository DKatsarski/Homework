const credentialManager = (() => {
    function save(user) {
        return new Promise((resolve, reject) => {
            const stringifiedUser = JSON.stringify(user);
            window.localStorage.setItem('loggedUser', stringifiedUser);
            window.localStorage.setItem('isLogged', 'loggedUser');
            resolve(user);
        });
    }

    function load() {
        return new Promise((resolve, reject) => {
            if (!isLogged) {
                reject(new Error('No logged user.'));
                return;
            }

            const stringifiedUser = window.localStorage.getItem('loggedUser');
            const user = JSON.parse(stringifiedUser);
            resolve(user);
        });
    }

    function remove() {
        return new Promise((resolve, reject) => {
            if (!isLogged) {
                reject(new Error('No logged user.'));
                return;
            }

            const stringifiedUser = window.localStorage.getItem('loggedUser');
            const user = JSON.parse(stringifiedUser);
            const username = user.username;

            window.localStorage.removeItem('loggedUser');
            window.localStorage.removeItem('isLogged');

            resolve(username);
        });
    }

    function isLogged() {
        const isLogged = window.localStorage.isLogged ? true : false;
        return isLogged;
    }

    return {
        save,
        load,
        remove,
        isLogged
    };
})();