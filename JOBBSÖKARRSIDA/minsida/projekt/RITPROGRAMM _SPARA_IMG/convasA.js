function Foto(){ // запускается после загрузки index.html
    var cnv = document.getElementById('canvasA'); // находим канву
 
    if (!cnv || !cnv.getContext) {
        return;
    }
 
    if (cnv && cnv.getContext) {
        var scr = cnv.getContext('2d'); // берем 2D контекст
        if (!scr) {
            return;
        }
    }
    
    //scr.fillStyle = '#00'; // устанавливаем чёрный цвет заливки
    //scr.fillRect(0, 0, cnv.width, cnv.height); // закрашиваем канву чёрным прямоугольником
    var img = new Image(); // создаем объект - картинку
    img.onload = function() { // после загрузки картинки
        scr.drawImage(img, 100, 100, 200, 200); // выводим ее в координатах [100;100]
    }
    img.src = "C:/Users/MoonGuard/Desktop/универ/лабы/веб/лаба1/картинки/Dragon.jpeg"; // имя картинки