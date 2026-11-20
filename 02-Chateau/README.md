# Château-viner

## Uppgift
Du har en lista (array) med vinnamn i programmet. Ta reda på **hur många viner som har ett namn som innehåller "chateau"**.

När du klickar på knappen **Räkna Château-viner** ska antalet visas.

Skriv din kod i metoden `OnCountClick` i `MainWindow.xaml.cs`.

### Exempel
Med vinerna som redan finns i programmet är rätt svar **3**.

## Mål
- Träna på att **loopa igenom en array**.
- Använda en **sträng-metod** för att söka efter text.
- Räkna med en **räknare** (`int`).

## Tips
- Vi behöver nog **gå igenom (loopa) alla viner** i listan – en i taget.
- För varje vin: **kontrollera om namnet innehåller** "chateau".
  - Det finns en färdig metod på en sträng som letar efter text i den.
  - Tänk på stora och små bokstäver – det finns en metod som gör om en text till små bokstäver innan du jämför.
- Om namnet innehåller "chateau": **öka räknaren** med 1.
- Visa räknaren till slut.

> I konstruktorn finns redan en loop som visar vinerna i listan. Du kan titta på den som ett exempel på hur en loop över arrayen ser ut.

### Pseudokod

```
antal = 0
för varje vin i listan:
    om vinets namn (i små bokstäver) innehåller "chateau":
        antal = antal + 1
visa antal
```
