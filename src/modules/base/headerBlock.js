'use strict';

import { name as controllerName } from './headerController.js';

const name = 'headerBlock';
function factory() {
    return {
        template: require('./headerBlock.html'),
        controller: controllerName
    }
}

export { name, factory };
