﻿
// Declaracion de variables.
var SolicitudContacto = document.getElementById("btnSolContacto");
var btnRetLogin = document.getElementById("btnReturLog");
var linkContacto = document.getElementById("lknCto");

var NombreContacto = document.getElementById("CteNombre");
var ApellidosContacto = document.getElementById("CteApe");
var CorreoContacto = document.getElementById("CteEmail");
var TelefonoContacto = document.getElementById("CteTel");
var ListaAsunto = document.getElementById("CteAs");
var Asunto = document.getElementById("CteOpOtro");
var Descripcion = document.getElementById("CteDesc");

btnRetLogin.addEventListener("click", function () {
    CleanForms();
    let SecLog = document.getElementById("SecLogin");
    SecLog.style.display = "block";
    let SecCto = document.getElementById("SecContacto");
    SecCto.style.display = "none";
});

SolicitudContacto.addEventListener("click", function () {
    EnviarSolicitudDeContacto();
});

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

function togglePasswordVisibility(NumEye) {

    let passwordInput = document.getElementById("password");

    if (passwordInput.type === "password") {
        passwordInput.type = "text";
    } else {
        passwordInput.type = "password";
    }

    let IcEyeNo = document.getElementById("Eye1");
    let IcEyeY  = document.getElementById("Eye2");

    if (NumEye == 1) {
        IcEyeNo.style.display = "none";
        IcEyeY.style.display = "block";
    } else if (NumEye == 2) {
        IcEyeY.style.display = "none";
        IcEyeNo.style.display = "block";
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

function EnviarSolicitudDeContacto() {

    let result = ValidaFormularioContacto();

    if (result == "OK") {

        let nombreCompleto = NombreContacto.value + ' ' + ApellidosContacto;
        let asunto = ListaAsunto.value == '4' ? Asunto.value : ListaAsunto.options[ListaAsunto.selectedIndex].text;
        let datos = {
            NombreContacto: nombreCompleto,
            Asunto: asunto,
            DatosContacto: {
                Telefono: TelefonoContacto.value,
                Correo: CorreoContacto.value
            },
            Cuerpo: Descripcion.value
        };

        $.ajax({
            url: '/Login/SolicitudContacto',
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            data: JSON.stringify(datos),
            success: function (data) {
                console.log(data);
                // Puedes acceder a las propiedades del objeto JSON, por ejemplo:
                // console.log(data.Nombre);
            },
            error: function (error) {
                console.log("Error: ", error);
            }
        });

    } else {
        alert(result);
    }
}

function ValidaFormularioContacto() {

    let resultado = "OK";

    if (NombreContacto.value == '') {
        return resultado = "Por favor, complete el campo <b>NOMBRE</b>.";
    }

    if (ApellidosContacto.value == '') {
        return resultado = "Por favor, complete el campo <b>APELLIDOS</b>.";
    }

    if (CorreoContacto.value == '') {
        return resultado = "Por favor, complete el campo <b>CORREO ELECTÓNICO</b>.";
    }

    if (TelefonoContacto.value != '' && isNaN(TelefonoContacto.value)) {
        return resultado = "Por favor, ingrese un numero valido el campo <b>TELÉFONO</b>.";
    } else if (TelefonoContacto.value == '') {
        return resultado = "Por favor, complete el campo <b>TELÉFONO</b>.";
    }

    if (ListaAsunto.value == '4') {
        if (Asunto.value == '') {
            return resultado = "Por favor, complete el campo <b>ASUNTO</b>.";
        }
    }

    if (Descripcion.value == '') {
        return resultado = "Por favor, complete el campo <b>DESCRIPCIÓN</b>.";
    }

    return resultado;
}