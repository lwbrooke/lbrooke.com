'use strict';

import base from '../base';
import routeConfig from './routeConfig.js';

export default angular.module('contact', ['ui.router', base])
    .config(routeConfig)
    .run(function (navigationRegistrar) {
        navigationRegistrar.addNavItem({name: 'contact', sref: 'contact'});
    })
    .name;
