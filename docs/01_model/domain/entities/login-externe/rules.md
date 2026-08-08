# Rules: Login Externe

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity rules, see [Global Rules](../../rules.md).

---

## Invariants

- <INV-07>: Le couple (Fournisseur, Login Externe) doit être unique.

---

## Validation Rules

| Field | Condition |
|-------|-----------|
| Fournisseur | Doit correspondre à un fournisseur configuré dans le STS. |
| Login Externe | Ne doit pas être vide. |

---

## Business Rules

- <RULE-08>: Si un login externe est utilisé pour la première fois et qu'il n'est lié à aucun utilisateur, un nouveau compte utilisateur doit être créé ou l'utilisateur doit être invité à lier un compte existant.

---

## Open Questions

- <OQ-15>: Peut-on limiter le nombre de logins externes par utilisateur ? ❓

---

## Links

→ [Entity](entity.md)
→ [Logic](logic.md)
→ [Global Rules](../../rules.md)
→ [Index](../../index.md)