<!--
OUTPUT FILE: docs/BMAD-TRACEABILITY-MATRIX.md
GENERATE:   after all other documents are produced — this is a living summary
INSTRUCTIONS:
- This matrix maps every artifact in the project to its sources and its downstream consumers
- Do not invent links — only record relationships that are explicitly stated in the referenced files
- Mark missing or unverified links with ❓
- Update this file whenever a new artifact is added or a relationship changes
- The matrix must be readable as a standalone document: a new team member should understand the project flow from it

ARTIFACT TYPES:
  Context     → docs/00_brainstorm/context.md
  Domain      → docs/01_model/domain/
  Architecture → docs/01_model/architecture/
  Analysis    → docs/02_analyse/ (assumptions, constraints, risks, edge-cases, tradeoffs)
  ASR         → docs/03_decide/asr/
  ADR         → docs/03_decide/adr/
  Backlog     → backlog/
  Source      → src/
-->

# BMAD Traceability Matrix: <System Name>

## Status
Draft | Review | Approved

---

## Project Flow

```
Context → Domain → Architecture → Analysis → Decisions (ASR/ADR) → Backlog → Source
```

Each arrow means: the downstream artifact is derived from, or constrained by, the upstream one.

---

## Artifact Registry

List every significant artifact in the project.

| ID | Type | File | Description | Status |
|----|------|------|-------------|--------|
| CTX-01 | Context | [context.md](00_brainstorm/context.md) | | Draft |
| DOM-01 | Domain | [domain/index.md](01_model/domain/index.md) | | Draft |
| DOM-XX | Entity | [domain/entities/\<name\>/entity.md](01_model/domain/entities/) | one row per entity | Draft |
| ARC-01 | Architecture | [architecture/index.md](01_model/architecture/index.md) | | Draft |
| ARC-XX | Container | [architecture/containers/\<name\>/component.md](01_model/architecture/containers/) | one row per container | Draft |
| ANA-01 | Analysis | [02_analyse/index.md](02_analyse/index.md) | | Draft |
| ASM-01 | Assumption | [assumptions.md](02_analyse/assumptions.md) | | Open |
| CON-01 | Constraint | [constraints.md](02_analyse/constraints.md) | | |
| RSK-01 | Risk | [risks.md](02_analyse/risks.md) | | Open |
| EC-01 | Edge Case | [edge-cases.md](02_analyse/edge-cases.md) | | Open |
| TRD-01 | Tradeoff | [tradeoffs.md](02_analyse/tradeoffs.md) | | |
| ASR-01 | ASR | [asr/\<title\>.md](03_decide/asr/) | | Draft |
| ADR-01 | ADR | [adr/\<title\>.md](03_decide/adr/) | | Draft |

---

## Forward Traceability

*From requirement / decision → to implementation.*
Shows that every decision has a downstream artifact.

| Source | Source ID | Implemented in | Notes |
|--------|-----------|----------------|-------|
| Context | CTX-01 | DOM-01, ARC-01, ANA-01 | |
| Domain | DOM-01 | ARC-01, EC-01 | |
| Entity | DOM-XX | ARC-XX (container), EC-01 | |
| Architecture | ARC-01 | TRD-01, ASR-01 | |
| Constraint | CON-01 | ARC-01, ADR-01 | |
| Assumption | ASM-01 | RSK-01 | |
| Risk | RSK-01 | ADR-01, TRD-01 | ❓ |
| Edge Case | EC-01 | ADR-01 | ❓ |
| ASR | ASR-01 | ADR-01, ARC-01 | |
| ADR | ADR-01 | backlog/, src/ | ❓ |

---

## Backward Traceability

*From implementation → to its justification.*
Shows that every architecture choice and backlog item can be traced to a decision or requirement.

| Artifact | Artifact ID | Justified by | Notes |
|----------|-------------|--------------|-------|
| Domain | DOM-01 | CTX-01 | |
| Entity | DOM-XX | CTX-01, DOM-01 | |
| Architecture | ARC-01 | CTX-01, DOM-01, ASR-01 | |
| Container | ARC-XX | ARC-01, ASR-01 | |
| Analysis | ANA-01 | CTX-01, DOM-01, ARC-01 | |
| Risk | RSK-01 | ASM-01, CON-01 | |
| Tradeoff | TRD-01 | RSK-01, CON-01, ADR-01 | |
| ADR | ADR-01 | ASR-01, RSK-01, EC-01 | |
| Backlog item | \<item\> | ADR-01 | ❓ |

---

## Coverage Gaps

List any artifact that has no upstream justification or no downstream implementation.

- \<Artifact ID\>: \<why it is a gap\>

---

## Open Questions

- \<OQ-01\>:

---

## Links

→ [Context](00_brainstorm/context.md)
→ [Domain](01_model/domain/index.md)
→ [Architecture](01_model/architecture/index.md)
→ [Analysis](02_analyse/index.md)
→ [ASRs](03_decide/asr/)
→ [ADRs](03_decide/adr/)
