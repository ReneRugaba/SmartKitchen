<!--
OUTPUT FILE: docs/02_analyse/edge-cases.md
INSTRUCTIONS:
- An edge case is a non-obvious or boundary situation the system must handle correctly
- Derive edge cases from the domain model (entities, state machines, business rules) and architecture
- Each edge case must describe the input condition, the expected behavior, and the risk if unhandled
- Group by domain entity or system boundary
- Mark edge cases with no defined behavior with ❓ — they require a decision
-->

# Edge Cases: <System Name>

> Part of: [Analysis](.)
> Non-obvious situations the system must explicitly handle.

---

## \<Entity or Area\>

| ID | Situation | Expected behavior | Risk if unhandled | Linked to |
|----|-----------|-------------------|-------------------|-----------|
| EC-01 | | | | |
| EC-02 | | | | ❓ |

(Repeat section per entity or area)

---

## Open Questions

Edge cases with no defined expected behavior.

- \<OQ-01\>: \<situation that needs a decision\>

---

## Links

→ [Domain](../01_model/domain/index.md)
→ [Architecture](../01_model/architecture/index.md)
→ [Risks](risks.md)
→ [ADRs](../03_decide/adr/)
