## Übungsaufgabe

Betrachtet die Source-Code-Dateien 
[FamilyTree.cs](FamilyTree.cs) und 
[Program.cs](Program.cs). In Familytree wird eine Datenstruktur aufgebaut,
die eine Art Familienstammbaum repräsentiert (Ähnlichkeiten mit realen Personen sind rein zufällig :-)).

Macht euch klar, dass die Datenstruktur `Person` rekursiv ist, denn jedes Objekt vom Typ `Person` referenziert
zwei weitere Objekte vom Typ `Person`, nämlich `Mom` und `Dad`. 

Die Methdode `BuildTree()` baut einen Beispiel-Baum auf. Setzt einen Breakpoint in [Zeile 19 von Program.cs](Program.cs#L19),
startet den Debugger und seht Euch den Inhalt von `root` im Debugger an.

> ## Antwort
> jüngste Person im Stammbaum: Willi Cambridge -
>| Mom        | Dad           |
>| ------------- |:-------------:|
>| Diana Spancer     | Charlie Wales |

> Die Eltern von Diana Spencer
>| Mom        | Dad           |
>| ------------- |:-------------:|
>| Franzi Roche    | Eddie Spencer |

> Die Eltern von Charlie Wales
>| Mom        | Dad           |
>| ------------- |:-------------:|
>| Else Windsor   | Phillip Battenberg |

> Die Eltern von Franzi Roche
>| Mom        | Dad           |
>| ------------- |:-------------:|
>| Ruth Gill   | Moritz Roche |

> Die Eltern von Eddie Spencer
>| Mom        | Dad           |
>| ------------- |:-------------:|
>| Cynthia Hamilton   | Albert Spencer |

> Die Eltern von Else windsor
>| Mom        | Dad           |
>| ------------- |:-------------:|
>| Lisbeth Bowes-Lyon  | Schorsch-Albert York |

> Die Eltern von Phillip Battenberg
>| Mom        | Dad           |
>| ------------- |:-------------:|
>| Alice Battenberg  | Andi ElGreco |

>Familien-Stammbaum hört bei `null` auf
>Bei der Abfrage nach den einzelnen Personen wird immer auf eine tiefere Ebene verwisen, bis keine mehr zur Verfügung steht.

Die Methode `Find()` durchläuft rekursiv den Baum und prüft alle `Person`-Objekte darauf, ob die Bedingung in 
[Zeile 22](FamilyTree.cs#L22) gegeben ist. Die erste `Person`, die die Bedingung erfüllt, wird zurückgeliefert.

Ändert die Bedingung so, dass nicht gleich die erste Person ("Willi") zurückgegeben wird. Eventuell gibt es Abstürze.
Analysiert die Abstürze mit dem Debugger, überprüft Variableninhalte und den Call-Stack.

> ## Antwort
>```C#
>if (person.LastName != "Cambridge"  && person.LastName != "Spencer")
>
>Es wird immer eine Ebene tiefer angefangen und von dort aus im Stammbaum bis `null` "runterverwiesen"
>Dabei wird als Ergebnis "Franzi Roche" ausgegeben
>``` 
>```C#
>Es gibt auch eine zweite Möglichkeit die Bedingung umzuschreiben: 
>if (person.LastName == "Battenberg")
>Hierbei wird eine System.NullReferenceException ausgeworfen, da der Stammbaum Rekursiv durchlaufen wird und eine Übereinstimmung mit dem Namen "Battenberg" sucht. Dabei wird der Stammbaum mütterlicherseits durchsucht, wird nichts gefunden führ dies zu einer NullReferenceException.
>```

Schreibt komplexere Bedingungen, findet z.B. die erste Person, die in einer Altersspanne liegt, vergleicht dazu person.DateOfBirth.Year
mit DateTime.Now.Year. Analysiert mit dem Debugger, ob Eure Bedingung richtig ist. 

> ## Antwort
>```csharp
>var age = DateTime.Now.Year - person.DateOfBirth.Year;
>            if(80 < age && age < 100)
>                return person;
>```
>Die Zeitpanne wird durch die Differenz berechnet und in einer if-Bedingung mit dem Alter der Personen verglichen. Sobald die Bedingung von einer Person im Stammbaum erfüllt wird, wird diese ausgegeben.
>```csharp
>public override string ToString()
>    {
>        return "Person: " + FirstName + " " + LastName + " " + "Geburtstag: " + DateOfBirth;
>    }
>``




