$(document).ready(function () {

    $('#btnHost').click(function () {
        $('#modalAccess').addClass('hidden');
    }); 
    $('#btnBackHome').click(function () {
        $('#modalAccess').removeClass('hidden');
    });

});

function showModal(id) {
    $('.modal').modal('hide');
    $('#' + id).modal('show');
};

