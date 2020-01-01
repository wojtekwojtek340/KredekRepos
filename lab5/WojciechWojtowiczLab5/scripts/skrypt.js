//zmienna numer uzywana do ładowanie obrazka na strone
let number = 1;

//funkcja obsługująca zegar na stronie
function clock() {
    var today = new Date();
    var day = today.getDate();
    var month = today.getMonth() + 1;
    var year = today.getFullYear();
    var hour = today.getHours();
    if (hour < 10) hour = "0" + hour;
    var minute = today.getMinutes();
    if (minute < 10) minute = "0" + minute;
    var secound = today.getSeconds();
    if (secound < 10) secound = "0" + secound;

    document.getElementById("clock").innerHTML =
        day + "/" + month + "/" + year + "|" + hour + ":" + minute + ":" + secound;

    setTimeout("clock()", 1000)
}

//funckja służąca do przełączania pomiedzy róznymi obrazkami
function characterInfo(id) {

    if (id == "rick") {
        let file = "<img src=\"../pictures/" + id + ".jpg\"height=300 width=220/>";        
        document.getElementById("content2").innerHTML = "Rick jest wysokim, chudym starcem. Ma długie nogi i ramiona i jest bardzo szczupły. Posiada bladą cerę i jasne, szaroniebieskie spiczaste włosy z łysą plamą z tyłu głowy oraz monobrew. Jego twarz jest pomarszczona. Widoczne są na niej liczne zmarszczki oraz wory pod oczami. Od czasu do czasu na jego brodzie widoczna jest zielona plama, która pojawia się głównie wtedy, gdy jest pijany lub wymiotuje. Rick wypowiada się w chaotyczny, bełkotliwy sposób. Gdy mówi, często przerywa swoją wypowiedź, by beknąć czy czknąć, co jest bezpośrednim wynikiem tego, iż jest pijany. Naukowiec nosi jasnoniebieski golf, brązowe spodnie spięte ciemnobrązowym paskiem z żółtą klamrą, czarne buty oraz biały fartuch laboratoryjny.";
        document.getElementById("picture").innerHTML = file;        
    }
    else if (id == "morty") { 
        let file = "<img src=\"../pictures/" + id + ".jpg \"height=300 width=220/>";        
        document.getElementById("content2").innerHTML = "Morty jest nastoletnim chłopakiem o krótkich, brązowych i starannie zaczesanych włosach oraz owalnej głowie, która wyróżnia go spośród innych postaci w serialu. Morty nosi żółtą podkoszulkę, niebieskie spodnie i białe buty. Gdy mówi, często się jąka, a jego głos stale się łamie ze względu na skutki okresu dojrzewania.";
        document.getElementById("picture").innerHTML = file;
    }
}

//funckja obsługująca zanikanie obrazka przy uzyciu Jquery
function hide() {
    $("#picture2").fadeOut(500);
}

//funckja obsłgująca zmiene obrazka
function changePicture() {

    let file = "<img src=\"../pictures/" + number + ".jpg\"width=980/>";
    document.getElementById("picture2").innerHTML = file;
    number++;  

    $("#picture2").fadeIn(500);
    setTimeout("changePicture()", 5000);
    setTimeout("hide()", 4500);
    if (number == 5) {
        number = 1;
    }
}

//funkcja obsługująca dodawanie nazwy osoby która przegląda stronę
function addName() {
    name = document.getElementById("box").value;
    localStorage.setItem('Imie', name);
    load();
}

//funkcja ładująca nawę uzytkownika który przegląda stronę
function load() {

    if (localStorage.getItem('Imie') != null) {
        document.getElementById("myName").innerHTML = "Przeglądasz jako: " + localStorage.getItem('Imie');
    }
    else {
        document.getElementById("myName").innerHTML = "Przeglądasz jako anonim";
    }

}