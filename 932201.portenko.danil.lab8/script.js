const page = document.getElementById("table");
const output = document.getElementById("savedTable");
var k = 0;

function createElement(tag, id, innerHTML){
    var el = document.createElement(tag);
    el.id = id;
    return el;
}

function addLine(){
    var table = createElement('div', 'row_' + k);
    table.classList.add('row');
    
    var in1 = createElement('input', 'input1_' + k);
    table.appendChild(in1);
    var in2 = createElement('input', 'input2_' + k);
    table.appendChild(in2);

    var up = createElement('button', 'up_' + k);
    up.innerHTML = '&#8593;';
    up.onclick = function(){
        var row = document.getElementById(table.id);
        var prevRow = row.previousElementSibling;
        if (prevRow) {
            row.parentNode.insertBefore(row, prevRow);
        }
    }
    table.appendChild(up);
    var down = createElement('button', 'down_' + k);
    down.innerHTML = '&#8595;';
    down.onclick = function(){
        var row = document.getElementById(table.id);
        var nextRow = row.nextElementSibling;
        if (nextRow) {
            row.parentNode.insertBefore(nextRow, row);
        }
    }
    table.appendChild(down);
    var del = createElement('button', 'del_' + k);
    del.innerHTML = '&#10006;';
    del.onclick = function(){
        var row = document.getElementById(table.id);
        row.remove();
    }
    table.appendChild(del);


    page.appendChild(table);
    k++;
}

function saveTable(){
    var table = document.querySelectorAll('.row');
    var tableText = '{';

    table.forEach((row,index) =>{
        tableText += '"';
        var in1 = row.querySelector('input[id^="input1_"]').value;
        tableText += in1 + '":"';
        var in2 = row.querySelector('input[id^="input2_"]').value;
        tableText += in2 + '"';
        if(index !== table.length - 1) {tableText += ',';}
    });

    tableText += '}';
    document.getElementById('savedTable').innerText = tableText;
}

addLine();