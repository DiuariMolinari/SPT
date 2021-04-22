function SugeriInvestimento(periodo, valorInvestido) {

    $.ajax({
        dataType: "json",
        type: "POST",
        url: "/Investimento/SugerirTipoInvestimento/",
        data: { valor: valorInvestido, periodo: periodo },
        success: function (data) {
            console.log(data);
            Swal.fire({
                icon: 'success',
                title: `Melhor Investimento: <label style="color:lightgreen; padding-left: 10px;" > ${data.tipoInvestimento}</label>`,
                text: `Valor ao final do período:     ${data.detalhesInvestimento}`,
                customClass: 'swal-wide'
            })
        },
        error: function (x, y, z) {
            console.log(x);
            console.log(y);
            console.log(z);
        }
    });
}

$(window).on('load', function () {
    var valorInvestido = $('#valorInvestido');
    var periodo = $('#periodo');

    valorInvestido.focusout(function (eventObj) {
        var valorInvestidoValue = valorInvestido.val();
        var periodoValue = periodo.val();

        if (valorInvestidoValue !== "" && periodoValue !== "") {
            SugeriInvestimento(periodoValue, valorInvestidoValue);
        }
    });

    periodo.focusout(function (eventObj) {
        var valorInvestidoValue = valorInvestido.val();
        var periodoValue = periodo.val();

        if (valorInvestidoValue !== "" && periodoValue !== "") {
            SugeriInvestimento(periodoValue, valorInvestidoValue);
        }
    });
});
 