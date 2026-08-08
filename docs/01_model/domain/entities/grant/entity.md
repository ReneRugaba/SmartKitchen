# Entity: Grant

> Part of: [Domain Index](../index.md)
> Vocabulary: [Ubiquitous Language](../ubiquitous-language.md)

---

## Description

Le Grant (ou Octroi) représente la persistance d'une autorisation accordée. Il s'agit principalement des Refresh Tokens et des Authorization Codes qui permettent d'obtenir de nouveaux jetons d'accès sans ré-authentification complète de l'utilisateur.

---

## Key Attributes

| Attribute | Description | Required |
|-----------|-------------|----------|
| Identifiant Unique | Clé primaire technique du grant | Yes |
| Type de Grant | Type de jeton persisté (ex: Refresh Token) | Yes |
| Données du Grant | Contenu sérialisé et chiffré du grant | Yes |
| Date d'Expiration | Date à laquelle le grant n'est plus valide | Yes |

---

## Value Objects

*Aucun objet de valeur spécifique identifié.*

---

## Relationships

| Related entity | Relationship type | Description |
|----------------|-------------------|-------------|
| [Utilisateur](../../utilisateur/entity.md) | belongs to | Un grant est lié à un utilisateur unique. |
| [Application Cliente](../application-cliente/entity.md) | belongs to | Un grant est lié à l'application cliente qui l'a demandé. |

---

## Lifecycle

- **States**: Valide $\rightarrow$ Expiré $\rightarrow$ Révoqué
- **Created by**: STS lors de l'émission d'un token.
- **Deleted / archived by**: Expiration automatique ou action de révocation.

---

## Invariants

- Un grant expiré ne doit jamais être utilisé pour émettre un nouveau jeton. (→ see [rules.md](rules.md))

---

## Open Questions

- <OQ-23>: Le système supporte-t-il la rotation des Refresh Tokens (un nouveau token à chaque usage) ? ❓

---

## Links

→ [Rules for this entity](rules.md)
→ [Logic for this entity](logic.md)
→ [Aggregates](../../aggregates.md)
→ [Global Rules](../../rules.md)
→ [Events](../../events.md)
→ [Index](../../index.md)