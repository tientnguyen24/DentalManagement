var BillController = function () {
    this.initialize = function () {
        loadData();
        registerEvents();
    }

    function registerEvents() {
        $('body').on('click', '.btn-plus-quantity', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val()) + 1;
            updateBill(id, quantity);
        });

        $('body').on('click', '.btn-minus-quantity', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val()) - 1;
            updateBill(id, quantity);
        });

        $('body').on('click', '.btn-remove-item', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            updateBill(id, 0);
        });
    }

    function updateBill(id, quantity) {
        $.ajax({
            type: "POST",
            url: '/Bill/UpdateBill',
            data: {
                id: id,
                quantity: quantity
            },
            success: function (res) {
                loadData();
            },
            error: function (err) {
                console.log(err)
            }
        });
    }

    function loadData() {
        $.ajax({
            type: "GET",
            url: '/Bill/GetListItems',
            success: function (res) {
                if (res.length === 0) {
                    $('#tbl_bill').hide();
                }
                var html = '';
                var total = 0;
                var tempTotal = 0;
                $.each(res, function (i, item) {
                    html += "<tr>"
                        + " <td><button type=\"button\" class=\"btn btn-remove-item\" data-id=\"" + item.productId + "\"><i class=\"fas fa-trash fa-sm text-danger\"></i></button></td>"
                        + " <td>" + (i + 1) + "</td>"
                        + " <td>" + item.productName + "</td>"
                        + " <td>" + item.unitPrice + "</td>"
                        + " <td><button type=\"button\" class=\"btn btn-minus-quantity\" data-id=\"" + item.productId + "\"><i class=\"fas fa-minus-circle fa-sm text-danger\"></i></button><input type=\"text\" placeholder=\"1\" id=\"txt_quantity_" + item.productId + "\" value=\"" + item.quantity + "\"/><button type=\"button\" class=\"btn btn-plus-quantity\" data-id=\"" + item.productId + "\"><i class=\"fas fa-plus-circle fa-sm text-success\"></i></button></td>"
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