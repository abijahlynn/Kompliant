(function (app) {
    var requirementsController = function ($scope, requirementService) {

        var init = function () {
            $scope.requirements = requirementService.getRequirements();
        };

        init();
    };
    app.controller("requirementsController", ["$scope", "requirementService", requirementsController]);

}(angular.module("kompliantApp")));