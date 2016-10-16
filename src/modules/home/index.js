'use strict';

import base from '../base';
import routeConfig from './routeConfig.js';

export default angular.module('home', ['ui.router', base])
    .config(routeConfig)
    .run(function (navigationRegistrar) {
        navigationRegistrar.addNavItem({name: 'home', sref: 'home'});
    })
    .name;
