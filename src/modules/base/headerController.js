'use strict';

const name = 'headerController';
function controller ($scope, navigationRegistrar, constants) {
    $scope.nav = navigationRegistrar.getItems();
    $scope.current = navigationRegistrar.getActive();
    $scope.siteName = constants.siteName;
}

export { name, controller };
