﻿function saveAsFile(filename, bytesbase64) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64," + bytesbase64;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}