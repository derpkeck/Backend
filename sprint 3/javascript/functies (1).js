 function toonPrompt(){
    var vraag = 'Hoeveel is 20 + 60 ?'; 
	var userinput = prompt(vraag, '');
    var antwoord = 80; 
    var goed = '<h2> Prima, ga zo door! </h2>'; 
    var fout = '<h2> Jammer, volgende keer beter !</h2>';
    
		
    if (userinput == antwoord)
    {
        document.getElementById("p1").innerHTML = goed;
    }
    else
    {
        document.getElementById("p1").innerHTML = fout;
    }
		
}