Fehler im Unit-Test: Die eingegebe Testsequenz von Spielzügen endet, bevor jemand gewonnen hat. Ein simples Ändern von {1, 2, 5, 6, 7} auf {1, 2, 5, 6, 9} lässt Spieler 1 mit einer diagonalen Reihe von oben links nach untern rechts gewinnen.

Aufgabe 3: Ich bin immer noch der Meinung, dass ein Array mit 3 möglichen Zuständen besser ist als die Idee mit dem bit-Und, einfach weil es verständlicher ist. Ja, das "Bitweise Und" ist clever, aber man muss dem Programm so oder so sagen, was die gewinnenden Kombinationen sind. Im Branch "Aufgabe 3" ist das GameBoard entsprechend modifiziert, und das prüfen nach einem Sieger sieht gar nicht mal so schlimm aus. Und man kann sich das ganze hin- und hergerechne mit den bits sparen.

