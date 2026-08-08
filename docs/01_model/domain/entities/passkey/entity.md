# Entity: Passkey

> Part of: [Domain Index](../index.md)
> Vocabulary: [Ubiquitous Language](../ubiquitous-language.md)

---

## Description

La Passkey est une clé cryptographique sécurisée (WebAuthn) permettant l'authentification forte sans mot de passe. Elle lie l'identité de l'utilisateur à un dispositif physique ou un gestionnaire de clés.

---

## Key Attributes

| Attribute | Description | Required |
|-----------|-------------|----------|
| Identifiant Unique | Clé primaire technique de la passkey | Yes |
| Clé Publique | La clé publique utilisée pour vérifier la signature | Yes |
| Identifiant de la Clé | ID unique généré par le dispositif (Credential ID) | Yes |
| Date de Création | Date d'enregistrement de la clé | Yes |

---

## Value Objects

*Aucun objet de valeur spécifique identifié.*

---

## Relationships

| Related entity | Relationship type | Description |
|----------------|-------------------|-------------|
| [Utilisateur](../../utilisateur/entity.md) | belongs to | Une passkey appartient à un utilisateur unique. |

---

## Lifecycle

- **States**: Enregistrée $\rightarrow$ Révoquée
- **Created by**: Utilisateur via le processus d'enregistrement WebAuthn.
- **Deleted / archived by**: Utilisateur ou Administrateur.

---

## Invariants

- Une passkey doit être liée à un utilisateur valide. (→ see [rules.md](rules.md))

---

## Open Questions

- <OQ-11>: Le système supporte-t-il la rotation des passkeys ? ❓

---

## Links

→ [Rules for this entity](rules.md)
→ [Logic for this entity](logic.md)
→ [Aggregates](../../aggregates.md)
→ [Global Rules](../../rules.md)
→ [Events](../../events.md)
→ [Index](../../index.md)