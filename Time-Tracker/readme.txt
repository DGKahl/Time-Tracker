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
		- single Task wird gestartet:
			- bereits laufende parallele Tasks werden beendet
			- ein laufender single Task wird beendet
	- in einem Extra-Menü können alle Zeiten angezeigt werden
		- getrackte Zeiten sind editier- und löschbar
		- es können weitere Zeiten per Hand eingetragen werden
- Zeiten:
	- lassen sich gesamtheitlich über Zeiträume (Zeitleiste?, Tag, Woche, Monat, Jahr, fortlaufend von x bis y) anzeigen
	- einzelne Tasks lassen sich im Detail anzeigen (update 24.10.: Wofür, was soll hier im Detail angezeigt werden? Raus...)
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

### UPDATE 24.10.2021
- Standard Timer funktioniert soweit. Zeiten lassen sich messen, Quickslots belegen, neue Timer anlegen.
 Nächste ToDos:
  [ ] Menü zum Bearbeiten der Zeiten: 
	[ ] Manuell Einträge anlegen (+ Prüfung, ob in diesem Zeitraum schon eine Single-Task lief)
	[ ] Vorhandene Einträge als Tabelle anzeigen und editieren (+ Prüfung, ob nach der Änderung Zeiträume von Single-Tasks doppelt belegt sind)
	[ ] Einträge komplett löschen
  [ ] Auswertung/Übersicht: 
	[ ] 2 Modi: 
		[ ] Einzelanzeige eines bestimmten Timers für heute bis Stichzeitpunkt JETZT; als "Torte"
		[ ] Gesamtanzeige aller Timer mit Stundenverteilung und Prozentanteilan allen Stunden
			- Zeitraum kann vorher festgelegt werden
			- Darstellung/Intervall kann vorher festgelegt werden (Tag, Woche, Monat...)
			- optional: Anzeige der "ungetrackten" Stunden
			- optional: Abzug von X Stunden je Tag von der Gesamtanzeige (z.B. 7 Std. für Schlaf täglich, o.ä.)
			- Darstellung als Balkendiagramm: x-Achse = Tage/Wochen etc.; y-Achse = Stunden
