var passwordApp = angular.module('PasswordApp', ['ngRoute', 'PasswordControllers']);

passwordApp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/list',
    {
        templateUrl: 'Static/List.html',
        controller: 'ListController'
    }).
    when('/create',
    {
        templateUrl: 'Static/Edit.html',
        controller: 'EditController'
    }).
    when('/edit/:id',
    {
        templateUrl: 'Static/Edit.html',
        controller: 'EditController'
    }).
    when('/delete/:id',
    {
        templateUrl: 'Static/Delete.html',
        controller: 'DeleteController'
    }).
    otherwise(
    {
        redirectTo: '/list'
    });
}]);