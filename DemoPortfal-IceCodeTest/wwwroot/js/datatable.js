window.DataTables1 = {
    dataTable: null,
    buildDataTable: function () {
        this.dataTable = $("#dt1").DataTable({searching: false, pagingType: 'simple_numbers'});
        var x = $(".dataTables_paginate").parent();
        x.removeClass("col-md-7");
        x.addClass("col-md-6");

    },
    destroyDataTable: function () {
        if (this.dataTable) {
            this.dataTable.destroy();
        }        
    }
}