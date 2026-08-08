---
name: gouvernance
description: Hiérarchie d'autorité, primauté de la Constitution, règles de gouvernance (GOV) et principe « la documentation approuvée fait foi » (DOC). À charger au début de toute session par tout agent avant de générer un artifact, un plan ou du code.
---

# Skill — Gouvernance

## Constitution : autorité suprême

Lis `meta/constitution.md` au début de chaque session.
En cas de conflit avec une skill, un template, un prompt ou une instruction locale, **la Constitution prévaut toujours**.

## Hiérarchie d'autorité

En cas de conflit entre plusieurs sources, applique l'ordre décroissant suivant :

```text
Constitution
  > Artifacts Approved dans docs/
  > Specs (specifications, plans, tasks, requirements dans /specs)
  > Backlog (US validées)
  > ADR Approved
  > Instructions utilisateur
  > Code existant
  > Connaissances implicites de l'agent
```

Le code est une conséquence de la documentation. La documentation n'est jamais une conséquence du code.

## Règles de gouvernance

**GOV-01 — Respecter la Constitution**
La Constitution est toujours prioritaire.
*Violation : Ignorer une règle de la Constitution.*

**GOV-02 — N'utiliser que des sources Approved**
Utiliser uniquement des artifacts `Approved` comme sources d'un livrable downstream.
*Violation : Générer à partir d'un artifact `Draft` ou `Review`.*

**GOV-03 — Ne jamais modifier un artifact Approved**
Les artifacts `Approved` sont immuables.
*Violation : Modifier directement ou indirectement un artifact `Approved`.*

**GOV-04 — Refuser les contradictions documentaires**
Si plusieurs artifacts `Approved` se contredisent : STOP et produire un rapport de blocage (voir skill `blocage`).
*Violation : Choisir arbitrairement une version.*

**GOV-05 — Respecter le flux documentaire BMAD**
Ordre autorisé : `context` → `domain` → `architecture` → `analyse` → `décisions` → `backlog` → `specs` → `implémentation`.
Ne jamais produire un artifact downstream avant que ses prérequis upstream existent et soient en statut `Review` ou `Approved`.
*Violation : Sauter une étape obligatoire.*

**GOV-06 — Supervision humaine obligatoire**
Tout livrable structurant (artifact `docs/`, plan `/specs`) doit être présenté et validé par l'utilisateur avant d'être écrit ou consommé en aval. Présenter le contenu avant d'écrire.
*Violation : Écrire ou propager un livrable sans validation humaine.*

## La documentation approuvée fait foi

**DOC-01 — Vérifier la documentation avant d'agir**
Ne jamais produire de code ou de plan sans avoir identifié les documents applicables.
*Violation : Agir à partir d'une hypothèse.*

**DOC-02 — La documentation approuvée prévaut**
En cas de conflit entre le code et la documentation approuvée : la documentation prévaut.
*Violation : Utiliser le comportement du code comme source de vérité.*

**DOC-03 — Ne jamais remplacer une exigence documentée**
Reproduire fidèlement l'intention des exigences approuvées.
*Violation : Modifier l'intention métier d'une exigence.*
