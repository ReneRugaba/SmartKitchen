<!--
OUTPUT FILE: docs/01_model/architecture/containers/<container-name>/component.md
LEVEL:      C4 Level 3 — Components of a specific container
RELATED:    containers/<container-name>/code.md  ← Level 4 (optional, complex modules only)
GENERATE:   one folder per container identified in containers.md
            folder name = kebab-case container name (e.g. backend-api/, worker/)
INSTRUCTIONS:
- Scope: only the internal components of THIS container
- Do not describe other containers here — reference containers.md instead
- Component types: Controller, Service, Repository, Gateway, Handler, Scheduler, …
- Dependencies reference sibling components by name, external containers by relative path
- Mark unknown responsibilities, inputs, or outputs with ❓
- Generate a Mermaid C4Component diagram from the components defined here
-->

# Components: <Container Name>

> Part of: [Containers](../../containers.md) | [Architecture Index](../../index.md)
> C4 Level 3 — internal components of this container.

## Status
Draft | Review | Approved

---

## Description

- What is the responsibility of this container?
- What are its main internal concerns?

---

## Components

### \<Component Name\>

- Type: (Controller / Service / Repository / Gateway / …)
- Responsibility:
- Inputs:
- Outputs:
- Dependencies:
  - \<sibling component\>
  - \<external container\> (→ [containers.md](../../containers.md))

(Repeat for each component)

---

## Interactions

- \<Component A\> → \<Component B\>: \<mechanism\> — \<purpose\>

---

## Diagram

Generate a Mermaid C4Component diagram based on the components and interactions above.

---

## Open Questions

- \<OQ-01\>:

---

## Links

→ [Container overview](../../containers.md)
→ [Code detail (if applicable)](code.md)
→ [Index](../../index.md)
