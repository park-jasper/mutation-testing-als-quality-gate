# Mutation Testing als Quality-Gate für KI-generierten Code

## Wenn KI den Code schreibt, und KI die Tests schreibt - wer testet dann die Tests? Ein Praxis-Guide für Mutation Testing

In Zeiten agentischen Codens gibt es mehrere Strategien, um die Korrektheit des Codes zu überprüfen. KI-generierter Code lässt sich mit Tests prüfen. Aber wie werden KI-generierte Tests geprüft?

Ansätze hierfür gab es auch schon vor agentic coding. Einer davon ist Mutation Testing. Hierbei werden durch ein externes Tool systematisch Bugs in den Code eingebaut, und dann geschaut, ob diese durch einen der bestehenden Tests abgefangen werden. Sind bei einer Mutation alle Tests weiterhin grün, sind an der Stelle die Tests blind.

Der Agent kann nun instruiert werden, bei vielen überlebenden Mutationen die Tests so zu erweitern, dass für die betroffene Code-Stelle ein Assert existiert. Es ist also ein weiteres Tool, mit dem Agents ihren generierten Code testen und das Ergebnis verbessern können.

In diesem Talk besprechen wir die Konzepte hinter Mutation Testing und schauen uns ein Praxis-Beispiel aus dem C#-Universum an, wie Stryker.NET in die lokale Entwicklungsumgebung sowie in die Pipeline integriert werden kann.

## aussortiert

 Ein Ansatz ist Mutation Testing, bei dem ...


 und mehr Code schreiben sind gute Tests unerlässlich, um Regressionen zu verhindern. Das sind zum Einen End-To-End-Tests, die sicherstellen, dass spezifizierte Use-Cases korrekt ablaufen. Zum Anderen ergänzen Unit-Tests das Bild, die die Domänenlogik auf Herz und Nieren prüfen.

Weil bei den Unit-Tests interne Klassen getestet werden, die keine öffentliche Schnittstelle haben, liegt er hier nah, diese Tests auch mit der KI generieren zu lassen. Die Frage ist hier also, wie die Tests auf Vollständigkeit getestet werden können.

- Halluzination
- Testen der Tests
- Wer testet deine Tests?

## Notes

- falsche Metriken -> nicht auf Test Coverage
- Zusammenspiel mit Verify Tests?
- Zusammenspiel mit Property Based Tests
- Devops PR Check (analog zu Coverage?)
- Self-Hosted Dashboard?

## Demo

- Domain project mit Logik
- Bootstrapper um das Projekt (CLI, Web) damit man etwas sehen kann
- Unit Test für das Domain Projekt
- Build Pipeline in Devops mit Reporting
- KI Skill und Prompt, damit sie das nutzt und sich selber kontrolliert
  - baseline? für lokal
  - baseline für PRs
- Wie umgehen mit unliebsamen Mutationen?
  - Empfehlung für Ignores und Best-Practices