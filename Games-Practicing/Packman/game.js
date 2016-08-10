// widnow document console
"use strict";

function createGame(selector) {
    var canvas = document.querySelector(selector),
    ctx = canvas.getContext("2d"),
    isMouthOpen = false,
    packman = {
        "x": 30,
        "y": 30,
        "size": 30
    },
    dir = 0,
    // doing the controlers (keys for movement)
    keyCodeToDirs = {
        "37": 2,
        "38": 3,
        "39": 0,
        "40": 1, 

    },
    // a variable to make packman move in th corresponding direction
    dirDeltas = [{
        "x": +1,
        "y": 0
    }, {
           "x": 0,
        "y": +1
    }, {
        "x": -1,
        "y": 0
    }, {
        "x": 0,
        "y": -1
    }];


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
        var deltaRadians = dir * Math.PI / 2; // this is a logic to change the direction (mouth) of packman.
 // for making a circle
    ctx.arc(packman.x, packman.y, packman.size, deltaRadians + Math.PI / 4, deltaRadians + 7 * Math.PI / 4 ); 

    //makes a line between the last point that i've been to to the new given point'
    //with this we can make for example a plain to shoot targets wit lasers or smth.
    ctx.lineTo(packman.x, packman.y ); 
    } else {
    ctx.arc(packman.x, packman.y, packman.size, 0, 2 * Math.PI ); 
    }
   

    ctx.fill();
   
   steps += 1;
   if (0 === ( steps % stepstToChangeMouth)) {
    isMouthOpen = !isMouthOpen;
       
   }

    packman.x += dirDeltas[dir].x;  // changing the directions appropriatly
    packman.y += dirDeltas[dir].y;

    // with this method we should make the anmation, because setTimeOut coould make problems
    //if for example our machin crashes *(i would continue running and so it would make occurred)
    window.requestAnimationFrame(gameLoop); 
    }
document.body.addEventListener("keydown", function(ev){
    console.log(ev.keyCode); //.keyCode shows what key have you pressed.

    //a way to deal with the undefined, if the wrong key is pressed
    //with hasOwnProperty we are avoiding the problem of when pressing zero to show undefined
    if (!keyCodeToDirs.hasOwnProperty(ev.keyCode)) {
        return;
    }

    //metho to change the direction
    dir = keyCodeToDirs[ev.keyCode];
    console.log(dir);
});

return {
        "start": function() {
            gameLoop();
        }
    };
}

