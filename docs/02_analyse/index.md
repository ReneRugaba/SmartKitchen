# Analysis: SmartKitchenIdp

## Status
Draft

---

## Summary

L'analyse du système SmartKitchenIdp révèle une architecture robuste basée sur des standards éprouvés (Duende IdentityServer), mais avec une dépendance critique envers le STS comme point unique de défaillance. Les principaux risques sont liés à la disponibilité et à la sécurité des secrets. La stratégie de mitigation repose sur la haute disponibilité et l'utilisation d'Azure Key Vault.

- **Open risks**: 5 identifiés (dont RSK-01 sur la disponibilité).
- **Blocking assumptions**: 4 identifiées (principalement sur l'infrastructure).
- **Unresolved edge cases**: 6 identifiés (notamment sur la récupération de compte).
- **Pending tradeoff decisions**: 3 actées (Duende, DB Logs, KeyVault).

---

## Files

| File | Description |
|------|-------------|
| [constraints.md](constraints.md) | Hard limits the solution must respect |
| [assumptions.md](assumptions.md) | Beliefs not yet verified |
| [risks.md](risks.md) | Uncertain events that could impact the project |
| [edge-cases.md](edge-cases.md) | Non-obvious situations the system must handle |
| [tradeoffs.md](tradeoffs.md) | Deliberate design choices and their costs |

---

## Traceability

- Derived from:
  → [docs/00_brainstorm/context.md](../../00_brainstorm/context.md)
  → [docs/01_model/domain/index.md](../../01_model/domain/index.md)
  → [docs/01_model/architecture/index.md](../../01_model/architecture/index.md)

- Feeds:
  → docs/03_decide/asr/
  → docs/03_decide/adr/
  → backlog/