# Risks: SmartKitchenIdp

> Part of: [Analysis](.)
> Uncertain events that could negatively impact the project.

---

## Risks

| ID | Risk | Category | Likelihood | Impact | Mitigation | Linked to |
|----|------|----------|------------|--------|------------|-----------|
| RSK-01 | Panne totale du STS bloquant tout l'écosystème | Technical | Low | High | Cluster STS et DB répliquée. | CON-04 |
| RSK-02 | Compromission d'un secret de client confidentiel | Technical | Med | High | Rotation régulière des secrets et monitoring. | CON-01 |
| RSK-03 | Indisponibilité d'Azure Key Vault empêchant le boot | Technical | Low | High | Stratégie de fallback ou cache local sécurisé. | ASM-02 |
| RSK-04 | Non-conformité RGPD sur la gestion des logs d'audit | Regulatory | Med | Med | Mise en œuvre d'une politique de purge et d'anonymisation. | CON-06 |
| RSK-05 | Latence excessive lors de la validation des tokens | Performance | Med | Med | Optimisation des index DB et cache en mémoire. | ASM-04 |

---

## Categories

- **Technical**: architecture, scalability, third-party dependencies, security
- **Business**: scope, stakeholder alignment, market changes
- **Organizational**: team, timeline, budget

---

## Open Questions

- <OQ-44>: Quelle est la stratégie de mitigation exacte pour RSK-03 ? ❓

---

## Links

→ [Assumptions](assumptions.md)
→ [Constraints](constraints.md)
→ [Tradeoffs](tradeoffs.md)
→ [ADRs](../03_decide/adr/)