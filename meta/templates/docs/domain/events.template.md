<!--
OUTPUT FILE: docs/01_model/domain/events.md
INSTRUCTIONS:
- Document events that are significant from a business perspective
- An event records something that happened — it is immutable, past tense
- Do NOT describe how events are technically published or consumed
- Reference the entity that owns the event and the use case that triggers it
-->

# Domain Events: <System Name>

> Part of: [Domain Index](index.md)
> Events are business facts — something that happened and cannot be undone.

---

## Event: \<EventName\>

- Trigger: \<use case or action from [logic.md](logic.md)\>
- Emitted by entity: [\<Entity\>](entities/\<entity\>.md)
- Description:
- Payload (business fields, not technical):
  - \<field\>:
- Downstream impact:
  - \<what changes, what reacts\>

(Repeat for each event)

---

## Open Questions

- \<OQ-01\>:

---

## Links

→ [Logic](logic.md)
→ [Index](index.md)
