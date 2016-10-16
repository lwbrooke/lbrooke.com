'use strict';

import base from '../base';
import routeConfig from './routeConfig.js';

export default angular.module('about', ['ui.router', base])
    .config(routeConfig)
    .run(function (navigationRegistrar) {
        navigationRegistrar.addNavItem({name: 'about', sref: 'about'});
    })
    .name;
