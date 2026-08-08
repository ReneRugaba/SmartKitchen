<!--
OUTPUT FILE: docs/01_model/domain/rules.md
SCOPE:      CROSS-ENTITY only — rules that span multiple entities or aggregates
            Entity-specific rules belong in entities/<name>/rules.md, not here
INSTRUCTIONS:
- Rules are DECLARATIVE and STATIC: what must always be true
- Do NOT add rules that apply to a single entity — put them in the entity folder
- Do NOT describe how to enforce rules — that belongs in logic.md
- Do NOT describe workflows or state transitions — that belongs in logic.md
- Each rule must be falsifiable: it can be tested true or false
-->

# Global Rules: <System Name>

> Part of: [Domain Index](index.md)
> Scope: cross-entity invariants and constraints only.
> Entity-specific rules live in `entities/<name>/rules.md`.
> Rules are declarative — they state conditions, not procedures.
> For enforcement and workflows, see [logic.md](logic.md).

---

## Invariants

Conditions that must ALWAYS be true across the entire domain.

- \<INV-01\>:
- \<INV-02\>:

---

## Cross-Entity Rules

Rules that involve more than one entity or aggregate.

- \<RULE-01\>: \<condition spanning \<Entity A\> and \<Entity B\>\>
- \<RULE-02\>:

---

## Constraints

- Regulatory:
  - \<constraint\>:
- Business:
  - \<constraint\>:

---

## Open Questions

- \<OQ-01\>:

---

## Links

→ [Aggregates](aggregates.md)
→ [Logic](logic.md)
→ [Index](index.md)
