# Logic: Log Système

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity workflows, see [Global Logic](../../logic.md).

---

## State Machine

- States: Créé $\rightarrow$ Supprimé
- Transitions:

  | From | To | Trigger | Condition (→ rules.md) |
  |------|----|---------|------------------------|
  | (Néant) | Créé | Événement système | <INV-12> |
  | Créé | Supprimé | Rotation des logs | |

---

## Use Cases

### Use Case: Diagnostic d'erreur
- Actor: Administrateur / Développeur
- Preconditions: Une erreur est survenue dans le système.
- Steps:
  1. Recherche des logs de niveau "Error" ou "Fatal".
  2. Analyse de la stacktrace.
  3. Corrélation avec l'horodatage.
- Rules applied: (→ [rules.md](rules.md))
- Events emitted: (→ [events.md](../../events.md))
- Postconditions: La cause racine de l'erreur est identifiée.

---

## Workflows

### Workflow: Rotation des logs
- Trigger: Taille du fichier atteinte ou intervalle de temps.
- Steps:
  1. Fermeture du fichier de log actuel.
  2. Archivage du fichier.
  3. Création d'un nouveau fichier de log.
- Rules applied: (→ [rules.md](rules.md))
- Events emitted: (→ [events.md](../../events.md))

---

## Open Questions

- <OQ-31>: Le système supporte-t-il le streaming des logs vers un collecteur centralisé (ex: ELK, Splunk) ? ❓

---

## Links

→ [Entity](entity.md)
→ [Rules](rules.md)
→ [Global Logic](../../logic.md)
→ [Events](../../events.md)
→ [Index](../../index.md)