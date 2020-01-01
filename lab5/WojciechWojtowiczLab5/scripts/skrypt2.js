//odwołąnie do obiektu z treścią zgadywanej postaci
const heroText = document.getElementById('heroText');
//odwołąnie do obiektów z klasą box
const boxes = document.querySelectorAll('.box');
//odwołanie do obiektu message
const message = document.getElementById('message')

//wartość przełączająca miedzy trybem grania i koncem gry
let isPlaying = true;
//odwołanie do instancji instrukcji setInterval
let countDown;
//licznik czasu odliczania do następnej rundy
let timer = 5;
//tablica przechowująca bohaterów serialu
let hero = generateRandomHero();
//wybrany boharer
let selectedHero;

//funkcja ustawiająca obrazek
function setPicture() {

    for (let i = 1; i <= 3; i++) {
        let file = "<img src=\"../pictures/gra/" + i + ".jpg\"height=200 width=200/>";
        boxes[i-1].innerHTML = file;
    }
}

//funckja dodająca id obazka to tablicy i zwracająca tą tablicę
function generateRandomHero() {
    let arr = [];
    for (let i = 0; i < boxes.length; i++) {
        arr.push(i+1);
    }
    return arr;
}

//funckja losująca ktorego bohatera należy zgadnąć
function heroName() {
    selectedHero = Math.floor(Math.random() * 3);

    if (hero[selectedHero] == 1) {
        document.getElementById("heroText").innerHTML = "Rick";
    }
    else if (hero[selectedHero] == 2) {
        document.getElementById("heroText").innerHTML = "Morty";
    }
    else if (hero[selectedHero] == 3) {
        document.getElementById("heroText").innerHTML = "Jerry";
    }
    selectedHero = hero[selectedHero];
    setPicture();
}

//funkcja ustawiająca obrazki na obrazek wygranego bohatera
function setWinner(id) {
    for (let i = 1; i <= 3; i++) {
        let file = "<img src=\"../pictures/gra/" + id + ".jpg\"height=200 width=200/>";
        boxes[i - 1].innerHTML = file;
        boxes[i - 1].style.opacity = '1';
    }
}

//funckja resetująca zakończoną grę
function resetGame() {
    clearInterval(countDown);
    isPlaying = true;
    timer = 5;
    message.textContent = 'Wybierz odpowiednią postać';
    heroName();

}

// iteracja dla wszystkich kwadratów
for (let i = 0; i < boxes.length; i++) {
    //dodawanie event listenera dla każedgo kwadrata na zdarzenie 'click'
    boxes[i].addEventListener('click', function (e) {
        // sprawdzenie trybu gry
        if (isPlaying) {
            // sprawdzenie czy kliknięty bohater jest tym wybranym
            if (i+1 === selectedHero) {
                //przełaczenie trybu gry
                isPlaying = false;

                // komunikat do gracza
                message.textContent = 'BRAWO!';

                // ustwienie zgadniętej postaci
                setWinner(selectedHero);

                // odroczenie funkcji resetGame na 7 sekund
                setTimeout(resetGame, 7000);

                // ustawinie interwału na każdą sekundę
                countDown = setInterval(function () {
                    // uruchomienie licznika
                    heroText.textContent = `Rozpoczęcie następnej rundy za ${timer} sekund`;
                    timer--;
                }, 1000);
            } else {
                // ukrycie klikniętego kwadrata
                boxes[i].style.opacity = '0';
                // komunikat do gracza
                message.textContent = 'Próbuj dalej';
            }
        }
    });
}
