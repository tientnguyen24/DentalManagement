var BillController = function () {
    this.initialize = function () {
        loadData();
    }

    function loadData() {
        $.ajax({
            type: "GET",
            url: '/Bill/GetListItems',
            success: function (res) {
                var html = '';
                var total = 0;
                var tempTotal = 0;
                $.each(res, function (i, item) {
                    html += "<tr>"
                        + " <td>" + (i + 1) + "</td>"
                        + " <td>" + item.productName + "</td>"
                        + " <td>" + item.unitPrice + "</td>"
                        + " <td><a type=\"button\" class=\"btn\" href=\"#\"><i class=\"fas fa-minus-circle fa-sm text-danger\"></i></a>" + item.quantity + "<a type=\"button\" class=\"btn\" href=\"#\"><i class=\"fas fa-plus-circle fa-sm text-success\"></i></a></td>"
                        + " <td>" + item.unitPrice * item.quantity + "</td>"
                        + " </tr>";
                    total += item.unitPrice * item.quantity;
                    tempTotal += item.unitPrice * item.quantity;
                });
                $('#bill_body').html(html);
                $('#lbl_total').text(total);
                $('#lbl_no_of_items').text(res.length);
                $('#lbl_temp_total').text(tempTotal);
            }
        });
    }
}