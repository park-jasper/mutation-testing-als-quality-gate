---
layout: default
---

# Wie binde ich Libraries ein, welche die KI nicht kennt? <img src="/images/FunicularSwitch.png" h-10 float-right/>

<v-clicks>

1. KI generiert Code, der die library inkorrekt benutzt
1. Der Mensch repariert die Nutzung an einer Stelle
1. "Die Library X wird nicht so benutzt, sondern so wie ich es in Methode Y gemacht habe. Pass das überall an"<br>=> "... und passe entsprechend die standards.md so an, dass es in Zukunft von alleine geht"

</v-clicks>

---

## Mittlerweile: Skills

Skills sind markdown files, die der KI bestimmte Dinge genauer beschreiben oder erklären.

<v-click>
<pre><code lang="markdown">&#45;&#45;&#45;
name: grill-me
description: Interview the user relentlessly about a plan or design until reaching
  shared understanding, resolving each branch of the decision tree. Use when user
  wants to stress-test a plan, get grilled on their design, or mentions &quot;grill me&quot;.
&#45;&#45;&#45;
Interview me relentlessly about every aspect of this plan until we reach a shared
  understanding. Walk down each branch of the design tree, resolving dependencies
  between decisions one-by-one. For each question, provide your recommended answer.
Ask the questions one at a time.
If a question can be answered by exploring the codebase, explore the codebase instead.
</code></pre>
</v-click>

<!--
Der Agent schaut inital die Header von allen verfügbaren Skills an und entscheidet, welche davon für den aktuellen Prompt relevant sind. Von den relevanten liest er dann den Inhalt. So können viele Skills vorhanden sein ohne den Context bei jedem Prompt zu vermüllen.
-->

---

### Skill selber erstellen

<v-click>

`In this project we are using the package X, the correct usage can be seen in file Y.cs. Create a skill that will facilitate the proper usage in the future.`

</v-click>

<v-click>

### Vorhandene Skills nutzen

</v-click>
<v-click>

Es gibt ein Package `skills` von Vercel, in dem eine ausgesuchte Menge an Skills out-of-the-box vorhanden

```sh
npx skills add org/repo
```

</v-click>
<v-click>

```sh
npx skills add juliusbrussee/caveman
```

</v-click>

---

# Game-Changer: Meta-Prompting

<v-click>
Erkenntnis: Wenn ich Spezifikationen selber hinschreibe, dann sind Formulierungen unvollständig und die KI muss bei jedem nachfolgenden lesen wieder herausfinden, was ich meine.
</v-click>
<br><br>
<v-click>
Stattdessen: lasse ich die KI einmal die Intention aus meinem kurzen Text bestimmen und sie soll die Spezifikation schreiben und anpassen. Ich lese dann nur noch drüber, ob das dem entspricht, was ich haben will.
</v-click>