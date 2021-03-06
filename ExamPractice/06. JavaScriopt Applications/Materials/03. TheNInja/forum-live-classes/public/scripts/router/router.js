const Navigo = require('../../bower_components/navigo/lib/navigo.min');

const Router = (() => {
    class Router {
        constructor(contentContainerId, homeController, loginController) {
            this.contentId = contentContainerId;

            this.homeController = homeController;
            this.loginController = loginController;

            this.__initRouter__();
        }

        start() {
            this._router.resolve();
        }

        __initRouter__() {
            const that = this;
            that._router = new Navigo(null, true);

            that._router.on(() => {
                that._router.navigate('/');
            });

            that._router.on('/login', () => {
                that.loginController.start(that.contentId);
            });

            that._router.on('/', () => {
                that.homeController.start(that.contentId);
            });
        }
    }

    return Router;
})();

module.exports = Router;