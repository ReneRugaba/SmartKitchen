# US-UI-01 — Modernisation du layout de connexion multi-device

**Statut :** In Progress
**Priorité :** Haute
**Estimation :** À définir

---

## 1. User Story

**En tant qu’** utilisateur de SmartKitchen,
**je veux** disposer d’une interface de connexion moderne, cohérente et adaptée à mon appareil (Desktop, Tablette ou Mobile),
**afin de** bénéficier d’une expérience de connexion professionnelle, claire et visuellement cohérente avec l’identité de SmartKitchen.

---

## 2. Contexte

L’interface actuelle de connexion présente une identité visuelle limitée et ne propose pas une expérience suffisamment adaptée aux différents formats d’écran.

Cette US consiste à **moderniser exclusivement les écrans d’authentification**, en s’appuyant sur le design défini dans Figma et en conservant l’identité visuelle globale du projet.

Le nouveau design repose sur un principe **responsive multi-device** :

* **Desktop :** layout Split-Screen avec une zone visuelle et une zone dédiée au formulaire.
* **Tablette :** adaptation du Split-Screen avec des proportions et espacements ajustés à la taille de l’écran.
* **Mobile :** passage à un layout Single-Column optimisé pour les petits écrans.

Les différents layouts doivent conserver une **cohérence visuelle et fonctionnelle**, tout en étant optimisés pour leur format d'affichage.

La génération et l’application des styles CSS doivent s’appuyer sur la pipeline **Tailwind CSS** existante.

---

## 3. Périmètre fonctionnel

### 3.1 Desktop

Le layout `idp-login-desktop` doit présenter :

* une zone visuelle occupant la partie gauche de l’écran ;
* une zone d’authentification occupant la partie droite ;
* le formulaire de connexion intégré dans cette seconde zone ;
* une composition respectant les proportions définies dans le design Figma.

### 3.2 Tablette

Le layout `idp-login-tablet` doit reprendre le principe du layout Desktop tout en adaptant :

* les proportions entre les différentes zones ;
* les marges et espacements ;
* la taille des éléments ;
* le positionnement des éléments visuels et du formulaire.

L’objectif est de conserver l’expérience visuelle du Desktop tout en garantissant une utilisation confortable sur tablette.

### 3.3 Mobile

Le layout `login-registration` doit proposer une expérience **Single-Column** adaptée aux écrans mobiles.

Le contenu doit être réorganisé afin de :

* faciliter la lecture ;
* garantir l’accessibilité des champs et boutons ;
* éviter les débordements horizontaux ;
* conserver les éléments graphiques essentiels du design ;
* garantir une expérience fluide sur différentes tailles d’écran.

---

## 4. Identité visuelle et assets

Le nouveau layout doit intégrer les assets fournis dans le design Figma.

### Assets à intégrer

* `f2b3193647d82c98bb785a6637a1a5b04b79a501.png`

  * utilisée comme visuel principal ;
  * application d’un overlay en dégradé conformément au design.

* `skoruba-icon.svg`

  * positionné dans la partie supérieure du formulaire.

* `vector.svg`

* `vector2.svg`

* `vector-5.svg`

  * utilisés comme éléments décoratifs conformément au design Figma.

Les assets existants doivent être réutilisés lorsqu’ils permettent de respecter le design, sans introduire de duplication inutile.

---

## 5. Architecture du layout

Un layout dédié à l’authentification doit être créé :

`_AuthLayout.cshtml`

Ce layout doit permettre d’isoler les écrans d’authentification du layout global de l’application.

Il doit notamment permettre de :

* supprimer le header global ;
* supprimer le footer global ;
* fournir une structure HTML spécifique aux écrans d’authentification ;
* centraliser les éléments communs aux différentes pages d’authentification ;
* faciliter l’évolution future des écrans Login / Registration.

Les vues d’authentification concernées doivent utiliser ce layout dédié.

---

## 6. Gestion du responsive

Le design doit être **responsive** et s’adapter aux trois catégories d’appareils :

