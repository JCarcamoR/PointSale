
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
}

function togglePasswordVisibility() {
    var passwordInput = document.getElementById("password");
    if (passwordInput.type === "password") {
        passwordInput.type = "text";
    } else {
        passwordInput.type = "password";
    }
}