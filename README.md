# FamilyBudget

Konzolová aplikace pro správu rodinného rozpoètu.

## Popis projektu

Aplikace **FamilyBudget** je jednoduchı nástroj pro správu rodinného rozpoètu. Umoòuje zaznamenávat pøíjmy a vıdaje, zobrazovat aktuální stav rozpoètu a pøehled všech transakcí.

## Funkce aplikace

- **Pøidání vıdaje** – Monost zaznamenat novou vıdajovou transakci.
- **Pøidání pøíjmu** – Monost zaznamenat novou pøíjmovou transakci.
- **Zobrazení všech vıdajù** – Vıpis všech zadanıch vıdajù.
- **Zobrazení všech pøíjmù** – Vıpis všech zadanıch pøíjmù.
- **Zobrazení všech transakcí** – Souhrnnı vıpis všech pøíjmù i vıdajù.
- **Zobrazení aktuálního stavu rozpoètu** – Informace o zbıvajícím zùstatku v rozpoètu.
- **Tøídìní vıdajù** – Vıpis vıdajù seøazenıch podle hodnoty.

## Instalace

1. Naklonuj repozitáø na svùj lokální stroj
   ```bash
   git clone <https://github.com/brachdavid/FamilyBudget>
2. Otevøi projekt v prostøedí Visual Studio nebo jiném C# editoru.
3. Sestav projekt a spus konzolovou aplikaci.

## Pouití

Po spuštìní aplikace se ti zobrazí menu s monostmi pro správu rodinného rozpoètu. Vyber èíslo odpovídající poadované akci (napø. 1 pro pøidání vıdaje). Aplikace se postará o zbytek, vèetnì validace vstupních údajù.

## Technologie

- **Jazyk**: C# (konzolová aplikace)
- **OOP pøístup**: Pouití tøíd a abstrakce pro modelování transakcí (Income, Expense) a jejich základní struktury (EntityBase).
- **Rozhraní**: Implementace rozhraní `ITransaction` pro sjednocení vlastností pøíjmù a vıdajù.
- **Validace vstupù**: Ošetøení vstupù uivatele pro zajištìní správnıch hodnot (napø. kontrola prázdného názvu poloky, kontrola zápornıch nebo nulovıch èástek).
- **LINQ**: Pouití LINQ pro tøídìní vıdajù podle jejich hodnoty.
- **Správa ID**: Automatická správa unikátních ID pro kadou transakci pomocí tøídy `EntityBase`.

## Autor

David Bøach - brasik20@seznam.cz