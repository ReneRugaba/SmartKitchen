<!--
OUTPUT FILE: docs/01_model/domain/aggregates.md
INSTRUCTIONS:
- An aggregate is a consistency boundary: changes inside it are atomic
- The root entity is the only entry point to the aggregate
- List only the invariants enforced at the aggregate level — not entity-level invariants
- Reference entity files by relative path
-->

# Aggregates: <System Name>

> Part of: [Domain Index](index.md)

---

## <Aggregate Name>

- Root entity: [\<Entity\>](entities/\<entity\>.md)
- Included entities:
  - [\<Entity\>](entities/\<entity\>.md)
- Included value objects:
  - \<Value Object\>
- Invariants enforced at boundary:
  - \<Invariant\>: (→ [rules.md](rules.md))

(Repeat for each aggregate)

---

## Open Questions

- \<OQ-01\>:

---

## Links

→ [Rules](rules.md)
→ [Index](index.md)
