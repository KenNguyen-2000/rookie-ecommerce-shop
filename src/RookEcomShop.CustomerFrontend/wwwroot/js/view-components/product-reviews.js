var dialog = $('#review-modal')[0];
$('#write-review-btn').on('click', function () {
  dialog.showModal();
});

$('#close-review-modal').on('click', function () {
  dialog.close();
});
