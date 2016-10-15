'use strict';

import routeConfig from './routeConfig.js';
import * as footerBlock from './footerBlock.js';
import * as headerBlock from './headerBlock.js';
import * as headerController from './headerController.js';
import * as navigationRegistrar from './navigationRegistrar.js';

export default angular.module('lbrooke.com.base', ['ui.router'])
    .config(routeConfig)
    .directive(footerBlock.name, footerBlock.factory)
    .controller(headerController.name, headerController.controller)
    .directive(headerBlock.name, headerBlock.factory)
    .factory(navigationRegistrar.name, navigationRegistrar.factory)
    .name;
