'use strict';

import './globalDependencies.js'
import globalConfig from './globalConfig.js';
import base from '../modules/base';
import home from '../modules/home';

export default angular.module('lbrooke.com', [base, home])
    .config(globalConfig)
    .name;
