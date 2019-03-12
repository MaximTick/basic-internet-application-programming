function getRand() {
    let n = document.getElementById('n').value;
    $.ajax({
        type: 'POST',
        url: '/post5c',
        headers: {
            'X-Rand-N': n
        }
    }).done(function (data, status, request) {
        let str = request.getResponseHeader('qwe');
        let arr = JSON.parse(str);
        for (let i = 0; i < arr.length; i++) {
            document.getElementById('result').value += arr[i] + '; ';
        }
    })
}