# Domain Model: SmartKitchenIdp

## Status
Draft

---

## Overview

Le modèle de domaine de SmartKitchenIdp définit la structure et le comportement d'un fournisseur d'identité (IdP) basé sur les standards OIDC et OAuth2. Il gère le cycle de vie des identités utilisateurs, la configuration des applications clientes, la gestion des permissions via des scopes et la traçabilité des actions administratives.

---

## Files

| File | Description |
|------|-------------|
| [ubiquitous-language.md](ubiquitous-language.md) | Shared vocabulary — read this first |
| [aggregates.md](aggregates.md) | Consistency boundaries across entities |
| [rules.md](rules.md) | Cross-entity invariants and constraints |
| [logic.md](logic.md) | Cross-entity workflows and use case flows |
| [events.md](events.md) | Domain events |

---

## Entities

| Folder | entity.md | rules.md | logic.md |
|--------|-----------|----------|----------|
| [entities/utilisateur/](entities/utilisateur/) | [entity.md](entities/utilisateur/entity.md) | [rules.md](entities/utilisateur/rules.md) | [logic.md](entities/utilisateur/logic.md) |
| [entities/role/](entities/role/) | [entity.md](entities/role/entity.md) | [rules.md](entities/role/rules.md) | [logic.md](entities/role/logic.md) |
| [entities/claim/](entities/claim/) | [entity.md](entities/claim/entity.md) | [rules.md](entities/claim/rules.md) | [logic.md](entities/claim/logic.md) |
| [entities/passkey/](entities/passkey/) | [entity.md](entities/passkey/entity.md) | [rules.md](entities/passkey/rules.md) | [logic.md](entities/passkey/logic.md) |
| [entities/login-externe/](entities/login-externe/) | [entity.md](entities/login-externe/entity.md) | [rules.md](entities/login-externe/rules.md) | [logic.md](entities/login-externe/logic.md) |
| [entities/application-cliente/](entities/application-cliente/) | [entity.md](entities/application-cliente/entity.md) | [rules.md](entities/application-cliente/rules.md) | [logic.md](entities/application-cliente/logic.md) |
| [entities/scope/](entities/scope/) | [entity.md](entities/scope/entity.md) | [rules.md](entities/scope/rules.md) | [logic.md](entities/scope/logic.md) |
| [entities/grant/](entities/grant/) | [entity.md](entities/grant/entity.md) | [rules.md](entities/grant/rules.md) | [logic.md](entities/grant/logic.md) |
| [entities/log-audit/](entities/log-audit/) | [entity.md](entities/log-audit/entity.md) | [rules.md](entities/log-audit/rules.md) | [logic.md](entities/log-audit/logic.md) |
| [entities/log-systeme/](entities/log-systeme/) | [entity.md](entities/log-systeme/entity.md) | [rules.md](entities/log-systeme/rules.md) | [logic.md](entities/log-systeme/logic.md) |

---

## Traceability

- Derived from:
  → [docs/00_brainstorm/context.md](../../00_brainstorm/context.md)

- Feeds:
  → docs/01_model/architecture/
  → docs/02_analyse/
  → docs/03_decide/adr/
  → backlog/
  → src/