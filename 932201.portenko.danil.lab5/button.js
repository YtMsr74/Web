var news = {
    title: ['Новость 1','Новость 2','Новость 3'],
    text: ['Новость 1: Lorem ipsum dolor sit amet consectetur adipisicing elit. Amet asperiores aut nihil! Corporis debitis labore fugiat id, eligendi ratione veritatis!',
    'Новость 2: Lorem ipsum dolor sit amet consectetur adipisicing elit. A, alias.',
    'Новость 3: Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam hic, ipsa, ullam, cupiditate.']
}

function showNews(i){
    var title = document.getElementById('title');
    var text = document.getElementById('text');
    title.innerText = news.title[i];
    text.innerText = news.text[i];
    var box = document.getElementById('news');
    var overlay = document.getElementById('overlay');
    box.style.visibility = 'visible';
    overlay.style.visibility = 'visible';
}
function hideNews(){
    var box = document.getElementById('news');
    var overlay = document.getElementById('overlay');
    box.style.visibility = 'hidden';
    overlay.style.visibility = 'hidden';
}