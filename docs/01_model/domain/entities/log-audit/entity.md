# Entity: Log d'Audit

> Part of: [Domain Index](../index.md)
> Vocabulary: [Ubiquitous Language](../ubiquitous-language.md)

---

## Description

Le Log d'Audit est un enregistrement immuable d'une action administrative ayant modifié la configuration du système. Il permet de répondre aux exigences de conformité et de traçabilité.

---

## Key Attributes

| Attribute | Description | Required |
|-----------|-------------|----------|
| Identifiant Unique | Clé primaire technique du log | Yes |
| Date de l'Action | Horodatage précis de l'événement | Yes |
| Utilisateur | L'administrateur ayant effectué l'action | Yes |
| Action | Type d'opération (Création, Modification, Suppression) | Yes |
| Entité Cible | Nom de l'entité modifiée (ex: "Client", "User") | Yes |
| Valeurs Antérieures | État de l'entité avant la modification (JSON) | No |
| Valeurs Nouvelles | État de l'entité après la modification (JSON) | No |

---

## Value Objects

*Aucun objet de valeur spécifique identifié.*

---

## Relationships

| Related entity | Relationship type | Description |
|----------------|-------------------|-------------|
| [Utilisateur](../../utilisateur/entity.md) | belongs to | Le log est lié à l'administrateur qui a déclenché l'action. |

---

## Lifecycle

- **States**: Créé $\rightarrow$ Archivé
- **Created by**: Système automatiquement lors d'une modification via l'API Admin.
- **Deleted / archived by**: Processus de purge automatique après X années (rétention légale).

---

## Invariants

- Un log d'audit ne peut jamais être modifié ou supprimé manuellement. (→ see [rules.md](rules.md))

---

## Open Questions

- <OQ-26>: Le système supporte-t-il la signature numérique des logs pour garantir l'intégrité ? ❓

---

## Links

→ [Rules for this entity](rules.md)
→ [Logic for this entity](logic.md)
→ [Aggregates](../../aggregates.md)
→ [Global Rules](../../rules.md)
→ [Events](../../events.md)
→ [Index](../../index.md)