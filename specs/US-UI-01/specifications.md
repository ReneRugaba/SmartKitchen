<!-- 
INSTRUCTIONS:
- Be concise and precise
- Do not invent missing information
- Explicitly state uncertainties
- Prefer bullet points
- Every technical choice must be traceable to the US or Figma
-->

# Spécifications Techniques
## US-UI-01 - Modernisation du layout de connexion multi-device

### Version
1.1

### Statut
Approved

### Solution concernée
Skoruba Duende IdentityServer

---

# 1. Contexte

L'application utilise Skoruba Duende IdentityServer comme fournisseur d'identité centralisé. Les écrans publics d'authentification doivent être modernisés pour offrir une expérience utilisateur responsive, accessible et cohérente sur Desktop, Tablette et Mobile.

Cette évolution concerne exclusivement la couche de présentation. Elle ne doit entraîner aucune modification des mécanismes de sécurité, d'authentification ou d'autorisation fournis par ASP.NET Core Identity et Duende IdentityServer.

---

# 2. Objectifs

## 2.1 Objectifs métiers
- **Modernisation** : Aligner l'interface sur l'identité visuelle actuelle de SmartKitchen.
- **Expérience Mobile** : Optimiser le parcours de connexion sur smartphone et tablette.
- **Cohérence** : Uniformiser le design entre Login, Register et les flux de récupération de mot de passe.
- **Efficacité** : Réduire la charge cognitive via un layout épuré.

## 2.2 Objectifs techniques
- **Isolation** : Créer un layout dédié (`_AuthLayout.cshtml`) pour supprimer les éléments globaux (header/footer).
- **Styling** : Utiliser exclusivement Tailwind CSS via la pipeline existante.
- **Responsive** : Implémenter un basculement automatique Split-Screen → Single-Column.
- **Intégrité** : Préserver les contrats et la logique native de Duende IdentityServer.

---

# 3. Périmètre

## 3.1 Inclus
### Vues concernées
- `Login.cshtml`
- `Register.cshtml`
- `ForgotPassword.cshtml`
- `ResetPassword.cshtml`
- `ExternalLoginConfirmation.cshtml`

### Éléments techniques
- Nouveau Layout d'authentification.
- Stratégie responsive (Breakpoints Tailwind).
- Intégration des assets graphiques (PNG/SVG).
- Refonte structurelle des formulaires.

## 3.2 Exclus
- Administration Skoruba et gestion des clients/rôles.
- Logique métier, contrôleurs et services.
- Écrans de consentement.

---

# 4. Architecture Cible

## 4.1 Layout dédié : `_AuthLayout.cshtml`
Un layout spécifique est créé pour isoler l'expérience d'authentification.

**Emplacement :** `src/MyProject.STS.Identity/Views/Shared/_AuthLayout.cshtml`

**Responsabilités :**
- Fournir la structure HTML de base (Head, Body).
- Gérer le conteneur responsive principal.
- Héberger la zone visuelle commune.
- Rendre le contenu des vues via `@RenderBody()`.

**Contraintes :**
- Exclusion stricte du header et footer globaux.
- Dépendance unique au fichier `wwwroot/css/app.css`.

## 4.2 Stratégie Responsive
L'interface s'adapte selon les breakpoints Tailwind CSS :

| Device | Breakpoint | Composition | Comportement |
| :--- | :--- | :--- | :--- |
| **Mobile** | `< md` | Single-Column | Formulaire centré, visuels simplifiés. |
| **Tablette** | `md` to `lg` | Split-Screen adapté | Proportions ajustées, visuel et formulaire côte à côte. |
| **Desktop** | `lg` | Split-Screen | Zone visuelle (gauche) et formulaire (droite) équilibrés. |

---

# 5. Intégration Visuelle et Assets

## 5.1 Assets Principaux
- **Visuel Principal** : `wwwroot/images/f2b3193647d82c98bb785a6637a1a5b04b79a501.png`
    - Application d'un overlay dégradé via Tailwind.
