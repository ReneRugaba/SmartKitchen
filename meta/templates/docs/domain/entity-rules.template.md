<!--
OUTPUT FILE: docs/01_model/domain/entities/<entity-name>/rules.md
RELATED:    entities/<entity-name>/entity.md   ← entity definition
            entities/<entity-name>/logic.md    ← how these rules are applied
INSTRUCTIONS:
- Rules are DECLARATIVE and STATIC: conditions that must always be true
- Scope: only rules that apply to THIS entity or its direct aggregate
- Cross-entity rules belong in the root rules.md, not here
- Do NOT describe how to enforce a rule — that belongs in logic.md
- Each rule must be falsifiable: it can be tested true or false
-->

# Rules: <Entity Name>

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity rules, see [Global Rules](../../rules.md).

---

## Invariants

Conditions that must ALWAYS be true for this entity.

- \<INV-01\>:
- \<INV-02\>:

---

## Validation Rules

Applied when creating or updating this entity.

| Field | Condition |
|-------|-----------|
| \<field\> | |

---

## Business Rules

Domain rules specific to this entity.

- \<RULE-01\>:
- \<RULE-02\>:

---

## Open Questions

- \<OQ-01\>:

---

## Links

→ [Entity](entity.md)
→ [Logic](logic.md)
→ [Global Rules](../../rules.md)
→ [Index](../../index.md)
