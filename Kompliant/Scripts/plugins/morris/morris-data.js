$(function() {

    Morris.Area({
        element: 'morris-area-chart',
        data: [{
            period: '2012 Q1',
            Trainings: 6,
            Reviews: 5,
            Meetings: 2
        }, {
            period: '2012 Q2',
            Trainings: 7,
            Reviews: 5,
            Meetings: 3
        }, {
            period: '2012 Q3',
            Trainings: 9,
            Reviews: 6,
            Meetings: 2
        }, {
            period: '2012 Q4',
            Trainings: 8,
            Reviews: 8,
            Meetings: 4
        }, {
            period: '2013 Q1',
            Trainings: 7,
            Reviews: 5,
            Meetings: 4
        }, {
            period: '2013 Q2',
            Trainings: 9,
            Reviews: 6,
            Meetings: 4
        }, {
            period: '2013 Q3',
            Trainings: 14,
            Reviews: 8,
            Meetings: 6
        }, {
            period: '2013 Q4',
            Trainings: 15,
            Reviews: 13,
            Meetings: 6
        }, {
            period: '2014 Q1',
            Trainings: 12,
            Reviews: 10,
            Meetings: 6
        }, {
            period: '2014 Q2',
            Trainings: 9,
            Reviews: 8,
            Meetings: 4
        }],
        xkey: 'period',
        ykeys: ['Trainings', 'Reviews', 'Meetings'],
        labels: ['Trainings', 'Reviews', 'Meetings'],
        pointSize: 2,
        hideHover: 'auto',
        resize: true
    });

    Morris.Donut({
        element: 'morris-donut-chart',
        data: [{
            label: "Download Sales",
            value: 12
        }, {
            label: "In-Store Sales",
            value: 30
        }, {
            label: "Mail-Order Sales",
            value: 20
        }],
        resize: true
    });

    Morris.Bar({
        element: 'morris-bar-chart',
        data: [{
            y: '2006',
            a: 100,
            b: 90
        }, {
            y: '2007',
            a: 75,
            b: 65
        }, {
            y: '2008',
            a: 50,
            b: 40
        }, {
            y: '2009',
            a: 75,
            b: 65
        }, {
            y: '2010',
            a: 50,
            b: 40
        }, {
            y: '2011',
            a: 75,
            b: 65
        }, {
            y: '2012',
            a: 100,
            b: 90
        }],
        xkey: 'y',
        ykeys: ['a', 'b'],
        labels: ['Series A', 'Series B'],
        hideHover: 'auto',
        resize: true
    });

});
