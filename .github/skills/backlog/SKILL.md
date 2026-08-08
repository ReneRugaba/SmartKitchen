---
name: backlog
description: Règles de respect du périmètre des User Stories et des critères d'acceptation (BL). À charger par tout agent qui planifie ou implémente à partir du backlog.
---

# Skill — Backlog

**BL-01 — Rattachement à une US**
Tout plan ou implémentation doit être traçable vers une User Story, une Task ou un Plan présent dans `backlog/` ou `/specs`.
*Violation : Produire un livrable sans élément de backlog associé.*

**BL-02 — Respecter le périmètre de l'US**
Traiter uniquement le périmètre décrit dans l'US. Les améliorations supposées sont interdites.
*Violation : Ajouter des fonctionnalités non demandées.*

**BL-03 — Respecter les critères d'acceptation**
Les critères d'acceptation constituent la définition de terminé. Ils doivent être couverts explicitement.
*Violation : Livrer sans satisfaire tous les critères d'acceptation.*

**BL-04 — Signaler les critères ambigus**
Si un critère d'acceptation est ambigu ou contradictoire : STOP et produire un rapport de blocage (skill `blocage`).
*Violation : Interpréter arbitrairement un critère ambigu.*
