'use strict';

export default function($locationProvider, $mdThemingProvider) {
    $locationProvider.html5Mode(true);

    $mdThemingProvider.theme('default')
        .primaryPalette('blue')
        .accentPalette('light-blue')
        .warnPalette('red')
        .backgroundPalette('grey');
};
