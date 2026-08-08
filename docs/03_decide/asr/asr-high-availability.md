# ASR: Haute Disponibilité du STS

## Status
Proposed

---

## Requirement

Le serveur de tokens (STS) doit être disponible en permanence pour éviter que l'ensemble de l'écosystème SmartKitchen ne soit bloqué.

- Le système doit supporter un basculement automatique en cas de panne d'une instance.
- Le temps d'indisponibilité doit être minimisé.

---

## Type

Non-Functional

---

## Motivation

- **Business value**: L'authentification est la porte d'entrée de tous les services. Une panne du STS rend toutes les applications inutilisables.
- **Risk mitigation**: Atténue le risque RSK-01 (Panne totale du STS).

---

## Context

- docs/00_brainstorm/context.md
- docs/02_analyse/constraints.md (CON-04)

---

## Constraints

- **Technology constraints**: Nécessite un orchestrateur de conteneurs (Kubernetes ou Docker Swarm) et une base de données répliquée.
- **Security constraints**: La synchronisation des clés de signature doit être garantie entre les instances.

---

## Impact

### Architecture Impact
- Passage d'une architecture mono-instance à un cluster de conteneurs.
- Mise en place d'un Load Balancer (Nginx Proxy).

### Components Impacted
- STS Identity
- Database

### Data Impact
- Nécessite une base de données avec réplication synchrone ou asynchrone.

---

## Quality Attributes (if applicable)

- Reliability: High
- Availability: 99.9%

---

## Risks

- Complexité accrue de la gestion des sessions et des grants si la réplication DB a un lag.

---

## Dependencies

- Depends on: Infrastructure Cloud / On-prem supportant le clustering.
- Blocks: Finalisation du plan de déploiement.

---

## Priority

High