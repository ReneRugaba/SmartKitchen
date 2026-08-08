# Tradeoffs: SmartKitchenIdp

> Part of: [Analysis](.)
> Deliberate design choices where one quality is sacrificed for another.

---

## Tradeoffs

| ID | Decision | Gained | Sacrificed | Justification | Linked to |
|----|----------|--------|------------|---------------|-----------|
| TRD-01 | Utilisation de Duende IdentityServer | Rapidité de mise en œuvre, conformité standards OIDC/OAuth2. | Indépendance technologique, coût de licence. | Le coût du développement d'un STS maison est prohibitif et risqué. | CON-01 |
| TRD-02 | Stockage des logs d'audit en base de données relationnelle | Facilité de requête, cohérence transactionnelle avec les données. | Performance d'écriture à très haute échelle. | Le volume d'actions administratives est faible comparé aux flux de tokens. | ASM-04 |
| TRD-03 | Centralisation des secrets dans Azure Key Vault | Sécurité maximale, gestion centralisée des clés. | Dépendance à un fournisseur cloud (Vendor Lock-in). | Exigence de sécurité critique pour un IdP. | CON-07 |

---

## Open Questions

- <OQ-46>: Faut-il envisager un cache distribué (Redis) pour les sessions malgré la complexité ajoutée ? ❓

---

## Links

→ [Constraints](constraints.md)
→ [Risks](risks.md)
→ [ADRs](../03_decide/adr/)
→ [ASRs](../03_decide/asr/)