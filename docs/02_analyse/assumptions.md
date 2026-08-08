# Assumptions: SmartKitchenIdp

> Part of: [Analysis](.)
> These are beliefs held during design. Each must be validated or invalidated.

---

## Assumptions

| ID | Assumption | Domain / Area | Consequence if wrong | Status |
|----|------------|---------------|----------------------|--------|
| ASM-01 | Le réseau entre les clients et le STS est sécurisé via HTTPS | Infrastructure | Vulnérabilité aux attaques MitM. | Open |
| ASM-02 | Azure Key Vault est disponible avec un SLA garanti | Infrastructure | Indisponibilité du STS lors du démarrage. | Open |
| ASM-03 | Les administrateurs possèdent les compétences pour gérer l'UI Admin | Organisationnel | Erreurs de configuration et risques de sécurité. | Open |
| ASM-04 | Le volume de logs d'audit est gérable par une base de données relationnelle | Performance | Saturation du stockage et ralentissement des requêtes. | Open |

---

## Open Questions

- <OQ-43>: L'hypothèse ASM-04 est-elle validée par un test de charge ? ❓

---

## Links

→ [Constraints](constraints.md)
→ [Risks](risks.md)
→ [Context](../00_brainstorm/context.md)