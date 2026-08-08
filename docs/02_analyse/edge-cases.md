# Edge Cases: SmartKitchenIdp

> Part of: [Analysis](.)
> Non-obvious situations the system must explicitly handle.

---

## Utilisateur & Authentification

| ID | Situation | Expected behavior | Risk if unhandled | Linked to |
|----|-----------|-------------------|-------------------|-----------|
| EC-01 | Suppression d'un utilisateur avec des Grants actifs | Révocation immédiate de tous les grants associés. | Accès résiduel non autorisé. | [ la logique de révocation](entities/utilisateur/logic.md) |
| EC-02 | Perte de toutes les Passkeys d'un utilisateur | Recours à un flux de récupération sécurisé (Email/Admin). | Perte définitive du compte. | [ la logique de passkey](entities/passkey/logic.md) |
| EC-03 | Tentatives de connexion massives sur un compte (Brute Force) | Verrouillage temporaire du compte après X échecs. | Compromission du compte. | [ la logique d'authentification](entities/utilisateur/logic.md) |

---

## Application Cliente & Scopes

| ID | Situation | Expected behavior | Risk if unhandled | Linked to |
|----|-----------|-------------------|-------------------|-----------|
| EC-04 | Changement d'URI de redirection en cours de session | Le STS doit rejeter le token si l'URI ne correspond plus. | Détournement de token (Token Theft). | [ la logique client](entities/application-cliente/logic.md) |
| EC-05 | Suppression d'un Scope utilisé par un client actif | Le client perd l'accès à la ressource lors du prochain refresh. | Erreurs inattendues dans l'application cliente. | [ la logique scope](entities/scope/logic.md) |

---

## Administration & Audit

| ID | Situation | Expected behavior | Risk if unhandled | Linked to |
|----|-----------|-------------------|-------------------|-----------|
| EC-06 | Modification d'un utilisateur par un admin alors que l'utilisateur est connecté | Invalidation immédiate de la session utilisateur. | Incohérence des droits d'accès. | [ la logique d'audit](entities/log-audit/logic.md) |

---

## Open Questions

- <OQ-45>: Comment gérer la récupération d'un compte si l'email ET les passkeys sont perdus ? ❓

---

## Links

→ [Domain](../01_model/domain/index.md)
→ [Architecture](../01_model/architecture/index.md)
→ [Risks](risks.md)
→ [ADRs](../03_decide/adr/)