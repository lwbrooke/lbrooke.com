'use strict';

const name = 'baseController';
function controller ($scope, $mdSidenav, navigationRegistrar, constants) {
    $scope.toggleLeftMenu = function() {
        $mdSidenav('left').toggle();
    }
    $scope.current = navigationRegistrar.getActive();
    $scope.nav = navigationRegistrar.getItems();

    $scope.author = constants.author;
    $scope.facebookLink = constants.facebookLink;
    $scope.githubLink = constants.githubLink;
    $scope.linkedinLink = constants.linkedinLink;
    $scope.siteName = constants.siteName;
}

export { name, controller };
