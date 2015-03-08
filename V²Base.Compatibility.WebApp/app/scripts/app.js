'use strict';

var app=angular.module('angularJsApp', [
  'ngCookies',
  'ngResource',
  'ngSanitize',
  'ngRoute'
])
  .config(function ($routeProvider) {
    $routeProvider
     
    .when('/', {
        templateUrl: 'views/main.html',
        controller: 'MainCtrl'
      }) 
      .otherwise({
        redirectTo: '/'
      });
  }).controller('zone', ['$scope', function($scope) {
 console.log("zone ctrl loaded3");
 
}]);