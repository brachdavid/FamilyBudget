# FamilyBudget

Konzolov� aplikace pro spr�vu rodinn�ho rozpo�tu.

## Popis projektu

Aplikace **FamilyBudget** je jednoduch� n�stroj pro spr�vu rodinn�ho rozpo�tu. Umo��uje zaznamen�vat p��jmy a v�daje, zobrazovat aktu�ln� stav rozpo�tu a p�ehled v�ech transakc�.

## Funkce aplikace

- **P�id�n� v�daje** � Mo�nost zaznamenat novou v�dajovou transakci.
- **P�id�n� p��jmu** � Mo�nost zaznamenat novou p��jmovou transakci.
- **Zobrazen� v�ech v�daj�** � V�pis v�ech zadan�ch v�daj�.
- **Zobrazen� v�ech p��jm�** � V�pis v�ech zadan�ch p��jm�.
- **Zobrazen� v�ech transakc�** � Souhrnn� v�pis v�ech p��jm� i v�daj�.
- **Zobrazen� aktu�ln�ho stavu rozpo�tu** � Informace o zb�vaj�c�m z�statku v rozpo�tu.
- **T��d�n� v�daj�** � V�pis v�daj� se�azen�ch podle hodnoty.

## Instalace

1. Naklonuj repozit�� na sv�j lok�ln� stroj
   ```bash
   git clone <https://github.com/brachdavid/FamilyBudget>
2. Otev�i projekt v prost�ed� Visual Studio nebo jin�m C# editoru.
3. Sestav projekt a spus� konzolovou aplikaci.

## Pou�it�

Po spu�t�n� aplikace se ti zobraz� menu s mo�nostmi pro spr�vu rodinn�ho rozpo�tu. Vyber ��slo odpov�daj�c� po�adovan� akci (nap�. 1 pro p�id�n� v�daje). Aplikace se postar� o zbytek, v�etn� validace vstupn�ch �daj�.

## Technologie

- **Jazyk**: C# (konzolov� aplikace)
- **OOP p��stup**: Pou�it� t��d a abstrakce pro modelov�n� transakc� (Income, Expense) a jejich z�kladn� struktury (EntityBase).
- **Rozhran�**: Implementace rozhran� `ITransaction` pro sjednocen� vlastnost� p��jm� a v�daj�.
- **Validace vstup�**: O�et�en� vstup� u�ivatele pro zaji�t�n� spr�vn�ch hodnot (nap�. kontrola pr�zdn�ho n�zvu polo�ky, kontrola z�porn�ch nebo nulov�ch ��stek).
- **LINQ**: Pou�it� LINQ pro t��d�n� v�daj� podle jejich hodnoty.
- **Spr�va ID**: Automatick� spr�va unik�tn�ch ID pro ka�dou transakci pomoc� t��dy `EntityBase`.

## Autor

David B�ach - brasik20@seznam.cz