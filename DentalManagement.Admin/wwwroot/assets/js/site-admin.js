$(document).ready(function () {
    $('.btn-product-list').click(function () {
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
                            + " <td>"
                            + " <input type=\"checkbox\" name=\"product\" data-id=\"" + item.id + "\"/>"
                            + " </td >"
                            + " <td class=\"text-left\">" + item.name + "</td>"
                            + " <td class=\"text-right\">" + numberWithCommas(item.unitPrice) + "</td>"
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
});

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
    if (res['totalInvoiceAmount'] === 0) {
        tableMedicalInvoiceHtml += "<tr><td colspan=\"5\">Không có dữ liệu </td></tr>"
    }
    else {
        $.each(res['invoiceDetailViewModels'], function (i, item) {
            tableMedicalInvoiceHtml += "<tr>"
                + "<td><button type=\"button\" class=\"btn\" id=\"btn_item_remove\" data-id=\"" + item.productId + "\"><i class=\"fa fa-trash fa-sm text-danger\"></i></button></td>"
                + "<td>" + item.productName + "</td>"
                + "<td class=\"text-right\">" + numberWithCommas(item.unitPrice) + "</td>"
                + "<td><div class=\"input-group input-group-sm mb-3\">"
                + "<div class=\"input-group-prepend\"><button type =\"button\" class=\"btn\" id=\"btn_quantity_minus\" data-id=\"" + item.productId + "\"><i class=\"fa fa-minus-circle fa-sm text-danger\"></i></button></div>"
                + "<input type =\"text\" class=\"form-control border-1 small text-center inp-product-quantity\" placeholder=\"1\" data-id=\"" + item.productId + "\" id=\"txt_quantity_" + item.productId + "\" value=\"" + item.quantity + "\"/>"
                + "<div class=\"input-group-append\"><button type =\"button\" class=\"btn\" id=\"btn_quantity_plus\" data-id=\"" + item.productId + "\"><i class=\"fa fa-plus-circle fa-sm text-success\"></i></button></div>"
                + "</div></td>"
                + "<td class=\"text-right\">" + numberWithCommas(item.unitPrice * item.quantity) + "</td>"
                + "</tr>";
        });
        tableMedicalInvoiceHtml += "<tr><td colspan=\"4\" class=\"text-right text-danger\">Tạm tính (<span>" + res['invoiceDetailViewModels'].length + "</span>):</td><td class=\"text-right\">" + numberWithCommas(res['totalInvoiceAmount']) + "</td></tr>";
    }
    $('#table_medical_invoice').html(tableMedicalInvoiceHtml);
    registerButtonEvents();
}

function registerButtonEvents() {
    $('body').on('click', '#btn_quantity_plus', function (e) {
        e.preventDefault();
        const productId = $(this).data('id');
        const productQuantity = parseInt($('#txt_quantity_' + productId).val()) + 1;
        updateProductQuantity(productId, productQuantity);
    });

    $('body').on('click', '#btn_quantity_minus', function (e) {
        e.preventDefault();
        const productId = $(this).data('id');
        const productQuantity = parseInt($('#txt_quantity_' + productId).val()) - 1;
        updateProductQuantity(productId, productQuantity);
    });

    $('body').on('click', '#btn_item_remove', function (e) {
        e.preventDefault();
        const productId = $(this).data('id');
        updateProductQuantity(productId, 0);
    });

    $('body').on('focusout', '.inp-product-quantity', function (e) {
        e.preventDefault();
        const productId = $(this).data('id');
        const productQuantity = $('#txt_quantity_' + productId).val();
        if (productQuantity == '') {
            updateProductQuantity(productId, 1);
        }
        else {
            updateProductQuantity(productId, productQuantity);
        }
    });

    $('body').on('input', '.inp-product-quantity', function (e) {
        textWithNumberOnly(this);
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
