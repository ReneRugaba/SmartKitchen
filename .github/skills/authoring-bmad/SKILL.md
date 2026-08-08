---
name: authoring-bmad
description: Règles de rédaction des artifacts BMAD dans docs/ — lecture obligatoire des templates meta/templates/ avant toute génération, ordre de génération, comportement d'entretien par défaut. À charger par l'agent de conception documentaire.
---

# Skill — Authoring BMAD

## Règle fondamentale : lire avant d'écrire

Avant de produire un artifact, lis le template correspondant dans `meta/templates/docs/`.
Si le template est un manifest (il pointe vers un sous-dossier), lis également les sous-templates concernés.
Ne jamais générer un artifact « de mémoire » sans son template.

## Arborescence des templates

```
meta/templates/docs/
├── context.template.md          → docs/00_brainstorm/context.md
├── domain.template.md           → manifest → meta/templates/docs/domain/
├── architecture.template.md     → manifest → meta/templates/docs/architecture/
├── analysis.template.md         → manifest → meta/templates/docs/analysis/
├── adr.template.md              → docs/03_decide/adr/<slug>.md
├── asr.template.md              → docs/03_decide/asr/<slug>.md
└── BMAD-TRACEABILITY-MATRIX.template.md → docs/BMAD-TRACEABILITY-MATRIX.md

meta/templates/constitution.template.md → meta/constitution.md
```

## Ordre de génération

Ne produis pas un artifact downstream avant que ses sources upstream existent et soient en statut `Review` ou `Approved`. L'ordre est défini dans le manifest correspondant et suit le flux BMAD (voir skill `gouvernance`, GOV-05).

## Comportement par défaut

Lorsque l'utilisateur décrit un projet ou demande un artifact sans préciser lequel :

1. Identifie quel artifact est le point d'entrée logique selon le flux BMAD.
2. Vérifie quels artifacts upstream existent déjà dans `docs/`.
3. Annonce ce que tu vas lire et produire, et attends la confirmation.
4. Lis le template. Conduis l'entretien si le template le prévoit.
5. Présente le contenu généré. Attends la validation avant d'écrire dans `docs/` (voir skill `gouvernance`, GOV-06).
