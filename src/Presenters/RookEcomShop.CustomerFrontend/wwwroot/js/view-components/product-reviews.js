var dialog = $('#review-modal')[0];
$('#write-review-btn').on('click', function () {
  dialog.showModal();
});

$('#close-review-modal').on('click', function () {
  dialog.close();
});

// --------------- Delete Review Modal behaviour BEGIN --------------
var deleteReviewDialog = $('#delete-review-dialog')[0];
var deleteReviewDialogBackdrop = $('.delete-review-dialog__backdrop');
var deleteReviewDialogModal = $('.delete-review-dialog__modal');

$('#cancel-delete-review-btn').on('click', toggleDeleteModal);
$('#delete-review-btn').on('click', toggleDeleteModal);

// $('#confirm-delete-review-btn').on('click', function () {
//   toggleDeleteModal();
// });

function toggleDeleteModal() {
  const isModalVisible = !deleteReviewDialog.classList.contains('invisible');
  if (isModalVisible) {
    hideDeleteReviewModal();
  } else {
    showDeleteReviewModal();
  }
}
function showDeleteReviewModal() {
  deleteReviewDialog.classList.toggle('invisible');

  deleteReviewDialogBackdrop.removeClass('opacity-0');
  deleteReviewDialogBackdrop.addClass('opacity-100');

  deleteReviewDialogModal.removeClass(
    'opacity-0 translate-y-4 sm:translate-y-0 sm:scale-95'
  );
  deleteReviewDialogModal.addClass('opacity-100 translate-y-0 sm:scale-100');

  setTimeout(() => {
    deleteReviewDialogBackdrop.removeClass('ease-out duration-300');
    deleteReviewDialogModal.removeClass('ease-out duration-300');

    deleteReviewDialogBackdrop.addClass('ease-in duration-200');
    deleteReviewDialogModal.addClass('ease-in duration-200');
  }, 300);
}

function hideDeleteReviewModal() {
  deleteReviewDialogBackdrop.removeClass('opacity-100');
  deleteReviewDialogBackdrop.addClass('opacity-0');

  deleteReviewDialogModal.removeClass('opacity-100 translate-y-0 sm:scale-100');
  deleteReviewDialogModal.addClass(
    'opacity-0 translate-y-4 sm:translate-y-0 sm:scale-95'
  );

  setTimeout(() => {
    deleteReviewDialogBackdrop.removeClass('ease-in duration-200');
    deleteReviewDialogModal.removeClass('ease-in duration-200');

    deleteReviewDialogBackdrop.addClass('ease-out duration-300');
    deleteReviewDialogModal.addClass('ease-out duration-300');
    deleteReviewDialog.classList.toggle('invisible');
  }, 200);
}

function deleteReview(reviewId) {
  var review = document.getElementById(reviewId);
  review.remove();
}

// --------------- Delete Review Modal behaviour End --------------