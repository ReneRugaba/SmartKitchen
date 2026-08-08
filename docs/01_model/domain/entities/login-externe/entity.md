# Entity: Login Externe

> Part of: [Domain Index](../index.md)
> Vocabulary: [Ubiquitous Language](../ubiquitous-language.md)

---

## Description

Le Login Externe représente le lien entre un compte utilisateur local et un compte d'identité externe (ex: Google, Microsoft, GitHub). Il permet l'authentification via des fournisseurs tiers (Federated Identity).

---

## Key Attributes

| Attribute | Description | Required |
|-----------|-------------|----------|
| Identifiant Unique | Clé primaire technique du lien | Yes |
| Fournisseur | Nom du fournisseur d'identité (ex: "google") | Yes |
| Login Externe | Identifiant unique chez le fournisseur (Subject ID) | Yes |

---

## Value Objects

*Aucun objet de valeur spécifique identifié.*

---

## Relationships

| Related entity | Relationship type | Description |
|----------------|-------------------|-------------|
| [Utilisateur](../../utilisateur/entity.md) | belongs to | Un login externe est lié à un utilisateur unique. |

---

## Lifecycle

- **States**: Actif $\rightarrow$ Supprimé
- **Created by**: Processus de connexion via un fournisseur externe.
- **Deleted / archived by**: Utilisateur ou Administrateur.

---

## Invariants

- Le couple (Fournisseur, Login Externe) doit être unique au sein du système. (→ see [rules.md](rules.md))

---

## Open Questions

- <OQ-14>: Le système supporte-t-il le changement de fournisseur pour un même compte ? ❓

---

## Links

→ [Rules for this entity](rules.md)
→ [Logic for this entity](logic.md)
→ [Aggregates](../../aggregates.md)
→ [Global Rules](../../rules.md)
→ [Events](../../events.md)
→ [Index](../../index.md)