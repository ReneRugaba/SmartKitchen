# Rules: Utilisateur

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity rules, see [Global Rules](../../rules.md).

---

## Invariants

Conditions that must ALWAYS be true for this entity.

- <INV-01>: L'adresse email doit être unique au sein de l'ensemble des utilisateurs.
- <INV-02>: Le nom d'utilisateur doit être unique au sein de l'ensemble des utilisateurs.
- <INV-03>: Un utilisateur ne peut pas avoir un mot de passe en clair stocké en base de données (doit être haché).

---

## Validation Rules

Applied when creating or updating this entity.

| Field | Condition |
|-------|-----------|
| Email | Doit correspondre à un format d'email valide. |
| Nom d'utilisateur | Ne doit pas contenir de caractères interdits (selon la politique Identity). |
| Mot de passe | Doit respecter la politique de complexité définie (longueur, caractères spéciaux, etc.). |
| Numéro de téléphone | Doit correspondre à un format international valide (si renseigné). |

---

## Business Rules

Domain rules specific to this entity.

- <RULE-01>: Un utilisateur ne peut pas s'authentifier si son compte est marqué comme "Bloqué".
- <RULE-02>: L'accès aux fonctionnalités administratives requiert l'appartenance à un Rôle spécifique.
- <RULE-03>: L'utilisation d'un Passkey remplace la nécessité d'un mot de passe pour l'authentification.

---

## Open Questions

- <OQ-03>: Existe-t-il une règle de verrouillage automatique du compte après X tentatives de connexion infructueuses ? ❓

---

## Links

→ [Entity](entity.md)
→ [Logic](logic.md)
→ [Global Rules](../../rules.md)
→ [Index](../../index.md)