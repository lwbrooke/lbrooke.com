'use strict';

export default function($stateProvider) {
    $stateProvider.state('about', {
        url: '/about',
        template: require('./about.html'),
        parent: 'base'
    });
}
