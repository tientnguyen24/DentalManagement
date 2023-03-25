$(document).ready(function () {
    $('body').on('click', '#btn_product_list', function (e) {
        $.ajax({
            type: "GET",
            url: '/Product/GetProductList',
            success: function (res) {
                if (res.length === 0) {
                    $('#table_product_list').hide();
                }
                else {
                    let tableProductListHtml = '';
                    $.each(res, function (i, item) {
                        tableProductListHtml += "<tr>"
                            + " <td class=\"width-5-percent\">"
                            + " <input type=\"checkbox\" name=\"product\" data-id=\"" + item.id + "\"/>"
                            + " </td>"
                            + " <td class=\"width-80-percent\">" + item.name + "</td>"
                            + " <td class=\"width-15-percent text-right\">" + numberWithCommas(item.unitPrice) + "</td>"
                            + " </tr>";
                    });
                    $('#table_product_list').html(tableProductListHtml);
                    addProductToMedicalInvoice();
                }
            },
            error: function (err) {
                console.log(err);
            }
        });
    });
})

function addProductToMedicalInvoice() {
    $('#btn_add_product_to_medical_invoice').click(function () {
        let productIds = [];
        $('input[name="product"]:checked').each(function () {
            productIds.push($(this).data('id'));
        });
        if (productIds.length === 0) {
            alert('Bạn chưa chọn dịch vụ !!!');
        }
        else {
            $.ajax({
                type: "POST",
                url: '/Invoice/AddProductToMedicalInvoice',
                data: { productIds: productIds },
                success: function (res) {
                    getMedicalInvoice(res);
                },
                error: function (err) {
                    console.log(err);
                }
            });
        }
    });
}

function getMedicalInvoice(res) {
    let tableMedicalInvoiceHtml = '';
    if (res['invoiceDetailViewModels'] == '') {
        tableMedicalInvoiceHtml += "<tr><td class=\"width-5-percent\"></td><td colspan=\"6\"class=\"width-40-percent text-left\">Không có dữ liệu </td></tr>"
    }
    else {
        $.each(res['invoiceDetailViewModels'], function (i, item) {
            tableMedicalInvoiceHtml += "<tr>"
                + "<td class=\"width-5-percent\"><a href=\"#\" type=\"button\" class=\"text-danger btn-item-remove\" data-id=\"" + item.productId + "\"><i class=\"fa fa-trash fa-sm text-danger\"></i></a></td>"
                + "<td class=\"width-50-percent text-left\">" + item.productName + "</td>"
                + "<td class=\"width-10-percent text-right\">" + numberWithCommas(item.unitPrice) + "</td>"
                + "<td class=\"width-5-percent\"><a href=\"#\" type =\"button\" class=\"text-danger btn-quantity-minus\" data-id=\"" + item.productId + "\"><i class=\"fa fa-minus-circle fa-sm\"></i></a></td>"
                + "<td class=\"width-10-percent\"><input type =\"text\" class=\"form-control border-1 small text-right inp-product-quantity\" placeholder=\"1\" data-id=\"" + item.productId + "\" id=\"quantity_" + item.productId + "\" value=\"" + item.quantity + "\" /></td>"
                + "<td class=\"width-5-percent\"><a href=\"#\" type =\"button\" class=\"text-success btn-quantity-plus\" data-id=\"" + item.productId + "\"><i class=\"fa fa-plus-circle fa-sm\"></i></a></td>"
                + "<td class=\"width-15-percent text-right\">" + numberWithCommas(item.unitPrice * item.quantity) + "</td>"
                + "</tr>";
        });
        tableMedicalInvoiceHtml += "<tr><td colspan=\"6\" class=\"text-right\">Tạm tính (<span>" + res['invoiceDetailViewModels'].length + "</span>):</td><td class=\"text-right width-15-percent\">" + numberWithCommas(res['totalInvoiceAmount']) + "</td></tr>"
            + "<tr><td colspan=\"6\" class=\"text-right\">Giảm giá:</td><td><input type =\"text\" class=\"form-control width-15-percent border-1 small text-right\" placeholder=\"0\" id=\"inp_total_discount_amount\" value=\"" + numberWithCommas(res['totalDiscountAmount']) + "\" /></td></tr>"
            + "<tr><td colspan=\"6\" class=\"text-right text-danger\">Thành tiền:</td><td class=\"text-right width-15-percent\">" + numberWithCommas(res['totalInvoiceAmount'] - res['totalDiscountAmount']) + "</td></tr>";
    }
    $('#table_medical_invoice').html(tableMedicalInvoiceHtml);
    registerButtonEvents();
}

