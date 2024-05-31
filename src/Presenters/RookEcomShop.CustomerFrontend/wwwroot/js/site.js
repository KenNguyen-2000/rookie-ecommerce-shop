// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('#search-form').on('submit', function (e) {
  e.preventDefault();
  const searchVal = $(e.target).find('input').val();
  const currentPath = window.location.pathname;
  const paramsString = window.location.href.split('?')[1];

  if (paramsString) {
    const params = new URLSearchParams(paramsString);
    params.set('searchTerm', searchVal);
    window.location.href = `${currentPath.split('?')[0]}?${params.toString()}`;
  } else {
    window.location.href = `${currentPath}?searchTerm=${searchVal}`;
  }
});
