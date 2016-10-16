'use strict';

import dependencies from './globalDependencies.js';
import config from './globalConfig.js';
import constants from './globalConstants.js';
import base from '../modules/base';
import home from '../modules/home';
import about from '../modules/about';
import contact from '../modules/contact';

export default angular.module('app', [base, home, about, contact].concat(dependencies))
    .constant('constants', constants)
    .config(config)
    .name;
