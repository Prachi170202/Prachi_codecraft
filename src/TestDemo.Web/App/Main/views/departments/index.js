(function () {
    angular.module('app').controller('app.views.departments.index',
        ['$scope', '$timeout', '$uibModal', 'abp.services.app.department',
            function ($scope, $timeout, $uibModal, departmentService) {
                var vm = this;

                vm.department = [];


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
                vm.openEditDepartment = function (department) {
                    var modalInstance = $uibModal.open({
                        templateUrl: '/App/Main/views/departments/editDepartment.cshtml',
                        controller: 'app.views.departments.editDepartment as vm',
                        backdrop: 'static',
                        resolve: {
                            id: function () {
                                return department.id;
                            }
                        }
                    });

                    modalInstance.rendered.then(function () {
                        $timeout(function () {
                            $.AdminBSB.input.activate();
                        }, 0);
                    });

                    modalInstance.result.then(function () {
                        getTest();
                    });
                };

                vm.delete = function (department) {
                    abp.message.confirm(
                        "Delete department '" + department.departmentName + "'?",
                        "Delete",
                        function (result) {
                            if (result) {
                                departmentService.delete({ id: department.id })
                                    .then(function () {
                                        abp.notify.info("Deleted department: " + department.departmentName);
                                        getTest();
                                    });
                            }
                        });
                }



                var init = function () {
                    getTest();
                }
                init();
            }
        ]);
})();