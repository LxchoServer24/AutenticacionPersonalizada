/*$(".toggle-password").click(function () {

    $(this).toggleClass("fa-eye fa-eye-slash");
    var input = $($(this).attr("toggle"));
    if (input.attr("type") == "password") {
        input.attr("type", "text");
    } else {
        input.attr("type", "password");
    }
});  */



const visibilityToggle = document.querySelector('.visibility');

const input = document.querySelector('.ojo input');

var password = true;

visibilityToggle.addEventListener('click', function () {
    if (password) {
        input.setAttribute('type', 'text');
        visibilityToggle.innerHTML = 'visibility';
    } else {
        input.setAttribute('type', 'password');
        visibilityToggle.innerHTML = 'visibility_off';
    }
    password = !password;

}); 
/*
var state = false;
function toggle() {
    if (state) {
        document.getElementById("password-field").setAttribute("type", "password");
        state = false;
    }
    else {
        document.getElementById("password-field").setAttribute("type", "text");
        state = true;
    }
}*/