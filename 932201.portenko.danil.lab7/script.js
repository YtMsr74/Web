const input = document.getElementById('amount');

function randNum(min,max){
    return Math.floor(Math.random() * (max - min + 1) + min);
}

function addShape(type){
    var num = amount.value;
    if (num > 1000 || num < 1)
        alert('Введите число от 1 до 1000');
    else 
        switch (type){
            case 'square':
                for (var i = 0; i < num; i++) createSquare();
                break;
            case 'circle':
                for (var i = 0; i < num; i++) createCircle();
                break;
            case 'triangle':
                for (var i = 0; i < num; i++) createTriangle();
                break;
        }
}

function createSquare(){
        var shape = document.createElement('div');
        shape.classList.add('square');
        var size = randNum(10,400);
        var highlight = false;
        shape.style.width = size + 'px';
        shape.style.height = size + 'px';
        shape.style.left = randNum(0, 1918 - size) + 'px';
        shape.style.top = randNum(50, 909 - size) + 'px';
        shape.addEventListener('click', function(){
                if (highlight)
                    shape.style.background = 'red';
                else
                    shape.style.background = 'yellow';
                highlight = !highlight;
        })
        shape.addEventListener('dblclick', function(){
            document.body.removeChild(shape);
        })
        document.body.appendChild(shape);
}

function createCircle(){
    var shape = document.createElement('div');
    shape.classList.add('circle');
    var size = randNum(10,400);
    var highlight = false;
    shape.style.width = size + 'px';
    shape.style.height = size + 'px';
    shape.style.left = randNum(0, 1918 - size) + 'px';
    shape.style.top = randNum(50, 909 - size) + 'px';

    shape.addEventListener('click', function(){
        if (highlight)
            shape.style.background = 'green';
        else
            shape.style.background = 'yellow';
        highlight = !highlight;
    })
    shape.addEventListener('dblclick', function(){
        document.body.removeChild(shape);
    })
    document.body.appendChild(shape);
}

function createTriangle(){
    var shape = document.createElement('div');
    shape.classList.add('triangle');
    var size = randNum(10,400);
    var highlight = false;
    shape.style.borderBottom = 'solid blue ' + size/2 + 'px';
    shape.style.borderLeft = 'solid transparent ' + size/2 + 'px';
    shape.style.borderRight = 'solid transparent ' + size/2 + 'px';
    shape.style.left = randNum(0, 1918 - size) + 'px';
    shape.style.top = randNum(50, 909 - size) + 'px';

    shape.addEventListener('click', function(){
        if (highlight)
            shape.style.borderBottomColor = 'blue';
        else
            shape.style.borderBottomColor = 'yellow';
        highlight = !highlight;
    })
    shape.addEventListener('dblclick', function(){
        document.body.removeChild(shape);
    })
    document.body.appendChild(shape);
}