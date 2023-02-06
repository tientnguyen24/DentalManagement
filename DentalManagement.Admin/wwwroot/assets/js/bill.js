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
                        + " <td class=\"text-left\">" + item.productCategoryName + "</td>"
                        + " <td class=\"text-left\">" + item.productName + "</td>"
                        + " <td>" + numberWithCommas(item.unitPrice) + "</td>"
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
                    dropListCustomer_html += "<option value=\"" + item.customerId + "\">" + item.fullName + "</option>"
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
                customer_table_body_html += " <tr><td>Họ và tên: " + item['FullName'] + "</td></tr>"
                    + " <tr><td>Giới tính: " + item['Gender'] + "</td></tr>"
                    + " <tr><td>Ngày sinh: " + (item['BirthDay']).substring(0, 10) + "</td></tr>"
                    + " <tr><td>Địa chỉ: " + item['Address'] + "</td></tr>"
                    + " <tr><td>Số điện thoại: " + item['PhoneNumber'] + "</td></tr>"
                    + " <tr><td>Tiền sử bệnh: " + item['Description'] + "</td></tr>"
                    + " <tr><td>Dư nợ hiện tại: " + item['CurrentBalance'] + "</td></tr>";
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
                    customer_table_body_html += " <tr><td>Họ và tên: " + item['FullName'] + "</td></tr>"
                        + " <tr><td>Giới tính: " + item['Gender'] + "</td></tr>"
                        + " <tr><td>Ngày sinh: " + (item['BirthDay']).substring(0, 10) + "</td></tr>"
                        + " <tr><td>Địa chỉ: " + item['Address'] + "</td></tr>"
                        + " <tr><td>Số điện thoại: " + item['PhoneNumber'] + "</td></tr>"
                        + " <tr><td>Tiền sử bệnh: " + item['Description'] + "</td></tr>"
                        + " <tr><td>Dư nợ hiện tại: " + item['CurrentBalance'] + "</td></tr>";
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
                        + "<td class=\"col-md-1\"><button type=\"button\" class=\"btn btn-remove-item\" data-id=\"" + item.productId + "\"><i class=\"fas fa-trash fa-sm text-danger\"></i></button></td>"
                        + "<td class=\"col-md-1\">" + (i + 1) + "</td>"
                        + "<td class=\"text-left col-md-5\">" + item.productName + "</td>"
                        + "<td class=\"col-md-1\">" + numberWithCommas(item.unitPrice) + "</td>"
                        + "<td class=\"col-md-2\"><div class=\"input-group input-group-sm mb-3\">"
                        + "<div class=\"input-group-prepend\"><button type =\"button\" class=\"btn btn-minus-quantity\" data-id=\"" + item.productId + "\"><i class=\"fas fa-minus-circle fa-sm text-danger\"></i></button></div>"
                        + "<input type =\"text\" class=\"form-control border-1 small text-center inp_quantity\" placeholder=\"1\" data-id=\"" + item.productId + "\" id=\"txt_quantity_" + item.productId + "\" value=\"" + item.quantity + "\"/>"
                        + "<div class=\"input-group-append\"><button type =\"button\" class=\"btn btn-plus-quantity\" data-id=\"" + item.productId + "\"><i class=\"fas fa-plus-circle fa-sm text-success\"></i></button></div>"
                        + "</div></td>"
                        + "<td class=\"col-md-2\">" + numberWithCommas(item.unitPrice * item.quantity) + "</td>"
                        + "</tr>";
                    tempTotal += item.unitPrice * item.quantity;
                });
                $('#bill_body').html(html);
                $('#lbl_no_of_items').text(res.length);
                $('#lbl_temp_total').text(numberWithCommas(tempTotal));
                loadSummary();
            }
        });
    }

    function loadSummary() {
        $.ajax({
            type: "GET",
            url: '/Bill/GetListSummary',
            success: function (res) {
                if (res['description'] != null) {
                    $('#inp_decription').attr("value", "" + res['description'] + "");
                }
                var tempTotalAmount = parseInt($('#lbl_temp_total').text().replace(/,/g, ''), 10);
                var total = tempTotalAmount - res['totalDiscountAmount'];
                $('#lbl_total').text(numberWithCommas(total));
                $('#inp_total_discount_amount').attr("value", "" + numberWithCommas(res['totalDiscountAmount']) + "");
                if (res['prepaymentAmount'] == '' || res['totalDiscountAmount'] != '') {
                    $('#inp_prepayment_amount').attr("value", "" + numberWithCommas(total) + "");
                }
                else {
                    $('#inp_prepayment_amount').attr("value", "" + numberWithCommas(res['prepaymentAmount']) + "");
                }

                if ($('#inp_prepayment_amount').val() == '') {
                    $('#lbl_remaining_amount').text(numberWithCommas(total));
                }
                else {
                    var prepaymentAmount = parseInt($('#inp_prepayment_amount').val().replace(/,/g, ''), 10);
                    $('#lbl_remaining_amount').text(numberWithCommas(total - prepaymentAmount));
                }
            },
            error: function (err) {
                console.log(err)
            }
        });
    }

    function registerEvents() {
        $('body').on('click', '.btn-plus-quantity', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val()) + 1;
            updateQuantity(id, quantity);
        });

        $('body').on('click', '.btn-minus-quantity', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val()) - 1;
            updateQuantity(id, quantity);
        });

        $('body').on('click', '.btn-remove-item', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            updateQuantity(id, 0);
        });

        $('body').on('focusout', '.inp_quantity', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = $('#txt_quantity_' + id).val();
            if (quantity == '') {
                updateQuantity(id, 1);
            }
            else {
                updateQuantity(id, quantity);
            }
        });

        $('body').on('focusout', '.inp_total_discount_amount, .inp_prepayment_amount, .inp_decription', function (e) {
            e.preventDefault();
            const totalDiscountAmount = $('#inp_total_discount_amount').val();
            const prepaymentAmount = $('#inp_prepayment_amount').val();
            const description = $('#inp_decription').val();
            const tempTotalAmount = parseInt($('#lbl_temp_total').text().replace(/,/g, ''), 10);
            $('#lbl_total').text(numberWithCommas(tempTotalAmount - totalDiscountAmount));
            const totalAmount = parseInt($('#lbl_total').text().replace(/,/g, ''), 10);
            $('#lbl_remaining_amount').text(numberWithCommas(totalAmount - prepaymentAmount));
            updateSummary(prepaymentAmount, totalDiscountAmount, description);
        });

        $('body').on('keyup', '.inp_quantity, .inp_total_discount_amount, .inp_prepayment_amount, .inp_decription', function (e) {
            updateTextView($(this));
        });

        $('body').on('input', '.inp_quantity, .inp_total_discount_amount, .inp_prepayment_amount', function (e) {
            this.value = this.value.replace(/[^0-9]/g, '').replace(/(\..*?)\..*/g, '$1');
        });

    }

    function updateQuantity(id, quantity) {
        $.ajax({
            type: "POST",
            url: '/Bill/UpdateQuantity',
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

    function updateSummary(prepaymentAmount, totalDiscountAmount, description) {
        $.ajax({
            type: "POST",
            url: '/Bill/UpdateListSummary',
            data: {
                prepaymentAmount: prepaymentAmount,
                totalDiscountAmount: totalDiscountAmount,
                description: description
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