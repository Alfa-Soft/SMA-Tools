# Tools rund um SMA und Sunny Portal

### Sunny Portal CSV Merger

Tool, welches exportierte CSV Dateien aus dem Sunny Portal in ein .xls Datei zusammenführt.

Anwendung:
-	Ordner welcher die CSV-Dateien beinhaltet oder Dateien per Drag&Drop hinzufügen
-	Zieldatei festlegen, konvertieren als .CSV oder .XLS


![](https://github.com/Alfa-Soft/SMA-Tools/blob/main/CSV-Converter/Misc/SMA-CSV-Converter.png)

-	Korrigiert wechselnde Einheiten unterschiedlicher Export-Dateien (W, kW, mW) zu kW.
-	Beherrscht die Situation unterschiedlicher Spalten (z.B. Verbraucher  unter dem Jahr hinzugekommen oder weggefallen). Spalte wird mit 0 für jene Monate zu welchen keine Daten vorliegen aufgefüllt.
-	Sortiert die Daten nach Datum.

In Excel können die Daten z.B. in dieser Form dargestellt werden.
![](https://github.com/Alfa-Soft/SMA-Tools/blob/main/CSV-Converter/Misc/xlsPivot.png)
-   Datei mit Excel öffnen
-   Warnung, dass es sich um ein .xml handelt, ignorieren
-   speichern als ".xlsx"
