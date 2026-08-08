# Entity: Utilisateur

> Part of: [Domain Index](../index.md)
> Vocabulary: [Ubiquitous Language](../ubiquitous-language.md)

---

## Description

L'Utilisateur représente une personne physique possédant un compte d'identité au sein du système SmartKitchenIdp. C'est l'entité centrale qui est authentifiée par le STS pour obtenir des jetons d'accès.

---

## Key Attributes

| Attribute | Description | Required |
|-----------|-------------|----------|
| Identifiant Unique | Clé primaire technique de l'utilisateur | Yes |
| Nom d'utilisateur | Identifiant unique utilisé pour la connexion | Yes |
| Email | Adresse électronique de contact et de récupération | Yes |
| Mot de passe | Hachage sécurisé du mot de passe | Yes (si pas de Passkey seul) |
| Numéro de téléphone | Numéro de téléphone pour le MFA / récupération | No |
| Email Confirmé | Indicateur précisant si l'email a été validé | Yes |
| Téléphone Confirmé | Indicateur précisant si le téléphone a été validé | Yes |

---

## Value Objects

*Aucun objet de valeur spécifique identifié pour cette entité.*

---

## Relationships

| Related entity | Relationship type | Description |
|----------------|-------------------|-------------|
| [Rôle](./role/entity.md) | has many | Un utilisateur peut appartenir à un ou plusieurs rôles. |
| [Claim](./claim/entity.md) | has many | Un utilisateur possède des attributs de sécurité spécifiques. |
| [Passkey](./passkey/entity.md) | has many | Un utilisateur peut enregistrer plusieurs clés de sécurité. |
| [Login Externe](./login-externe/entity.md) | has many | Un utilisateur peut être lié à plusieurs comptes externes. |

---

## Lifecycle

- **States**: Actif $\rightarrow$ Bloqué $\rightarrow$ Supprimé ❓
- **Created by**: Processus d'inscription ou création par un Administrateur.
- **Deleted / archived by**: Demande de l'utilisateur ou action d'un Administrateur.

---

## Invariants

- L'email et le nom d'utilisateur doivent être uniques au sein du système. (→ see [rules.md](rules.md))

---

## Open Questions

- <OQ-02>: Existe-t-il des états de compte spécifiques (ex: "En attente de validation") non standards dans IdentityUser ? ❓

---

## Links

→ [Rules for this entity](rules.md)
→ [Logic for this entity](logic.md)
→ [Aggregates](../../aggregates.md)
→ [Global Rules](../../rules.md)
→ [Events](../../events.md)
→ [Index](../../index.md)