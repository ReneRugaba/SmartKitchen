# Cross-Cutting Concerns: SmartKitchenIdp

> Part of: [Architecture Index](index.md)
> Applies across all containers.
> Grounded in: docs/03_decide/asr/ and docs/02_analyse/constraints.md

## Status
Draft

---

## Security

- **Authentication**: Basée sur OpenID Connect. L'accès à l'Admin UI et l'Admin API est restreint aux utilisateurs possédant le rôle "Administrateur".
- **Authorization**: Gestion basée sur les rôles (RBAC) et les scopes OAuth2.
- **Data in transit**: Chiffrement TLS (HTTPS) obligatoire pour tous les échanges.
- **Data at rest**: Mots de passe hachés avec salted-bcrypt. Données sensibles chiffrées via Azure Key Vault.
- **Secrets management**: Utilisation d'Azure Key Vault pour les secrets de production et `appsettings.json` / User Secrets en développement.
- **Input validation**: Validation via DataAnnotations et FluentValidation dans les services.

---

## Performance

- **Expected load**: Modérée (usage interne entreprise).
- **SLOs**: Disponibilité cible de 99.9%. Latence p99 < 200ms pour l'émission de tokens.
- **Critical paths**: Flux d'authentification $\rightarrow$ Validation $\rightarrow$ Émission de token.
- **Caching strategy**: Cache en mémoire pour les configurations du STS. ❓

---

## Scalability

- **Horizontal scaling approach**: Déploiement de multiples instances de STS et Admin API derrière le Nginx Proxy.
- **Known bottlenecks**: La base de données unique peut devenir un goulot d'étranglement. ❓
- **Data growth projection**: Croissance linéaire liée au nombre d'utilisateurs et au volume des logs d'audit.

---

## Resilience

- **Key failure modes**: Panne de la base de données ou indisponibilité d'Azure Key Vault.
- **Retry / circuit-breaker strategy**: Implémentation via Polly pour les appels vers Key Vault et l'Email Service. ❓
- **Data consistency model**: Cohérence forte (Strong Consistency) via SQL Server/PostgreSQL.

---

## Observability

- **Logging**: Centralisé via Serilog. Logs système et logs d'audit stockés en base de données.
- **Metrics**: Health Checks intégrés pour surveiller la disponibilité des dépendances (DB, Vault).
- **Distributed tracing**: Non implémenté explicitement, mais possible via Application Insights. ❓

---

## Deployment

- **Deployment strategy**: Blue-Green deployment via Docker.
- **CI/CD approach**: Pipeline GitHub Actions pour le build, test et déploiement.
- **Environment matrix**: Development, Staging, Production.

---

## Constraints

- <CON-01>: Compatibilité stricte avec les standards OIDC.

---

## Risks

- <RISK-01>: Dépendance critique au STS.
  - Likelihood: Low
  - Impact: High
  - Mitigation: Cluster STS et DB répliquée.

---

## Assumptions

- <ASM-01>: Communication HTTPS sécurisée.
  - Consequence if wrong: Vulnérabilité MitM.

---

## Open Questions

- <OQ-41>: Quelle est la stratégie de backup et de restauration des données d'identité ? ❓

---