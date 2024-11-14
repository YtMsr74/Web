var lightStatus = false;
var isRabbit = false;
var clickDelay = false;
var switchActive = false;

function reveal(){
    curtain.style.transition = "1s";
    curtain.style.bottom = "110%";
}

const switchOff = () =>{
    if (switchActive){
        lightSwitch.style.top = '100px';
        if (lightStatus) {
            light.style.opacity = '0%';
            stage.style.opacity = '0%';
        }
        else {
            light.style.opacity = '50%';
            stage.style.opacity = '100%';
        }
        lightStatus = !lightStatus;
        switchActive = false;
    }
}

triggerLight.addEventListener("mouseup", switchOff);
triggerLight.addEventListener("mouseleave", switchOff);

triggerLight.addEventListener("mousedown",()=>{
    switchActive = true;
    lightSwitch.style.top = '110px';
})

function trick(){
    if (lightStatus && !clickDelay){
        clickDelay = true;
        animal.style.top = '710px';
        setTimeout(()=>{
            if (isRabbit) {
                animal.src = 'images/Bird.png';
                animal.style.top = '500px';
            }
            else {
                animal.src = 'images/Rabbit.png';
                animal.style.top = '530px';
            }
            isRabbit = !isRabbit;
            setTimeout(()=>{ clickDelay = false;}, 500);
        }, 500);
    }
}