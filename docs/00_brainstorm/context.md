# Context: SmartKitchenIdp

## Status
Draft

---

## Problem

Le projet vise à fournir une solution d'identité centralisée (Identity Provider - IdP) pour l'écosystème SmartKitchen. Il s'agit de remplacer ou d'implémenter un système de gestion d'accès et d'authentification robuste basé sur les standards OpenID Connect et OAuth 2.0.

- **Situation actuelle** : Mise en place d'une infrastructure d'identité basée sur Duende IdentityServer.
- **Besoin** : Un système capable de gérer les utilisateurs, les rôles, les clients applicatifs et d'assurer la sécurité des échanges via des tokens.
- **Impact** : Toutes les applications de l'écosystème dépendant d'une authentification unique (SSO).

---

## Goals

- Fournir un serveur de tokens (STS) sécurisé et performant.
- Permettre l'administration complète du serveur d'identité (utilisateurs, clients, scopes) via une interface dédiée.
- Supporter des méthodes d'authentification modernes (dont les Passkeys).
- Assurer la traçabilité des actions via un système de logs d'audit.

---

## Non-Goals

- Le système ne gère pas la logique métier des applications clientes, uniquement leur authentification et autorisation.
- La gestion du hardware SmartKitchen n'est pas dans le périmètre de l'IdP.

---

## Scope

### In Scope
- Serveur de tokens (STS) basé sur Duende IdentityServer.
- API d'administration pour la configuration du STS.
- Interface utilisateur d'administration.
- Gestion des utilisateurs et des rôles (Identity).
- Support des Passkeys.
- Persistance des données via Entity Framework (PostgreSQL/SQL Server).

### Out of Scope
- Développement des applications clientes.
- Gestion du cycle de vie du matériel physique.

---

## Stakeholders

| Role | Responsibilities | Decision authority |
|------|-----------------|-------------------|
| Product Owner | Définition des besoins fonctionnels | Yes |
| Architecte | Choix techniques et structurels | Yes |
| Développeur | Implémentation et maintenance | No |

---

## Users

| Actor | Description | Primary need |
|-------|-------------|--------------|
| Administrateur | Gère la configuration du système et les accès | Configurer les clients et utilisateurs |
| Utilisateur Final | S'authentifie pour accéder aux services | Accès sécurisé et SSO |
| Application Cliente | Demande des tokens d'accès | Authentifier l'utilisateur et obtenir des permissions |

---

## System Environment

- **External systems and integrations**:
    - Bases de données (PostgreSQL / SQL Server).
    - Azure Key Vault (pour la gestion des secrets).
    - SendGrid / SMTP (pour l'envoi d'emails).
- **Infrastructure / deployment environment**: Docker avec Nginx comme reverse proxy.
- **Key dependencies**: Duende IdentityServer, .NET Core, Entity Framework Core.

---

## High-Level Use Cases

- **Administrateur** crée un nouveau client OAuth2 $\rightarrow$ système enregistre la configuration et permet l'authentification de l'app.
- **Utilisateur** s'authentifie via le STS $\rightarrow$ système émet un ID Token et un Access Token.
- **Utilisateur** configure un Passkey $\rightarrow$ système lie la clé cryptographique au compte utilisateur.
- **Administrateur** consulte les logs d'audit $\rightarrow$ système affiche l'historique des modifications de configuration.

---

## Initial Constraints

- **Technical**: Dépendance forte à l'écosystème Duende IdentityServer.
- **Business**: Nécessité d'un SSO fluide pour l'utilisateur.
- **Regulatory**: ❓ (À définir selon les normes RGPD ou autres).
- **Organizational**: ❓