# Projekt-Dokumentation

Greub Manuel

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|  29.09.22 |  0.0.1 | Wir haben mit dem Auftrag angefangen und einen Teil schon fertig gemacht.|         
|  07.11.22 |  0.0.2 | Wir haben Azure Maps kennengelernt und mit diesem weitergearbeitet|
|  14.11.22 |  0.0.3 | Wir haben heute an dem Programm weitergearbeitet 


## 1) Informieren
    

### 1.1 Ihr Projekt

In diesem Projekt geht es darum, ein Programm zu erstellen, welches durch die Informationen der Länge und des Verkehrsmittels, die Kosten für den eigenen Schulweg berechnet

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1 | Muss | Funktional | Der Benutzer kann die Länge der Strecke seines Schulweges eingeben, welche anschliessend abgespeichert wird.|
| 2 | Kann | Funktional | Der Benutzer kann den Start und Endpunkt seines Schulweges eingeben, Distanz wird automatisch erfasst. |
| 3 | Muss | Funktional | Der Benutzer wählt zwischen den verschiedenen Verkehrsmitteln aus. |
| 4 | Muss | Funktional | Je nach Eingabe des Verkehrsmittels werden nun die Kosten für die Strecke berechnet. |
| 5 | Kann | Funktional | Es soll die voraussichtliche Zeit für die Fahrt pro Verkehrsmittel ausgegeben werden. |
| 6 | Kann | Funktional | Es sollen die Kosten für die angegebene Strecke per ÖV berechnet werden. | 



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Das Programm stellt eine Frage die Länge der Strecke einzugeben und fährt fort.| Eingabe Kilometeranzahl| Wechsel zur nächsten Frage|
| 2.1  | Das Programm fragt nach Eingabe des Start- und Endpunktes des Weges| Eingabe Start- und Endpunkt| Wechsel zur nächsten Frage| 
| 3.1  | Das Programm fragt welches Transportmittel der Benutzer auswählen will.| Eingabe ausgewähltes Transportmittel| Wechsel zu den Antworten| 
| 3.2  | Das gewünschte Transportmittel wurde eingegeben| Gewünschtes Transportmittel| Kosten der Strecke|
| 3.3  | Das gewünschte Transportmittel wurde eingegeben| Gewünschtes Transportmittel| Zeit der Fahrt pro Verkehrsmittel|
| 3.4  | Das gewünschte Transportmittel wurde eingegeben| Gewünschtes Transportmittel| Kosten der angegebene Strecke per ÖV|

### 1.4 Diagramme



## 2) Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 5.12.2022| Greub | Erstellung der Formel zur Berechnung der Wegkosten der einzelnen Transportmittel| 70' | 
| 2.A  | 5.12.2022| Manser, Evans | Das Basic Programm erstellen | 80' |
| 3.A  | 5.12.2022| Greub | Einteilung des Programms in Funktionen| 60' |

## 3) Entscheiden


## 4) Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 29.09.2022| Greub | 70'| 90'|
| 2.A  | 29.09.2022| Manser, Evans | 80' | 70' |
| 3.A  | 31.10.2022| Greub | 60


## 5) Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |    |    O.K.      |      |


**Fazit**


### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |  |  |       |    |
| II  |  | | | |


## 6) Auswerten

