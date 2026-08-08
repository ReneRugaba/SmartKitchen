# Rules: Passkey

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity rules, see [Global Rules](../../rules.md).

---

## Invariants

- <INV-06>: Une passkey doit être liée à un utilisateur unique.

---

## Validation Rules

| Field | Condition |
|-------|-----------|
| Clé Publique | Doit être un format de clé valide (COSE/DER). |
| Identifiant de la Clé | Doit être unique au niveau global. |

---

## Business Rules

- <RULE-06>: L'utilisation d'une passkey valide permet de bypasser la saisie du mot de passe.
- <RULE-07>: Un utilisateur peut enregistrer plusieurs passkeys pour assurer la redondance.

---

## Open Questions

- <OQ-12>: Existe-t-il une limite maximale de passkeys par utilisateur ? ❓

---

## Links

→ [Entity](entity.md)
→ [Logic](logic.md)
→ [Global Rules](../../rules.md)
→ [Index](../../index.md)