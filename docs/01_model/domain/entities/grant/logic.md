# Logic: Grant

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity workflows, see [Global Logic](../../logic.md).

---

## State Machine

- States: Valide $\rightarrow$ Expiré $\rightarrow$ Révoqué
- Transitions:

  | From | To | Trigger | Condition (→ rules.md) |
  |------|----|---------|------------------------|
  | (Néant) | Valide | Émission du token | Validation des données |
  | Valide | Expiré | Passage de la date d'expiration | <INV-10> |
  | Valide | Révoqué | Action Utilisateur / Admin | <RULE-12> |

---

## Use Cases

### Use Case: Renouvellement de Jeton (Refresh)
- Actor: Application Cliente
- Preconditions: Le client possède un Refresh Token valide.
- Steps:
  1. Le client envoie le Refresh Token au STS.
  2. Le STS vérifie la validité du grant.
  3. Le STS vérifie que le client est toujours autorisé.
  4. Le STS émet un nouvel Access Token (et éventuellement un nouveau Refresh Token).
- Rules applied: (→ [rules.md](rules.md)) <INV-10>, <RULE-13>
- Events emitted: (→ [events.md](../../events.md))
- Postconditions: Le client a un nouveau jeton d'accès.

---

## Workflows

### Workflow: Révocation Globale
- Trigger: Changement de mot de passe ou demande de sécurité.
- Steps:
  1. Identification de tous les grants liés à l'utilisateur.
  2. Marquage de tous les grants comme Révoqués.
- Rules applied: (→ [rules.md](rules.md)) <RULE-12>
- Events emitted: (→ [events.md](../../events.md))

---

## Open Questions

- <OQ-25>: Comment est géré le nettoyage des grants expirés en base de données ? ❓

---

## Links

→ [Entity](entity.md)
→ [Rules](rules.md)
→ [Global Logic](../../logic.md)
→ [Events](../../events.md)
→ [Index](../../index.md)