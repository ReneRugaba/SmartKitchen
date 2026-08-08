<!--
OUTPUT FILE: docs/01_model/domain/entities/<entity-name>/logic.md
RELATED:    entities/<entity-name>/entity.md   ← entity definition
            entities/<entity-name>/rules.md    ← rules applied in this logic
INSTRUCTIONS:
- Logic is PROCEDURAL and DYNAMIC: how things work for THIS entity
- Scope: only workflows and state machines scoped to this entity
- Cross-entity workflows belong in the root logic.md, not here
- Do NOT restate rules — reference rules.md instead
- State machine must be exhaustive: list all invalid transitions explicitly
-->

# Logic: <Entity Name>

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity workflows, see [Global Logic](../../logic.md).

---

## State Machine

- States: \<state A\> → \<state B\> → \<state C\>
- Transitions:

  | From | To | Trigger | Condition (→ rules.md) |
  |------|----|---------|------------------------|
  | \<state A\> | \<state B\> | | |

- Invalid transitions:
  - \<state X\> → \<state Y\>: \<why forbidden\>

---

## Use Cases

### Use Case: \<Name\>

- Actor:
- Preconditions:
- Steps:
  1.
- Rules applied: (→ [rules.md](rules.md))
- Events emitted: (→ [events.md](../../events.md))
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
- Events emitted: (→ [events.md](../../events.md))

---

## Open Questions

- \<OQ-01\>:

---

## Links

→ [Entity](entity.md)
→ [Rules](rules.md)
→ [Global Logic](../../logic.md)
→ [Events](../../events.md)
→ [Index](../../index.md)
