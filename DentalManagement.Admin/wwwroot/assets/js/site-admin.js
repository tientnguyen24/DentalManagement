$('body').on('click', '.btn-add-to-bill', function (e) {
    e.preventDefault();
    const id = $(this).data('id');
    $.ajax({
        type: "POST",
        url: '/Bill/AddToBill',
        data: {id: id},
        success: function (res) {
            console.log(res)
        },
        error: function (err) {
            console.log(err)
        }
    });
})

function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}