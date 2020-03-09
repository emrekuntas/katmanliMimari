$(function () {
    $('.js-modal-onayEkrani .btn').on('click', function () {
        var color = $(this).data('color');
        $('#mdModal .modal-content').removeAttr('class').addClass('modal-content modal-col-' + color);
        $('#mdModal').modal('show');
    });
});
$(function () {
    $('.js-modal-istenCikarma .btn').on('click', function () {
        var color = $(this).data('color');
        $('#mdModal2 .modal-content').removeAttr('class').addClass('modal-content modal-col-' + color);
        $('#mdModal2').modal('show');
    });
});
$(function () {
    $('.js-modal-pozisyonEkle .btn').on('click', function () {
        var color = $(this).data('color');
        $('#largeModal .modal-content').removeAttr('class').addClass('modal-content modal-col-' + color);
        $('#largeModal').modal('show');
    });
});
$(function () {
    $('.js-modal-maasbilgisiEkle .btn').on('click', function () {
        var color = $(this).data('color');
        $('#maasModal .modal-content').removeAttr('class').addClass('modal-content modal-col-' + color);
        $('#maasModal').modal('show');
    });
});
$(function () {
    $('.js-modal-izinEkle .btn').on('click', function () {
        var color = $(this).data('color');
        $('#izinEkleModal .modal-content').removeAttr('class').addClass('modal-content modal-col-' + color);
        $('#izinEkleModal').modal('show');
    });
});
$(function () {
    $('.js-modal-izinDurumuEkle .btn').on('click', function () {
        var color = $(this).data('color');
        $('#izinDetayModal .modal-content').removeAttr('class').addClass('modal-content modal-col-' + color);
        $('#izinDetayModal').modal('show');
    });
});
$(function () {
    $('.js-modal-OdemeEkle .btn').on('click', function () {
        var color = $(this).data('color');
        $('#odemeModal .modal-content').removeAttr('class').addClass('modal-content modal-col-' + color);
        $('#odemeModal').modal('show');
    });
});
$(function () {
    $('.js-modal-fazlaMesaiEkle .btn').on('click', function () {
        var color = $(this).data('color');
        $('#mesaiModal .modal-content').removeAttr('class').addClass('modal-content modal-col-' + color);
        $('#mesaiModal').modal('show');
    });
});
$(function () {
    $('.js-modal-zimmetEkle .btn').on('click', function () {
        var color = $(this).data('color');
        $('#zimmetEkleModal .modal-content').removeAttr('class').addClass('modal-content modal-col-' + color);
        $('#zimmetEkleModal').modal('show');
    });
});