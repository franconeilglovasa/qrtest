angular
    .module('demoApp', ['ngSanitize', 'ngAnimate', 'ngTouch'])
    .controller("DemoCtrl", DemoCtrl);

function DemoCtrl(scope, $http, $timeout, $window, $filter) {
    vm = this;
    $scope.code;
    vm.url;

    $scope.start = function () {
        $scope.cameraRequested = true;
    }

    $scope.processURLfromQR = function (url) {
        $scope.code = url;
        $scope.cameraRequested = false;
    }

    $scope.buttonClick = function (code) {
        console.log("1");
    }

    vm.click = function (code) {
        console.log("2");
    }
}

function testClick(code) {
    console.log(code);
}
