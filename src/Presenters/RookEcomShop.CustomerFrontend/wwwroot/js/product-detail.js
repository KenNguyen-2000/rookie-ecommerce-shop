// <reference path='~/Scripts/jquery-3.7.1.js' />;
// ------------- Review star rating -----------------
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

// ------------- Description and Reviews switch -----------------
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

// ------------- Image gallary -----------------
const swiper = new Swiper('.swiper', {
  // Optional parameters
  direction: 'horizontal',
  // Enable autoplay
  autoplay: {
    delay: 3000, // Delay between slides in milliseconds
    disableOnInteraction: false, // Keep autoplay running even after user interactions
  },
  loop: true,
  wrapper: {
    el: '.swiper-wrapper',
  },

  // Navigation arrows
  navigation: {
    nextEl: '.swiper-button-next',
    prevEl: '.swiper-button-prev',
  },

  // If we need pagination
  pagination: {
    el: '.swiper-pagination',
  },
});

// ------------- Product add to cart -----------------

$('#decrease-quantity-btn').on('click', function () {
  var quantity = parseInt($('#product-quantity').val());
  if (quantity > 1) {
    $('#product-quantity').val(quantity - 1);
  }
});

$('#increase-quantity-btn').on('click', function () {
  var quantity = parseInt($('#product-quantity').val());
  $('#product-quantity').val(quantity + 1);
});

$('#add-to-cart-form').on('submit', function (event) {
  event.preventDefault();
  const productId = $(this).find('input[name="productId"]').val();
  const productQuantity = $(this).find('input[name="productQuantity"]').val();
  console.log(`Add ${productQuantity} products with id ${productId} to cart`);
  if (productId) {
    addProductToCart(productId, productQuantity);
  }
});

$('#add-one-cart-form').on('submit', function (event) {
  event.preventDefault();
  const productId = $(this).find('input[name="productId"]').val();
  const productQuantity = $(this).find('input[name="productQuantity"]').val();
  console.log(`Add ${productQuantity} products with id ${productId} to cart`);
  if (productId) {
    addProductToCart(productId, productQuantity);
  }
});

function addProductToCart(productId, productQuantity) {
  $.ajax({
    url: '/cart/add-to-cart?productId=' + productId,
    type: 'POST',
    headers: {
      'X-Requested-With': 'XMLHttpRequest',
      'Access-Control-Allow-Origin': '*', // Required for CORS
    },
    data: {
      productId: productId,
      quantity: productQuantity ?? 1,
    },
    success: function (data) {
      console.log('Success:', data);
      // Handle the response data here
      showSuccessToast('Product added to cart');
      $.ajax({
        url: '/cart/update-header',
        type: 'GET',
        success: function (headerHtml) {
          $('#header-wrapper').html(headerHtml);
        },
      });
    },
    error: function (error) {
      console.log('Error:', error);
      // Handle the error here
    },
  });
}

function showSuccessToast(message) {
  var customNode = document.createElement('div');
  customNode.innerHTML = `
    <div>
      <h3 class="text-white">${message}</h3>
    </div>
    `;
  Toastify({
    text: message,
    duration: 3000,
    newWindow: true,
    close: true,
    node: customNode,
    gravity: 'bottom', // `top` or `bottom`
    position: 'right', // `left`, `center` or `right`
    stopOnFocus: true, // Prevents dismissing of toast on hover
    className: 'success-toast', // The CSS class name of the toast
    onClick: function () {}, // Callback after click
  }).showToast();
}
