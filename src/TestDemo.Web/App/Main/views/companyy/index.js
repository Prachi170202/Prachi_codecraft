(function () {
    angular.module('app').controller('app.views.companyy.index',
        ['$scope', '$timeout', '$uibModal', 'abp.services.app.company',
            function ($scope, $timeout, $uibModal, companyService) {
                var vm = this;

                vm.company = [];


                function getTest() {
                    companyService.getAllEmploye({}).then(function (result) {
                        vm.company = result.data;

                    });
                }

                vm.openCreateDepartment = function () {
                   
                    var modalInstance = $uibModal.open({
                        templateUrl: '/App/Main/views/companyy/createCompany.cshtml',
                        controller: 'app.views.companyy.createCompany as vm',
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
