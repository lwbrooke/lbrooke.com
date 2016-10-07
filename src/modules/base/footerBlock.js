'use strict';

const name = 'footerBlock';
function factory() {
    return {
        template: require('./footerBlock.html'),
    }
}

export { name, factory };
