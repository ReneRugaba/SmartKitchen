# Logic: Utilisateur

> Part of: [Entity](entity.md) | [Domain Index](../../index.md)
> For cross-entity workflows, see [Global Logic](../../logic.md).

---

## State Machine

- States: Actif $\rightarrow$ Bloqué $\rightarrow$ Supprimé
- Transitions:

  | From | To | Trigger | Condition (→ rules.md) |
  |------|----|---------|------------------------|
  | (Néant) | Actif | Inscription / Création | Validation des données |
  | Actif | Bloqué | Trop d'échecs de connexion / Action Admin | <RULE-01> |
  | Bloqué | Actif | Réinitialisation / Action Admin | Vérification d'identité |
  | Actif | Supprimé | Demande de suppression | Consentement utilisateur |
  | Bloqué | Supprimé | Action Admin | |

- Invalid transitions:
  - Supprimé $\rightarrow$ Actif: Un compte supprimé ne peut pas être réactivé (doit être recréé).

---

## Use Cases

### Use Case: Authentification
- Actor: Utilisateur
- Preconditions: L'utilisateur possède un compte Actif.
- Steps:
  1. L'utilisateur fournit ses identifiants (ou Passkey).
  2. Le système vérifie la validité des informations.
  3. Le système vérifie que le compte n'est pas Bloqué.
  4. Le système émet un Jeton (Token).
- Rules applied: (→ [rules.md](rules.md)) <INV-03>, <RULE-01>, <RULE-03>
- Events emitted: (→ [events.md](../../events.md))
- Postconditions: L'utilisateur est authentifié.
- Edge cases:
  - Identifiants incorrects: Le système incrémente le compteur d'échecs.

### Use Case: Enregistrement de Passkey
- Actor: Utilisateur
- Preconditions: L'utilisateur est authentifié.
- Steps:
  1. L'utilisateur initie la création d'une Passkey.
  2. Le système génère un challenge.
  3. L'utilisateur signe le challenge avec sa clé privée.
  4. Le système enregistre la clé publique associée à l'utilisateur.
- Rules applied: (→ [rules.md](rules.md)) <RULE-03>
- Events emitted: (→ [events.md](../../events.md))
- Postconditions: La Passkey est liée au compte.

---

## Workflows

### Workflow: Récupération de compte
- Trigger: Demande de réinitialisation de mot de passe.
- Steps:
  1. Vérification de l'existence de l'email.
  2. Envoi d'un token de récupération par email.
  3. Validation du token.
  4. Mise à jour du mot de passe.
- Rules applied: (→ [rules.md](rules.md)) <INV-01>
- Events emitted: (→ [events.md](../../events.md))

---

## Open Questions

- <OQ-04>: Le workflow de suppression est-il immédiat ou y a-t-il une période de grâce (soft-delete) ? ❓

---

## Links

→ [Entity](entity.md)
→ [Rules](rules.md)
→ [Global Logic](../../logic.md)
→ [Events](../../events.md)
→ [Index](../../index.md)