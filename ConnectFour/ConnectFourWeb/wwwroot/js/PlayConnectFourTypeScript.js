const red = "red";
const yellow = "yellow";
let currentTurn = red;
let gameOver = true;
let msg;
let allCircles;
let allEnterButtons;
let winningSets = [];
let lstTokens1 = [];
let lstTokens2 = [];
let lstTokens3 = [];
let lstTokens4 = [];
let lstTokens5 = [];
let lstTokens6 = [];
let lstTokens7 = [];
$(document).ready(function () {
    msg = $("#msg");
    allCircles = [...document.querySelectorAll(".circle")];
    allEnterButtons = [...document.querySelectorAll(".enter")];
    allEnterButtons.forEach(b => b.addEventListener("click", getColumn));
    //$(allEnterButtons).click(getColumn);
    setupWinningSets();
});
function setupWinningSets() {
    for (let i = 1; i < 25; i++) {
        winningSets.push([...$(`.d${i}`)]);
        winningSets.push([...$(`.r${i}`)]);
        if (i < 22) {
            winningSets.push([...$(`.c${i}`)]);
        }
    }
}
function setupEnterButtonSets() {
    lstTokens1 = [];
    lstTokens2 = [];
    lstTokens3 = [];
    lstTokens4 = [];
    lstTokens5 = [];
    lstTokens6 = [];
    lstTokens7 = [];
    lstTokens1.push([...$(".e1.bg-white")]);
    lstTokens2.push([...$(".e2.bg-white")]);
    lstTokens3.push([...$(".e3.bg-white")]);
    lstTokens4.push([...$(".e4.bg-white")]);
    lstTokens5.push([...$(".e5.bg-white")]);
    lstTokens6.push([...$(".e6.bg-white")]);
    lstTokens7.push([...$(".e7.bg-white")]);
    const lstOfTokens = [lstTokens1, lstTokens2, lstTokens3, lstTokens4, lstTokens5, lstTokens6, lstTokens7];
    lstOfTokens.forEach(t => t.map(row => row.reverse()).reverse());
}
function startGame() {
    gameOver = false;
    currentTurn = "red";
    ShowMessage();
    $(allCircles).addClass("bg-white").removeClass("red").removeClass("yellow").removeClass("tie").text("");
    $(allEnterButtons).removeClass("yellow").addClass("red");
}
function takeSpot(lst) {
    if (gameOver == false) {
        const token = lst[0][0];
        if (currentTurn == red) {
            $(token).removeClass("bg-white");
            $(token).addClass("red");
            $(allEnterButtons).removeClass("red").addClass("yellow");
        }
        else {
            $(token).removeClass("bg-white");
            $(token).addClass("yellow");
            $(allEnterButtons).removeClass("yellow").addClass("red");
        }
        winningSets.forEach(l => DetectWinner(l));
        if (gameOver == false) {
            detectTie();
        }
        if (gameOver == false) {
            currentTurn = currentTurn == red ? yellow : red;
        }
        ShowMessage();
    }
}
function getColumn(event) {
    const btn = event.target;
    let lst;
    setupEnterButtonSets();
    if (btn.id == "btn1") {
        lst = lstTokens1;
    }
    if (btn.id == "btn2") {
        lst = lstTokens2;
    }
    if (btn.id == "btn3") {
        lst = lstTokens3;
    }
    if (btn.id == "btn4") {
        lst = lstTokens4;
    }
    if (btn.id == "btn5") {
        lst = lstTokens5;
    }
    if (btn.id == "btn6") {
        lst = lstTokens6;
    }
    if (btn.id == "btn7") {
        lst = lstTokens7;
    }
    takeSpot(lst);
}
function DetectWinner(lst) {
    if (lst.every(l => l.classList.contains(currentTurn))) {
        gameOver = true;
        $(allEnterButtons).removeClass("yellow").removeClass("red");
        $(lst).text("W");
    }
}
function detectTie() {
    if (allCircles.every(e => !e.classList.contains("bg-white"))) {
        gameOver = true;
        $(allEnterButtons).removeClass("yellow").removeClass("red").addClass("tie");
        $(allCircles).removeClass("yellow").removeClass("red").addClass("tie");
    }
}
function ShowMessage() {
    if (gameOver == false) {
        msg.text("Current turn is " + currentTurn);
    }
    else if (allCircles.every(e => !e.classList.contains("bg-white"))) {
        msg.text("Tie!!!!!");
    }
    else {
        msg.text("Winner is " + currentTurn);
    }
}
//# sourceMappingURL=PlayConnectFourTypeScript.js.map