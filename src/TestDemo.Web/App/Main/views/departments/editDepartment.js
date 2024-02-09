(function () {
    angular.module('app').controller('app.views.departments.editDepartment', [
        '$scope', '$uibModalInstance', 'abp.services.app.department', 'id',
        function ($scope, $uibModalInstance, departmentService, id) {
            var vm = this;
            vm.department = {};

            var init = function () {
                getDepartmentById();
            }

            function getDepartmentById() {

                departmentService.getDepartmentById({ id: id })
                    .then(function (result) {
                        vm.department = result.data;


                    });

            }
            vm.save = function () {
                departmentService.updateDepartment(vm.department)
                    .then(function () {
                        abp.notify.info(App.localize('SavedSuccessfully'));
                        $uibModalInstance.close();
                    });
            };


            vm.cancel = function () {
                $uibModalInstance.dismiss({});
            };

            init();


        }
    ]);
})();