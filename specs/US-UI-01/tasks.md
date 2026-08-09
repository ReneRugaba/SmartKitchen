<!-- 
INSTRUCTIONS:
- Tasks must be atomic and testable
- Each task must link to a requirement or acceptance criterion
- Format: Description -> Actions -> Success Criterion
-->

# Tâches d'Implémentation
## US-UI-01 - Modernisation du layout de connexion multi-device

### Version
1.1

### Statut
Approved

### Référence
[US-UI-01](../../backlog/US-UI-01-modernisation-login.md)

---

# Phase 1 : Préparation
- [ ] **T-01 : Audit des Assets**
    - **Action** : Vérifier la présence de `f2b3193647d82c98bb785a6637a1a5b04b79a501.png`, `skoruba-icon.svg` et des vecteurs SVG.
    - **Succès** : Tous les fichiers sont accessibles via les chemins `wwwroot`.
- [ ] **T-02 : Validation Pipeline CSS**
    - **Action** : Exécuter `npm run build:css`.
    - **Succès** : `app.css` est généré sans erreur.

# Phase 2 : Layout `_AuthLayout.cshtml`
- [ ] **T-03 : Création du fichier Layout**
    - **Action** : Créer `src/MyProject.STS.Identity/Views/Shared/_AuthLayout.cshtml`.
    - **Succès** : Fichier créé et reconnu par Razor.
- [ ] **T-04 : Structure HTML de base**
    - **Action** : Implémenter `<head>`, `<body>` et `@RenderBody()`.
    - **Succès** : Le layout rend le contenu des vues.
- [ ] **T-05 : Implémentation Responsive**
    - **Action** : Créer le conteneur Grid/Flex avec breakpoints `md` et `lg`.
    - **Succès** : Basculement automatique Single-Column → Split-Screen.
- [ ] **T-06 : Zone Visuelle**
    - **Action** : Intégrer l'image de fond et l'overlay dégradé.
    - **Succès** : Rendu visuel conforme au design Figma.

# Phase 3 : Vues d'Authentification
- [ ] **T-07 : Migration Login**
    - **Action** : Basculer `Login.cshtml` vers `_AuthLayout` et refondre le formulaire.
    - **Succès** : Page de connexion conforme au design.
- [ ] **T-08 : Migration Register**
    - **Action** : Basculer `Register.cshtml` vers `_AuthLayout` et refondre le formulaire.
    - **Succès** : Page d'inscription conforme au design.
- [ ] **T-09 : Migration Vues Secondaires**
    - **Action** : Basculer `ForgotPassword`, `ResetPassword` et `ExternalLoginConfirmation` vers `_AuthLayout`.
    - **Succès** : Cohérence visuelle sur tout le parcours.
- [ ] **T-10 : Intégration Graphique**
    - **Action** : Positionner le logo et les vecteurs décoratifs.
    - **Succès** : Assets positionnés selon la maquette.

# Phase 4 : Validation
- [ ] **T-11 : Build CSS Final**
    - **Action** : Lancer `npm run build:css`.
    - **Succès** : Styles appliqués correctement.
- [ ] **T-12 : Recette Visuelle Multi-Device**
    - **Action** : Tester sur Desktop, Tablette et Mobile.
    - **Succès** : Aucun débordement, alignements corrects.
- [ ] **T-13 : Test Fonctionnel**
    - **Action** : Effectuer un cycle complet de connexion/inscription.
    - **Succès** : Aucun bug fonctionnel introduit.

---

# Phase 2 - Création du Layout d'Authentification

## T-003 - Création du Layout Dédié

### Description

Créer un layout d'authentification indépendant du layout administratif.

### Fichier

```text
Views/Shared/_AuthLayout.cshtml
```

### Critère de succès

- Le layout est créé.
- Le layout est compilable.

【1-ba9ac1】

---

## T-004 - Construction de la Structure HTML

### Description

Mettre en place la structure Razor standard du layout.

### Éléments attendus

- `<html>`
- `<head>`
- `<body>`
- Référencement de `app.css`
- `@RenderBody()`

### Critère de succès

- Le layout s'affiche correctement.
- Le contenu des vues est rendu.

【1-ba9ac1】

---

## T-005 - Implémentation de la Structure Responsive

### Description

Développer une structure responsive compatible :

- Mobile
- Tablette
- Desktop

### Comportements attendus

#### Mobile

```text
Single Column
```

#### Tablette

```text
Split-Screen Adapté
```

#### Desktop

