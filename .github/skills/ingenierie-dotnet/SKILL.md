---
name: ingenierie-dotnet
description: Principes d'ingénierie .NET/C#, DDD, SOLID, Clean Architecture (règles DEV et ARCH) et checklist qualité avant livraison. À charger par l'agent d'implémentation avant toute production de code.
---

# Skill — Ingénierie .NET

## Expertise technique

- .NET 8+ / C# 12
- ASP.NET Core
- Entity Framework Core / PostgreSQL
- DDD (Domain Driven Design)
- SOLID
- CQRS
- Clean Architecture / Architecture Hexagonale
- TDD / xUnit / Integration Testing
- Design Patterns / Clean Code

## Principes d'ingénierie (DEV)

**DEV-01 — Respecter SOLID**
Toute implémentation doit respecter SOLID.
*Violation : Classes multi-responsabilités ou couplage excessif.*

**DEV-02 — Respecter DDD**
Les règles métier appartiennent au domaine.
*Violation : Logique métier dans les Controllers ou l'Infrastructure.*

**DEV-03 — Préserver l'indépendance du domaine**
Le domaine ne dépend jamais d'ASP.NET, d'Entity Framework, ou de fournisseurs Cloud.
*Violation : Référencer un framework dans le domaine.*

**DEV-04 — Respecter Clean Architecture**
Les dépendances doivent pointer vers l'intérieur : `Domain` ← `Application` ← `Infrastructure` ← `Presentation`.
*Violation : Faire dépendre le domaine d'une couche externe.*

**DEV-05 — Appliquer YAGNI**
Implémenter uniquement le besoin actuellement documenté.
*Violation : Développer une fonctionnalité future hypothétique.*

**DEV-06 — Appliquer DRY**
Toute connaissance doit avoir une seule source.
*Violation : Dupliquer une logique métier ou technique.*

**DEV-07 — Appliquer KISS**
Choisir la solution la plus simple répondant au besoin.
*Violation : Introduire une complexité injustifiée.*

**DEV-08 — Favoriser la composition**
Privilégier la composition à l'héritage.
*Violation : Créer une hiérarchie uniquement pour partager du code.*

**DEV-09 — Écrire du code auto-documenté**
Utiliser des noms explicites. Les commentaires expliquent le pourquoi, jamais le quoi.
*Violation : Utiliser des noms ambigus ou des commentaires redondants.*

**DEV-10 — Garantir la testabilité**
Le code doit être découplé, injectable et testable.
*Violation : Introduire des dépendances difficiles à tester.*

**DEV-11 — Sécuriser par défaut**
Toujours considérer l'authentification, l'autorisation, la validation des entrées et la gestion des secrets.
*Violation : Ignorer un aspect de sécurité documenté.*

**DEV-12 — Architecture avant framework**
Le framework est un détail d'implémentation.
*Violation : Faire dépendre la conception métier d'un framework.*

**DEV-13 — Optimiser la lisibilité avant la performance**
Privilégier la clarté tant qu'aucune mesure ne justifie une optimisation.
*Violation : Complexifier le code sans preuve d'un problème de performance.*

**DEV-14 — Boy Scout Rule**
Laisser le code dans un état meilleur qu'à l'origine.
*Violation : Introduire volontairement de la dette technique.*

**DEV-15 — Réutiliser avant de créer**
Avant de créer un service, un repository, un handler, un composant ou une classe, vérifier qu'une implémentation équivalente n'existe pas déjà. Privilégier l'extension d'un composant existant lorsqu'elle respecte SOLID.
*Violation : Créer un nouveau composant alors qu'une implémentation appropriée existe déjà.*

**DEV-16 — Respecter les conventions du projet**
Le code généré doit suivre l'organisation des dossiers, les conventions de nommage, les conventions de tests et les conventions architecturales déjà présentes dans le repository.
*Violation : Introduire un style ou une structure différente de celle du projet.*

**DEV-17 — Lire avant d'écrire**
Avant toute modification : analyser le code existant, identifier les points d'extension et comprendre les dépendances impactées avant de proposer une solution.
*Violation : Réécrire une fonctionnalité sans analyse préalable.*

**DEV-18 — Minimiser l'impact**
Modifier le minimum de code nécessaire pour satisfaire le besoin. Éviter les refactorings opportunistes non demandés.
*Violation : Modifier plusieurs modules sans justification liée à la demande.*

**DEV-19 — Garantir la non-régression**
Toute implémentation doit identifier les tests unitaires à ajouter, les tests d'intégration à ajouter et les scénarios de régression impactés.
*Violation : Livrer une modification sans stratégie de validation.*

**DEV-20 — Aucun TODO permanent**
Ne jamais introduire de TODO, FIXME ou HACK sans ticket de traçabilité associé. Format obligatoire : `TODO[US-123]` ou `TODO[TASK-456]`.
*Violation : Introduire un TODO non traçable.*

## Clean Architecture (ARCH)

**ARCH-01 — Le domaine reste pur**
Le projet Domain ne doit contenir aucune référence à l'Infrastructure, Entity Framework, HTTP, Azure, PostgreSQL ou tout autre framework externe.
*Violation : Introduire une dépendance technique dans le domaine.*

**ARCH-02 — Les Use Cases appartiennent à Application**
Les règles d'orchestration métier doivent être implémentées dans la couche Application.
*Violation : Déplacer des cas d'usage dans Api ou Infrastructure.*

**ARCH-03 — Infrastructure est remplaçable**
Toute dépendance externe doit être abstraite derrière une interface.
*Violation : Coupler directement le domaine à un fournisseur technique.*

**ARCH-04 — Controllers minces**
Les Controllers doivent uniquement recevoir la requête, déléguer et retourner la réponse.
*Violation : Ajouter de la logique métier dans un Controller.*

## Auto-check obligatoire avant livraison

Avant de produire une implémentation, vérifier :

- [ ] Constitution respectée
- [ ] Sources Approved utilisées
- [ ] User Story identifiée
- [ ] Critères d'acceptation couverts
- [ ] Aucune règle métier inventée
- [ ] Aucune hypothèse non documentée
- [ ] SOLID respecté
- [ ] DDD respecté
- [ ] DRY respecté
- [ ] YAGNI respecté
- [ ] KISS respecté
- [ ] Tests identifiés
- [ ] Traçabilité documentée
- [ ] Aucun TODO non traçable
