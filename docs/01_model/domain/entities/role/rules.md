# Rules: Rôle

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity rules, see [Global Rules](../../rules.md).

---

## Invariants

- <INV-04>: Le nom d'un rôle doit être unique au sein du système.

---

## Validation Rules

| Field | Condition |
|-------|-----------|
| Nom du Rôle | Ne doit pas être vide et doit respecter un format alphanumérique. |

---

## Business Rules

- <RULE-04>: Un rôle ne peut pas être supprimé s'il est assigné à au moins un utilisateur (ou nécessite une réassignation).

---

## Open Questions

- <OQ-06>: Le système supporte-t-il des rôles prédéfinis non modifiables ? ❓

---

## Links

→ [Entity](entity.md)
→ [Logic](logic.md)
→ [Global Rules](../../rules.md)
→ [Index](../../index.md)