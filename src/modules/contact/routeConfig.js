'use strict';

export default function($stateProvider) {
    $stateProvider.state('contact', {
        url: '/contact',
        template: require('./contact.html'),
        parent: 'base'
    });
}
