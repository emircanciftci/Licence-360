function LoginCheck() {
    var data = {
        username: $('#username').val(),
        password: $('#password').val(),
    }

    if (data.username != '' || data.username != null) {
        if (data.password != '' || data.password != null) {
            $.ajax({
                url: '/Login/LoginCheck',
                type: 'post',
                data: data,
                success: function (res) {
                    if (res.ID != 0) {
                        window.location.replace('/Home/Index')
                    }
                    else {
                        alert('Giriş Yapılamadı !!!')
                    }
                }
            });
        }
        else {
            alert("Şifre Adı Hatalı!")
        }
    }
    else {
        alert("Kullanıcı Adı Hatalı!")
    }

}