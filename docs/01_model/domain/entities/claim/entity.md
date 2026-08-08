# Entity: Claim

> Part of: [Domain Index](../index.md)
> Vocabulary: [Ubiquitous Language](../ubiquitous-language.md)

---

## Description

Le Claim est un attribut de sécurité associé à un utilisateur. Il représente une information spécifique (ex: date de naissance, pays, niveau d'accréditation) utilisée pour l'autorisation.

---

## Key Attributes

| Attribute | Description | Required |
|-----------|-------------|----------|
| Identifiant Unique | Clé primaire technique du claim | Yes |
| Type de Claim | Le nom du type de claim (ex: "birthdate") | Yes |
| Valeur | La valeur associée au claim | Yes |

---

## Value Objects

*Aucun objet de valeur spécifique identifié.*

---

## Relationships

| Related entity | Relationship type | Description |
|----------------|-------------------|-------------|
| [Utilisateur](../../utilisateur/entity.md) | belongs to | Un claim est toujours lié à un utilisateur unique. |

---

## Lifecycle

- **States**: Actif $\rightarrow$ Supprimé
- **Created by**: Administrateur ou processus automatique lors de l'inscription.
- **Deleted / archived by**: Administrateur ou utilisateur (si autorisé).

---

## Invariants

- Un claim doit toujours être associé à un utilisateur. (→ see [rules.md](rules.md))

---

## Open Questions

- <OQ-08>: Les claims peuvent-ils être partagés entre plusieurs utilisateurs ? ❓

---

## Links

→ [Rules for this entity](rules.md)
→ [Logic for this entity](logic.md)
→ [Aggregates](../../aggregates.md)
→ [Global Rules](../../rules.md)
→ [Events](../../events.md)
→ [Index](../../index.md)