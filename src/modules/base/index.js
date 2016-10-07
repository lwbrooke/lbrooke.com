'use strict';

import routeConfig from './routeConfig.js';
import * as footerBlock from './footerBlock.js';
import * as headerBlock from './headerBlock.js';

export default angular.module('lbrooke.com.base', ['ui.router'])
    .config(routeConfig)
    .directive(footerBlock.name, footerBlock.factory)
    .directive(headerBlock.name, headerBlock.factory)
    .name;
