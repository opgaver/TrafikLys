# TrafikLys

Dette er en simpel opgave i at skrive en klasse, der repræsenterer et trafiklys i C#. I datamatiker/datalog uddannelsen er dette første skridt i at lære om objektorienteret programmering (OOP) samt tilstandsmaskiner.

## Opgave

Du skal skrive en klasse `TrafficLight`, der repræsenterer et trafiklys. Trafiklyset skal have tre tilstande: `Red`, `RedYellow`, `Green` og `Yellow`. Trafiklyset skal have en metode `ChangeState()`, der skifter til næste tilstand. 

Du kan læse lidt om (danske) trafiklys på [Wikipedia](https://da.wikipedia.org/wiki/Trafiksignal), men her er en kort beskrivelse af de forskellige tilstande (billedet er fra artiklen):

![](https://upload.wikimedia.org/wikipedia/commons/thumb/f/f8/Traffic_lights_4_states.png/220px-Traffic_lights_4_states.png)

Du bestemmer selv timingen for skift mellem tilstandene - men i min løsning har jeg valgt at skifte tilstand som følger:

- `Red` -> `RedYellow` (efter 5 sekunder)
- `RedYellow` -> `Green` (efter 2 sekunder)
- `Green` -> `Yellow` (efter 5 sekunder)
- `Yellow` -> `Red` (efter 2 sekunder)

men det kan selvfølgelig ændres til noget der simulerer virkeligheden.

Du kan se en gif af min løsning her, og kan naturligvis kigge på min kode under solution-mappen - men prøv at se hvad du kan skabe uden at kigge først.

<div>
    <video src='https://github.com/opgaver/TrafikLys/raw/master/solution/mcronberg/TrafficLight/trafiklys.mp4' />
</div>

Du er velkommen til at skabe en PR med din løsning, hvis du vil dele den. Du skal bare sørge for, at den ligger i Solution-mappen i en folder med dit navn.