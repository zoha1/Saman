$(document).ready(function () {

    $('.shakeimage').on('mouseover','img', function () {
        $(this).focus();
    });

    $('.shakeimage').on('mouseleave','img', function () {
        $(this).focusout();
    });
})
