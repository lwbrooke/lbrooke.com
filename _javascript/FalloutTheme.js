function prepareEventHandlers() {
    var links = document.links;

    for (var i = 0; i < links.length; i++) {
        links[i].onmouseover = function () {
            if (flag) {
                flag = false;
                typeout("typeText", this.text, 0);
            }
        }
        links[i].onfocus = function () {
            if (flag) {
                flag = false;
                typeout("typeText", this.text, 0);
            }
        }
        links[i].onmouseout = function () {
            flag = true;
            typeClear();
        }
        links[i].onblur = function () {
            flag = true;
            typeClear();
        }
    }
}

function typeout(id, msg, n) {
    if (document.getElementById(id).childNodes.length == 0) {
        document.getElementById(id).appendChild(document.createTextNode(""));
    }
    if (n >= msg.length) {
        return
    };
    document.getElementById(id).firstChild.data += msg.charAt(n);
    typer = setTimeout("typeout('" + id + "', '" + msg + "', " + (n + 1) + ")", 60);
}

function typeClear() {
    if (typer != null) {
        clearTimeout(typer);
    }
    var text = document.getElementById("typeText");
    text.textContent = "";    
}

function blinkCursor() {
    var cursor = document.getElementById("blinkCursor");

    if (cursor != null) {
        if (cursor.style.display == "none") {
            cursor.style.display = "inline";
        } else {
            cursor.style.display = "none";
        }
    }
}

var typer;
var flag = true;

window.onload = function () {
    prepareEventHandlers();
    setInterval(blinkCursor, 500);
}

/*
*/