'use strict';

const name = 'navigationRegistrar';
function factory () {
    var navItems = [];
    var activeItem = '';

    function addNavItem(item) {
        navItems.push(item);
    }

    function getItems() {
        return { items: navItems };
    }

    function setActive() {
    }

    function getActive() {
        return { active: activeItem };
    }

    return {
        addNavItem: addNavItem,
        getActive: getActive,
        getItems: getItems,
        setActive: setActive
    };
}

export { name, factory };
