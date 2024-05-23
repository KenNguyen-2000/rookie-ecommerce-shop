// <reference path='~/Scripts/jquery-3.7.1.js' />;

$('.review-star-btn').on('mouseover', function () {
  var starValue = $(this).find('input').val();
  $('.review-star-btn').each(function (index, element) {
    if (index <= starValue) {
      $(element)
        .addClass('selected fill-amber-400 stroke-amber-400')
        .removeClass('fill-white')
        .removeClass('stroke-black');
    }
  });
});

$('.review-star-btn').on('mouseout', function () {
  $('.review-star-btn').each(function (index, element) {
    $(element)
      .addClass('fill-white stroke-black')
      .removeClass('fill-amber-400')
      .removeClass('stroke-amber-400');
  });
});

$('.review-star-btn').on('click', function () {
  var starValue = $(this).find('input').val();
  console.log(starValue);
  $('.review-star-btn').each(function (index, element) {
    if (index <= starValue) {
      $(element)
        .addClass('fill-amber-400 stroke-amber-400')
        .removeClass('fill-white stroke-black');
    }
  });
});

$('.product-info-btn').on('click', function () {
  this.classList.add('selected');
  $('.product-info-btn').not(this).removeClass('selected');

  if (this.value === 'description') {
    $('#product-description-sec').removeClass('hidden');
    $('#product-reviews-sec').addClass('hidden');
  } else {
    $('#product-description-sec').addClass('hidden');
    $('#product-reviews-sec').removeClass('hidden');
  }
});
