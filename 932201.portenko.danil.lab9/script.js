var start = true;
var result = 0.0;
var curNum = 0.0;
var fSize = 38;
display.textContent = '0';

calculator.addEventListener('click', (event)=>{
    if (event.target.tagName === 'BUTTON'){
        if (display.textContent.length > 18) fSize -= 1.5;
        else fSize = 38;
        display.style.fontSize = fSize + 'px';
    }
})

function clearRes(){
    start = true;
    display.textContent = '0';
}

function numClick(num){
    if (start){
        display.textContent = num;
        start = false;
    }
    else display.textContent += num;
}

function opClick(op){
    const operations = /[+-/*]/;
    check = display.textContent.slice(-2);
    if (operations.test(check)) {
        display.textContent = display.textContent.slice(0,-2);
    }
    result = display.textContent;
    display.textContent = result + " " + op + " ";
}

function dotClick(){
    if (!display.textContent.includes('.')){
        display.textContent += '.';
    }
}

function backspace(){
    text = display.textContent;
    if (text.slice(-1) == ' ') display.textContent = text.slice(0,-2);
    else display.textContent = text.slice(0,-1);
    if (display.textContent == '') clearRes();
}

function calculate(){
    display.textContent = eval(display.textContent);
}
