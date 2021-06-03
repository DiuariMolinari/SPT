function GetAddressByCep(cep) {
    $.ajax({
        dataType: "json",
        type: "GET",
        url: `https://api.postmon.com.br/v1/cep/${cep}`,
        data: { cep: cep},
        success: function (data) {
            $("#pais").val("Brasil");
            $("#estado").val(data.estado);
            $("#cidade").val(data.cidade);
            $("#bairro").val(data.bairro);
            $("#logradouro").val(data.logradouro);
        },
        error: function (x, y, z) {
            console.log(x);
            console.log(y);
            console.log(z);
        }
    });
}

$(window).on('load', function () {
    var cep = $("#cep");
    cep.focusout(function (eventObj) {
        var cepValue = $("#cep").val();

        if (cepValue !== "") {
            GetAddressByCep(cepValue);
        }
    });
});