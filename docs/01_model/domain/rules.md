# Global Rules: SmartKitchenIdp

> Part of: [Domain Index](index.md)
> Scope: cross-entity invariants and constraints only.
> Entity-specific rules live in `entities/<name>/rules.md`.
> Rules are declarative — they state conditions, not procedures.
> For enforcement and workflows, see [logic.md](logic.md).

---

## Invariants

Conditions that must ALWAYS be true across the entire domain.

- <INV-1S>: Tout Jeton (Token) émis doit être associé à un Utilisateur actif et à une Application Cliente active.
- <INV-2S>: Aucun accès aux ressources ne peut être accordé sans un Jeton valide et non révoqué.

---

## Cross-Entity Rules

Rules that involve more than one entity or aggregate.

- <RULE-GS1>: Un Utilisateur ne peut être associé à un Rôle que si ce Rôle a été préalablement créé et activé.
- <RULE-GS2>: Un Grant ne peut être valide que si l'Application Cliente associée possède toujours les Scopes requis pour ce grant.
- <RULE-GS3>: Toute modification d'un Utilisateur (email, mot de passe) doit entraîner la révocation immédiate de tous ses Grants actifs pour des raisons de sécurité.

---

## Constraints

- **Regulatory**:
  - <C-REG-01>: Les données d'identité doivent être traitées conformément au RGPD (Droit à l'oubli, portabilité). ❓
- **Business**:
  - <C-BUS-01>: Le système doit garantir une disponibilité élevée du STS pour ne pas bloquer l'accès aux applications clientes.

---

## Open Questions

- <OQ-33>: Existe-t-il des règles de dépendance entre les types de Grants et les types de Clients (ex: certains clients ne peuvent utiliser que le flux Implicit) ? ❓

---

## Links

→ [Aggregates](aggregates.md)
→ [Logic](logic.md)
→ [Index](index.md)