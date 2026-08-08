<!--
PURPOSE:
  This is the MANIFEST for the domain model templates.
  It does not contain content — it dispatches to focused sub-templates.

  One template file = one output file.
  To update a section, edit only the relevant sub-template.

OUTPUT STRUCTURE:
  docs/01_model/domain/
  ├── index.md                          ← domain/index.template.md
  ├── ubiquitous-language.md            ← domain/ubiquitous-language.template.md
  ├── aggregates.md                     ← domain/aggregates.template.md
  ├── entities/
  │   ├── <entity-name>/
  │   │   ├── entity.md                 ← domain/entity.template.md        (attributes, lifecycle, relationships)
  │   │   ├── rules.md                  ← domain/entity-rules.template.md  (rules specific to this entity)
  │   │   └── logic.md                  ← domain/entity-logic.template.md  (workflows and state machine for this entity)
  │   └── ...                           ← one folder per entity
  ├── rules.md                          ← domain/rules.template.md         (cross-entity invariants only)
  ├── logic.md                          ← domain/logic.template.md         (cross-entity workflows only)
  └── events.md                         ← domain/events.template.md

RULES vs LOGIC (applies at every level):
  rules.md  → DECLARATIVE: what must always be true (invariants, constraints, validation)
  logic.md  → PROCEDURAL: how things work (workflows, state machines, use case flows)

ENTITY FOLDER vs GLOBAL FILES:
  entities/<name>/rules.md  → rules that apply only to that entity or its aggregate
  entities/<name>/logic.md  → workflows and state machine scoped to that entity
  rules.md (root)           → invariants that span multiple entities or aggregates
  logic.md (root)           → workflows that involve multiple entities or aggregates

GENERATION ORDER:
  1. ubiquitous-language.md             (vocabulary must be defined first)
  2. entities/<name>/entity.md          (one folder per entity — repeat for each)
  3. entities/<name>/rules.md           (per-entity rules — after entity.md)
  4. entities/<name>/logic.md           (per-entity logic — after rules.md)
  5. aggregates.md                      (references entity folders)
  6. rules.md                           (cross-entity only — after all entity folders)
  7. logic.md                           (cross-entity only — after rules.md)
  8. events.md                          (references entities and logic)
  9. index.md                           (generated last — lists all produced files and folders)

GLOBAL INSTRUCTIONS (apply to all sub-templates):
  - Focus on business concepts — no technical implementation details
  - Use the Ubiquitous Language from ubiquitous-language.md consistently
  - Do not invent rules, entities, or events not grounded in the context
  - Mark every unknown with ❓ and add it to Open Questions in that file
  - Remove placeholder examples before delivering — they are guidance only
  - Never mix rules and logic in the same file
-->

# Domain Model Templates — Manifest

See `meta/templates/docs/domain/` for individual sub-templates.
