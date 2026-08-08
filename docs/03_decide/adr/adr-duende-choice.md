# ADR: Choix de Duende IdentityServer

## Status
Accepted

---

## Context

Le projet nécessite la mise en place d'un serveur d'identité robuste, conforme aux standards OIDC et OAuth2, capable de gérer des clients complexes et des utilisateurs avec des rôles et des claims.

References:
- docs/00_brainstorm/context.md
- docs/02_analyse/constraints.md (CON-01)

---

## Decision

Utiliser **Duende IdentityServer** comme moteur central du STS.

---

## Options Considered

### Option A: Développement d'un STS maison
- Description: Implémenter les protocoles OIDC/OAuth2 à partir de zéro.
- Pros: Contrôle total, pas de coût de licence.
- Cons: Risque de sécurité majeur, temps de développement prohibitif, maintenance complexe.

### Option B: Utilisation de Duende IdentityServer
- Description: Intégrer le framework Duende dans une application .NET Core.
- Pros: Conformité standards garantie, rapidité de mise en œuvre, support professionnel.
- Cons: Coût de licence, dépendance au framework.

---

## Rationale

Le risque associé au développement d'un serveur de tokens maison est jugé inacceptable pour un système d'identité. Duende fournit une implémentation éprouvée et sécurisée, permettant à l'équipe de se concentrer sur la logique métier (Passkeys, Administration) plutôt que sur la plomberie du protocole.

---

## Consequences

### Positive
- Mise sur le marché rapide.
- Sécurité accrue grâce à un framework audité.
- Interopérabilité totale avec les clients standards.

### Negative
- Coût financier lié à la licence.
- Courbe d'apprentissage pour la configuration avancée du framework.

### Risks Introduced
- Dépendance forte envers l'éditeur (Vendor Lock-in).

---

## Impact

### Affected Components
- STS Identity

### Affected Domain
- Tout le domaine de l'authentification et de l'autorisation.

### Backlog Impact
- Configuration des endpoints OIDC.
- Mise en place du stockage des configurations.

---

## Links

- Related ASRs: [asr-high-availability.md](../asr/asr-high-availability.md)