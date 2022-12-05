# Projekt-Dokumentation

Greub Manuel, Evans Tristan, Manser Alberto

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|  29.09.22 |  0.0.1 | Wir haben mit dem Auftrag angefangen und einen Teil schon fertig gemacht.|         
|  07.11.22 |  0.0.2 | Wir haben Azure Maps kennengelernt und mit diesem weitergearbeitet.|
|  14.11.22 |  0.0.3 | Wir haben heute an dem Programm weitergearbeitet.|
|  21.11.22 |  0.0.4 | Wir haben am Programm weitergearbeitet und wir sind fast fertig.|
|  28.11.22 |  1.0.0 | Das Programm ist fertig, aber kann noch verbessert werden.|


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
| 4.1  | Alle nötigen eingaben wurden getätigt | nichts | Mit dem Töff werden sie pro Kilometer 0,0000081 Fr kosten |
| 5.1  | Fahrzeug wurde ausgewählt | Baden Zürich | Reisezeit: 00:45:00 |


### 1.4 Diagramme

![LA_ProjektSchulwegPAP](https://user-images.githubusercontent.com/110893008/204315332-3ed4d224-6c02-40a0-a937-7737fc0bbcaf.png)


## 2) Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 5.12.2022| Evans, Greub, Manser | Erstellung der User Storys | 20'|
| 2.A  | 5.12.2022| Evans, Greub, Manser | Erstellung der Testfälle| 20'|
| 3.A  | 5.12.2022| Greub, Manser | Erstellung der Formel zur Berechnung der Wegkosten der einzelnen Transportmittel| 70' | 
| 4.A  | 5.12.2022| Manser, Evans| Erstellung des Alpha Programmes| 60' | 
| 5.A  | 5.12.2022| Greub, Manser | Einteilung des Programms in Funktionen| 60' |
| 6.A  | 5.12.2022| Manser, Greub, Evans| Integrierung von dem Azure Maps System| 80'| 
| 7.A  | 5.12.2022| Evans, Greub, Manser| Code verschönern und allfällige Probleme verbessern| 30'|




## 3) Entscheiden
* ÖV konnten wir Leider nicht realisieren, da eine Verknüpfung an die SBB Datenbank nicht möglich war.

## 4) Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 29.09.2022| Evans, Greub, Manser| 20'| 20'|
| 2.A  | 29.09.2022| Evans, Greub Manser | 20'| 30'|
| 3.A  | 6.09.2022| Greub, Manser | 70'| 80' |
| 4.A  | 31.10.2022| Evans, Manser | 60'| 90'|
| 5.A  | 07.11.2022 | Manser, Greub| 60'| 80'|
| 6.A  | 28.11.2022| Manser, Greub, Evans| 80'| 120'|
| 7.A  | 28.11.2022| Evans, Greub, Manser| 30'| 60' |

## 5) Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
|1.1|5.12.2022|O.K.| Greub|
|2.1|5.12.2022|O.K.|Greub |
|3.1|5.12.2022|O.K.|Greub |
|3.2|5.12.2022|O.K.|Greub |
|3.3|5.12.2022|O.K.|Greub |
|3.4|5.12.2022|Nicht O.K.|Greub|
|4.1|5.12.2022|O.K.|Greub|
|5.1|5.12.2022|O.K.|Greub|


**Fazit**


### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |  |  |       |    |
| II  |  | | | |


## 6) Auswerten
