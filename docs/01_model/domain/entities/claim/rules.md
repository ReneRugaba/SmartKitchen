# Rules: Claim

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity rules, see [Global Rules](../../rules.md).

---

## Invariants

- <INV-05>: Un claim ne peut pas exister sans utilisateur associé.

---

## Validation Rules

| Field | Condition |
|-------|-----------|
| Type de Claim | Ne doit pas être vide. |
| Valeur | Ne doit pas être vide. |

---

## Business Rules

- <RULE-05>: Un utilisateur peut posséder plusieurs claims du même type (ex: plusieurs adresses email).

---

## Open Questions

- <OQ-09>: Existe-t-il des restrictions sur le nombre de claims par utilisateur ? ❓

---

## Links

→ [Entity](entity.md)
→ [Logic](logic.md)
→ [Global Rules](../../rules.md)
→ [Index](../../index.md)