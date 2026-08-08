<!--
OUTPUT FILE: docs/01_model/domain/index.md
GENERATE:   last — after all other domain files are produced
INSTRUCTIONS:
- List every file AND folder produced in docs/01_model/domain/
- Each entity folder must appear with its three files (entity.md, rules.md, logic.md)
- Include a one-line description and a relative link for each entry
- Reflect the actual files generated — do not list files that were not produced
-->

# Domain Model: <System Name>

## Status
Draft | Review | Approved

---

## Overview

One-paragraph summary of the business domain.

---

## Files

| File | Description |
|------|-------------|
| [ubiquitous-language.md](ubiquitous-language.md) | Shared vocabulary — read this first |
| [aggregates.md](aggregates.md) | Consistency boundaries across entities |
| [rules.md](rules.md) | Cross-entity invariants and constraints |
| [logic.md](logic.md) | Cross-entity workflows and use case flows |
| [events.md](events.md) | Domain events |

---

## Entities

| Folder | entity.md | rules.md | logic.md |
|--------|-----------|----------|----------|
| [entities/\<entity-name\>/](entities/\<entity-name\>/) | [entity.md](entities/\<entity-name\>/entity.md) | [rules.md](entities/\<entity-name\>/rules.md) | [logic.md](entities/\<entity-name\>/logic.md) |

---

## Traceability

- Derived from:
  → docs/00_brainstorm/context.md

- Feeds:
  → docs/01_model/architecture/
  → docs/02_analyse/
  → docs/03_decide/adr/
  → backlog/
  → src/
