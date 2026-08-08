<!--
OUTPUT FILE: docs/01_model/architecture/containers.md
LEVEL:      C4 Level 2 — Containers overview
RELATED:    containers/<name>/component.md  ← Level 3 for each container listed here
INSTRUCTIONS:
- Identify every deployable unit (container) that composes the system
- Do not describe internal components here — that belongs in containers/<name>/component.md
- Technology choices must be grounded in ASRs or context — mark unknown ones with ❓
- Each container listed here drives the creation of a folder in containers/
- Generate a Mermaid C4Container diagram from the containers and interactions defined here
-->

# Containers: <System Name>

> Part of: [Architecture Index](index.md)
> C4 Level 2 — deployable units that compose the system.
> For internal components, see each container's folder.

## Status
Draft | Review | Approved

---

## Containers

### \<Container Name\>

- Type: (Web App / API / Worker / Database / Message Broker / …)
- Responsibility:
- Technology: ❓
- Exposes:
- Consumes:
- Components detail: [containers/\<container-name\>/component.md](containers/\<container-name\>/component.md)

(Repeat for each container)

---

## Interactions

- \<Container A\> → \<Container B\>: \<protocol\> — \<purpose\>

---

## Diagram

Generate a Mermaid C4Container diagram based on the containers and interactions above.

---

## Risks

- \<RISK-01\>:
  - Likelihood:
  - Impact:
  - Mitigation:

---

## Open Questions

- \<OQ-01\>:

---

## Links

→ [Context](context.md)
→ [Cross-Cutting](cross-cutting.md)
→ [Index](index.md)
