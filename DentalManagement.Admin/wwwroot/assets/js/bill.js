var BillController = function () {
    this.initialize = function () {
        loadProduct();
        addToBill();
        loadCustomer();
        loadData();
        registerEvents();
    }
    function loadProduct() {
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
                        + " <button type=\"button\" class=\"btn btn-add-to-bill\" data-id=\"" + item.customerId + "\">"
                        + " <i class=\"fas fa-plus-circle fa-sm\"></i>"
                        + " </button>"
                        + " <td>" + (i + 1) + "</td>"
                        + " </td >"
                        + " <td>" + item.productName + "</td>"
                        + " <td>" + item.productName + "</td>"
                        + " <td>" + item.unitPrice + "</td>"
                        + " </tr>";
                });
                $('#product_bill_body').html(product_table_body_html);
            }
        });
    }

    function addToBill() {
        $('body').on('click', '.btn-add-to-bill', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            $.ajax({
                type: "POST",
                url: '/Bill/AddToBill',
                data: { id: id },
                success: function (res) {
                    console.log(res)
                },
                error: function (err) {
                    console.log(err)
                }
            });
        })
    }

    function loadCustomer() {
        $.ajax({
            type: "GET",
            url: '/Bill/GetListCustomers',
            success: function (res) {
                if (res.length === 0) {
                    $('#tbl_customer_bill').hide();
                }
                var customer_table_body_html = '';
                $.each(res, function (i, item) {
                    if (item.gender === 0) {
                        item.gender = 'Nam';
                    }
                    if (item.gender === 1) {
                        item.gender = 'Nữ';
                    }
                    customer_table_body_html += "<tr>"
                        + " <td>"
                        + " <button type=\"button\" class=\"btn btn-add-to-bill\" data-id=\"" + item.customerId + "\">"
                        + " <i class=\"fas fa-plus-circle fa-sm\"></i>"
                        + " </button>"
                        + " <td>" + (i + 1) + "</td>"
                        + " <td>" + item.fullName + "</td>"
                        + " <td>" + item.gender + "</td>"
                        + " <td>" + (item.birthDay).substring(0, 10) + "</td>"
                        + " <td>" + item.address + "</td>"
                        + " <td>" + item.identifyCard + "</td>"
                        + " <td>" + item.phoneNumber + "</td>"
                        + " </tr>";
                });
                $('#customer_bill_body').html(customer_table_body_html);
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

    $('.radio-group .radio').click(function () {
        $(this).parent().find('.radio').removeClass('selected');
        $(this).addClass('selected');
    });

    $(".submit").click(function () {
        return false;
    })

});