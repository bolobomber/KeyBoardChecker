

window.PlayAudio = (elementName) => {
    document.getElementById(elementName).currentTime = 0;
    document.getElementById(elementName).play();
    

}
