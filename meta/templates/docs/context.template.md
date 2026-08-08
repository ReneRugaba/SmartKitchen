<!--
OUTPUT FILE: docs/00_brainstorm/context.md
GENERATE:   first — this is the primary input for all downstream artifacts
INSTRUCTIONS:
- This is the LLM's primary source of truth for the project
- Be clear, precise, and structured — do NOT invent missing information
- Mark every unknown or unverified element with ❓
- Constraints, assumptions, and risks captured here are INITIAL — they will be refined in docs/02_analyse/
- Do not make architecture or technology decisions here — those belong in docs/01_model/ and docs/03_decide/
- Scope must be explicit: list what is in scope AND what is out of scope
-->

# Context: <System Name>

## Status
Draft | Review | Approved

---

## Problem

Describe the problem clearly.

- What is the current situation?
- What is not working or missing?
- Who is affected?

---

## Goals

Define measurable objectives.

- What does success look like?
- What must be achieved?

---

## Non-Goals

Clarify what is NOT in scope.

- What will NOT be addressed?
- What is explicitly excluded?

---

## Scope

### In Scope
-

### Out of Scope
-

---

## Stakeholders

| Role | Responsibilities | Decision authority |
|------|-----------------|-------------------|
| \<Stakeholder\> | | Yes / No |

---

## Users

| Actor | Description | Primary need |
|-------|-------------|--------------|
| \<Actor\> | | |

---

## System Environment

Describe the environment the system will operate in.

- External systems and integrations:
- Infrastructure / deployment environment: ❓
- Key dependencies:

---

## High-Level Use Cases

Describe the key interactions — no implementation detail.

- \<Actor\> does \<action\> → system does \<response\>

---

## Initial Constraints

> These will be refined in [docs/02_analyse/constraints.md](../02_analyse/constraints.md).
> Capture obvious hard limits here; do not analyse them yet.

- Technical:
- Business:
- Regulatory: ❓
- Organizational:

---

## Initial Assumptions

> These will be refined in [docs/02_analyse/assumptions.md](../02_analyse/assumptions.md).
> Capture beliefs that may affect design; do not validate them here.

- \<assumption\>: ❓

---

## Initial Risks

> These will be refined in [docs/02_analyse/risks.md](../02_analyse/risks.md).
> Capture obvious risks from brainstorming; do not assess them here.

- \<risk\>:

---

## Unknowns

List what is unclear or missing — these become Open Questions in downstream artifacts.

- \<unknown\>:

---

## Traceability

- Origin:
  → brainstorm input

- Feeds:
  → docs/01_model/domain/index.md
  → docs/01_model/architecture/index.md
  → docs/02_analyse/
  → docs/03_decide/
