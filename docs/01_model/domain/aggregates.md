# Aggregates: SmartKitchenIdp

> Part of: [Domain Index](index.md)

---

## Agrégat Utilisateur

- Root entity: [Utilisateur](entities/utilisateur/entity.md)
- Included entities:
  - [Rôle](entities/role/entity.md)
  - [Claim](entities/claim/entity.md)
  - [Passkey](entities/passkey/entity.md)
  - [Login Externe](entities/login-externe/entity.md)
- Included value objects:
  - *Aucun*
- Invariants enforced at boundary:
  - L'unicité globale de l'email et du nom d'utilisateur doit être maintenue lors de toute modification du profil. (→ [rules.md](entities/utilisateur/rules.md))

---

## Agrégat Application Cliente

- Root entity: [Application Cliente](entities/application-cliente/entity.md)
- Included entities:
  - [Scope](entities/scope/entity.md)
- Included value objects:
  - *Aucun*
- Invariants enforced at boundary:
  - Un client ne peut pas être associé à un scope qui n'existe pas dans le système. (→ [rules.md](entities/application-cliente/rules.md))

---

## Agrégat Grant

- Root entity: [Grant](entities/grant/entity.md)
- Included entities:
  - *Aucune* (L'agrégat Grant est léger et référence l'Utilisateur et le Client via leurs IDs).
- Included value objects:
  - *Aucun*
- Invariants enforced at boundary:
  - Un grant ne peut être émis que si l'Utilisateur et l'Application Cliente sont tous deux dans l'état "Actif". (→ [rules.md](entities/grant/rules.md))

---

## Agrégat Audit

- Root entity: [Log d'Audit](entities/log-audit/entity.md)
- Included entities:
  - *Aucune*
- Included value objects:
  - *Aucun*
- Invariants enforced at boundary:
  - L'immuabilité absolue des enregistrements : aucune modification n'est permise après la création. (→ [rules.md](entities/log-audit/rules.md))

---

## Open Questions

- <OQ-32>: Faut-il inclure le Log Système dans un agrégat spécifique ou le considérer comme un flux de données transverse ? ❓

---

## Links

→ [Rules](rules.md)
→ [Index](index.md)