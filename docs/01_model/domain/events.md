# Domain Events: SmartKitchenIdp

> Part of: [Domain Index](index.md)
> Events are business facts — something that happened and cannot be undone.

---

## Event: UserAuthenticated

- Trigger: [Use Case: Authentification](logic.md#use-case-authentification)
- Emitted by entity: [Utilisateur](entities/utilisateur/entity.md)
- Description: Un utilisateur a réussi à s'authentifier auprès du STS.
- Payload:
  - UserId: Identifiant de l'utilisateur.
  - AuthenticationMethod: Méthode utilisée (Password, Passkey, External).
  - Timestamp: Date et heure de l'événement.
- Downstream impact:
  - Mise à jour de la date de dernière connexion.
  - Émission des jetons d'accès.

---

## Event: PasskeyRegistered

- Trigger: [Use Case: Enregistrement de Passkey](entities/passkey/logic.md#use-case-enregistrement-de-passkey)
- Emitted by entity: [Passkey](entities/passkey/entity.md)
- Description: Une nouvelle clé de sécurité a été liée au compte de l'utilisateur.
- Payload:
  - UserId: Identifiant de l'utilisateur.
  - PasskeyId: Identifiant de la clé.
- Downstream impact:
  - Notification de sécurité envoyée à l'utilisateur.

---

## Event: ClientRegistered

- Trigger: [Use Case: Enregistrement de Client](entities/application-cliente/logic.md#use-case-enregistrement-de-client)
- Emitted by entity: [Application Cliente](entities/application-cliente/entity.md)
- Description: Une nouvelle application a été autorisée à utiliser le STS.
- Payload:
  - ClientId: Identifiant du client.
  - ClientName: Nom de l'application.
- Downstream impact:
  - Mise à jour des caches de configuration du STS.

---

## Event: AllGrantsRevoked

- Trigger: [Workflow: Révocation de Sécurité Globale](logic.md#workflow-révocation-de-sécurité-globale)
- Emitted by entity: [Grant](entities/grant/entity.md)
- Description: Tous les jetons de rafraîchissement d'un utilisateur ont été invalidés.
- Payload:
  - UserId: Identifiant de l'utilisateur.
  - Reason: Motif de la révocation (ex: PasswordChange, SecurityBreach).
- Downstream impact:
  - Déconnexion forcée de l'utilisateur sur toutes les applications clientes.

---

## Event: ResourceAccessed

- Trigger: [Use Case: Accès aux Ressources API](logic.md#use-case-accès-aux-ressources-api)
- Emitted by entity: [Grant](entities/grant/entity.md)
- Description: Une ressource protégée a été accédée via un jeton valide.
- Payload:
  - UserId: Identifiant de l'utilisateur.
  - ClientId: Identifiant du client.
  - Scope: Scope utilisé pour l'accès.
- Downstream impact:
  - Alimentation des logs d'audit et statistiques d'utilisation.

---

## Open Questions

- <OQ-35>: Doit-on émettre un événement pour chaque modification de claim ? ❓

---

## Links

→ [Logic](logic.md)
→ [Index](index.md)