const usersController = (() => {
    function load(containerId) {
        const content = $(containerId);
        return templatesService.loadTemplate('login')
            .then((template) => {
                const html = template();
                content.html(html);
            })
            .then(() => {
                const btnLogin = content.find('#btn-login');
                btnLogin.on('click', () => {
                    const tbUsername = content.find('#tb-username');
                    const tbPassword = content.find('#tb-password');
                    const user = {
                        username: tbUsername.val(),
                        passHash: tbPassword.val()
                    };

                    login(user);
                });

                const btnRegister = content.find('#btn-register');
                btnRegister.on('click', () => {
                    const tbUsername = content.find('#tb-username');
                    const tbPassword = content.find('#tb-password');
                    const user = {
                        username: tbUsername.val(),
                        passHash: tbPassword.val()
                    };

                    const usernameLength = user.username.length;
                    if (!(6 <= usernameLength && usernameLength <= 30)) {
                        toastr.error('Incorret username length.', 'Username should be between 6 and 30 characters long.');
                        return new Promise((resolve, reject) => {
                            resolve();
                        });
                    }

                    return usersService.register(user)
                        .then(() => {
                            toastr.success('registered');
                        })
                        .then(() => {
                            login(user);
                        })
                        .catch(() => {
                            toastr.error('error');
                        });
                });

                function login(user) {
                    usersService.login(user)
                        .then(() => {
                            toastr.success('logged in');
                        })
                        .then(() => {
                            window.location = '#/';
                        })
                        .catch(() => {
                            toastr.error('error');
                        });
                }
            });
    }

    function displayAll(containerId) {
        const content = $(containerId);

        return Promise.all([
            templatesService.loadTemplate('users'),
            usersService.allUsers()
        ])
            .then(([template, users]) => {
                const html = template(users.result);
                content.html(html);
            })
            .catch((error) => {
                toastr.error('Login first.');
                window.location = '#/';
            });
    }

    function myCookie(containerId) {
        const content = $(containerId);

        return Promise.all([
            templatesService.loadTemplate('my-cookie'),
            usersService.myCookie()
        ])
            .then(([template, data]) => {
                const html = template(data.result);
                content.html(html);
            })
            .catch((error) => {
                toastr.error('Login first');
            });
    }

    function like(cookie) {
        return usersService.like(cookie)
            .then((data) => {
                toastr.success('oh snap!');
            })
            .catch((error) => {
                toastr.error('Login first');
            });
    }

    function share(cookie) {
        return usersService.share(cookie)
            .then((data) => {
                toastr.success('oh snap!');
            })
            .catch((error) => {
                toastr.error('Login first');
            });
    }

    function logout() {
        return usersService.logout();
    }

    return {
        load,
        logout,
        displayAll,
        myCookie,
        like,
        share
    };
})();