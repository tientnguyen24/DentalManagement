$(document).ready(function () {
    $('.btn-product-list').click(function () {
        $.ajax({
            type: "GET",
            url: '/Customer/GetProductList',
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
                            + " <td>" + numberWithCommas(item.unitPrice) + "</td>"
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
                url: '/Customer/AddProductToMedicalInvoice',
                data: { productIds: productIds },
                success: function (res) {
                    let tableMedicalInvoiceHtml = '';
                    if (res['invoiceDetailViewModels'] === null) {
                        tableMedicalInvoiceHtml += "<tr><td colspan=\"5\">Không có dữ liệu </td></tr>"
                    }
                    else {
                        let tempTotalInvoiceAmount = 0;
                        $.each(res['invoiceDetailViewModels'], function (i, item) {
                            tableMedicalInvoiceHtml += "<tr>"
                                + "<td><button type=\"button\" class=\"btn btn-remove-item\" data-id=\"" + item.productId + "\"><i class=\"fa fa-trash fa-sm text-danger\"></i></button></td>"
                                + "<td>" + item.productName + "</td>"
                                + "<td>" + numberWithCommas(item.unitPrice) + "</td>"
                                + "<td><div class=\"input-group input-group-sm mb-3\">"
                                + "<div class=\"input-group-prepend\"><button type =\"button\" class=\"btn btn-minus-quantity\" data-id=\"" + item.productId + "\"><i class=\"fa fa-minus-circle fa-sm text-danger\"></i></button></div>"
                                + "<input type =\"text\" class=\"form-control border-1 small text-center inp_quantity\" placeholder=\"1\" data-id=\"" + item.productId + "\" id=\"txt_quantity_" + item.productId + "\" value=\"" + item.quantity + "\"/>"
                                + "<div class=\"input-group-append\"><button type =\"button\" class=\"btn btn-plus-quantity\" data-id=\"" + item.productId + "\"><i class=\"fa fa-plus-circle fa-sm text-success\"></i></button></div>"
                                + "</div></td>"
                                + "<td>" + numberWithCommas(item.unitPrice * item.quantity) + "</td>"
                                + "</tr>";
                            tempTotalInvoiceAmount += item.unitPrice * item.quantity;
                        });
                        tableMedicalInvoiceHtml += "<tr><td colspan=\"4\" class=\"text-right text-danger\">Tạm tính (<span>" + res['invoiceDetailViewModels'].length + "</span>):</td><td>" + numberWithCommas(tempTotalInvoiceAmount) + "</td></tr>";
                    }
                    $('#table_medical_invoice').html(tableMedicalInvoiceHtml);
                },
                error: function (err) {
                    console.log(err);
                }
            });
        }
    });
}


function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}

function updateTextView(_obj) {
    var num = getNumber(_obj.val());
    if (num == 0) {
        _obj.val('');
    } else {
        _obj.val(num.toLocaleString());
    }
}

function getNumber(_str) {
    var arr = _str.split('');
    var out = new Array();
    for (var cnt = 0; cnt < arr.length; cnt++) {
        if (isNaN(arr[cnt]) == false) {
            out.push(arr[cnt]);
        }
    }
    return Number(out.join(''));
}
