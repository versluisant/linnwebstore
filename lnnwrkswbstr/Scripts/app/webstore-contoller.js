var app = angular.module('webStoreApp', []);

app.controller('categoriesCtrl', function ($scope) {
    $scope.categories = [
    { 'name': 'books' },
    { 'name': 'cofee machines' },
    { 'name': 'hardware' }
    ];
});