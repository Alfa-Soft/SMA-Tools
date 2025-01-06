# Tools rund um SMA und Sunny Portal

-   Sunny Portal CSV Merger CLI (Windows Console Anwendung ohne Oberfläche)
-   Sunny Portal CSV Merger GUI (Windows Anwendung)


.
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



.

### Sunny Portal CSV Merger CLI

SMA.CSV.Merger.exe
- Argument 1: Output
  Zieldatei, unterstützte Dateitypen .csv und .xls.

- Argument 2 bis n: Input
  Entweder Dateipfad (Ordner) in welcher die zu verarbeitenden .csv Dateien beinhaltet
  oder die zu verarbeitenden .csv Dateien werden direkt als Argument 2 bis n übergeben.

Beispiele
-   SMA.CSV.Merger.exe "c:\output.xls" "c:\SMA-CSV-Files\"

-   SMA.CSV.Merger.exe "c:\output.xls" "c:\SMA-CSV-Files\file1.csv" "c:\SMA-CSV-Files\file2.csv" "c:\SMA-CSV-Files\file3.csv"


