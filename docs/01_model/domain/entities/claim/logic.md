# Logic: Claim

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity workflows, see [Global Logic](../../logic.md).

---

## State Machine

- States: Actif $\rightarrow$ Supprimé
- Transitions:

  | From | To | Trigger | Condition (→ rules.md) |
  |------|----|---------|------------------------|
  | (Néant) | Actif | Ajout de claim | Validation des données |
  | Actif | Supprimé | Action Admin / Utilisateur | |

---

## Use Cases

### Use Case: Ajout de Claim
- Actor: Administrateur
- Preconditions: L'utilisateur cible existe.
- Steps:
  1. Sélection de l'utilisateur.
  2. Saisie du type de claim et de sa valeur.
  3. Enregistrement.
- Rules applied: (→ [rules.md](rules.md)) <INV-05>, <RULE-05>
- Events emitted: (→ [events.md](../../events.md))
- Postconditions: Le claim est associé au profil de l'utilisateur.

---

## Workflows

### Workflow: Mise à jour du profil
- Trigger: Modification des informations utilisateur.
- Steps:
  1. Identification des claims à modifier.
  2. Mise à jour des valeurs.
  3. Validation et enregistrement.
- Rules applied: (→ [rules.md](rules.md))
- Events emitted: (→ [events.md](../../events.md))

---

## Open Questions

- <OQ-10>: Les claims peuvent-ils être hérités d'un rôle ? ❓

---

## Links

→ [Entity](entity.md)
→ [Rules](rules.md)
→ [Global Logic](../../logic.md)
→ [Events](../../events.md)
→ [Index](../../index.md)