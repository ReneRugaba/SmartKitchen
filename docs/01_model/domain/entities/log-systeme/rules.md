# Rules: Log Système

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity rules, see [Global Rules](../../rules.md).

---

## Invariants

- <INV-12>: Tout log doit avoir un niveau de sévérité associé.

---

## Validation Rules

| Field | Condition |
|-------|-----------|
| Niveau de Log | Doit appartenir à la liste prédéfinie (Trace, Debug, Info, Warning, Error, Fatal). |

---

## Business Rules

- <RULE-15>: Les logs de niveau "Error" ou "Fatal" doivent déclencher une alerte système (si configuré).

---

## Open Questions

- <OQ-30>: Existe-t-il une politique de masquage des données sensibles (PII) dans les logs système ? ❓

---

## Links

→ [Entity](entity.md)
→ [Logic](logic.md)
→ [Global Rules](../../rules.md)
→ [Index](../../index.md)