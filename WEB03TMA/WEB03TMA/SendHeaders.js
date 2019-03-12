    function sendHeaders() {
        let x = document.getElementById('X-Value-x').value;
    let y = document.getElementById('X-Value-y').value;

            $.ajax({
        type: 'POST',
    url: '/post',
                headers: {
        "X-Value-x": x,
    "X-Value-y": y
}
            }).done(function (data, status, request) {
        document.getElementById('X-Value-z').value = request.getResponseHeader('X-Value-z');
    })
};
