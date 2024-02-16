(function () {
    angular.module('app').controller('app.views.companyy.createCompany', [
        '$scope', '$uibModalInstance', 'abp.services.app.company',
        function ($scope, $uibModalInstance, companyService) {
            var vm = this;
            vm.company = {};
            vm.department = [];


            function getDepartmentData() {
                companyService.bindDepartmentIds()
                    .then(function (result) {
                        debugger;
                        vm.department = result.data;

                    });
            }
            getDepartmentData();

            vm.save = function () {
                abp.ui.setBusy();
                companyService.createDepartment(vm.company)
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
