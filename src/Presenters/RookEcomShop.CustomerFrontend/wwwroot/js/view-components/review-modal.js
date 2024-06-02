const $reviewStars = $(".review-star");

function updateStars(starValue) {
  $reviewStars.each(function (index, element) {
    const $element = $(element);
    if (index < starValue) {
      $element
        .addClass("fill-amber-400 stroke-amber-400")
        .removeClass("fill-white stroke-black");
    } else {
      $element
        .addClass("fill-white stroke-black")
        .removeClass("fill-amber-400 stroke-amber-400");
    }
  });
}

$reviewStars.on("mouseover", function () {
  const starValue = $(this).find("input").val();
  updateStars(starValue);
});

$reviewStars.on("mouseout", function () {
  const selectedValue = $(".review-star.selected").length;
  updateStars(selectedValue);
});

$reviewStars.on("click", function () {
  const starValue = $(this).find("input").val();
  $("#modal-rating").val(starValue);
  updateStars(starValue);

  $reviewStars.each(function (index, element) {
    const $element = $(element);
    if (index < starValue) {
      $element.addClass("selected");
    } else {
      $element.removeClass("selected");
    }
  });

  ratingReview(starValue);
});

function ratingReview(starValue) {
  updateStars(starValue);
}