function registerButtonEvents() {
    $('body').on('click', '.btn-quantity-plus', function (e) {
        e.preventDefault();
        const productId = $(this).data('id');
        const productQuantity = parseInt($('#quantity_' + productId).val()) + 1;
        updateProductQuantity(productId, productQuantity);
    });

    $('body').on('click', '.btn-quantity-minus', function (e) {
        e.preventDefault();
        const productId = $(this).data('id');
        const productQuantity = parseInt($('#quantity_' + productId).val()) - 1;
        updateProductQuantity(productId, productQuantity);
    });

    $('body').on('click', '.btn-item-remove', function (e) {
        e.preventDefault();
        const productId = $(this).data('id');
        updateProductQuantity(productId, 0);
    });

    $('body').on('focusout', '.inp-product-quantity', function (e) {
        e.preventDefault();
        const productId = $(this).data('id');
        const productQuantity = $('#quantity_' + productId).val();
        if (productQuantity == '') {
            updateProductQuantity(productId, 1);
        }
        else {
            updateProductQuantity(productId, productQuantity);
        }
    });

    $('body').on('focusout', '#inp_total_discount_amount', function (e) {
        e.preventDefault();
        const totalDiscountAmount = $(this).val();
        updateTotalDiscountAmount(totalDiscountAmount);
    });

    $('body').on('input', '.inp-product-quantity, #inp_total_discount_amount', function (e) {
        textWithNumberOnly(this);
    });

    $('body').on('keyup', '.inp-product-quantity, #inp_total_discount_amount', function (e) {
        updateTextView($(this));
    });
}

function updateProductQuantity(productId, productQuantity) {
    $.ajax({
        type: "POST",
        url: '/Invoice/UpdateProductQuantity',
        data: {
            productId: productId,
            productQuantity: productQuantity
        },
        success: function (res) {
            getMedicalInvoice(res);
        },
        error: function (err) {
            console.log(err)
        }
    });
}

function updateTotalDiscountAmount(totalDiscountAmount) {
    $.ajax({
        type: "POST",
        url: '/Invoice/UpdateTotalDiscountAmount',
        data: { totalDiscountAmount: totalDiscountAmount },
        success: function (res) {
            getMedicalInvoice(res);
        },
        error: function (err) {
            console.log(err)
        }
    });
}

$(document).ready(function () {
    let invoiceId;
    let productId;
    let updatedInvoiceDetailStatus;

    $('.btn-get-status').click(function (e) {
        e.preventDefault();
        let data = $(this).data('id');
        let values = data.split(" ");
        invoiceId = values[0];
        productId = values[1];
        updatedInvoiceDetailStatus = values[2];
        $('#complete_invoice_detail_status').modal('show');
    });

    $('.btn-update-status').click(function (e) {
        e.preventDefault();
        updateInvoiceDetailStatus(invoiceId, productId, updatedInvoiceDetailStatus);
    });
})

function updateInvoiceDetailStatus(invoiceId, productId, updatedInvoiceDetailStatus) {
    $.ajax({
        type: "POST",
        url: '/Invoice/UpdateInvoiceDetailStatus',
        data: {
            invoiceId: invoiceId,
            productId: productId,
            updatedInvoiceDetailStatus: updatedInvoiceDetailStatus
        },
        success: function (res) {
            location.reload();
        },
        error: function (err) {
            console.log(err);
        }
    });
}

function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}

function textWithNumberOnly(x) {
    x.value = x.value.replace(/[^0-9.]+/g, '').replace(/(\..*?)\..*/g, '$1');
}

function updateTextView(_obj) {
    let num = getNumber(_obj.val());
    if (num == 0) {
        _obj.val('');
    } else {
        _obj.val(num.toLocaleString());
    }
}

function getNumber(_str) {
    let arr = _str.split('');
    let out = new Array();
    for (const element of arr) {
        if (!isNaN(element)) {
            out.push(element);
        }
    }
    return Number(out.join(''));
}
