# Ubiquitous Language: SmartKitchenIdp

> This vocabulary is the single source of truth for all domain terminology.
> Every team member, document, and line of code must use these exact terms.

---

## Glossary

| Term | Definition | Notes |
|------|------------|-------|
| **STS (Security Token Service)** | Serveur central responsable de l'authentification des utilisateurs et de l'émission de jetons de sécurité (tokens). | |
| **Application Cliente** | Application logicielle enregistrée auprès du STS et autorisée à demander des jetons d'accès pour agir au nom d'un utilisateur. | |
| **Utilisateur** | Personne physique possédant un compte d'identité et pouvant s'authentifier auprès du STS. | |
| **Rôle** | Groupe de permissions assigné à un utilisateur pour définir son niveau d'accès dans le système. | |
| **Scope (Portée)** | Définition d'une ressource ou d'une fonctionnalité spécifique que l'application cliente demande d'accéder. | |
| **Passkey** | Clé cryptographique sécurisée permettant une authentification forte sans mot de passe. | |
| **Jeton (Token)** | Preuve numérique d'authentification ou d'autorisation (ID Token, Access Token) émise par le STS. | |
| **Grant (Octroi)** | Méthode ou flux spécifique utilisé pour obtenir un jeton (ex: Code d'autorisation). | |
| **Log d'Audit** | Enregistrement chronologique et immuable des modifications de configuration et des actions administratives. | |
| **Consentement** | Action par laquelle l'utilisateur autorise explicitement une application cliente à accéder à certaines de ses données (scopes). | |

---

## Open Questions

- Aucun pour le moment.

---

## Links

→ [index.md](index.md)