- **Logo** : `wwwroot/images/skoruba-icon.svg`
    - Positionné en tête du formulaire.

## 5.2 Éléments Décoratifs
- `wwwroot/icons/vector.svg`
- `wwwroot/icons/vector2.svg`
- `wwwroot/icons/vector-5.svg`

---

# 6. Traçabilité
- **US Source** : [US-UI-01 — Modernisation du layout de connexion multi-device](../../backlog/US-UI-01-modernisation-login.md)
- **Design Figma** : ColdMind Design — Node `78-8`

---

# 5. Responsive Design

## 5.1 Principe général

La conception doit suivre une approche Mobile First basée sur les breakpoints standards de Tailwind CSS. 【1-47bc8a】【2-45705b】

---

## 5.2 Mobile

### Breakpoint

```text
< 768px
```

### Comportement attendu

- Affichage en colonne unique.
- Formulaire centré horizontalement.
- Priorité donnée au contenu fonctionnel.
- Réduction des éléments visuels secondaires.
- Largeur maximale adaptée aux smartphones.

### Schéma

```text
+------------------+
|      Logo        |
|                  |
|    Formulaire    |
|                  |
| Actions annexes  |
+------------------+
```

---

## 5.3 Tablette

### Breakpoint

```text
768px à 1024px
```

### Comportement attendu

- Mise en page Split-Screen adaptée.
- Priorité visuelle accordée au formulaire.
- Réorganisation automatique des espacements.
- Conservation de la visibilité de l'image de présentation.

### Schéma

```text
+--------------------------------+
| Image      |     Formulaire    |
|             |                  |
+--------------------------------+
```

---

## 5.4 Desktop

### Breakpoint

```text
> 1024px
```

### Comportement attendu

- Affichage plein écran.
- Répartition équilibrée des colonnes.
- Valorisation de l'identité visuelle.
- Optimisation de la lisibilité.

### Schéma

```text
+--------------------------------------------------+
|                  |                               |
|  Visuel          |      Formulaire               |
|                  |                               |
|      50%         |          50%                  |
+--------------------------------------------------+
```

---

# 6. Structure Visuelle

## 6.1 Panneau Visuel

Le panneau visuel est situé à gauche en mode Desktop et Tablette.

### Contenu

- Image principale.
- Overlay dégradé.
- Éléments décoratifs.
- Messages institutionnels éventuels.

### Image principale

```text
wwwroot/images/auth-background.png
```

### Overlay

Un overlay dégradé doit être appliqué au-dessus de l'image afin :

- d'améliorer la lisibilité ;
- d'harmoniser l'identité graphique ;
- de renforcer la profondeur visuelle.

---

## 6.2 Panneau Authentification

Le panneau d'authentification est situé à droite en mode Desktop et Tablette.

### Contenu

- Logo.
- Titre de page.
- Sous-titre.
- Formulaire.
- Actions secondaires.

### Logo

```text
wwwroot/images/skoruba-icon.svg
```

Le logo doit apparaître dans la partie supérieure du formulaire. 【1-47bc8a】【2-45705b】

---

# 7. Gestion des Assets

## Assets principaux

### Images

```text
wwwroot/images/auth-background.png
wwwroot/images/skoruba-icon.svg
```

### Éléments décoratifs

```text
wwwroot/icons/vector.svg
wwwroot/icons/vector2.svg
wwwroot/icons/vector-5.svg
```

### Contraintes

Les assets doivent :

- être optimisés pour le web ;
- être responsive ;
- supporter les écrans HD ;
- conserver une qualité visuelle constante.

---

# 8. Framework de Style

## Technologie retenue

```text
Tailwind CSS
```

## Génération du CSS

```bash
npm run build:css
```

## Fichier généré

```text
wwwroot/css/app.css
```

## Règles d'implémentation

- Les styles doivent être réalisés principalement via les classes utilitaires Tailwind.
- Les styles 