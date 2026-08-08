# Constraints: SmartKitchenIdp

> Part of: [Analysis](.)
> Hard limits the solution must respect. Non-negotiable.

---

## Technical

| ID | Constraint | Source | Impact |
|----|------------|--------|--------|
| CON-01 | Utilisation impérative de Duende IdentityServer pour le moteur de tokens | Architecture | Dépendance forte au framework et à sa licence. |
| CON-02 | Persistance des données via Entity Framework Core (PostgreSQL/SQL Server) | Architecture | Modèle de données lié à l'ORM. |
| CON-03 | Déploiement obligatoire via Docker et Nginx Proxy | Context | Contrainte d'infrastructure et de routage. |

---

## Business

| ID | Constraint | Source | Impact |
|----|------------|--------|--------|
| CON-04 | Disponibilité critique du STS (Single Point of Failure) | Context | Nécessite une stratégie de haute disponibilité. |
| CON-05 | Support obligatoire des Passkeys pour l'authentification forte | Domain | Impacte le flux d'inscription et de connexion. |

---

## Regulatory

| ID | Constraint | Source | Impact |
|----|------------|--------|--------|
| CON-06 | Conformité RGPD pour la gestion des données personnelles | Réglementaire | Obligation de mise en œuvre du droit à l'oubli et portabilité. |

---

## Organizational

| ID | Constraint | Source | Impact |
|----|------------|--------|--------|
| CON-07 | Utilisation d'Azure Key Vault pour la gestion des secrets en production | Architecture | Dépendance à l'écosystème Azure. |

---

## Open Questions

- <OQ-42>: Existe-t-il des contraintes de performance spécifiques (nombre de requêtes/sec) imposées par le business ? ❓

---

## Links

→ [Assumptions](assumptions.md)
→ [Risks](risks.md)
→ [ASRs](../03_decide/asr/)
→ [Context](../00_brainstorm/context.md)