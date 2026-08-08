<!--
OUTPUT FILE: docs/01_model/architecture/index.md
GENERATE:   last — after all other architecture files are produced
INSTRUCTIONS:
- List every file and folder produced in docs/01_model/architecture/
- Each container folder must be listed with its component.md (and code.md if generated)
- Include a one-line description and a relative link for each entry
- Reflect the actual files generated, not the template list
-->

# Architecture: <System Name>

## Status
Draft | Review | Approved

---

## Overview

One-paragraph summary of the architecture and the key decisions made.

---

## Files

| File | Description |
|------|-------------|
| [context.md](context.md) | C4 Level 1 — System Context |
| [containers.md](containers.md) | C4 Level 2 — Container overview |
| [containers/\<name\>/component.md](containers/\<name\>/component.md) | C4 Level 3 — Components of \<Container\> |
| [cross-cutting.md](cross-cutting.md) | Security, performance, resilience, deployment |

---

## Traceability

- Derived from:
  → docs/00_brainstorm/context.md
  → docs/01_model/domain/
  → docs/03_decide/asr/

- Feeds:
  → docs/02_analyse/
  → docs/03_decide/adr/
  → backlog/
  → src/
