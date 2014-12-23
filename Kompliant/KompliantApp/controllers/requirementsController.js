(function (app) {
    var requirementsController = function ($scope, requirementService) {

        var onError = function() {
            alert("error!");
        };
        var onRequirements = function(response) {
            $scope.requirements = response.data;
        };
        
        var init = function () {
            $scope.requirements = requirementService.getRequirements().then(onRequirements, onError);
        };

        init();
    };
    app.controller("requirementsController", ["$scope", "requirementService", requirementsController]);

}(angular.module("kompliantApp")));