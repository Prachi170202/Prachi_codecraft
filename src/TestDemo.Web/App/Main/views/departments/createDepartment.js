(function () {
    angular.module('app').controller('app.views.departments.createDepartment', [
        '$scope', '$uibModalInstance', 'abp.services.app.department',
        function ($scope, $uibModalInstance, departmentService) {
            var vm = this;

            vm.department = {};


            vm.save = function () {
                abp.ui.setBusy();
                departmentService.createDepartment(vm.department)
                    .then(function () {
                        abp.notify.info(App.localize('SavedSuccessfully'));
                        alert(11);
                        debugger;
                        $uibModalInstance.close();
                    }).finally(function () {
                        abp.ui.clearBusy();
                    });
            };

            vm.cancel = function () {
                $uibModalInstance.dismiss();
            };
        }
    ]);
})();
