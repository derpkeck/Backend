 function toonPrompt(){
        var code = prompt('Vul uw promotiecode in', 'uw code');
        var tekst = 'De code die u invoerde was: ' + code; 
        var elem = document.getElementById('para');
        document.getElementById("p1").innerHTML = tekst;
      }