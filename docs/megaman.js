
const gravity = 1.0;
const maxXVelocity = 7;
const acceleration = 0.15;
const runningLeft = 'data:image/gif;base64,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';
const runningRight = 'data:image/gif;base64,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';
const standingLeft = 'data:image/gif;base64,R0lGODlhJAAlAPcAAAAAABgYGCAwgBhYsABA8ACA+FCg8HjY8IBAILhgSPBAEICAgPiwgODg4AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACH5BAEAAP8ALAAAAAAkACUAAAj/AP8JHEiwoMGDCBMWDMBQoUOFDA8cMNDwoUWBAQxMDEBAgIAAFx8GGHBgAMcCHT+GhCiRo0cCHUGuPBgAgQIFCAQYoJhS5kyCNRvk3LmTocqfQAUo0MmQ4gKGPpH+y8i0QQIEDBVUlIqRYoAGDLAG0Mp1IYMADMKadHm0bIK0YRkSKPDRZFm0Z89+RBlgot2QUAcGeJuTAEfDEg2stfi1McYAHgvQhTzyQOS2CL82CPC06YGTPY0KQImZZoOnCwQgnujRI8UGsFV7jErz6enRAvx6dgo7denMC1LD7GgX8mzYt2lDFP1RJmgBC3orZ7y17+iYwaf/7MtaAMnAdzNOa1RcuaT2i5AN7yxOcTbXAKRHOj/sfvtoupjhk/4tci7+qPrhxx9Ekv0HlH89zaRfgkBJltKANMnVGm2gQbUVRHMZNqFBHLFVX0InOQhVaXI5uGFm/u13omD3mfjhQhbGeOFUMlpY1o04FhQQADs=';
const standingRight = 'data:image/gif;base64,R0lGODlhJAAlAPcAAAAAABgYGCAwgBhYsABA8ACA+FCg8HjY8IBAILhgSPBAEICAgPiwgODg4AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACH5BAEAAP8ALAAAAAAkACUAAAj/AP8JHEiwoMGDCBMqDMBQocOFAQwcONDwoUWBAQQIIBDxgIEAFx9m3FiA44ADA0CGTJiRAAGNHCeqXGlwJEcDBgQgUKAAwUyaAzMyxIlTZwOfQAsyDLAg4lABCgT8TMpQAUMECRpEFPAxqVKrARAw0OrUK0aYDAeIZRCArdl/AVIKKHmVgd0Eb+NKDECggFC2dqdeTCuRoku+OhkkmLnUYsYCGlEKnQtZqsoAWrWKJKlxKUy6Hpc2baB5IUwBpLXm1MhV5sumC0qbFhC7QVOJH/UemEtba1PHvUmPlAp3wEaXtH8Prr2AJEeMwxuvZNqUM8WgFYEuRamxsGCqJyUPa8AZ+nvIkWX1fnxpfvPxinFb+qX6eX5QjQUgt0c4PL/9s5Q9N119AgLo3341sdbXfwAuiCBBSzHUV4EAbiSdQ8NZSGGFfNGFoYL5cTSVUBL6tyGEIPpHHIqskRSieRHGmB10Mkb41o04JhQQADs=';
const oneUp = 'data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAMAAAAoLQ9TAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAnUExURRgYGFCg8ABA8HjY8CAwgACA+ODg4BhYsPBAEICAgPiwgLhgSAAAAP9FadsAAAANdFJOU////////////////wA96CKGAAAACXBIWXMAAA7DAAAOwwHHb6hkAAAAfklEQVQoUy2PARLEIAgDA1Vabf//3tvgMQhkRUV9NilC/7Jl6roILfCR02DmsMJzHjCzgRumMAAtBmOkqpQUDe6IoefRiLiRvIjzQjr7aIUKgiYVYFEtD7YAyy0NvAMgcal2aW/VpuzBUMc8O27CZTS0YEHevd/z3Q5GR37fD2akBPkGxzYlAAAAAElFTkSuQmCC';

