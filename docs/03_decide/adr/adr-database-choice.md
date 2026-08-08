# ADR: Persistance via PostgreSQL / SQL Server

## Status
Accepted

---

## Context

Le système doit stocker des données d'identité, des configurations de clients et des logs d'audit. Ces données nécessitent une forte cohérence transactionnelle et une capacité de requête complexe.

References:
- docs/01_model/domain/index.md
- docs/02_analyse/constraints.md (CON-02)

---

## Decision

Utiliser un système de gestion de base de données relationnelle (RDBMS), spécifiquement **PostgreSQL** ou **SQL Server**, via **Entity Framework Core**.

---

## Options Considered

### Option A: NoSQL (ex: MongoDB)
- Description: Stockage documentaire pour plus de flexibilité.
- Pros: Scalabilité horizontale facile, schéma flexible.
- Cons: Cohérence transactionnelle plus faible, complexité pour les jointures.

### Option B: RDBMS (PostgreSQL / SQL Server)
- Description: Stockage relationnel classique.
- Pros: Cohérence forte (ACID), maturité des outils, support natif par EF Core.
- Cons: Scalabilité verticale plus coûteuse.

---

## Rationale

La nature des données d'identité (relations Utilisateur $\rightarrow$ Rôle $\rightarrow$ Claim) et l'exigence d'immuabilité des logs d'audit justifient l'utilisation d'une base de données relationnelle. La cohérence forte est primordiale pour éviter les problèmes de droits d'accès incohérents.

---

## Consequences

### Positive
- Garantie d'intégrité des données.
- Facilité de reporting et d'audit.
- Écosystème d'outils riches.

### Negative
- Nécessite une gestion rigoureuse des migrations de schéma.
- Performance potentiellement moindre sur des volumes de données massifs sans optimisation.

### Risks Introduced
- Goulot d'étranglement potentiel lors de pics de connexion (RSK-05).

---

## Impact

### Affected Components
- STS Identity
- Admin API

### Affected Domain
- Persistance.

### Backlog Impact
- Mise en place des migrations EF Core.
- Configuration des index de performance.

---

## Links

- Related Architecture Docs: [containers.md](../../architecture/containers.md)