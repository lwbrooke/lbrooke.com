'use strict';

const name = 'footerBlock';
function factory() {
    return {
        template: require('./footerBlock.html'),
        controller: function($scope, constants) {
            $scope.author = constants.author;
            $scope.linkedinLink = constants.linkedinLink;
            $scope.githubLink = constants.githubLink;
            $scope.facebookLink = constants.facebookLink;
        }
    }
}

export { name, factory };
