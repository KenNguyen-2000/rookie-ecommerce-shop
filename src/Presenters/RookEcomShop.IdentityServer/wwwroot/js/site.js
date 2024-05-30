// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// <reference path='~/Scripts/jquery-3.7.1.js' />;
$(function () {
  $("#user-menu-button").on("click", () => {
    var userMenu = $('[aria-labelledby="user-menu-button"]');
    if (userMenu.hasClass("invisible")) {
      userMenu.removeClass(
        "transition ease-out duration-100 transform opacity-0 scale-95 invisible",
      );
      userMenu.addClass(
        "transition ease-in duration-75 transform opacity-100 scale-100",
      );
    } else {
      userMenu.removeClass(
        "transition ease-in duration-75 transform opacity-100 scale-100",
      );
      userMenu.addClass(
        "transition ease-out duration-100 transform opacity-0 scale-95",
      );
      setTimeout(() => {
        userMenu.addClass("invisible");
      }, 100);
    }
  });

  $(".navigation-btn").map((btnIndex, button) => {
    $(button).on("click", function (event) {
      event.preventDefault();
      event.stopPropagation();
      this.classList.toggle("active");
      $(".navigation-btn").not(this).removeClass("active");

      $(".flyout-menu").map((menuInedx, menu) => {
        if (menuInedx === btnIndex) {
          toggleFlyout.bind(menu)();
        } else {
          hideFlyoutMenu.bind(menu)();
        }
      });
    });
  });

  function hideFlyoutMenu() {
    $(this).removeClass("transition ease-out duration-200 opacity-100");
    $(this).addClass("transition ease-in duration-150 opacity-0");
    setTimeout(() => {
      $(this).addClass("invisible");
    }, 200);
  }

  function toggleFlyout() {
    if ($(this).hasClass("invisible")) {
      $(this).removeClass(
        "transition ease-in duration-150 opacity-0 invisible",
      );
      $(this).addClass("transition ease-out duration-200 opacity-100");
    } else {
      $(this).removeClass("transition ease-out duration-200 opacity-100");
      $(this).addClass("transition ease-in duration-150 opacity-0");
      setTimeout(() => {
        $(this).addClass("invisible");
      }, 200);
    }
  }

  function hideAllFlyouts() {
    $(".flyout-menu").map((menuIndex, menu) => {
      hideFlyoutMenu.bind(menu)();
    });
    $(".navigation-btn").removeClass("active");
  }

  $(document).on("click", function (e) {
    if (
      !$(".flyout-menu").is(e.target) &&
      $(".flyout-menu").has(e.target).length === 0 &&
      !$(".navigation-btn").is(e.target) &&
      $(".navigation-btn").has(e.target).length === 0
    ) {
      hideAllFlyouts();
    }
  });
});
