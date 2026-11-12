Fehler im Unit-Test: Die eingegebe Testsequenz von Spielzügen endet, bevor jemand gewonnen hat. Ein simples Ändern von {1, 2, 5, 6, 7} auf {1, 2, 5, 6, 9} lässt Spieler 1 mit einer diagonalen Reihe von oben links nach untern rechts gewinnen.

Aufgabe 3: Ich bin immer noch der Meinung, dass ein Array mit 3 möglichen Zuständen besser ist als die Idee mit den Bits, einfach weil es leichter zu verstehen ist. Ja, das "Bitweise UND" ist clever, aber das wahrlich schlaue an dem ganzen ist die Idee der Mustererkennung. Die geht auch mit einem Array mit drei möglichen zuständen pro Feld. Man muss dem Code so oder so sagen, wie die gewinnenden Kombinationen aussehen. Ich habe das im Branch "Aufgabe-3" umgesetzt. Dies hat den Vorteil, dass das Rechnen mit bits komplett wegfällt, und das Prüfen nach einem Sieger sieht gar nicht so schlimm aus.

Aufgabe 2? Ich habe nicht wirklich was. 

Teilweise weil mir die Zeit ausgegangen ist. Ich habe bei Aufgabe 1 viel zu lange gebraucht. Ich habe erst den code nicht wirklich verstanden und erst viel zu spät gemerkt, dass die Testsequenz nicht im eigentlichen Test steht und damit zum verändern freigegeben ist... Und dann aber trotzdem noch ewig gezögert ob es tatsächlich erlaubt ist und/oder die Lösung so einfach sein soll. Aufgabe 3 hat mich vielleicht 1 1/2 stunden gekostet, was leichte Unvertrautheit mis VS Code (habe im betrieb immer Visual Studio verwendet) und ein googeln nach "Wie stelle ich Copilot aus?" beinhaltet.

Und teilweise weil ich mich gefragt habe wie sinnvoll es ist im eigentlichen Code Tests laufen zu haben.
Ich verstehe die Theorie, ich simuliere "einfach" einen Sieg und ein Unentschieden im Hintergrund sobald das Programm startet.
Ich weiß nur nicht ob das sinnvoll ist, und eine Google-Suche bestätigte mein Gefühl von "solche Tests haben im Produktiv-Code nichts verloren".
So sehr, dass ich mich frage ob die ganze zweite Aufgabe eine "Falle" oder Fangfrage ist.
Und darauf basierend frage ich mich sogar, ob die ganze Sache mit den Bits nicht auch eine Falle war.


KI benutzt: Keine. Als Copilot mir genau die Arraystruktur, die ich für die Siegesmuster wollte, vorgegeben hat und dieses Array schon vollständing und korrekt "vorgefüllt" war... Ich war erstaunt wie gut die Assistenten inzwischen sind und nach kurzer und erfolgloser suche prompt gegoogelt wie ich das Ding ausstelle.

Könnte ich heimlich weiterarbeiten, weit über die 3-4 stunden hinweg? Könnte ich versuchen Dinge schönzureden? Ja zu beidem.

Aber wenn ich hier auf die Nase fliege, dann tue ich das ehrlich.