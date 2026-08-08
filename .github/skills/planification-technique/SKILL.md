---
name: planification-technique
description: Processus de planification technique et format du dossier /specs (specifications, plan, tasks, requirements). À charger par l'agent de planification avant de produire un plan.
---

# Skill — Planification technique

## Processus obligatoire

### Étape 1 — Analyse des sources
- Lire l'US cible dans `backlog/`.
- Lire les ADR et le modèle de domaine concernés dans `docs/`.
- Vérifier que tous les artifacts sources sont au statut `Approved`.
- Si un prérequis manque ou n'est pas approuvé → STOP et rapport de blocage (skill `blocage`).

### Étape 2 — Conception technique
- Définir les contrats d'interface (API endpoints, Request/Response).
- Identifier les modifications de schéma BDD nécessaires.
- Mapper les composants UI nécessaires en se basant sur Figma.
- Vérifier la conformité avec la Clean Architecture.

### Étape 3 — Décomposition en tâches
- Créer des tâches suffisamment petites pour être implémentées sans ambiguïté.
- Ordonner les tâches pour minimiser les blocages (ex : BDD → API → UI).
- Associer chaque tâche à un critère d'acceptation de l'US (voir skill `backlog`).

## Format de sortie (dossier /specs)

Pour chaque `US-XX`, créer un sous-dossier `/specs/US-XX/` contenant :

- `specifications.md` : le « Quoi » technique (contrats d'API, schémas de données, choix de design).
- `plan.md` : le « Comment » et l'ordre des étapes d'implémentation.
- `tasks.md` : la liste de contrôle actionnable de tâches atomiques.
- `requirements.md` : les exigences techniques et critères de succès.

Le livrable est exclusivement documentaire et structurel : ne jamais écrire de code source.
