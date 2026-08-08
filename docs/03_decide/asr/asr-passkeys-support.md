# ASR: Support des Passkeys (WebAuthn)

## Status
Proposed

---

## Requirement

Le système doit permettre aux utilisateurs de s'authentifier via des Passkeys pour renforcer la sécurité et améliorer l'expérience utilisateur.

- Support du standard WebAuthn.
- Possibilité d'enregistrer plusieurs clés par utilisateur.

---

## Type

Functional

---

## Motivation

- **Business value**: Modernisation de l'accès et réduction de la dépendance aux mots de passe.
- **Technical necessity**: Alignement avec les standards de sécurité modernes.

---

## Context

- docs/01_model/domain/entities/passkey/entity.md
- docs/02_analyse/constraints.md (CON-05)

---

## Constraints

- **Technology constraints**: Nécessite un navigateur compatible WebAuthn et un dispositif d'authentification physique ou biométrique.

---

## Impact

### Architecture Impact
- Ajout de flux d'authentification spécifiques dans le STS.

### Components Impacted
- STS Identity (Identity Services, Controllers)

### Data Impact
- Création d'une table dédiée pour stocker les clés publiques et les identifiants de clés.

---

## Quality Attributes (if applicable)

- Security: High
- Maintainability: Medium

---

## Risks

- Complexité du flux de récupération de compte en cas de perte totale des passkeys.

---

## Dependencies

- Depends on: Support navigateur.
- Blocks: Finalisation du flux d'inscription.

---

## Priority

High