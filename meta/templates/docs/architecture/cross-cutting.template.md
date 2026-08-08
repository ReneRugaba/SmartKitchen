<!--
OUTPUT FILE: docs/01_model/architecture/cross-cutting.md
INSTRUCTIONS:
- Every answer must be grounded in the ASRs and constraints — do not invent
- Mark anything unresolved with ❓ and add it to Open Questions
- This file is transversal: it applies to ALL containers
- Do not repeat container-specific decisions here — reference containers/<name>/component.md
-->

# Cross-Cutting Concerns: <System Name>

> Part of: [Architecture Index](index.md)
> Applies across all containers.
> Grounded in: docs/03_decide/asr/ and docs/02_analyse/constraints.md

## Status
Draft | Review | Approved

---

## Security

- Authentication:
- Authorization:
- Data in transit:
- Data at rest:
- Secrets management:
- Input validation: ❓

---

## Performance

- Expected load:
- SLOs (latency p99, availability %):
- Critical paths:
- Caching strategy: ❓

---

## Scalability

- Horizontal scaling approach:
- Known bottlenecks: ❓
- Data growth projection:

---

## Resilience

- Key failure modes:
- Retry / circuit-breaker strategy: ❓
- Data consistency model: ❓

---

## Observability

- Logging:
- Metrics:
- Distributed tracing: ❓

---

## Deployment

- Deployment strategy:
- CI/CD approach:
- Environment matrix:

---

## Constraints

- \<CON-01\>:
- \<CON-02\>:

---

## Risks

- \<RISK-01\>:
  - Likelihood:
  - Impact:
  - Mitigation:

---

## Assumptions

- \<ASM-01\>:
  - Consequence if wrong:

---

## Open Questions

- \<OQ-01\>:

---

## Links

→ [Context](context.md)
→ [Containers](containers.md)
→ [Index](index.md)
→ [ASRs](../../../03_decide/asr/)
→ [Constraints](../../../02_analyse/constraints.md)
