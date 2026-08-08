# Global Logic: SmartKitchenIdp

> Part of: [Domain Index](index.md)
> Scope: cross-entity workflows and use cases only.
> Entity-specific workflows live in `entities/<name>/logic.md`.
> Logic is procedural — it describes behavior, not conditions.
> For conditions and invariants, see [rules.md](rules.md).

---

## Cross-Entity Use Cases

### Use Case: Flux d'Authentification Complet (OIDC)
- Actor: Utilisateur
- Preconditions: L'Utilisateur et l'Application Cliente sont enregistrés et actifs.
- Steps:
  1. L'Application Cliente redirige l'Utilisateur vers le STS.
  2. Le STS authentifie l'Utilisateur (via mot de passe ou Passkey).
  3. Le STS demande le Consentement de l'Utilisateur pour les Scopes demandés.
  4. Le STS génère un Authorization Code.
  5. L'Application Cliente échange le code contre un Access Token et un ID Token.
- Rules applied: (→ [rules.md](rules.md#INV-1S))
- Events emitted: (→ [events.md](events.md#UserAuthenticated))
- Postconditions: L'utilisateur est authentifié et l'application possède un jeton d'accès.
- Edge cases:
  - Refus du consentement: Le flux s'arrête et l'utilisateur est redirigé vers le client avec une erreur.

### Use Case: Accès aux Ressources API
- Actor: Application Cliente
- Preconditions: L'application possède un Access Token valide.
- Steps:
  1. L'Application Cliente présente le jeton à l'API cible.
  2. L'API valide le jeton auprès du STS (ou via clé publique).
  3. L'API vérifie que le jeton contient les Scopes requis pour l'action.
  4. L'API autorise ou refuse l'accès.
- Rules applied: (→ [rules.md](rules.md#INV-2S))
- Events emitted: (→ [events.md](events.md#ResourceAccessed))
- Postconditions: La ressource est accessible ou un accès 403 est retourné.

---

## Workflows

### Workflow: Révocation de Sécurité Globale
- Trigger: Détection d'une compromission de compte ou changement de mot de passe.
- Steps:
  1. Marquage de l'Utilisateur comme "Bloqué" ou mise à jour du secret.
  2. Identification de tous les Grants associés à cet Utilisateur.
  3. Révocation immédiate de tous les Grants (Refresh Tokens).
  4. Invalidation des sessions actives.
- Rules applied: (→ [rules.md](rules.md#RULE-GS3))
- Events emitted: (→ [events.md](events.md#AllGrantsRevoked))

---

## State Machines

*Les machines d'état sont gérées au niveau des entités. Aucune machine d'état globale n'est identifiée.*

---

## Edge Cases

- **Expiration du Grant pendant le flux de renouvellement**:
  - Why it matters: Évite l'utilisation de jetons obsolètes.
  - Expected behavior: Le STS rejette la demande et force une nouvelle authentification complète.

---

## Open Questions

- <OQ-34>: Comment est géré le "Single Log-Out" (SLO) entre le STS et les multiples applications clientes ? ❓

---

## Links

→ [Rules](rules.md)
→ [Events](events.md)
→ [Index](index.md)