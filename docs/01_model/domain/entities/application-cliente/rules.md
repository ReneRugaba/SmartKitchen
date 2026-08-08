# Rules: Application Cliente

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity rules, see [Global Rules](../../rules.md).

---

## Invariants

- <INV-08>: Le Client ID doit être unique.

---

## Validation Rules

| Field | Condition |
|-------|-----------|
| Client ID | Ne doit pas être vide et doit être alphanumérique. |
| URIs de Redirection | Doivent être des URLs valides et sécurisées (HTTPS sauf localhost). |

---

## Business Rules

- <RULE-09>: Un client de type "Public" ne doit jamais avoir de secret stocké.
- <RULE-10>: Un client ne peut demander que des scopes auxquels il a été explicitement autorisé.

---

## Open Questions

- <OQ-18>: Existe-t-il une limitation sur le nombre d'URIs de redirection par client ? ❓

---

## Links

→ [Entity](entity.md)
→ [Logic](logic.md)
→ [Global Rules](../../rules.md)
→ [Index](../../index.md)