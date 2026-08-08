# Architecture: SmartKitchenIdp

## Status
Draft

---

## Overview

L'architecture de SmartKitchenIdp suit le modèle C4 pour fournir une vue multi-niveaux du système. Elle repose sur un découpage en conteneurs autonomes (UI, API, STS) orchestrés par un reverse proxy Nginx. Le système est conçu pour être hautement sécurisé, s'appuyant sur les standards OIDC/OAuth2 et une gestion centralisée des secrets via Azure Key Vault.

---

## Files

| File | Description |
|------|-------------|
| [context.md](context.md) | C4 Level 1 — System Context |
| [containers.md](containers.md) | C4 Level 2 — Container overview |
| [containers/admin-ui/component.md](containers/admin-ui/component.md) | C4 Level 3 — Components of Admin UI |
| [containers/admin-api/component.md](containers/admin-api/component.md) | C4 Level 3 — Components of Admin API |
| [containers/sts-identity/component.md](containers/sts-identity/component.md) | C4 Level 3 — Components of STS Identity |
| [cross-cutting.md](cross-cutting.md) | Security, performance, resilience, deployment |

---

## Traceability

- Derived from:
  → [docs/00_brainstorm/context.md](../../00_brainstorm/context.md)
  → [docs/01_model/domain/](../../domain/)
  → docs/03_decide/asr/

- Feeds:
  → docs/02_analyse/
  → docs/03_decide/adr/
  → backlog/
  → src/