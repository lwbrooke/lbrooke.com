'use strict';

const name = 'headerController';
function controller ($scope, navigationRegistrar) {
    $scope.nav = navigationRegistrar.getItems();
    $scope.current = navigationRegistrar.getActive();
}

export { name, controller };
