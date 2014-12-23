(function (app)
{
    var requirementService = function ($http) {

        var baseUrl = "/api/requirements";
        var requirementFactory = {};
        requirementFactory.getRequirements = function()
        {
            return $http.get(baseUrl);
        };
        return requirementFactory;
    };
    app.factory("requirementService", ["$http", requirementService]);
}(angular.module("kompliantApp")));