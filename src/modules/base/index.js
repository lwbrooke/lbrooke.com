'use strict';

import routeConfig from './routeConfig.js';

export default angular.module('lbrooke.com.base', ['ui.router'])
    .config(routeConfig)
    .name;
