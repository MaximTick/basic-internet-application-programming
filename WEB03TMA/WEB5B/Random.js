function getRand() {
    let n = document.getElementById("X-Rand-N").value;
    $.ajax({
        type: 'POST',
        url: '/post',
        headers: {
            'X-Rand-N': n
        }
    }).done(function (data, status, req) {
        let xml = req.getResponseHeader('qwe');
        let str = $.parseXML(xml);
        let arr = str.getElementsByTagName('number');
        for (let i = 0; i < arr.length; i++) {
            document.getElementById('result').value += arr[i].innerHTML + '; ';
        }
    })
}