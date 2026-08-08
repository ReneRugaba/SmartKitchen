# Rules: Scope

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity rules, see [Global Rules](../../rules.md).

---

## Invariants

- <INV-09>: Le nom d'un scope doit être unique.

---

## Validation Rules

| Field | Condition |
|-------|-----------|
| Nom du Scope | Ne doit pas être vide et doit suivre la convention de nommage (ex: lowercase, points). |

---

## Business Rules

- <RULE-11>: Un scope ne peut pas être supprimé s'il est utilisé par au moins un client actif.

---

## Open Questions

- <OQ-21>: Peut-on définir des dépendances entre scopes (un scope A requiert le scope B) ? ❓

---

## Links

→ [Entity](entity.md)
→ [Logic](logic.md)
→ [Global Rules](../../rules.md)
→ [Index](../../index.md)