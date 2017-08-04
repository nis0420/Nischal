var app = angular.module('MyApp', ['datatables']);
app.controller('homeCtrl', ['$scope', '$http', 'DTOptionsBuilder', 'DTColumnBuilder',
    function ($scope, $http, DTOptionsBuilder, DTColumnBuilder) {
        $scope.dtColumns = [
            //DTColumnBuilder.newColumn("Id", "Id"),
            DTColumnBuilder.newColumn("ModuleName", "Module Name")
            //,
            //DTColumnBuilder.newColumn("ContactName", "Contact Name"),
            //DTColumnBuilder.newColumn("Phone", "Phone"),
            //DTColumnBuilder.newColumn("City", "City")
        ];
        $scope.dtOptions = DTOptionsBuilder.newOptions().withOption('ajax', {
                url: "/home/getdata",
                type: "POST"
            })
            .withPaginationType('full_numbers')
            .withDisplayLength(10);
    }]);