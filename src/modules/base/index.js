'use strict';

import routeConfig from './routeConfig.js';
import * as baseController from './baseController.js';
import * as navigationRegistrar from './navigationRegistrar.js';

export default angular.module('base', ['ui.router'])
    .config(routeConfig)
    .controller(baseController.name, baseController.controller)
    .factory(navigationRegistrar.name, navigationRegistrar.factory)
    .name;
