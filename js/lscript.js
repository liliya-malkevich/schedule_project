function togglePassword(){
    var input = document.getElementById('password');
    var icon = document.getElementById('icon');

    if(input.type==="password"){
        input.type = "text";
        icon.classList.add('selected');
    }
    else{
        input.type="password";
        icon.classList.remove('selected');
    }
}

function loginSystem(){
    var input = document.getElementById('password').value;
    var login = document.getElementById('login').value;
    // alert(input);
    
    // alert(typeof(input));
    if(login=="student"){
       // alert(login);
    //var url = document.getElementById('log-button');
	// document.location.href = url.value;
    window.location.href = '../html/schedule.html';
    }
}