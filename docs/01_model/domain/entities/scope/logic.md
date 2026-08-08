# Logic: Scope

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity workflows, see [Global Logic](../../logic.md).

---

## State Machine

- States: Actif $\rightarrow$ Supprimé
- Transitions:

  | From | To | Trigger | Condition (→ rules.md) |
  |------|----|---------|------------------------|
  | (Néant) | Actif | Création du scope | Validation du nom |
  | Actif | Supprimé | Action Admin | <RULE-11> |

---

## Use Cases

### Use Case: Définition de Scope
- Actor: Administrateur
- Preconditions: L'administrateur est authentifié.
- Steps:
  1. Saisie du nom et de la description du scope.
  2. Vérification de l'unicité.
  3. Enregistrement.
- Rules applied: (→ [rules.md](rules.md)) <INV-09>
- Events emitted: (→ [events.md](../../events.md))
- Postconditions: Le scope peut être assigné à des clients.

---

## Workflows

### Workflow: Mise à jour des permissions client
- Trigger: Modification des scopes d'un client.
- Steps:
  1. Sélection du client.
  2. Ajout/Suppression de scopes.
  3. Mise à jour de la relation Client-Scope.
- Rules applied: (→ [rules.md](rules.md))
- Events emitted: (→ [events.md](../../events.md))

---

## Open Questions

- <OQ-22>: Le système supporte-t-il la modification du nom d'un scope après création ? ❓

---

## Links

→ [Entity](entity.md)
→ [Rules](rules.md)
→ [Global Logic](../../logic.md)
→ [Events](../../events.md)
→ [Index](../../index.md)