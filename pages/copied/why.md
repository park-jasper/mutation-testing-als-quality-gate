---
layout: center
---

## "Die KI ist eine vorübergehende Erscheinung. Ich glaube an das Pferd."

<v-click at="1">

### - Nicht Kaiser Wilhelm II.

</v-click>

---
layout: image
image: /images/luddites-loom.jpg
backgroundSize: 52%
---

<div class="citation" style="left: 33%">
Quelle: [https://www.historic-uk.com/HistoryUK/HistoryofBritain/The-Luddites/]
</div>

<!--
Luddites: Manchester Textile Workers rebel 9. Oktober 1779
-->


---
layout: two-cols
---

<style scoped>
.vs-text {
  left: 48%;
  border-color: var(--bh-dark-blue);
}
</style>

<!-- Slide with comparison Gain vs. Risk -->

<!-- Headers -->
::left::

<h1> Gains </h1>

<div class="flex items-center justify-center h-95">
  <div class="rounded-full bh-primary-blue w-80 h-80 flex items-center text-white text-center justify-center text-3xl font-bold p-2">
    <v-switch>
      <template #0>
        KI kann viel
      </template>
      <template #1>
        Die KI ist schneller als ich
      </template>
      <template #2>
        Die KI kann schnell Prototypes erstellen
      </template>
      <template #3>
        Die KI versteht, was in meinem Code passiert
      </template>
    </v-switch>
  </div>
</div>

::right::

<h1 style="color: var(--bh-dark-blue);"> Risks </h1>
<div class="flex items-center justify-center h-95">
  <div class="absolute border w-10 h-10 flex rounded-full p-2 font-bold italic bh-light-blue vs-text items-center justify-center text-center">vs.</div>
  <div class="rounded-full bh-dark-blue w-80 h-80 flex items-center text-white text-center justify-center text-3xl font-bold p-2">
    <v-switch at="1">
      <template #0>
        Es ist nicht immer alles richtig, was dabei herauskommt
      </template>
      <template #1>
        Spare ich Zeit, wenn ich alles verstehen will?
      </template>
      <template #2>
        Wie geht das bei einer bestehenden, großen Code-Basis?
      </template>
      <template #3>
        Wie Verantwortung für Code übernehmen, den ich nicht selbst geschrieben habe?
      </template>
    </v-switch>
  </div>
</div>

<!-- ---

# Sorgen als Software-Developer

- Verpasse ich die nächste Technologie?

- KI kann viel, aber naive Beobachtung zeigt: es ist nicht immer alles richtig, was dabei rauskommt
  -> erster Eindruck: das macht mir mehr Arbeit als es hilft
- Vergleich Näher-Gilde, die Nähmaschinen kaputt machen weil sie um ihre Jobs fürchten -> sind das aktuell die SW-Devs, die das ablehnen?
- Das Problem mit Halluzinationen:
  - Benchmark Car-Wash
- Vergleich mit Lotto -> One-Shot hat nur geringe Chance, das alles auf einmal richtig wird
  - Trial und Error ist mühsam
- Hier kommt spec-driven Development zum Einsatz: Wir fügen absichtlich breaks ein, und lassen uns Zwischenergebnisse als Markdown ausgeben, die wir lesen und sogar bearbeiten können (manuell oder mit KI) bevor wir weiter machen
  - Ablauf:
    - Produktplanung: was soll am Ende rauskommen? mission.ms, roadmap.md, tech-stack.md
    - Plan für Feature -> eingebautes Plan-Feature (vorher /write-spec)
    - shape-spec für AgentOs spezifische Themen
    - Dann haben wir eine Liste an Tasks, die wir einzeln implementieren lassen können -> so kann der Mensch verstehen, was passiert, ohne überwältigt zu werden von 1000+ Zeilen an Änderungen auf einmal
    - Code-Review und commit der changes mit git, dann der nächste Task -->

<!--
  Notes: Vergleich Luddites, die mechanische Webstühle zerstören, weil ihr Berufsbild dadurch gefährdet ist

-->