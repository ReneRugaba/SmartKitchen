# Logic: Rôle

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity workflows, see [Global Logic](../../logic.md).

---

## State Machine

- States: Actif $\rightarrow$ Supprimé
- Transitions:

  | From | To | Trigger | Condition (→ rules.md) |
  |------|----|---------|------------------------|
  | (Néant) | Actif | Création du rôle | Validation du nom |
  | Actif | Supprimé | Action Admin | <RULE-04> |

---

## Use Cases

### Use Case: Création de Rôle
- Actor: Administrateur
- Preconditions: L'administrateur est authentifié.
- Steps:
  1. Saisie du nom du rôle.
  2. Vérification de l'unicité.
  3. Enregistrement en base.
- Rules applied: (→ [rules.md](rules.md)) <INV-04>
- Events emitted: (→ [events.md](../../events.md))
- Postconditions: Le rôle est disponible pour assignation.

---

## Workflows

### Workflow: Assignation de Rôle
- Trigger: Action d'administration sur un utilisateur.
- Steps:
  1. Sélection de l'utilisateur.
  2. Sélection du rôle.
  3. Création du lien Utilisateur-Rôle.
- Rules applied: (→ [rules.md](rules.md))
- Events emitted: (→ [events.md](../../events.md))

---

## Open Questions

- <OQ-07>: Existe-t-il un workflow de validation pour la création de nouveaux rôles ? ❓

---

## Links

→ [Entity](entity.md)
→ [Rules](rules.md)
→ [Global Logic](../../logic.md)
→ [Events](../../events.md)
→ [Index](../../index.md)