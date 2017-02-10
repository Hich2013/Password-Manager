var PasswordControllers = angular.module("PasswordControllers", []);

//  controller call the api method and display the list of passwords  
// in list.html  
PasswordControllers.controller("ListController", ['$scope', '$http',
    function ($scope, $http) {
        $http.get('/api/password').success(function (data) {
            $scope.passwords = data;
        });
    }
]);


// this controller call the api method and display the record of selected password  
// in delete.html and provide an option for delete  
PasswordControllers.controller("DeleteController", ['$scope', '$http', '$routeParams', '$location',
    function ($scope, $http, $routeParams, $location) {
        $scope.id = $routeParams.id;
        $http.get('/api/password/' + $routeParams.id).success(function (data) {
            $scope.application = data.Application;
            $scope.password = data.Password;
            $scope.createdDate = data.CreatedDate;
        });
        $scope.delete = function () {
            $http.delete('/api/password/' + $scope.id).success(function (data) {
                $location.path('/list');
            }).error(function (data) {
                $scope.error = "An error has occured while deleting the password! " + data;
            });
        };
    }
]);


// this controller call the api method and display the record of selected password  
// in edit.html and provide an option for create and modify the password and save the password record  
PasswordControllers.controller("EditController", ['$scope', '$filter', '$http', '$routeParams', '$location',
    function ($scope, $filter, $http, $routeParams, $location) {
     
        $scope.save = function () {
            var today = new Date();
            var date = today.getFullYear() + '-' + (today.getMonth() + 1) + '-' + today.getDate();

            var obj = {
                SecurityEntityId: $scope.id,
                Application: $scope.application,
                CreatedDate: date,
            };
            if ($scope.id == 0) {
                $http.post('/api/password/', obj).success(function (data) {
                    $location.path('/list');
                }).error(function (data) {
                    $scope.error = "An error has occured while adding password! " + data.ExceptionMessage;
                });
            }
            else {
                $http.put('/api/password/', obj).success(function (data) {
                    $location.path('/list');
                }).error(function (data) {
                    console.log(data);
                    $scope.error = "An Error has occured while Saving password! " + data.ExceptionMessage;
                });
            }
        }
        if ($routeParams.id) {
            $scope.id = $routeParams.id;
            $scope.title = "Edit Password";
            $http.get('/api/password/' + $routeParams.id).success(function (data) {
                $scope.password = data.Password;
                $scope.application = data.Application;
                $scope.createdDate = data.CreatedDate;
            });
        }
        else {
            $scope.title = "Create New Employee";
        }
    }
]);