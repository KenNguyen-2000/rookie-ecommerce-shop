// ------------- Review star rating -----------------
$('.review-star').on('mouseover', function () {
  var starValue = $(this).find('input').val();
  $('.review-star').each(function (index, element) {
    if (index + 1 <= starValue) {
      $(element)
        .addClass('fill-amber-400 stroke-amber-400')
        .removeClass('fill-white stroke-black');
    }
  });
});

$('.review-star').on('mouseout', function () {
  $('.review-star').each(function (index, element) {
    if ($(element).hasClass('selected')) return;

    $(element)
      .addClass('fill-white stroke-black')
      .removeClass('fill-amber-400')
      .removeClass('stroke-amber-400');
  });
});

$('.review-star').on('click', function () {
  const starValue = $(this).find('input').val();
  console.log(starValue);
  $('#modal-rating').val(starValue);

  $('.review-star').each(function (index, element) {
    $(element).removeClass('fill-amber-400 stroke-amber-400 selected');

    if (index + 1 <= starValue) {
      $(element)
        .addClass('fill-amber-400 stroke-amber-400 selected')
        .removeClass('fill-white stroke-black');
    }
  });
});
