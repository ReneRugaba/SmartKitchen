<!--
OUTPUT FILE: docs/01_model/architecture/context.md
LEVEL:      C4 Level 1 — System Context
GENERATE:   first — all other architecture files depend on this
INSTRUCTIONS:
- Describe the system and its environment, not its internals
- List every human actor and every external system — do not invent any
- Mark unknown protocols, directions, or data exchanged with ❓
- Generate a Mermaid C4Context diagram from the actors and external systems defined here
-->

# Context: <System Name>

> Part of: [Architecture Index](index.md)
> C4 Level 1 — describes the system in its environment.

## Status
Draft | Review | Approved

---

## Description

Summarize the system in a few sentences.

- What is the system and what problem does it solve?
- Who are its users?
- Deployment environment: (cloud / on-prem / hybrid) ❓

---

## Actors

List every human actor that interacts directly with the system.

- \<Actor\>:
  - Role:
  - How they interact:

---

## External Systems

List every external system the system communicates with.

- \<System\>:
  - Purpose of the interaction:
  - Protocol / integration type: ❓
  - Direction: inbound / outbound / both

---

## Diagram

Generate a Mermaid C4Context diagram based on the actors and external systems above.

---

## Constraints

- \<CON-01\>:

---

## Assumptions

- \<ASM-01\>:
  - Consequence if wrong:

---

## Open Questions

- \<OQ-01\>:

---

## Links

→ [Containers](containers.md)
→ [Cross-Cutting](cross-cutting.md)
→ [Index](index.md)
