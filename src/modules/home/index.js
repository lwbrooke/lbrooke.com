'use strict';
import angular from 'angular';
import PhoneListController from './phoneListController.js';
console.log(PhoneListController)

module.export = angular.module('lbrooke.com.home', [])
    .controller('PhoneListController', PhoneListController)
    .name;
