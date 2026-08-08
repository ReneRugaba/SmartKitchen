# Entity: Scope

> Part of: [Domain Index](../index.md)
> Vocabulary: [Ubiquitous Language](../ubiquitous-language.md)

---

## Description

Le Scope (ou Portée) définit une ressource ou une fonctionnalité spécifique du système que l'utilisateur peut autoriser une application cliente à utiliser. Il sert de base à la définition des permissions dans le jeton d'accès.

---

## Key Attributes

| Attribute | Description | Required |
|-----------|-------------|----------|
| Identifiant Unique | Clé primaire technique du scope | Yes |
| Nom du Scope | Identifiant unique du scope (ex: "openid", "profile", "api.read") | Yes |
| Description | Explication textuelle de ce que le scope permet de faire | No |

---

## Value Objects

*Aucun objet de valeur spécifique identifié.*

---

## Relationships

| Related entity | Relationship type | Description |
|----------------|-------------------|-------------|
| [Application Cliente](../application-cliente/entity.md) | has many | Plusieurs clients peuvent être autorisés à demander ce scope. |

---

## Lifecycle

- **States**: Actif $\rightarrow$ Supprimé
- **Created by**: Administrateur.
- **Deleted / archived by**: Administrateur.

---

## Invariants

- Le nom du scope doit être unique. (→ see [rules.md](rules.md))

---

## Open Questions

- <OQ-20>: Existe-t-il des scopes "système" non modifiables ? ❓

---

## Links

→ [Rules for this entity](rules.md)
→ [Logic for this entity](logic.md)
→ [Aggregates](../../aggregates.md)
→ [Global Rules](../../rules.md)
→ [Events](../../events.md)
→ [Index](../../index.md)