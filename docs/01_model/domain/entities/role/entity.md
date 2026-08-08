# Entity: Rôle

> Part of: [Domain Index](../index.md)
> Vocabulary: [Ubiquitous Language](../ubiquitous-language.md)

---

## Description

Le Rôle définit un ensemble de permissions ou un niveau d'accès au sein du système. Il permet de regrouper des utilisateurs ayant des responsabilités similaires.

---

## Key Attributes

| Attribute | Description | Required |
|-----------|-------------|----------|
| Identifiant Unique | Clé primaire technique du rôle | Yes |
| Nom du Rôle | Nom unique du rôle (ex: "Admin", "User") | Yes |
| Normalisé Nom | Nom du rôle en minuscule pour comparaison | Yes |

---

## Value Objects

*Aucun objet de valeur spécifique identifié.*

---

## Relationships

| Related entity | Relationship type | Description |
|----------------|-------------------|-------------|
| [Utilisateur](../../utilisateur/entity.md) | has many | Un rôle peut être assigné à plusieurs utilisateurs. |

---

## Lifecycle

- **States**: Actif $\rightarrow$ Supprimé
- **Created by**: Administrateur via l'interface d'administration.
- **Deleted / archived by**: Administrateur.

---

## Invariants

- Le nom du rôle doit être unique. (→ see [rules.md](rules.md))

---

## Open Questions

- <OQ-05>: Existe-t-il une hiérarchie de rôles (rôles parents/enfants) ? ❓

---

## Links

→ [Rules for this entity](rules.md)
→ [Logic for this entity](logic.md)
→ [Aggregates](../../aggregates.md)
→ [Global Rules](../../rules.md)
→ [Events](../../events.md)
→ [Index](../../index.md)