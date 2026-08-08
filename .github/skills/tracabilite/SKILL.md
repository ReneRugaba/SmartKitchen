---
name: tracabilite
description: Exigences de traçabilité — rattacher chaque livrable (artifact, plan, code) à ses identifiants sources (US, ADR, Requirement, Architecture) et ne pas dupliquer l'information.
---

# Skill — Traçabilité

**TRC-01 — Tout livrable est rattachable à une source**
Identifier systématiquement, lorsqu'ils existent :

- Requirement IDs
- Story IDs (US-XX)
- ADR IDs
- Architecture IDs

*Violation : Produire un livrable sans origine documentaire identifiable.*

**TRC-02 — Ne pas dupliquer**
Si une information existe dans un artifact upstream, la référencer par un lien relatif. Ne jamais la recopier.
*Violation : Dupliquer une information déjà présente dans une source.*