| Device   | Layout               | Principe            |
| -------- | -------------------- | ------------------- |
| Desktop  | `idp-login-desktop`  | Split-Screen        |
| Tablette | `idp-login-tablet`   | Split-Screen adapté |
| Mobile   | `login-registration` | Single-Column       |

Le comportement responsive doit être défini à partir des breakpoints Tailwind CSS et non par la création de variantes spécifiques uniquement pour une résolution donnée.

L’interface doit rester fonctionnelle sur les résolutions intermédiaires.

---

## 7. Critères d’acceptation

### Layout

* [ ] Le layout Desktop respecte le design Figma et utilise une composition Split-Screen.
* [ ] Le layout Tablette adapte correctement les proportions, tailles et espacements.
* [ ] Le layout Mobile utilise une composition Single-Column adaptée aux petits écrans.
* [ ] Le passage entre les différents layouts est automatique en fonction de la taille du viewport.
* [ ] Aucun débordement horizontal n’est présent sur les résolutions supportées.
* [ ] Les champs et boutons restent facilement utilisables sur tablette et mobile.

### Identité visuelle

* [ ] L’image `f2b3193647d82c98bb785a6637a1a5b04b79a501.png` est intégrée avec son overlay dégradé.
* [ ] Le `skoruba-icon.svg` est positionné conformément au design.
* [ ] Les vecteurs `vector.svg`, `vector2.svg` et `vector-5.svg` sont intégrés conformément au design.
* [ ] Les espacements, tailles et alignements sont cohérents avec le design Figma.
* [ ] Les éléments visuels ne compromettent pas la lisibilité ou l’utilisation du formulaire.

### Architecture

* [ ] Un layout `_AuthLayout.cshtml` est créé pour les écrans d’authentification.
* [ ] Les éléments du layout global (header/footer) ne sont pas présents sur les écrans d’authentification.
* [ ] Les vues d’authentification utilisent `_AuthLayout.cshtml`.
* [ ] La structure permet de réutiliser le layout pour les futures pages d’authentification.

### CSS / Tailwind

* [ ] Les styles sont implémentés avec Tailwind CSS conformément à la pipeline existante.
* [ ] La commande `npm run build:css` permet de générer le CSS nécessaire.
* [ ] Le fichier `wwwroot/css/app.css` est correctement régénéré après modification des styles.
* [ ] Aucun style indispensable au fonctionnement du nouveau layout ne dépend d’une modification manuelle du CSS généré.

### Validation

* [ ] Le rendu Desktop est conforme au design Figma.
* [ ] Le rendu Tablette est conforme au design Figma.
* [ ] Le rendu Mobile est conforme au design Figma.
* [ ] Le parcours de connexion existant reste fonctionnel.
* [ ] Aucun écran d’authentification existant non concerné par l’US n’est régressé.

---

## 8. Contraintes techniques

Les modifications doivent principalement être réalisées dans :

`src/MyProject.STS.Identity/Views/Account/`

Les assets doivent être recherchés et réutilisés depuis :

* `wwwroot/images`
* `wwwroot/icons`

Le layout d’authentification doit être créé dans l’emplacement approprié aux layouts Razor existants.

La pipeline Tailwind doit être utilisée pour générer les styles :

```bash
npm run build:css
```

Le fichier CSS généré est :

`wwwroot/css/app.css`

---

## 9. Références

* **Domaine :** [Utilisateur](docs/01_model/domain/entities/utilisateur/entity.md)
* **Architecture :** [STS Identity](docs/01_model/architecture/containers/sts-identity/component.md)
* **Design Figma :** ColdMind Design — Node `78-8`

---

## 10. Hors périmètre

Cette US concerne uniquement la **modernisation visuelle et responsive des écrans d’authentification**.

Elle ne doit pas modifier :

* le fonctionnement du processus d’authentification ;
* la logique métier de connexion ;
* la gestion des utilisateurs ;
* les mécanismes OAuth/OIDC existants ;
* les contrats ou API d’authentification ;
* les écrans existants qui ne font pas partie du périmètre de cette modernisation.
