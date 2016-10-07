'use strict';

import routeConfig from './routeConfig.js';

export default angular.module('lbrooke.com.home', ['ui.router'])
    .config(routeConfig)
    .name;
