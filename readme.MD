# oe-generics-treasure-chest-opl
![cave](images/cave.jpg)
## Opzet
Ahoy, matey! In deze oefening kruip je in de huid van Captain Jack Sparrow als boy pirate of in de huid van Redd mocht je een lady pirate zijn.

Je maakt schatkisten (`TreasureChest`) met verschillende soorten sloten (`Lock`) die enkel open gaan met een correcte sleutel (`Key`).

Dit is een begeleide oefening die de mogelijkheden van generics binnen C# verkent. Yo Ho Ho!

## Doel
* Generics leren gebruiken
* Generic constraints leren gebruiken
* Loose coupling verkennen in een generic situatie

## Voor we van start gaan ...
Beschouw even het concept van een schatkist. Mochten we die in het echt maken, dan is elke schatkist anders. Hij heeft verschillende vormen, is gemaakt van een ander materiaal, heeft een ander soort slot, dat op zijn beurt weer een andere soort sleutel heeft, enzovoort.

Iets dergelijks programmeren is niet evident. Alle behoort namelijk toe aan zijn eigen klasse(s). Wanneer we dan een schatkist willen maken zouden we heel veel verschillende soorten klasses kunnen maken met elk zijn specifieke eigenschappen, maar dat is op lange termijn niet onderhoudbaar. Arrrghh.

Hier zijn generics interessant. In wat volgt verkennen we de mogelijkheden en leren we er de voordelen van kennen. 

We bieden in deze oefening dus een antwoord op het volgende:
*"Hoe zorg je ervoor dat we een schatkist kunnen maken die we flexibel kunnen programmeren?"*

Ter visualisatie willen we het mogelijk maken om deze schatkisten te maken in onze code (maar slechts 1 klasse ervoor nodig te hebben):

![chests](images/chests.png)

> Merk alvast op dat:
> * We steeds eenzelfde schatkist (`TreasureChest`) maken
> * De inhoud van de schatkist eender wat kan zijn. Misschien wel rum!
> * Een schatkist vergrendeld wordt met eender wel soort slot ...
> * ... die open gaat met een sleutel van hetzelfde materiaal.

**Let's ... sail away!**

## Opdracht 1 - Eender wel item in de schatkist stoppen
We starten zo eenvoudig mogelijk. We zullen beginnen met het maken van een schatkist zonder slot, maar we zorgen er wel voor dat we reeds eender welk item in de kist kunnen stoppen.



Maak in het `.Core` project alvast een map `Items` in de `Domain` map. Hier zullen we verschillende klasses onderbrengen die de inhoud van onze `TreasureChest` zullen voorstellen.





