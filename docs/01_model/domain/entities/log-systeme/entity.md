# Entity: Log Système

> Part of: [Domain Index](../index.md)
> Vocabulary: [Ubiquitous Language](../ubiquitous-language.md)

---

## Description

Le Log Système est un enregistrement technique des événements survenus lors de l'exécution du système (erreurs, avertissements, informations). Contrairement au log d'audit, il ne trace pas les intentions métier mais la santé technique du système.

---

## Key Attributes

| Attribute | Description | Required |
|-----------|-------------|----------|
| Identifiant Unique | Clé primaire technique du log | Yes |
| Niveau de Log | Sévérité (ex: Info, Warning, Error, Fatal) | Yes |
| Message | Description textuelle de l'événement | Yes |
| Exception | Détails de l'exception technique (Stacktrace) | No |
| Horodatage | Date et heure de l'événement | Yes |

---

## Value Objects

*Aucun objet de valeur spécifique identifié.*

---

## Relationships

| Related entity | Relationship type | Description |
|----------------|-------------------|-------------|
| (Néant) | | Les logs système sont généralement transverses. |

---

## Lifecycle

- **States**: Créé $\rightarrow$ Supprimé
- **Created by**: Framework de logging (Serilog).
- **Deleted / archived by**: Rotation des fichiers de logs ou purge automatique.

---

## Invariants

- Un log système doit toujours posséder un niveau de sévérité. (→ see [rules.md](rules.md))

---

## Open Questions

- <OQ-29>: Les logs système sont-ils stockés en base de données ou uniquement dans des fichiers ? ❓

---

## Links

→ [Rules for this entity](rules.md)
→ [Logic for this entity](logic.md)
→ [Aggregates](../../aggregates.md)
→ [Global Rules](../../rules.md)
→ [Events](../../events.md)
→ [Index](../../index.md)