### Idee
App zum Tracken von Zeiten für bestimmte "Töpfe" (z.B. Aufgaben, Projekte, Arbeitszeit, etc.).
Die App soll flexibel genug sein, um neue "Töpfe" zu definieren. 
Einstellungen sollen möglich sein, um z.B. beim Start eines neuen Trackers alle anderen abzubrechen.
Die Darstellung, Auswahl und Steuerung soll einfach von der Hand gehen.

### Grundlegende Funktionen
- Tasks:
	- die Elemente, welche zeitlich getrackt werden
	- können angelegt, geändert, gelöscht und ausgewertet werden
	- Tasks können per Einstellung entweder parallel zu anderen laufen, oder "allein"; Verhalten:
		- parallele Task wird gestartet:
			- bereits laufende parallele Tasks laufen weiter
			- ein laufender single Task wird beendet
		- singe Task wird gestartet:
			- bereits laufende parallele Tasks werden beendet
			- ein laufender single Task wird beendet
	- in einem Extra-Menü können alle Zeiten angezeigt werden
		- getrackte Zeiten sind editier- und löschbar
		- es können weitere Zeiten per Hand eingetragen werden
- Zeiten:
	- lassen sich gesamtheitlich über Zeiträume (Zeitleiste?, Tag, Woche, Monat, Jahr, fortlaufend von x bis y) anzeigen
	- einzelne Tasks lassen sich im Detail anzeigen
- Tracking:
	- wird über ein zentrales Menü gestartet/beendet
	- pausieren gibt es nicht; jede Unterbrechung führt zu einem neuen Eintrag
	- Aufaddieren der Zeiten je Task erfolgt in der >>Zeitenübersicht


### Offenes
Starten der Tasks: Zwei Versionen sind vorstellbar...
	- große Buttons (Max. Anz. fix), welche mit Tasks belegt werden und diese Starten/Beenden; 
	- Anzeigen je Button geben info zum Status.
		--> Einfacher zu starten/switchen; schwerer zu implementieren?
	- Dropdown-Feld (Alternativ: Liste) wo neue Tasks hinzugefügt werden und wo das als nächstes zu startende Element ausgewählt wird;
	- Liste gibt Auskunft über aktuellen Status laufender Tasks. Alternativ: neues Menüfenster je laufendem Task?
		--> umständlicher Start neuer Tasks. Leichter zu implementieren?

### Version 1
- Dropdown-Feld zur Auswahl der Timer
- Knöpfe zur Anlage/Pflege der Timer
- Anlegen/Bearbeiten --> neues Fenster
- Timer Starten --> neues Fenster
- ein paar Buttons, denen man "quick" Timer zuweisen kann (zum Starten)