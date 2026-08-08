# Logic: Log d'Audit

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity workflows, see [Global Logic](../../logic.md).

---

## State Machine

- States: Créé $\rightarrow$ Archivé
- Transitions:

  | From | To | Trigger | Condition (→ rules.md) |
  |------|----|---------|------------------------|
  | (Néant) | Créé | Action Admin | <INV-11> |
  | Créé | Archivé | Purge automatique | Politique de rétention |

---

## Use Cases

### Use Case: Traçabilité d'une modification
- Actor: Administrateur / Auditeur
- Preconditions: L'auditeur est authentifié.
- Steps:
  1. Recherche d'une entité cible (ex: Client X).
  2. Filtrage des logs par date ou par utilisateur.
  3. Comparaison des valeurs antérieures et nouvelles.
- Rules applied: (→ [rules.md](rules.md))
- Events emitted: (→ [events.md](../../events.md))
- Postconditions: L'historique des modifications est exposé.

---

## Workflows

### Workflow: Génération automatique de log
- Trigger: Appel d'un service de modification dans l'API Admin.
- Steps:
  1. Capture de l'état actuel de l'entité.
  2. Exécution de la modification.
  3. Capture du nouvel état.
  4. Écriture du log d'audit.
- Rules applied: (→ [rules.md](rules.md)) <RULE-14>
- Events emitted: (→ [events.md](../../events.md))

---

## Open Questions

- <OQ-28>: Le système gère-t-il l'exportation des logs vers un SIEM externe ? ❓

---

## Links

→ [Entity](entity.md)
→ [Rules](rules.md)
→ [Global Logic](../../logic.md)
→ [Events](../../events.md)
→ [Index](../../index.md)