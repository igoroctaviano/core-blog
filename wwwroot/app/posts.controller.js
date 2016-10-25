(function() {
'use strict';

  angular
    .module('app')
    .controller('PostsController', PostsController);

  PostsController.$inject = ['$http'];
  function PostsController($http) {
    var vm = this;
    vm.posts = [];

    activate();

    function activate() { 
      $http.get('/api/post')
        .then(function(response) {
            vm.posts = response.data;
        })
        .catch(function(err){
            console.log(err);
        });
    }
  }
})();