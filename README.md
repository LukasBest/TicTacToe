# Aufgabe: Tic Tac Toe

Willkommen! Diese kleine Solution ist ein Konsolen-Tic-Tac-Toe in C# mit Unit-Tests.
Sie ist bewusst **nicht** perfekt – wir möchten sehen, wie Sie mit bestehendem Code umgehen.

## Voraussetzungen

- [.NET SDK 10](https://dotnet.microsoft.com/download) (oder neuer)
- [Visual Studio Code](https://code.visualstudio.com/) mit der Erweiterung **C# Dev Kit**
  (VS Code schlägt sie beim Öffnen des Ordners automatisch vor).
  Visual Studio 2022/2026 oder JetBrains Rider funktionieren ebenso.

Läuft unter Windows, macOS und Linux.

## Loslegen

```bash
dotnet build
dotnet test
```

Alternativ in VS Code: Ordner öffnen → Testing-Ansicht (Kolbensymbol links) → *Run Tests*.

Das Spiel starten Sie mit `F5` (Konfiguration „TicTacToe.Console starten“) oder per

```bash
dotnet run --project Src/TicTacToe.Console
```

Die Felder sind von 1 (oben links) bis 9 (unten rechts) nummeriert.

**Erwartung:** Von den 12 Tests schlägt genau einer fehl.

## Ihre Aufgaben

1. **Fehlgeschlagener Unit-Test**
   Verstehen und beheben Sie das Problem mit dem fehlgeschlagenen Unit-Test.
   Erklären Sie kurz, *warum* er fehlschlägt und warum Ihre Korrektur die richtige ist.

2. **Testbarkeit und Test-Doubles**
   Die GameState-Tests verwenden einen handgeschriebenen Stub (`TestDoubles/StubIUserInput.cs`).
   Sorgen Sie dafür, dass sich die Spiellogik ohne echte Konsole und ohne Sonderpfade im
   Produktivcode testen lässt.
   - *Erwartung:* eigene Implementierungen von Test-Doubles.
   - *Erlaubt:* ein Mocking-Framework (z. B. NSubstitute, Moq, FakeItEasy), wenn Sie die Wahl begründen.

3. **Design-Analyse**
   Analysieren Sie die Solution und decken Sie Designfehler auf. Ihnen werden vermutlich
   Stellen auffallen, die wenig Sinn ergeben oder besser anders strukturiert wären.
   Wenn Sie bessere Ideen haben: Toben Sie sich aus und refaktorieren Sie.

## Abgabe

- Ihre Solution als **Git-Repository** (Link zu GitHub/GitLab o. Ä. oder als ZIP inkl. `.git`-Ordner).
  Bitte committen Sie den Ausgangsstand zuerst unverändert (`git init`, `git add .`, `git commit`).
  Kleine, nachvollziehbare Commits sind uns lieber als ein großer.
- Eine kurze **`LOESUNG.md`** (eine bis zwei Seiten genügen): Ursache des Testfehlers,
  gefundene Designfehler, was Sie geändert haben und warum, und was Sie mit mehr Zeit noch tun würden.
- **Zeitrahmen:** Planen Sie etwa 3–4 Stunden ein. Es muss nicht alles fertig werden. Priorisieren Sie
  und schreiben Sie auf, was offen geblieben ist.

## KI-Assistenten

Sie dürfen KI-Werkzeuge (Copilot, ChatGPT, Claude o. Ä.) verwenden. Bitte geben Sie in der
`LOESUNG.md` an, wofür. Im anschließenden Gespräch gehen wir Ihre Lösung gemeinsam durch.
Sie sollten jede Änderung erklären und begründen können.

Viel Spaß!
