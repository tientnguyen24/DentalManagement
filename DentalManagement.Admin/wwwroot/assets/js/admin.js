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
                type: 'GET',
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
                type: 'GET',
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
            });
            if (productIds.length === 0) {
                alert('Bạn chưa chọn dịch vụ.');
            }
            else {
                $.ajax({
                    type: 'POST',
                    url: '/Invoice/AddProductToMedicalInvoice',
                    data: { productIds: productIds },
                    success: function (res) {
                        getMedicalInvoice(res);
                        $('#add_product_medical_invoice').modal('hide');
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
            });
            if (productIds.length === 0) {
                alert('Bạn chưa chọn dịch vụ.');
            }
            else {
                $.ajax({
                    type: 'POST',
                    url: '/Invoice/UpdateCurrentInvoiceProcessingList',
                    data: { productIds: productIds },
                    success: function (res) {
                        getMedicalInvoice(res);
                        $('#add_product_medical_invoice').modal('hide');
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
            $('.btn-create-medical-invoice').prop("disabled", true);
        }
        else {
            /*enabled submit button*/
            $('.btn-create-medical-invoice').prop("disabled", false).removeAttr("disabled");
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
        $('.btn-update-medical-invoice').data('res', res['invoiceDetailViewModels'].length);
    }

    function registerEvents() {
        $('body').on('click', '.btn-quantity-plus, .btn-quantity-minus, .btn-item-remove', handleProductQuantityChange);
        $('body').on('focusout', '.inp-product-quantity', handleProductQuantityFocusOut);
        $('body').on('focusout', '.inp-total-discount-amount, .inp-prepayment-amount', handleDiscountPrepaymentFocusOut);
        $('body').on('click', '.btn-close-invoice-modal', handleCloseModalClick);
        $('.btn-create-medical-invoice').on('click', handleCreateMedicalInvoiceClick);
        $('.btn-update-medical-invoice').on('click', handleUpdateMedicalInvoiceClick);
        $('body').on('input', '.inp-product-quantity, .inp-total-discount-amount, .inp-prepayment-amount', handleNumericInput);
        $('body').on('keyup', '.inp-product-quantity, .inp-total-discount-amount, .inp-prepayment-amount', handleTextViewUpdate);
    }

    function handleProductQuantityChange(e) {
        e.preventDefault();
        const productId = $(this).data('id');
        let productQuantity = parseInt($('#quantity_' + productId).val());
        if ($(this).hasClass('btn-quantity-plus')) {
            productQuantity += 1;
        } else if ($(this).hasClass('btn-quantity-minus')) {
            if (productQuantity == 1) {
                if (confirm('Hủy điều trị?')) {
                    updateProductQuantity(productId, 0);
                }
                return;
            }
            productQuantity -= 1;
        } else if (confirm('Hủy điều trị?')) {
            productQuantity = 0;
        }
        updateProductQuantity(productId, productQuantity);
    }

    function handleProductQuantityFocusOut(e) {
        e.preventDefault();
        const productId = $(this).data('id');
        const productQuantity = $('#quantity_' + productId).val() || 1;
        updateProductQuantity(productId, productQuantity);
    }

    function handleDiscountPrepaymentFocusOut(e) {
        e.preventDefault();
        const totalDiscountAmount = $('.inp-total-discount-amount').val();
        const prepaymentAmount = $('.inp-prepayment-amount').val();
        updateTotalInvoiceAmount(totalDiscountAmount, prepaymentAmount);
    }

    function handleCloseModalClick(e) {
        e.preventDefault();
        const modal = $(this).closest('.modal');
        if (confirm('Xác nhận hủy?')) {
            closeModal(modal);
        }
    }

    function handleCreateMedicalInvoiceClick(e) {
        e.preventDefault();
        const form = $(this).closest('form');
        if (confirm('Xác nhận lưu?')) {
            form.submit();
        }
    }

    function handleUpdateMedicalInvoiceClick(e) {
        e.preventDefault();
        const form = $(this).closest('form');
        const res = $(this).data('res');
        const confirmMessage = (res === 0) ? 'CHÚ Ý: Không có điều trị, phiếu khám sẽ bị hủy. Xác nhận hủy?' : 'Xác nhận lưu?';
        if (confirm(confirmMessage)) {
            form.submit();
        }
    }

    function handleNumericInput(e) {
        textWithNumberOnly(this);
    }

    function handleTextViewUpdate(e) {
        updateTextView($(this));
    }

    function closeModal(modal) {
        $(modal).on('hidden.bs.modal', function () {
            $.ajax({
                type: 'GET',
                url: '/Invoice/RemoveInvoiceSession',
                success: function (res) {
                    location.reload();
                },
                error: function (err) {
                    console.log(err)
                }
            });
        });
        $(modal).modal('hide');
    }

    function updateProductQuantity(productId, productQuantity) {
        $.ajax({
            type: 'POST',
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
            type: 'POST',
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
    let description;

    $('.btn-show-status-modal').click(function (e) {
        e.preventDefault();
        let data = $(this).data('id');
        let values = data.split(' ');
        invoiceId = values[0];
        productId = values[1];
        updatedInvoiceDetailStatus = values[2];
        $.ajax({
            type: 'GET',
            url: '/Invoice/GetById/',
            data: {
                invoiceId: invoiceId
            },
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
        if (remainAmount <= 0) {
            $('.inp-prepayment-amount').val(0).prop('readonly', true);
            prepaymentAmount = remainAmount;
        }
        $('#complete_invoice_detail_status').on('input', '.inp-prepayment-amount', function () {
            textWithNumberOnly(this);
            updateTextView($(this));
        });
        $('#complete_invoice_detail_status').on('focusout', '.inp-prepayment-amount', function () {
            //remove commas out of prepayment amount after user input
            prepaymentAmount = $(this).val().replace(/,/g, '');
            if (remainAmount > 0 && remainAmount < prepaymentAmount) {
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
        if (confirm('Xác nhận lưu?')) {
            $.ajax({
                type: 'POST',
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
    }

    $('.btn-show-description-modal').click(function (e) {
        e.preventDefault();
        let data = $(this).data('id');
        let values = data.split(' ');
        invoiceId = values[0];
        productId = values[1];
        $.ajax({
            type: 'GET',
            url: '/Invoice/GetInvoiceDetailById/',
            data: {
                invoiceId: invoiceId,
                productId: productId
            },
            success: function (res) {
                showDescriptionModal(res);
            },
            error: function (err) {
                console.log(err);
            }
        });
    });

    function showDescriptionModal(res) {
        $('#description_invoice_detail').modal('show');
        $('.product-name').text(res['productName']);
    }

    $('.btn-update-description').click(function (e) {
        e.preventDefault();
        description = $('.invoice-description').val();
        updateInvoiceDescription(invoiceId, productId, description);
    });

    function updateInvoiceDescription(invoiceId, productId, description) {
        if (description == '') {
            alert('Chưa nhập thông tin, không thể lưu.');
        }
        else {
            if (confirm('Xác nhận lưu?')) {
                $.ajax({
                    type: 'POST',
                    url: '/Invoice/UpdateInvoiceDetailDescription/',
                    data: {
                        invoiceId: invoiceId,
                        productId: productId,
                        description: description
                    },
                    success: function (res) {
                        location.reload();
                    },
                    error: function (err) {
                        console.log(err);
                    }
                });
            }
        }
    }

    $('body').on('click', '.btn-close-modal', function (e) {
        e.preventDefault();
        let modal = $(this).closest('.modal');
        if (confirm('Xác nhận hủy?')) {
            $(modal).on('hidden.bs.modal', function () {
                $.ajax({
                    type: 'GET',
                    url: '/Invoice/RemoveInvoiceSession',
                    success: function (res) {
                        location.reload();
                    },
                    error: function (err) {
                        console.log(err)
                    }
                });
            });
            $(modal).modal('hide');
        }
    });
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