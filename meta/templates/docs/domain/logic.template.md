<!--
OUTPUT FILE: docs/01_model/domain/logic.md
SCOPE:      CROSS-ENTITY only — workflows that span multiple entities or aggregates
            Entity-specific workflows belong in entities/<name>/logic.md, not here
INSTRUCTIONS:
- Logic is PROCEDURAL and DYNAMIC: how things work across entity boundaries
- Do NOT add workflows scoped to a single entity — put them in the entity folder
- Do NOT restate rules — reference rules.md or entities/<name>/rules.md instead
- Document use cases, workflows, and cross-aggregate sagas only
-->

# Global Logic: <System Name>

> Part of: [Domain Index](index.md)
> Scope: cross-entity workflows and use cases only.
> Entity-specific workflows live in `entities/<name>/logic.md`.
> Logic is procedural — it describes behavior, not conditions.
> For conditions and invariants, see [rules.md](rules.md).

---

## Cross-Entity Use Cases

Use cases that involve more than one entity or aggregate.

### Use Case: \<Name\>

- Actor:
- Preconditions:
- Steps:
  1.
- Rules applied: (→ [rules.md](rules.md#\<rule-id\>))
- Events emitted: (→ [events.md](events.md#\<event-name\>))
- Postconditions:
- Edge cases:
  - \<case\>: \<expected behavior\>

(Repeat for each use case)

---

## Workflows

### Workflow: \<Name\>

- Trigger:
- Steps:
  1.
- Rules applied: (→ [rules.md](rules.md))
- Events emitted: (→ [events.md](events.md))

---

## State Machines

### \<Entity Name\> — States

- States: \<state A\> → \<state B\> → \<state C\>
- Transitions:
  | From | To | Trigger | Condition |
  |------|----|---------|-----------|
  | \<state A\> | \<state B\> | | |
- Invalid transitions:
  - \<state X\> → \<state Y\>: \<why it is forbidden\>

---

## Edge Cases

- \<case\>:
  - Why it matters:
  - Expected behavior:

---

## Open Questions

- \<OQ-01\>:

---

## Links

→ [Rules](rules.md)
→ [Events](events.md)
→ [Index](index.md)
