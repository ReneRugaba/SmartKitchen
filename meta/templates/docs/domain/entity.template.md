<!--
OUTPUT FILE: docs/01_model/domain/entities/<entity-name>/entity.md
GENERATE:   one folder per entity — folder name = kebab-case entity name (e.g. booking/, user-account/)
RELATED:    entities/<entity-name>/rules.md  ← rules specific to this entity
            entities/<entity-name>/logic.md  ← workflows and state machine for this entity
INSTRUCTIONS:
- Describe the entity from a business perspective only — no database schema, no code
- Use terms from ubiquitous-language.md exclusively
- Value Objects owned solely by this entity are documented here
- Value Objects shared across entities belong in a dedicated file — note it with ❓
- Relationships reference other entity folders by relative path
- Mark any unknown attribute, lifecycle state, or relationship with ❓
-->

# Entity: <Name>

> Part of: [Domain Index](../index.md)
> Vocabulary: [Ubiquitous Language](../ubiquitous-language.md)

---

## Description

What this entity represents in the business domain.

---

## Key Attributes

| Attribute | Description | Required |
|-----------|-------------|----------|
| \<attribute\> | | Yes / No |
| \<attribute\> | | ❓ |

---

## Value Objects

Immutable concepts that belong to this entity.

### \<Value Object Name\>

- Description:
- Attributes:
  - \<attribute\>:

---

## Relationships

| Related entity | Relationship type | Description |
|----------------|-------------------|-------------|
| [\<Entity\>](\<entity\>.md) | has one / has many / belongs to | |

---

## Lifecycle

Describe the states this entity can be in and how it transitions between them.

- States: \<state A\> → \<state B\> → \<state C\> ❓
- Created by: \<use case or event\>
- Deleted / archived by: \<use case or event\>

---

## Invariants

Conditions that must always be true for this entity.

- \<Invariant\>: (→ see [rules.md](../rules.md))

---

## Open Questions

- \<OQ-01\>:

---

## Links

→ [Rules for this entity](rules.md)
→ [Logic for this entity](logic.md)
→ [Aggregates](../../aggregates.md)
→ [Global Rules](../../rules.md)
→ [Events](../../events.md)
→ [Index](../../index.md)
