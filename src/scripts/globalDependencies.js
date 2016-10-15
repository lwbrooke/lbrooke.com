'use strict';

var dependencies = [];

// libraries

import 'angular';
import 'angular-ui-router';

import 'angular-aria';
import 'angular-animate';
import angularMaterial from 'angular-material';
dependencies.push(angularMaterial);

// less/css
import 'angular-material/angular-material.css';
import '../style/app.less';

export default dependencies;
