$(document).ready(function () {
    alert("ddddd");
        //$('#idTableClients').DataTable().destroy();
    let table = $('#idTableClients').DataTable({
        //"ajax": {
        //    "url": "/Clients/Index",
        //    "type": "Get",
        //    "datatype": "json"
        //},
        "columns": [
          
            { "title": "Nom" },
            { "title": "Adresse" },
            { "title": "Famille" },
            { "title": "Ville" },
            { "title": "Contact" },
            { "title": "Mail" },
            { "title": "Téléphone" },
            { "title": "Fax" },
            { "title": "Date de Creation" },
            { "title": "I.D.F." },
            { "title": "CNSS." },
            { "title": "ICE." },
            { "title": "GSM." },
            { "title": "Téléphone" },
            {
                "title": "Actions",
                "width": "80%",
                "orderable": false,
                "class": "center",
                //"render": function (data, type, full, meta) {
                //    return "<a  style='width:40px' class='btn btn-success' ><i class='far fa-edit'></i></a><a  style= 'margin-left: 5px;width:40px' class='btn btn-danger'><i class='fas fa-trash-alt'></i></a><a  style= 'margin-left: 5px;width:40px' class='btn btn-outline-dark'><i class='fas fa-info'></i></a>";
                //},


            }
            
        ],
        //"columnDefs": [
        //  //  { "width": "150%", "targets": "_all" },
        //    { "width": "20%", "targets": 0 },
        //    { "width": "15%", "targets": 1 },
        //    { "width": "60%", "targets": 2 },
        //    { "width": "80%", "targets": 14 },
        //    // { "width": "60%", "targets": 0 },
            
        //        "targets": 14,
        //           "width": "80%",
        //    },
        //],
        //fixedColumns: {
        //    leftColumns: 1,
        //    rightColumns: 1
        //},
       // exemple 
        //columnDefs: [
        //    { "width": "20%", "targets": 0, "responsivePriority": 1, },
        //    { "width": "15%", "targets": 1 },
        //    {
        //        "width": "30%", "targets": 2, "render": function (data, type, row, meta) {
        //            return '<a href="monLien/' + idVile + '"+>Localiser ma ville</a>';
        //        }
        //    },
        "searching": true,
        scrollX: true,
        scrollCollapse: true,
        autoWidth: true,
        colReorder: true,
        
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