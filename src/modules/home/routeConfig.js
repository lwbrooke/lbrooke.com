'use strict';

export default function($stateProvider) {
    $stateProvider.state('home', {
        url: '/home',
        template: require('./home.html'),
        parent: 'base'
    });
}
