# Rules: Grant

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity rules, see [Global Rules](../../rules.md).

---

## Invariants

- <INV-10>: Un grant expiré est invalide.

---

## Validation Rules

| Field | Condition |
|-------|-----------|
| Données du Grant | Doivent être chiffrées et intègres. |
| Date d'Expiration | Doit être postérieure à la date de création. |

---

## Business Rules

- <RULE-12>: Un grant peut être révoqué manuellement par l'utilisateur ou l'administrateur.
- <RULE-13>: La durée de vie d'un grant dépend de la configuration du client et du type de grant.

---

## Open Questions

- <OQ-24>: Existe-t-il une limite sur le nombre de grants actifs par utilisateur et par client ? ❓

---

## Links

→ [Entity](entity.md)
→ [Logic](logic.md)
→ [Global Rules](../../rules.md)
→ [Index](../../index.md)