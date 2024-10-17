function resize(i){
    var cat = document.getElementById('cat');
    var dog = document.getElementById('dog');
    var catpic = document.getElementById('catpic');
    var dogpic = document.getElementById('dogpic');
    switch(i){
        case 0:
            cat.style.width = "95%";
            dog.style.width = "5%";
            catpic.style.visibility = "visible";
            dogpic.style.visibility = "hidden";
            break;
        case 1:
            cat.style.width = "50%";
            dog.style.width = "50%";
            catpic.style.visibility = "visible";
            dogpic.style.visibility = "visible";
            break;
        case 2:
        cat.style.width = "5%";
        dog.style.width = "95%";
        catpic.style.visibility = "hidden";
        dogpic.style.visibility = "visible";
        break;
    }

}