```text
Split-Screen
```

### Critère de succès

- Le changement de mise en page est automatique selon les breakpoints Tailwind.

【1-ba9ac1】

---

## T-006 - Mise en Place du Panneau Visuel

### Description

Intégrer la zone visuelle de gauche.

### Éléments concernés

- image de fond ;
- overlay dégradé ;
- décorations SVG ;
- panneaux d'information éventuels.

### Critère de succès

- Le visuel est correctement affiché.
- Le dégradé est appliqué.

【1-ba9ac1】

---

# Phase 3 - Adaptation des Écrans d'Authentification

## T-007 - Migration de la Vue Login

### Description

Configurer la vue Login pour utiliser le nouveau layout.

### Fichier

```text
Views/Account/Login.cshtml
```

### Critère de succès

- La vue utilise `_AuthLayout`.

【1-ba9ac1】

---

## T-008 - Refonte du Formulaire de Connexion

### Description

Adapter la structure HTML et les styles de l'écran de connexion selon la maquette.

### Actions

- Réorganisation des champs.
- Mise à jour des espacements.
- Mise à jour des composants visuels.
- Application des classes Tailwind.

### Critère de succès

- Conformité visuelle avec le design cible.

【1-ba9ac1】

---

## T-009 - Intégration du Logo

### Description

Ajouter le logo dans le panneau d'authentification.

### Asset

```text
wwwroot/images/skoruba-icon.svg
```

### Critère de succès

- Le logo est visible au-dessus du formulaire.

【1-ba9ac1】

---

## T-010 - Migration de la Vue Register

### Description

Configurer la vue Register pour utiliser le nouveau layout.

### Fichier

```text
Views/Account/Register.cshtml
```

### Critère de succès

- La vue utilise `_AuthLayout`.

【1-ba9ac1】

---

## T-011 - Refonte du Formulaire d'Inscription

### Description

Adapter l'écran d'inscription au nouveau design.

### Actions

- Réorganisation du formulaire.
- Mise en place du responsive.
- Application des styles Tailwind.

### Critère de succès

- L'écran est conforme à la maquette.

【1-ba9ac1】

---

## T-012 - Intégration des Éléments Décoratifs

### Description

Ajouter les éléments décoratifs de la charte graphique.

### Assets

```text
wwwroot/icons/vector.svg
wwwroot/icons/vector2.svg
wwwroot/icons/vector-5.svg
```

### Écrans concernés

- Login
- Register
- Forgot Password
- Reset Password

### Critère de succès

- Les décorations sont visibles et correctement positionnées.

【1-ba9ac1】

---

# Phase 4 - Extension des Écrans d'Authentification

## T-013 - Adaptation de Forgot Password

### Description

Appliquer le nouveau layout à l'écran de récupération de mot de passe.

### Fichier

```text
Views/Account/ForgotPassword.cshtml
```

### Critère de succès

- L'écran utilise le nouveau design.

---

## T-014 - Adaptation de Reset Password

### Description

Appliquer le nouveau layout à l'écran de réinitialisation du mot de passe.

### Fichier

```text
Views/Account/ResetPassword.cshtml
```

### Critère de succès

- L'écran utilise le nouveau design.

---

## T-015 - Adaptation de External Login Confirmation

### Description

Uniformiser l'expérience graphique des inscriptions via fournisseurs externes.

### Fichier

```text
Views/Account/ExternalLoginConfirmation.cshtml
```

### Critère de succès

- Cohérence graphique avec les autres écrans.

---

# Phase 5 - Génération des Styles

## T-016 - Génération du CSS Final

### Description

Compiler les styles Tailwind utilisés par les nouvelles vues.

### Commande

```bash
npm run build:css
```

### Critère de succès

```text
wwwroot/css/app.css
```

est généré sans erreur.

【1-ba9ac1】

---

# Phase 6 - Validation Technique

## T-017 - Validation du Build Applicatif

### Description

Vérifier que la solution compile correctement.

### Commande

```bash
dotnet build
```

### Critère de succès

- Aucune erreur de compilation.

---

## T-018 - Validation du Responsive

### Description

Vérifier le rendu sur l'ensemble des formats supportés.

### Vérifications

#### Desktop

- Split-Screen correct

#### Tablette

- Split-Screen adapté

#### Mobile

- Single Column

### Critère de succès

- Affichage conforme sur chaque résolution.

【1-ba9ac1】

---

## T-019 - Contrôle des Débordements

### Description

Vérifier l'absence de débordement 