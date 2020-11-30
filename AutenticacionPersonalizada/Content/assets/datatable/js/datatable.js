// Call the dataTables jQuery plugin
$(document).ready(function () {
    $('#dataTable_length').DataTable({
        "language": {
            "url": "../../Content/assets/datatable/language/Spanish.json"
        },
        "order": [[0, "asc"]]
    });
});
