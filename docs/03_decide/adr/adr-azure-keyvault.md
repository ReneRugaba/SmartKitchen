# ADR: Gestion des Secrets via Azure Key Vault

## Status
Accepted

---

## Context

Le système manipule des secrets critiques (clés de signature de tokens, secrets de clients, chaînes de connexion DB). Le stockage de ces secrets dans des fichiers de configuration (`appsettings.json`) en production est une faille de sécurité majeure.

References:
- docs/01_model/architecture/context.md
- docs/02_analyse/constraints.md (CON-07)

---

## Decision

Utiliser **Azure Key Vault** comme coffre-fort centralisé pour tous les secrets de production.

---

## Options Considered

### Option A: Fichiers de configuration chiffrés
- Description: Chiffrer les sections sensibles des fichiers JSON.
- Pros: Simple, pas de dépendance externe.
- Cons: Gestion complexe des clés de déchiffrement, rotation difficile.

### Option B: Azure Key Vault
- Description: Externaliser les secrets dans un service managé Azure.
- Pros: Sécurité maximale, rotation automatique, audit des accès, gestion centralisée.
- Cons: Dépendance au cloud Azure, latence réseau minime.

---

## Rationale

La sécurité est la priorité absolue pour un IdP. Azure Key Vault offre des garanties de sécurité et de gestion du cycle de vie des secrets bien supérieures à tout stockage local, tout en s'intégrant nativement avec .NET Core.

---

## Consequences

### Positive
- Suppression des secrets en clair dans le code et la config.
- Rotation simplifiée des secrets.
- Audit complet des accès aux secrets.

### Negative
- Dépendance à la connectivité Azure.
- Configuration initiale plus complexe (Managed Identity).

### Risks Introduced
- Indisponibilité du service Key Vault bloquant le démarrage du STS (RSK-03).

---

## Impact

### Affected Components
- STS Identity
- Admin API

### Affected Domain
- Infrastructure et Sécurité.

### Backlog Impact
- Configuration de l'identité managée Azure.
- Intégration du provider Key Vault dans la configuration .NET.

---

## Links

- Related ASRs: N/A
- Related Architecture Docs: [cross-cutting.md](../../architecture/cross-cutting.md)