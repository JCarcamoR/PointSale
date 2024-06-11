
var btnRetLogin = document.getElementById("btnReturLog");
btnRetLogin.addEventListener("click", function () {
    CleanForms();
    let SecLog = document.getElementById("SecLogin");
    SecLog.style.display = "block";
    let SecCto = document.getElementById("SecContacto");
    SecCto.style.display = "none";
});

var linkContacto = document.getElementById("lknCto");
linkContacto.addEventListener("click", function () {
    CleanForms();
    let SecLog = document.getElementById("SecLogin");
    SecLog.style.display = "none";
    let SecCto = document.getElementById("SecContacto");
    SecCto.style.display = "block";
});

function CleanForms() {
    $('#UserLogin').val('');
    $('#password').val('');
    $('#CteNombre').val('');
    $('#CteApe').val('');
    $('#CteEmail').val('');
    $('#CteTel').val('');
    $('#CteOpOtro').val('');
    $('#CteDesc').val('');
    $('#CteAs').val('1');
    cambioOpcion();
}

function togglePasswordVisibility() {
    var passwordInput = document.getElementById("password");
    if (passwordInput.type === "password") {
        passwordInput.type = "text";
    } else {
        passwordInput.type = "password";
    }
}

function cambioOpcion() {
    let valorSeleccionado = $("#CteAs").val();
    let txtOtro = document.getElementById("CteOpOtro");
    let lstASun = document.getElementById("CteAs");

    if (valorSeleccionado == 4) {
        lstASun.style.display = "none";
        txtOtro.style.display = "block";
    } else {
        lstASun.style.display = "block";
        txtOtro.style.display = "none";
    }
}