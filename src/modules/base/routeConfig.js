'use strict';

export default function($stateProvider, $urlRouterProvider) {
    $stateProvider.state('base', {
        abstract: true,
        template: require('./base.html')
    });

    $urlRouterProvider.when('', '/');
    $urlRouterProvider.when('/', '/home');
}
