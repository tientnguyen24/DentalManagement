var BillController = function () {
    this.initialize = function () {
        loadProductList();
        addProductToBill();
        loadCustomerDropdownList();
        customerDropdownListOnChange();
        loadData();
        loadCustomer();
        registerEvents();
    }
    function loadProductList() {
        $.ajax({
            type: "GET",
            url: '/Bill/GetListProducts',
            success: function (res) {
                if (res.length === 0) {
                    $('#tbl_product_bill').hide();
                }
                var product_table_body_html = '';
                $.each(res, function (i, item) {
                    product_table_body_html += "<tr>"
                        + " <td>"
                        + " <button type=\"button\" class=\"btn btn-add-product-to-bill\" data-id=\"" + item.productId + "\">"
                        + " <i class=\"fas fa-plus-circle fa-sm\"></i>"
                        + " </button></td>"
                        + " <td>" + (i + 1) + "</td>"
                        + " </td >"
                        + " <td>" + item.productCategoryName + "</td>"
                        + " <td>" + item.productName + "</td>"
                        + " <td>" + item.unitPrice + "</td>"
                        + " </tr>";
                });
                $('#product_bill_body').html(product_table_body_html);
            }
        });
    }

    function addProductToBill() {
        $('body').on('click', '.btn-add-product-to-bill', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            $.ajax({
                type: "POST",
                url: '/Bill/AddProductToBill',
                data: { id: id },
                success: function (res) {
                    console.log(res);
                    window.location.reload();
                },
                error: function (err) {
                    console.log(err)
                }
            });
        })
    }

    function loadCustomerDropdownList() {
        $.ajax({
            type: "GET",
            url: '/Bill/GetListCustomers',
            success: function (res) {
                var dropListCustomer_html = "<option value=\"\">-- Chọn khách hàng --</option>";
                $.each(res, function (i, item) {
                    dropListCustomer_html += "<option value=\"" + item.customerId + "\">" + item.fullName+"</option>"
                });
                $('#dropListCustomer').html(dropListCustomer_html);
            }
        });
    }

    function loadCustomer() {
        $.ajax({
            type: "GET",
            url: '/Bill/GetCustomer',
            success: function (res) {
                console.log(res);
                var item = $.parseJSON(res);
                if (res.length === 0) {
                    $('#tbl_customer_bill').hide();
                }
                var customer_table_body_html = '';
                if (item['Gender'] === 0) {
                    item['Gender'] = 'Nam';
                }
                if (item['Gender'] === 1) {
                    item['Gender'] = 'Nữ';
                }
                customer_table_body_html += " <tr><td><input type=\"hidden\" id=\"" + item['CustomerId'] + "\" value=\"" + item['CustomerId'] + "\" /></td></tr>"
                    + " <tr><td>" + item['FullName'] + "</td></tr>"
                    + " <tr><td>" + item['Gender'] + "</td></tr>"
                    + " <tr><td>" + (item['BirthDay']).substring(0, 10) + "</td></tr>"
                    + " <tr><td>" + item['Address'] + "</td></tr>"
                    + " <tr><td>" + item['IdentifyCard'] + "</td></tr>"
                    + " <tr><td>" + item['PhoneNumber'] + "</td></tr>";
                $('#customer_bill_body').html(customer_table_body_html);
            },
            error: function (err) {
                console.log(err)
            }
        });
    }

    function customerDropdownListOnChange() {
        $('body').on('change', '#dropListCustomer', function (e) {
            e.preventDefault();
            const id = $(this).val();
            $.ajax({
                type: "POST",
                url: '/Bill/AddCustomerToBill',
                data: { id: id },
                success: function (res) {
                    console.log(res);
                    var item = $.parseJSON(res);
                    if (res.length === 0) {
                        $('#tbl_customer_bill').hide();
                    }
                    var customer_table_body_html = '';
                    if (item['Gender'] === 0) {
                        item['Gender'] = 'Nam';
                    }
                    if (item['Gender'] === 1) {
                        item['Gender'] = 'Nữ';
                    }
                    customer_table_body_html += " <tr><td>" + item['FullName'] + "</td></tr>"
                        + " <tr><td>" + item['Gender'] + "</td></tr>"
                        + " <tr><td>" + (item['BirthDay']).substring(0, 10) + "</td></tr>"
                        + " <tr><td>" + item['Address'] + "</td></tr>"
                        + " <tr><td>" + item['IdentifyCard'] + "</td></tr>"
                        + " <tr><td>" + item['PhoneNumber'] + "</td></tr>";
                    $('#customer_bill_body').html(customer_table_body_html);
                },
                error: function (err) {
                    console.log(err)
                }
            });
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

}

$(document).ready(function () {

    var current_fs, next_fs, previous_fs; //fieldsets
    var opacity;

    $(".next").click(function () {

        current_fs = $(this).parent();
        next_fs = $(this).parent().next();

        //Add Class Active
        $("#progressbar li").eq($("fieldset").index(next_fs)).addClass("active");

        //show the next fieldset
        next_fs.show();
        //hide the current fieldset with style
        current_fs.animate({ opacity: 0 }, {
            step: function (now) {
                // for making fielset appear animation
                opacity = 1 - now;

                current_fs.css({
                    'display': 'none',
                    'position': 'relative'
                });
                next_fs.css({ 'opacity': opacity });
            },
            duration: 600
        });
    });

    $(".previous").click(function () {

        current_fs = $(this).parent();
        previous_fs = $(this).parent().prev();

        //Remove class active
        $("#progressbar li").eq($("fieldset").index(current_fs)).removeClass("active");

        //show the previous fieldset
        previous_fs.show();

        //hide the current fieldset with style
        current_fs.animate({ opacity: 0 }, {
            step: function (now) {
                // for making fielset appear animation
                opacity = 1 - now;

                current_fs.css({
                    'display': 'none',
                    'position': 'relative'
                });
                previous_fs.css({ 'opacity': opacity });
            },
            duration: 600
        });
    });
});