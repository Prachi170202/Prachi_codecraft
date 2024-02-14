(function () {
    angular.module('app').controller('app.views.companyy.index',
        ['$scope', '$timeout', '$uibModal', 'abp.services.app.department',
            function ($scope, $timeout, $uibModal, departmentService) {
                var vm = this;

                vm.company = [];


                function getTest() {
                    departmentService.getAllEmploye({}).then(function (result) {
                        vm.department = result.data;

                    });
                }

                vm.openCreateDepartment = function () {
                    var modalInstance = $uibModal.open({
                        templateUrl: '/App/Main/views/departments/createDepartment.cshtml',
                        controller: 'app.views.departments.createDepartment as vm',
                        backdrop: 'static'
                    });

                    modalInstance.rendered.then(function () {
                        $.AdminBSB.input.activate();
                    });

                    modalInstance.result.then(function () {
                        getTest();
                    });
                };
              

                var init = function () {
                    getTest();
                }
                init();
            }
        ]);
})();
