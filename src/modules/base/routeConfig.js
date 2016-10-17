'use strict';

import { name } from './baseController.js';

export default function($stateProvider, $urlRouterProvider) {
    $stateProvider.state('base', {
        abstract: true,
        template: require('./base.html'),
        controller: name
    });

    $urlRouterProvider.when('', '/');
    $urlRouterProvider.when('/', '/home');
}
