# Logic: Application Cliente

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity workflows, see [Global Logic](../../logic.md).

---

## State Machine

- States: Actif $\rightarrow$ Désactivé $\rightarrow$ Supprimé
- Transitions:

  | From | To | Trigger | Condition (→ rules.md) |
  |------|----|---------|------------------------|
  | (Néant) | Actif | Enregistrement du client | Validation des données |
  | Actif | Désactivé | Action Admin | |
  | Désactivé | Actif | Action Admin | |
  | Actif | Supprimé | Action Admin | |

---

## Use Cases

### Use Case: Enregistrement de Client
- Actor: Administrateur
- Preconditions: L'administrateur est authentifié.
- Steps:
  1. Saisie des informations du client (ID, Nom, URIs).
  2. Vérification de l'unicité du Client ID.
  3. Assignation des scopes autorisés.
  4. Enregistrement.
- Rules applied: (→ [rules.md](rules.md)) <INV-08>, <RULE-10>
- Events emitted: (→ [events.md](../../events.md))
- Postconditions: Le client peut initier des flux d'authentification.

---

## Workflows

### Workflow: Rotation du Secret
- Trigger: Expiration du secret ou compromission.
- Steps:
  1. Génération d'un nouveau secret.
  2. Mise à jour du secret en base.
  3. Notification au propriétaire de l'application.
- Rules applied: (→ [rules.md](rules.md))
- Events emitted: (→ [events.md](../../events.md))

---

## Open Questions

- <OQ-19>: Le système gère-t-il des secrets temporaires lors de la création ? ❓

---

## Links

→ [Entity](entity.md)
→ [Rules](rules.md)
→ [Global Logic](../../logic.md)
→ [Events](../../events.md)
→ [Index](../../index.md)