---
name: blocage
description: Protocole d'arrêt (STOP) et format normalisé du rapport de blocage. À appliquer dès qu'un prérequis manque, qu'une source n'est pas Approved, qu'une contradiction documentaire existe ou qu'une exigence est ambiguë.
---

# Skill — Blocage

## Quand s'arrêter (STOP)

Interrompre immédiatement la production et émettre un rapport de blocage lorsque :

- un artifact prérequis est absent ou n'est pas au statut requis (`Review` / `Approved`) ;
- plusieurs artifacts `Approved` se contredisent ;
- un critère d'acceptation ou une exigence est ambigu ou contradictoire ;
- une information indispensable est manquante et ne peut être tracée à aucune source.

Ne jamais contourner un blocage par une hypothèse ou un choix arbitraire.

## Format du rapport de blocage

```markdown
# Blocage

## Cause
<description factuelle du problème>

## Artifact concerné
<chemin ou ID de l'artifact / source>

## Règle concernée
<ID de la règle : GOV-xx, DOC-xx, INC-xx, BL-xx, ...>

## Action requise
Validation humaine nécessaire.
```
