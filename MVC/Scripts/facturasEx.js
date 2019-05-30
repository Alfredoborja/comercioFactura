

function cargarClientes() {
  
    $.ajax({
        alert("CargarCLientes"),
        url:'/FacturasEX/ListarClientes',
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",

        //success: function (result) {
        //    var html = '';
        //    $.each(result, function(indice, item){
        //        html += '<tr style="font-family: Calibri; font-size: 16px; color:#333333">';
        //        html += '<td>' + item.ID + '</td>';
        //        html += '<td>' + item.cliente + '</td>';
        //        html += '<td>' + item.calle + '</td>';
        //        html += '<td>' + item.cp + '</td>';
        //        html += '<td>' + item.colonia + '</td>';
        //        html += '<td>' + item.pais + '</td>';
        //        html += '<td>' + item.moneda + '</td>';
        //        html += '<td><input type="button" value="Seleccionar" class="btn btn-primary" /></td>'
        //        html += '</tr>';
              
        //    });
            
        //    $('#tbl1').append(html);
        //    //document.getElementById("tbl1").innerHTML = html;
            
        //},
        //error: function (errormessage) {
        //    alert(errormessage)
        //}

    });
}

$(document).ready(function () {
    $.ajax({
        url: '/FacturasEX/ListarClientes',
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",

        //success: function (result) {
        //    var html = '';
        //    $.each(result, function (indice, item) {
        //        html += '<tr style="font-family: Calibri; font-size: 16px; color:#333333">';
        //        html += '<td>' + item.ID + '</td>';
        //        html += '<td>' + item.cliente + '</td>';
        //        html += '<td>' + item.calle + '</td>';
        //        html += '<td>' + item.cp + '</td>';
        //        html += '<td>' + item.colonia + '</td>';
        //        html += '<td>' + item.pais + '</td>';
        //        html += '<td>' + item.moneda + '</td>';
        //        html += '</tr>';

        //    });

        //    $('#tbl1').append(html);
        //    //document.getElementById("tbl1").innerHTML = html;

        //},
        //error: function (errormessage) {
        //    alert(errormessage)
        //}

    });
});

function cargarClientesBusqueda(e) {
    alert("Aqui"+e);
    $.ajax({
        url: '/FacturasEX/LisatarClientesXBusqueda',
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        data: { idC: $("id_cliente").val() },
       
        success: function (result)
        {
            var html = '';
            $.each(result, function(indice, item){
                html += '<tr style="font-family: Calibri; font-size: 16px; color:#333333">';
                html += '<td>' + item.ID + '</td>';
                html += '<td>' + item.cliente + '</td>';
                html += '<td>' + item.calle + '</td>';
                html += '<td>' + item.cp + '</td>';
                html += '<td>' + item.colonia + '</td>';
                html += '<td>' + item.pais + '</td>';
                html += '<td>' + item.moneda + '</td>';
                html += '<td><input type="button" value="Seleccionar" class="btn btn-primary" /></td>'
                html += '</tr>';
            });

            $('#tbl1').append(html);
            
        },

        error: function (errormessage) {
            alert(errormessage)
        }
    });

}
