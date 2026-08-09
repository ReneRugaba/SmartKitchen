<!-- 
INSTRUCTIONS:
- Sequence must be logical (Infrastructure -> Layout -> Views -> Validation)
- Each phase must have a clear objective and deliverable
- No code implementation in this file
-->

# Plan d'Implémentation
## US-UI-01 - Modernisation du layout de connexion multi-device

### Version
1.1

### Statut
Approved

### Référence
[US-UI-01](../../backlog/US-UI-01-modernisation-login.md)

---

# 1. Objectif du Plan

Ce document définit la séquence d'exécution pour moderniser les écrans d'authentification. L'approche privilégie la stabilité en isolant d'abord la structure (Layout) avant de refondre les contenus (Vues).

---

# 2. Prérequis

## 2.1 Techniques
- Environnement de développement .NET opérationnel.
- Node.js et NPM installés.
- Pipeline Tailwind CSS configurée.

## 2.2 Fonctionnels
- Assets graphiques validés et présents dans `wwwroot`.
- Spécifications techniques approuvées.

---

# 3. Séquence d'Exécution

## Phase 1 : Préparation et Assets
**Objectif** : Garantir que toutes les ressources sont disponibles.
- Vérification des chemins d'accès aux images et SVG.
- Validation du build CSS initial (`npm run build:css`).
- **Livrable** : Inventaire des assets validé.

## Phase 2 : Infrastructure Layout
**Objectif** : Créer le cadre responsive sans impacter les vues.
- Implémentation de `_AuthLayout.cshtml`.
- Mise en place de la structure HTML et des liens CSS.
- Développement du conteneur responsive (Split-Screen / Single-Column).
- Intégration de la zone visuelle et de l'overlay dégradé.
- **Livrable** : Layout d'authentification fonctionnel.

## Phase 3 : Refonte des Vues
**Objectif** : Adapter les formulaires au nouveau design.
- Migration de `Login.cshtml` et `Register.cshtml` vers `_AuthLayout`.
- Refonte structurelle des formulaires (Tailwind).
- Intégration du logo et des éléments décoratifs.
- Adaptation des vues secondaires (`ForgotPassword`, `ResetPassword`, `ExternalLoginConfirmation`).
- **Livrable** : Vues d'authentification modernisées.

## Phase 4 : Compilation et Validation
**Objectif** : Assurer la conformité visuelle et technique.
- Génération finale du CSS via `npm run build:css`.
- Tests de rendu sur Desktop, Tablette et Mobile.
- Vérification de l'absence de débordements horizontaux.
- Tests de non-régression sur le flux d'authentification.
- **Livrable** : Interface validée et conforme au design Figma.

---

# 4. Traçabilité
- **US Source** : [US-UI-01](../../backlog/US-UI-01-modernisation-login.md)
- **Specs** : [specifications.md](./specifications.md)

---

# 3. Phase 1 - Préparation des Assets

## Objectif

Vérifier la disponibilité de l'ensemble des fichiers graphiques nécessaires à l'implémentation.

## Actions

### Vérification des images

Contrôler la présence des fichiers :

```text
wwwroot/images/f2b3193647d82c98bb785a6637a1a5b04b79a501.png
wwwroot/images/skoruba-icon.svg
```

### Vérification des éléments décoratifs

Contrôler la présence des fichiers :

```text
wwwroot/icons/vector.svg
wwwroot/icons/vector2.svg
wwwroot/icons/vector-5.svg
```

### Vérification de la qualité

Vérifier :

- résolution adaptée ;
- transparence des SVG ;
- optimisation du poids ;
- compatibilité responsive.

## Livrable

Ensemble des assets validés.

【1-d397b7】【3-b0a1b0】

---

# 4. Phase 2 - Préparation de Tailwind CSS

## Objectif

Garantir la disponibilité du framework de style avant les développements UI.

## Actions

### Vérification de la configuration

Contrôler :

```text
tailwind.config.js
```

### Vérification du pipeline CSS

Exécuter :

```bash
npm install
```

Puis :

```bash
npm run build:css
```
