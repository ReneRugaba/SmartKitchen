# Logic: Passkey

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity workflows, see [Global Logic](../../logic.md).

---

## State Machine

- States: Enregistrée $\rightarrow$ Révoquée
- Transitions:

  | From | To | Trigger | Condition (→ rules.md) |
  |------|----|---------|------------------------|
  | (Néant) | Enregistrée | Enregistrement WebAuthn | Validation signature |
  | Enregistrée | Révoquée | Action Utilisateur / Admin | |

---

## Use Cases

### Use Case: Enregistrement de Passkey
- Actor: Utilisateur
- Preconditions: L'utilisateur est authentifié.
- Steps:
  1. Le système génère un challenge.
  2. L'utilisateur signe le challenge avec son dispositif.
  3. Le système vérifie la signature.
  4. Le système enregistre la clé publique.
- Rules applied: (→ [rules.md](rules.md)) <INV-06>, <RULE-07>
- Events emitted: (→ [events.md](../../events.md))
- Postconditions: La passkey est prête pour l'authentification.

### Use Case: Authentification via Passkey
- Actor: Utilisateur
- Preconditions: L'utilisateur possède au moins une passkey enregistrée.
- Steps:
  1. Le système demande l'authentification.
  2. L'utilisateur signe le challenge avec sa passkey.
  3. Le système valide la signature avec la clé publique stockée.
- Rules applied: (→ [rules.md](rules.md)) <RULE-06>
- Events emitted: (→ [events.md](../../events.md))
- Postconditions: L'utilisateur est authentifié.

---

## Workflows

### Workflow: Révocation de Passkey
- Trigger: Perte du dispositif ou demande de sécurité.
- Steps:
  1. Sélection de la passkey à révoquer.
  2. Marquage de la clé comme Révoquée.
- Rules applied: (→ [rules.md](rules.md))
- Events emitted: (→ [events.md](../../events.md))

---

## Open Questions

- <OQ-13>: Comment est gérée la récupération du compte si toutes les passkeys sont perdues ? ❓

---

## Links

→ [Entity](entity.md)
→ [Rules](rules.md)
→ [Global Logic](../../logic.md)
→ [Events](../../events.md)
→ [Index](../../index.md)