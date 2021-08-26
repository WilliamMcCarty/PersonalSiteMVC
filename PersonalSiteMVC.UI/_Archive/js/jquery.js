
jQuery(document).ready(function () {
    console.log("jQuery is working!");
});

$(function () {
    $(".thumb").on("click", function () {
        var imgSrc = $(this).attr("src");
        $("#lightbox-content").html('<img src="' + imgSrc + '" class="img-responsive-lightBox" />');
        $("#lightbox-container").fadeIn(1300);
        $("#lightbox-container").on("click", function () {
            $(this).fadeOut(500);
        });

    });


});

$('.main-carousel').flickity({
    // options
    cellAlign: 'left',
    contain: true
});

