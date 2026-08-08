# Rules: Log d'Audit

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity rules, see [Global Rules](../../rules.md).

---

## Invariants

- <INV-11>: L'immuabilité absolue : aucun enregistrement de log d'audit ne peut être mis à jour ou supprimé.

---

## Validation Rules

| Field | Condition |
|-------|-----------|
| Date de l'Action | Doit être l'horodatage UTC actuel. |
| Utilisateur | Doit être un utilisateur authentifié avec des droits d'administration. |

---

## Business Rules

- <RULE-14>: Chaque modification de configuration critique doit obligatoirement générer un log d'audit.

---

## Open Questions

- <OQ-27>: Existe-t-il des actions administratives exclues de l'audit pour des raisons de performance ? ❓

---

## Links

→ [Entity](entity.md)
→ [Logic](logic.md)
→ [Global Rules](../../rules.md)
→ [Index](../../index.md)