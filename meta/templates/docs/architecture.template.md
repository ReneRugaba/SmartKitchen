<!--
PURPOSE:
  This is the MANIFEST for the architecture templates.
  It does not contain content — it dispatches to focused sub-templates.

  One template file = one output file.
  To update a section, edit only the relevant sub-template.

OUTPUT STRUCTURE:
  docs/01_model/architecture/
  ├── index.md                          ← architecture/index.template.md
  ├── context.md                        ← architecture/context.template.md         (C4 Level 1)
  ├── containers.md                     ← architecture/containers.template.md      (C4 Level 2 — overview)
  ├── containers/
  │   ├── <container-name>/
  │   │   ├── component.md              ← architecture/container-component.template.md  (C4 Level 3)
  │   │   └── code.md                   ← architecture/container-code.template.md       (C4 Level 4, optional)
  │   └── ...                           ← one folder per container
  └── cross-cutting.md                  ← architecture/cross-cutting.template.md

  CONTAINER FOLDER vs GLOBAL FILES:
    containers/<name>/component.md  → components internal to that container (Level 3)
    containers/<name>/code.md       → code-level detail for a module in that container (Level 4, optional)
    containers.md                   → overview of ALL containers and their interactions (Level 2)

GENERATION ORDER:
  1. context.md                   (Level 1 — must exist before any other level)
  2. containers.md                (Level 2 — identifies all containers; drives folder creation)
  3. containers/<name>/component.md  (Level 3 — one folder per container identified in containers.md)
  4. containers/<name>/code.md       (Level 4 — only for complex or high-risk modules)
  5. cross-cutting.md             (after containers are defined — references ASRs and constraints)
  6. index.md                     (generated last — lists all produced files and folders)

GLOBAL INSTRUCTIONS (apply to all sub-templates):
  - Follow the C4 model: each level must refine the previous one
  - Use only information derived from context.md, domain model, and ASRs
  - Do not invent actors, systems, or technology choices
  - Mark every unknown or unverified element with ❓ and add it to Open Questions
  - Generate a Mermaid diagram for every level (C4Context, C4Container, C4Component)
  - Remove placeholder examples before delivering — they are guidance only
-->

# Architecture Templates — Manifest

See `meta/templates/docs/architecture/` for individual sub-templates.
