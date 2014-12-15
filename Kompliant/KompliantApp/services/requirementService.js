(function (app)
{
    var testData =
            [
                {
                    requirementId: "HS-C-1",
                    standardId: 18234,
                    description: "All members must take evacuation training",
                    period: "Quarterly"
                },
                {
                    requirementId: "HS-C-2",
                    standardId: 34325,
                    description: "Company must post signs demonstrating evacuation routes",
                    period: "Initially"
                },
                {
                    requirementId: "HS-M-1",
                    standardId: 20293,
                    description: "Must review and update published evacuation routes",
                    period: "Annually"
                },
                {
                    requirementId: "HS-M-2",
                    standardId: 20487,
                    description: "Must spot check training certificates to ensure compliance",
                    period: "Annually"
                }
            ];

    var requirementService = function()
    {
        var requirementFactory = {};
        requirementFactory.getRequirements = function()
        {
            return testData;
        };
        return requirementFactory;
    };
    app.factory("requirementService", requirementService);
}(angular.module("kompliantApp")));