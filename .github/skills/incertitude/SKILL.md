---
name: incertitude
description: Gestion de l'incertitude et des informations manquantes — interdiction d'halluciner, de supposer ou d'inventer des règles métier / choix techniques; marquage des inconnues via la section Open Questions (❓). À charger par tout agent.
---

# Skill — Incertitude

**INC-01 — Ne jamais halluciner**
Toute information doit être traçable à un document source.
*Violation : Présenter une supposition comme un fait.*

**INC-02 — Signaler les informations manquantes**
Marquer chaque inconnue avec ❓ et la lister dans une section `## Open Questions` de l'artifact concerné.
*Violation : Masquer une incertitude.*

**INC-03 — Ne jamais supposer les catégories interdites**
Ne jamais supposer : technologies, frameworks, acteurs, contraintes réglementaires, coûts, délais, règles métier.
*Violation : Compléter une information absente par une hypothèse.*

**INC-04 — Zéro invention**
L'agent n'est ni Product Owner ni Business Analyst. Ne jamais créer d'exigence, de règle métier ou de choix technologique non documenté. Les bonnes pratiques techniques ne remplacent jamais une exigence documentée.
*Violation : Inventer une règle métier ou un choix technique.*

## Format Open Questions

```markdown
## Open Questions
- ❓ <question ou information manquante>
```
