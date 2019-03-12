function sendHeaders() {
    let request = new XMLHttpRequest();
    request.open("POST", "/posta", false);
    let x = document.getElementById('X-Value-x').value;
    let y = document.getElementById('X-Value-y').value;
    request.setRequestHeader('X-Value-x', x);
    request.setRequestHeader('X-Value-y', y);
    request.onreadystatechange = () => {
        document.getElementById('X-Value-z').value = request.getResponseHeader('X-Value-z');
    }
    request.send();
};

function getRand() {
    let requestB = new XMLHttpRequest();
    let n = document.getElementById("X-Rand-N").value;
    requestB.open("POST", '/postb', false);
    requestB.setRequestHeader('X-Rand-N', n);
    requestB.onreadystatechange = () => {
        let xml = requestB.getResponseHeader('qwe');
        let str = $.parseXML(xml);
        let arr = str.getElementsByTagName('number');
        for (let i = 0; i < arr.length; i++) {
            document.getElementById('result').value += arr[i].innerHTML + '; ';
        }
    }
    requestB.send();
}

function getRandJSON() {
    let requestC = new XMLHttpRequest();
    let nj = document.getElementById('n').value;
    requestC.open("POST", '/postc', false);
    requestC.setRequestHeader('X-Rand-N', nj);
    requestC.onreadystatechange = () => {
        let strj = requestC.getResponseHeader('qwe');
        let arrj = JSON.parse(strj);
        for (let i = 0; i < arrj.length; i++) {
            document.getElementById('res').value += arrj[i] + '; ';
        }
    }
    requestC.send();
}

function XMLreq() {
    let request = new XMLHttpRequest();
    request.open("POST", "/posta", true);
    let x = document.getElementById('X-Value-x').value;
    let y = document.getElementById('X-Value-y').value;
    request.setRequestHeader('X-Value-x', x);
    request.setRequestHeader('X-Value-y', y);
    request.onreadystatechange = () => {
        document.getElementById('X-Value-z').value = request.getResponseHeader('X-Value-z');
    }
    request.send();

    let requestB = new XMLHttpRequest();
    let n = document.getElementById("X-Rand-N").value;
    requestB.open("POST", '/postb', true);
    requestB.setRequestHeader('X-Rand-N', n);
    requestB.onreadystatechange = () => {
        let xml = requestB.getResponseHeader('qwe');
        let str = $.parseXML(xml);
        let arr = str.getElementsByTagName('number');
        for (let i = 0; i < arr.length; i++) {
            document.getElementById('result').value += arr[i].innerHTML + '; ';
        }
    }
    requestB.send();

    let requestC = new XMLHttpRequest();
    let nj = document.getElementById('n').value;
    requestC.open("POST", '/postc', true);
    requestC.setRequestHeader('X-Rand-N', nj);
    requestC.onreadystatechange = () => {
        let strj = requestC.getResponseHeader('qwe');
        let arrj = JSON.parse(strj);
        for (let i = 0; i < arrj.length; i++) {
            document.getElementById('res').value += arrj[i] + '; ';
        }
    }
    requestC.send();
}