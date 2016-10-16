'use strict';

export default function($stateProvider) {
    $stateProvider.state('home', {
        url: '/home',
        template: require('./home.html'),
        parent: 'base',
        controller: function($scope, constants) {
            $scope.siteName = constants.siteName;
        }
    });
}
