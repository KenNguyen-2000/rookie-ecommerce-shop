// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// <reference path='~/Scripts/jquery-3.7.1.js' />;
$('#user-menu-button').on('click', () => {
  var userMenu = $('[aria-labelledby="user-menu-button"]');
  if (userMenu.hasClass('invisible')) {
    userMenu.removeClass(
      'transition ease-out duration-100 transform opacity-0 scale-95 invisible'
    );
    userMenu.addClass(
      'transition ease-in duration-75 transform opacity-100 scale-100'
    );
  } else {
    userMenu.removeClass(
      'transition ease-in duration-75 transform opacity-100 scale-100'
    );
    userMenu.addClass(
      'transition ease-out duration-100 transform opacity-0 scale-95'
    );
    setTimeout(() => {
      userMenu.addClass('invisible');
    }, 100);
  }
});
