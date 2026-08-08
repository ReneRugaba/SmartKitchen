# Logic: Login Externe

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity workflows, see [Global Logic](../../logic.md).

---

## State Machine

- States: Actif $\rightarrow$ Supprimé
- Transitions:

  | From | To | Trigger | Condition (→ rules.md) |
  |------|----|---------|------------------------|
  | (Néant) | Actif | Liaison de compte | Validation du fournisseur |
  | Actif | Supprimé | Action Utilisateur / Admin | |

---

## Use Cases

### Use Case: Connexion via Fournisseur Externe
- Actor: Utilisateur
- Preconditions: Le fournisseur est configuré dans le STS.
- Steps:
  1. L'utilisateur choisit le fournisseur externe.
  2. Le fournisseur authentifie l'utilisateur et renvoie un token.
  3. Le système extrait le Login Externe.
  4. Le système vérifie si ce login est déjà lié à un utilisateur.
  5. Si oui, l'utilisateur est connecté. Si non, le workflow de liaison est lancé.
- Rules applied: (→ [rules.md](rules.md)) <INV-07>, <RULE-08>
- Events emitted: (→ [events.md](../../events.md))
- Postconditions: L'utilisateur est authentifié.

---

## Workflows

### Workflow: Liaison de compte externe
- Trigger: Première connexion réussie via un fournisseur externe.
- Steps:
  1. Authentification réussie chez le fournisseur.
  2. Demande à l'utilisateur de s'authentifier localement pour lier le compte.
  3. Création du lien Login Externe $\rightarrow$ Utilisateur.
- Rules applied: (→ [rules.md](rules.md))
- Events emitted: (→ [events.md](../../events.md))

---

## Open Questions

- <OQ-16>: Comment gérer la déconnexion simultanée du compte local et du fournisseur externe ? ❓

---

## Links

→ [Entity](entity.md)
→ [Rules](rules.md)
→ [Global Logic](../../logic.md)
→ [Events](../../events.md)
→ [Index](../../index.md)