$(document).ready(function () {
    alert("ddddd");
        //$('#idTableClients').DataTable().destroy();
    let table = $('#idTableClients').DataTable({
        
        "columns": [
                
            { "title": "Nom" },
            { "title": "Adresse", "width": "40%" },
            { "title": "Famille" },
            { "title": "Ville" },
            { "title": "contact" },
            { "title": "Mail" },
            { "title": "Mail" },
       
            //{ "title": "DatedeCreation" },
            { "title": "GSM" },

            {
                //"targets": 14,
                "title": "Actions",
                "data": "id",
                "width": "20%",
                "text-align": "center",
                "orderable": false,
                "text-align": "center",
                "render": function (data, type, full, meta) {
                    return "<a   style='width:40px' class='btn btn-success' onclick=PopupForm('@Url.Action("Edit", "Client")/" + data + "') ><i class='far fa-edit'></i></a><a onclick=Delete('" + data + "') style= 'margin-left: 5px;width:40px' class='btn btn-danger'><i class='fas fa-trash-alt'></i></a><a  style= 'margin-left: 5px;width:40px' class='btn btn-outline-dark'><i class='fas fa-info'></i></a>";
                    }
                }
        ],
       "searching": true,
        // "scrollX": true,
        "scrollCollapse": true,
        //"autoWidth": false,
        //"colReorder": true,
        "language": {
            "info": "Afficher _END_ sur _TOTAL_ ",
            "lengthMenu": "Afficher _MENU_ par page",
            "paginate": {
                "first": "Premier",
                "last": "Dernier",
                "next": "Suivant",
                "previous": "Précédent"
            },
            //"emptyTabale": "Pas d'enregistrement trouvés",
            "emptyTable": "Chargement des donnée en cours, veuillez patienter ...",
            select: {
                style: 'multi'
            },
        }
    });






});


function PopupForm(url) {
    var formDiv = $('<div/>');
    $.get(url)
        .done(function (response) {
            formDiv.html(response);
            Popup = formDiv.dialog({
                autoOpen: true,
                height: 550,
                width: 700,
                resizable: false,
                title: 'Fiche client',
                close: function () {
                   Popup.dialog('destory').remove();
                }
            });
        });
}
    function Delete(id) {
        if (confirm("Etes-vous sur de vouloir supprimer ce client")) {
            $.ajax({
                type: "Post",
                url: "@Url.Action("Delete","Clients")/" + id ,
                success: function (data) {
                    if (data.success) {
                        dataTables.ajax.reload(),
                            $.notify(data.message, {
                                globalPosition: "top center",
                                className: "success",
                            })
                    }
                }
            });
        }
    }
