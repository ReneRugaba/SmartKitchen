<!--
OUTPUT FILE: docs/02_analyse/index.md
GENERATE:   after all analysis files are produced
INSTRUCTIONS:
- List every file produced in docs/02_analyse/ with a one-line description and a relative link
- Summarize the key findings: how many open risks, blocking assumptions, unresolved edge cases
- Reflect the actual content generated — do not list files that were not produced
-->

# Analysis: <System Name>

## Status
Draft | Review | Approved

---

## Summary

One-paragraph summary of the analysis findings.

- Open risks:
- Blocking assumptions:
- Unresolved edge cases:
- Pending tradeoff decisions:

---

## Files

| File | Description |
|------|-------------|
| [constraints.md](constraints.md) | Hard limits the solution must respect |
| [assumptions.md](assumptions.md) | Beliefs not yet verified |
| [risks.md](risks.md) | Uncertain events that could impact the project |
| [edge-cases.md](edge-cases.md) | Non-obvious situations the system must handle |
| [tradeoffs.md](tradeoffs.md) | Deliberate design choices and their costs |

---

## Traceability

- Derived from:
  → docs/00_brainstorm/context.md
  → docs/01_model/domain/index.md
  → docs/01_model/architecture/index.md

- Feeds:
  → docs/03_decide/asr/
  → docs/03_decide/adr/
  → backlog/
