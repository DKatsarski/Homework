// widnow document console
"use strict";

function createGame(selector) {
    var canvas = document.querySelector(selector),
    ctx = canvas.getContext("2d"),
    isMouthOpen = false;

var x = 150;

//logic to slow down opening and closing of the mouth
var steps = 0;
const stepstToChangeMouth = 12;

    function gameLoop() {
    //Give a color to the packman.
    ctx.fillStyle = "yellow";
    
    //method to reDraw the canvas
    ctx.clearRect(0, 0, canvas.width, canvas.height);

    // helping to restart the path. begin from 0. otherwise drawing is impossible.
    ctx.beginPath();

    if (isMouthOpen){
 // for making a circle
    ctx.arc(x, 150, 70, Math.PI / 4, 7 * Math.PI / 4 ); 

    //makes a line between the last point that i've been to to the new given point'
    ctx.lineTo(x, 150 ); 
    } else {
    ctx.arc(x, 150, 70, 0, 2 * Math.PI ); 
    }
   
   x += 1;
    ctx.fill();
   
   steps += 1;
   if (0 === ( steps % stepstToChangeMouth)) {
    isMouthOpen = !isMouthOpen;
       
   }

    // with this method we should make the anmation, because setTimeOut coould make problems
    //if for example our machin crashes *(i would continue running and so it would make occurred)
    window.requestAnimationFrame(gameLoop); 
    }
    return {
        "start": function() {
            gameLoop();
        }
    };
}

