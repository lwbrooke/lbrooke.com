'use strict';

import dependencies from './globalDependencies.js'
import globalConfig from './globalConfig.js';
import base from '../modules/base';
import home from '../modules/home';
import about from '../modules/about';
import contact from '../modules/contact';

export default angular.module('lbrooke.com', [base, home, about, contact].concat(dependencies))
    .config(globalConfig)
    .name;