var width = document.body.clientWidth;
var height = document.body.clientHeight;
var divWidth = width * 0.03;
var divHeight = width * 0.03;
var x = getRandom(document.body.clientWidth);
var y = 0;
var pauseCount = 0;
var yVelocity = 0;
var xVelocity = 0;
var movingRight = true;
var divElement;
var shouldDisplay = (window.localStorage.getItem('shouldDisplay') === null || (window.localStorage.getItem('shouldDisplay') === 'true'));
var imageElement;
var lastImageName = '';

function buildElements() {
    divElement = document.createElement('div');
    divElement.id = 'mega-man-div';
    divElement.style.position = 'fixed';
    divElement.style.top = 0;
    divElement.style.left = 0;
    setDisplay();

    imageElement = document.createElement('img');
    imageElement.style.width = '100%';
    imageElement.style.imageRendering = 'pixelated';
    imageElement.alt = 'Mega Man';
    divElement.appendChild(imageElement);

    document.body.appendChild(divElement);

    var button = document.createElement('button');
    button.id = 'mega-man-button';
    button.style.position = 'fixed';
    button.style.right = '3%';
    button.style.top = '3%';
    button.onclick = () => {
        shouldDisplay = !shouldDisplay;
        window.localStorage.setItem('shouldDisplay', shouldDisplay);
        setDisplay();
        if (ga) ga('send', 'event', 'mythicant.com', 'interaction', 'Mega Man Click');
    };
    var image = document.createElement('img');
    image.src = oneUp;
    image.alt = 'Toggle Mega Man';
    button.appendChild(image);

    document.body.appendChild(button);
}

function setDisplay() {
    divElement.style.display = shouldDisplay ? 'unset' : 'none';
}

function update() {
    if (!shouldDisplay) return;

    width = window.visualViewport.width;
    height = document.body.clientHeight;
    divWidth = width * 0.03;
    divHeight = width * 0.03;
    divElement.style.width = divWidth;
    divElement.style.height = divHeight;    

    yVelocity += gravity;
    y += yVelocity;

    if (pauseCount > 0) {
        pauseCount--;
        xVelocity = 0;
        if (getRandom(100) < 1) movingRight = !movingRight;
    }
    else {
        if (getRandom(100) < 1) pauseCount = getRandom(100) + 100;

        if (movingRight) {
            xVelocity += acceleration;
            if (xVelocity > maxXVelocity) xVelocity = maxXVelocity;
        }
        else {
            xVelocity -= acceleration;
            if (xVelocity < -maxXVelocity) xVelocity = -maxXVelocity;
        }
        x += xVelocity;
    }
    if (xVelocity === 0) {
        if (movingRight) updateImage('standing right');
        else updateImage('standing left');
    }
    else {
        if (movingRight) updateImage('running right');
        else updateImage('running left');
    }
    updatePosition();
}

function updateImage(imageName) {
    if (lastImageName === imageName) return;
    switch (imageName) {
        case 'running left':
            imageElement.src = runningLeft
            break;
        case 'running right':
            imageElement.src = runningRight
            break;
        case 'standing left':
            imageElement.src = standingLeft;
            break;
        case 'standing right':
            imageElement.src = standingRight;
            break;
    }
    lastImageName = imageName;

}

function getRandom(max) {
    return Math.floor(Math.random() * max);
}

function updatePosition() {
    let maxY = window.visualViewport.height;
    if (y > maxY - divElement.clientHeight) {
        yVelocity = 0;
        y = maxY - divElement.clientHeight + 3;
    }
    if (y < 0) y = 0;
    if (x < 0) {
        x = 0;
        movingRight = true;
        xVelocity = -xVelocity * 0.5;
    }
    if (x > document.body.clientWidth - divElement.clientWidth) {
        x = document.body.clientWidth - divElement.clientWidth;
        movingRight = false;
        xVelocity = -xVelocity * 0.5;
    }
    divElement.style.left = (x + 'px');
    divElement.style.top = (y + 'px');
}

buildElements();
setInterval(update, 20);