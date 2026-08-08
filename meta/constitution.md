# Agent Constitution — SmartKitchenIdp

> Cette constitution définit les règles d'autorité, de génération et de gouvernance applicables aux agents intervenant sur le projet. En cas de conflit avec un template, un prompt ou une instruction locale, cette constitution prévaut.

---

## 1. Directives Primaires de Génération

### R-01 — Interdiction Absolue d'Invention
N'invente jamais une information absente des artifacts upstream, du code source ou des sources explicitement fournies. Face à une information manquante, l'agent doit **bloquer la génération et demander explicitement** la précision à l'utilisateur.

**Justification :** Protège le projet contre les hallucinations et les décisions fondées sur des informations erronées, suite à des expériences passées négatives.
**Violation :** Générer une information présentée comme factuelle sans source ou artefact de référence.

### R-02 — Interdiction de Supposer les Catégories Critiques
Ne suppose jamais, même partiellement, les éléments suivants lorsqu'ils ne sont pas explicitement définis :
- Choix technologiques (langages, frameworks, cloud providers).
- Règles métier et invariants du domaine.
- Acteurs et parties prenantes.
- Contraintes réglementaires ou de conformité.
- Estimations de coût ou de délai.

**Justification :** Préserve l'intégrité des décisions structurantes du projet.
**Violation :** Introduire un framework, une règle métier, une estimation ou une contrainte non documentée.

### R-03 — Préservation des Artifacts Approuvés
Ne modifie jamais un artifact dont le statut est `Approved`. Toute modification d'un tel document nécessite une intervention humaine explicite et, si la décision change, la création d'un ADR.

**Justification :** Protège les décisions validées et réduit les régressions documentaires.
**Violation :** Modifier directement un artifact au statut `Approved`.

### R-04 — Respect Strict des Prérequis Documentaires
Vérifie systématiquement que tous les artifacts prérequis existent et sont au statut `Approved` avant de générer un artifact downstream.

**Justification :** Réduit les incohérences et les dépendances invalides.
**Violation :** Générer un artifact avant la validation complète de ses sources de vérité.

### R-05 — Application d'un Niveau de Prudence Élevé
Considère toute génération comme susceptible d'impacter des livrables ou décisions en aval. Applique une vérification renforcée de la cohérence avant toute production.

**Justification :** Limite la propagation d'erreurs dans la chaîne documentaire.
**Violation :** Produire un livrable sans contrôle de cohérence alors qu'il influence des artifacts downstream.

---

## 2. Discipline de Statut et Immuabilité

### R-06 — Respect du Cycle de Vie Documentaire
Utilise exclusivement les statuts suivants : `Draft` $\rightarrow$ `Review` $\rightarrow$ `Approved` $\rightarrow$ `Deprecated`.

**Justification :** Maintient un cycle de validation clair et traçable.
**Violation :** Employer un statut non défini ou ignorer le statut d'un artifact.

### R-07 — Immuabilité du Statut Approved
Considère tout artifact `Approved` comme immuable pour l'agent.

**Justification :** Garantit la stabilité des décisions validées.
**Violation :** Éditer un artifact `Approved` directement ou indirectement.

### R-08 — Utilisation Exclusive de Sources Approved
Utilise uniquement des artifacts au statut `Approved` comme source pour la génération d'un artifact downstream.

**Justification :** Garantit la fiabilité des dépendances documentaires.
**Violation :** Référencer ou baser une génération sur un document en statut `Draft` ou `Review`.