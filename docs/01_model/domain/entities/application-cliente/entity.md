# Entity: Application Cliente

> Part of: [Domain Index](../index.md)
> Vocabulary: [Ubiquitous Language](../ubiquitous-language.md)

---

## Description

L'Application Cliente est une entité logicielle enregistrée auprès du STS. Elle est autorisée à demander des jetons d'accès pour agir au nom d'un utilisateur ou pour son propre compte, selon le flux d'authentification utilisé.

---

## Key Attributes

| Attribute | Description | Required |
|-----------|-------------|----------|
| Identifiant Unique | Clé primaire technique du client | Yes |
| Client ID | Identifiant public utilisé dans les requêtes OIDC/OAuth2 | Yes |
| Nom de l'Application | Nom lisible pour l'utilisateur lors du consentement | Yes |
| Secret du Client | Clé secrète pour l'authentification du client (si confidentiel) | No |
| URIs de Redirection | Liste des URLs autorisées pour le retour du token | Yes |
| Type de Client | Public (ex: SPA) ou Confidentiel (ex: API Server) | Yes |

---

## Value Objects

*Aucun objet de valeur spécifique identifié.*

---

## Relationships

| Related entity | Relationship type | Description |
|----------------|-------------------|-------------|
| [Scope](./scope/entity.md) | has many | Un client est autorisé à demander certains scopes. |

---

## Lifecycle

- **States**: Actif $\rightarrow$ Désactivé $\rightarrow$ Supprimé
- **Created by**: Administrateur via l'interface d'administration.
- **Deleted / archived by**: Administrateur.

---

## Invariants

- Le Client ID doit être unique au sein du système. (→ see [rules.md](rules.md))

---

## Open Questions

- <OQ-17>: Le système supporte-t-il la rotation automatique des secrets de client ? ❓

---

## Links

→ [Rules for this entity](rules.md)
→ [Logic for this entity](logic.md)
→ [Aggregates](../../aggregates.md)
→ [Global Rules](../../rules.md)
→ [Events](../../events.md)
→ [Index](../../index.md)