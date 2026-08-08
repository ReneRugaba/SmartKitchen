<!--
PURPOSE:
  This is the MANIFEST for the analysis templates.
  It does not contain content — it dispatches to focused sub-templates.

  One template file = one output file.
  To update a section, edit only the relevant sub-template.

OUTPUT STRUCTURE:
  docs/02_analyse/
  ├── index.md          ← analysis/index.template.md
  ├── assumptions.md    ← analysis/assumptions.template.md
  ├── constraints.md    ← analysis/constraints.template.md
  ├── risks.md          ← analysis/risks.template.md
  ├── edge-cases.md     ← analysis/edge-cases.template.md
  └── tradeoffs.md      ← analysis/tradeoffs.template.md

FILE RESPONSIBILITIES:
  assumptions.md  → things believed to be true but not yet verified
  constraints.md  → hard limits the solution must respect (non-negotiable)
  risks.md        → uncertain events that could negatively impact the project
  edge-cases.md   → non-obvious or boundary situations the system must handle
  tradeoffs.md    → explicit design choices where one quality is sacrificed for another

GENERATION ORDER:
  1. constraints.md    (hard limits — referenced by all other files)
  2. assumptions.md    (beliefs that may affect decisions)
  3. risks.md          (derives from assumptions and constraints)
  4. edge-cases.md     (derives from domain model and architecture)
  5. tradeoffs.md      (derives from risks, constraints, and ADRs)
  6. index.md          (generated last — summarizes findings and links all files)

GLOBAL INSTRUCTIONS (apply to all sub-templates):
  - Derive every entry from context.md, domain model, or architecture — do not invent
  - Mark every unverified element with ❓
  - Each entry must have a unique ID (ASM-XX, CON-XX, RSK-XX, EC-XX, TRD-XX)
  - Remove placeholder examples before delivering — they are guidance only
-->

# Analysis Templates — Manifest

See `meta/templates/docs/analysis/` for individual sub-templates.
