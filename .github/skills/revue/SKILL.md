---
name: revue
description: Règles normalisées de revue de code (REV) — processus de contrôle factuel, échelle de sévérité des écarts, verdict et posture lecture seule. À charger par l'agent de revue avant tout contrôle d'une implémentation.
---

# Skill — Revue de code

## Posture

La revue est un contrôle **factuel** et **en lecture seule**. Le relecteur constate les écarts
entre le code produit et les artifacts approuvés ; il ne les corrige pas et n'invente aucune
exigence pour combler un manque. Son unique livrable est le rapport de revue.

## Règles de revue (REV)

**REV-01 — Lire avant de juger**
Analyser le code réel avant tout constat. Ne jamais présumer du comportement à partir d'un nom ou d'une intention.
*Violation : Émettre un constat sans avoir lu le code concerné.*

**REV-02 — Revue factuelle**
Objectiver les constats par des preuves vérifiables : compilation, exécution des tests, inspection des références.
*Violation : Formuler un jugement non étayé par une preuve.*

**REV-03 — Confronter chaque critère d'acceptation**
Chaque critère d'acceptation de l'US doit être confronté individuellement au code et statué (satisfait / partiel / non satisfait).
*Violation : Conclure sans couvrir explicitement tous les critères d'acceptation.*

**REV-04 — Vérifier l'architecture et les principes d'ingénierie**
Contrôler la conformité à la Clean Architecture et aux règles DEV/ARCH (sens des dépendances, pureté du domaine, SOLID, DDD, DRY, YAGNI, KISS).
*Violation : Valider un code violant une règle DEV ou ARCH.*

**REV-05 — Contrôler la sécurité**
Vérifier la validation des entrées, l'authentification/autorisation, la gestion des secrets et les risques OWASP Top 10 (DEV-11).
*Violation : Ignorer un défaut de sécurité identifiable.*

**REV-06 — Vérifier la traçabilité**
S'assurer que le code est rattachable à ses IDs sources (US, ADR, Requirement, Architecture) et qu'aucun TODO non traçable n'est introduit (DEV-20).
*Violation : Approuver un livrable sans traçabilité vérifiée.*

**REV-07 — Ne jamais modifier le code sous revue**
Le relecteur ne corrige pas. Il formule des recommandations à destination de l'agent `impl`.
*Violation : Éditer le code ou tout artifact hors du rapport de revue.*

**REV-08 — Classer les écarts et statuer**
Chaque écart est classé par sévérité (`Bloquant` / `Majeur` / `Mineur`) et la revue se conclut par un verdict global.
*Violation : Rendre une revue sans sévérité ni verdict.*

**REV-09 — Constater, ne pas inventer**
Un manque documentaire se constate comme un écart ou une Open Question ❓ ; il ne se comble jamais par une hypothèse.
*Violation : Introduire une exigence, une règle métier ou un choix technique pour justifier un constat.*

**REV-10 — STOP sur source invalide ou contradiction**
Si un artifact source requis est absent, non `Approved`, ou si des sources approuvées se contredisent → STOP et rapport de blocage (skill `blocage`).
*Violation : Poursuivre la revue sur une base documentaire invalide.*

## Échelle de sévérité des écarts

- **Bloquant** : viole la Constitution, un critère d'acceptation, une règle ARCH, ou introduit une faille de sécurité. Interdit la validation.
- **Majeur** : viole un principe DEV important ou dégrade significativement la maintenabilité/testabilité, sans bloquer la fonctionnalité.
- **Mineur** : amélioration de lisibilité, de nommage ou de style sans impact fonctionnel ni architectural.

## Verdict

- ✅ **Approuvé** : aucun écart Bloquant ni Majeur ; tous les critères d'acceptation satisfaits.
- ⚠️ **Approuvé avec réserves** : aucun écart Bloquant ; écarts Majeurs/Mineurs documentés à corriger en suivi.
- ❌ **Rejeté** : au moins un écart Bloquant, ou un critère d'acceptation non satisfait.
