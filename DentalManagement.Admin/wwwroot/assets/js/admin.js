let InvoiceController = function () {
    this.createInitialize = function () {
        getProductList();
        addProductToMedicalInvoice();
        registerEvents();
    }

    this.updateInitialize = function () {
        getCurrentInvoiceProcessingList();
        getProductList();
        updateCurrentInvoiceProcessingList();
        registerEvents();
    }

    function getCurrentInvoiceProcessingList() {
        $('body').on('click', '.update-medical-invoice', function (e) {
            e.preventDefault();
            const invoiceId = $(this).data('id');
            $.ajax({
                type: "GET",
                url: '/Invoice/GetCurrentInvoiceProcessingList/' + invoiceId,
                success: function (res) {
                    getMedicalInvoice(res);
                    $('#update_medical_invoice').modal('show');
                },
                error: function (err) {
                    console.log(err);
                }
            });
        })
    }

    function getProductList() {
        $('body').on('click', '.btn-product-list', function (e) {
            $.ajax({
                type: "GET",
                url: '/Product/GetProductList',
                success: function (res) {
                    if (res.length === 0) {
                        $('.table-product-list').hide();
                    }
                    else {
                        let tableProductListHtml = '';
                        $.each(res, function (i, item) {
                            tableProductListHtml += "<tr>"
                                + " <td class=\"width-5-percent\">"
                                + " <input type=\"checkbox\" class=\"checkbox-product-id\" name=\"product\" data-id=\"" + item.id + "\"/>"
                                + " </td>"
                                + " <td class=\"width-80-percent\">" + item.name + "</td>"
                                + " <td class=\"width-15-percent text-right\">" + numberWithCommas(item.unitPrice) + "</td>"
                                + " </tr>";
                        });
                        $('.table-product-list').html(tableProductListHtml);
                        $('.checkbox-product-id').change(function () {
                            if (this.checked) {
                                $('.btn-add-product-to-medical-invoice').removeClass('disabled');
                            }
                        });
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            });
        });
    }

    function addProductToMedicalInvoice() {
        $('.btn-add-product-to-medical-invoice').click(function () {
            let productIds = [];
            $('input[name="product"]:checked').each(function () {
                productIds.push($(this).data('id'));
                $('.btn-add-product-to-medical-invoice').addClass('disabled');
            });
            if (productIds.length === 0) {
                alert('Bạn chưa chọn dịch vụ.');
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

    function updateCurrentInvoiceProcessingList() {
        $('.btn-add-product-to-medical-invoice').click(function () {
            let productIds = [];
            $('input[name="product"]:checked').each(function () {
                productIds.push($(this).data('id'));
                $('.btn-add-product-to-medical-invoice').addClass('disabled');
            });
            if (productIds.length === 0) {
                alert('Bạn chưa chọn dịch vụ.');
            }
            else {
                $.ajax({
                    type: "POST",
                    url: '/Invoice/UpdateCurrentInvoiceProcessingList',
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
        if (res['invoiceDetailViewModels'] == null || res['invoiceDetailViewModels'] == '') {
            $('.no-of-products').text('(0)');
            tableMedicalInvoiceHtml += "<tr><td class=\"width-5-percent\"></td><td colspan=\"6\"class=\"width-40-percent text-left\">Không có dữ liệu </td></tr>"
            /*disable submit button*/
            $("#btn_create_medical_invoice").prop("disabled", true);
        }
        else {
            /*enabled submit button*/
            $("#btn_create_medical_invoice").prop("disabled", false).removeAttr("disabled");
            $('.no-of-products').text('(' + res['invoiceDetailViewModels'].length + ')');
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
            tableMedicalInvoiceHtml += "<tr><td colspan=\"6\" class=\"text-right\">Tạm tính (1):</td><td class=\"text-right width-15-percent\">" + numberWithCommas(res['totalInvoiceAmount'] + res['totalDiscountAmount']) + "</td></tr>"
                + "<tr><td colspan=\"6\" class=\"text-right\">Giảm giá (2):</td><td><input type =\"text\" class=\"form-control width-15-percent border-1 small text-right inp-total-discount-amount\" placeholder=\"0\" value=\"" + numberWithCommas(res['totalDiscountAmount']) + "\" /></td></tr>"
                + "<tr><td colspan=\"6\" class=\"text-right text-danger\">Thành tiền (1 - 2):</td><td class=\"text-right width-15-percent\"><span class=\"txt-total-invoice-amount\">" + numberWithCommas(res['totalInvoiceAmount']) + "<span></td></tr>"
                + "<tr><td colspan=\"6\" class=\"text-right\">Thanh toán (3):</td><td><input type =\"text\" class=\"form-control width-15-percent border-1 small text-right inp-prepayment-amount\" placeholder=\"0\" value=\"" + numberWithCommas(res['prepaymentAmount']) + "\" /></td></tr>"
                + "<tr><td colspan=\"6\" class=\"text-right text-danger\">Còn lại (1 - 2 - 3):</td><td class=\"text-right width-15-percent\">" + numberWithCommas(res['remainAmount']) + "</td></tr>";
        }
        $('.table-medical-invoice').html(tableMedicalInvoiceHtml);
    }

    function registerEvents() {
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

        $('body').on('focusout', '.inp-total-discount-amount', function (e) {
            e.preventDefault();
            const totalDiscountAmount = $(this).val();
            const prepaymentAmount = $('.inp-prepayment-amount').val();
            updateTotalInvoiceAmount(totalDiscountAmount, prepaymentAmount);
            
        });

        $('body').on('focusout', '.inp-prepayment-amount', function (e) {
            e.preventDefault();
            const totalDiscountAmount = $('.inp-total-discount-amount').val();
            const prepaymentAmount = $(this).val();
            updateTotalInvoiceAmount(totalDiscountAmount, prepaymentAmount);
        });

        $('body').on('input', '.inp-product-quantity, .inp-total-discount-amount, .inp-prepayment-amount', function (e) {
            textWithNumberOnly(this);
        });

        $('body').on('keyup', '.inp-product-quantity, .inp-total-discount-amount, .inp-prepayment-amount', function (e) {
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

    function updateTotalInvoiceAmount(totalDiscountAmount, prepaymentAmount) {
        $.ajax({
            type: "POST",
            url: '/Invoice/UpdateTotalInvoiceAmount',
            data: {
                totalDiscountAmount: totalDiscountAmount,
                prepaymentAmount: prepaymentAmount
            },
            success: function (res) {
                getMedicalInvoice(res);
            },
            error: function (err) {
                console.log(err)
            }
        });
    }

}

$(document).ready(function () {
    let invoiceId;
    let productId;
    let updatedInvoiceDetailStatus;
    let prepaymentAmount;
    let processingStatusCount = 0;
    let completedAmount = 0;

    $('.btn-get-status').click(function (e) {
        e.preventDefault();
        let data = $(this).data('id');
        let values = data.split(" ");
        invoiceId = values[0];
        productId = values[1];
        updatedInvoiceDetailStatus = values[2];
        $.ajax({
            type: "GET",
            url: '/Invoice/GetById/' + invoiceId,
            success: function (res) {
                checkInvoiceDetailProcessingStatus(res['invoiceDetailViewModels']);
                invoiceDetailCompletedAmount(res['invoiceDetailViewModels']);
                $.each(res['invoiceDetailViewModels'], function (i, item) {
                    if (item.productId == productId) {
                        if (updatedInvoiceDetailStatus == 'Completed') {
                            showCompleteInvoiceDetailModal(item, res['remainAmount']);
                        }
                        if (updatedInvoiceDetailStatus == 'Cancelled') {
                            showCancelInvoiceDetailModal(item, res['prepaymentAmount']);
                        }
                    }
                });
            },
            error: function (err) {
                console.log(err);
            }
        });
    });

    function checkInvoiceDetailProcessingStatus(res) {
        $.each(res, function (i, item) {
            //2 is processing status for invoice detail
            if (item.status == '2') {
                processingStatusCount++;
            }
        });
        return processingStatusCount;
    }

    function invoiceDetailCompletedAmount(res) {
        $.each(res, function (i, item) {
            //4 is completed status for invoice detail
            if (item.status == '4') {
                completedAmount += item.itemAmount;
            }
        });
        return completedAmount;
    }

    function showCompleteInvoiceDetailModal(item, remainAmount) {
        $('#complete_invoice_detail_status').modal('show');
        $('.product-name').text(item.productName);
        $('.remain-amount').text("Dư nợ còn lại: " + numberWithCommas(remainAmount));
        if (processingStatusCount == 1 && remainAmount > 0) {
            alert('Điều trị cuối cùng của phiếu khám, vui lòng thanh toán tất cả dư nợ còn lại.');
            $('.inp-prepayment-amount').val(numberWithCommas(remainAmount)).prop('readonly', true);
            prepaymentAmount = remainAmount;
        }
        if (remainAmount == 0) {
            $('.inp-prepayment-amount').val(numberWithCommas(remainAmount)).prop('readonly', true);
            prepaymentAmount = remainAmount;
        }
        $('#complete_invoice_detail_status').on('input', '.inp-prepayment-amount', function () {
            textWithNumberOnly(this);
            updateTextView($(this));
        });
        $('#complete_invoice_detail_status').on('focusout', '.inp-prepayment-amount', function () {
            //remove commas out of prepayment amount after user input
            prepaymentAmount = $(this).val().replace(/,/g, '');
            if (remainAmount < prepaymentAmount) {
                alert('Giá trị không hợp lệ, số tiền cần thanh toán vượt mức dư nợ.');
                $(this).val('0');
            }
        });
    }

    function showCancelInvoiceDetailModal(item, currPrepaymentAmount) {
        $('#cancel_invoice_detail_status').modal('show');
        $('.product-name').text(item.productName);
        if (processingStatusCount == 1 && completedAmount > currPrepaymentAmount) {
            alert('Vui lòng thanh toán tất cả dư nợ còn lại trước khi hủy.');
            $('.remain-amount').text("Dư nợ còn lại: " + numberWithCommas(completedAmount - currPrepaymentAmount));
            prepaymentAmount = completedAmount - currPrepaymentAmount;
        }
    }

    $('.btn-update-status').click(function (e) {
        e.preventDefault();
        updateInvoiceDetailStatus(invoiceId, productId, updatedInvoiceDetailStatus, prepaymentAmount);
    });

    function updateInvoiceDetailStatus(invoiceId, productId, updatedInvoiceDetailStatus, prepaymentAmount) {
        $.ajax({
            type: "POST",
            url: '/Invoice/UpdateInvoiceDetailStatus',
            data: {
                invoiceId: invoiceId,
                productId: productId,
                updatedInvoiceDetailStatus: updatedInvoiceDetailStatus,
                prepaymentAmount: prepaymentAmount
            },
            success: function (res) {
                location.reload();
            },
            error: function (err) {
                console.log(err);
            }
        });
    }
})

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

// Auto-dismiss the success message after 5 seconds
$(document).ready(function () {
    window.setTimeout(function () {
        $("#alert-success-msg").fadeTo(500, 0).slideUp(500, function () {
            $(this).remove();
        });
    }, 5000);
});

// Auto-dismiss the error message after 5 seconds
$(document).ready(function () {
    window.setTimeout(function () {
        $("#alert-error-msg").fadeTo(500, 0).slideUp(500, function () {
            $(this).remove();
        });
    }, 5000);
});
