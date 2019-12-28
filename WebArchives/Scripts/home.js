$(function () {
    $loginForm = $('#loginForm');
    $loginForm.on('submit', function (e) {

        e.preventDefault();

        // ajax request
        $.ajax(
        {
            url: $loginForm.attr('action'),
            type: $loginForm.attr('method'),
            data: JSON.stringify({ 'email': $('#email').val(), 'password': $('#password').val() }),
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            complete: function () {
            },
            success: function (data) {
                if (!data.success) {
                    $('#res').remove();

                    $('#login').append('<div id="res" class="alert alert-danger alert-dismissable">Identifiant ou mot de passe incorrect</div>');
                }
                else {
                    $('#res').remove();

                    $('#login').html('<div id="res" class="alert alert-success alert-dismissable">Identification réussie</div>');
                    window.location.href = data.url;
                }
            },
            error: function () {
                alert('Erreur.Merci de contacter le webmaster!');
            }
        });
    });
});