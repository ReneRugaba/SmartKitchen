<!-- 
INSTRUCTIONS:
- Every requirement must have a unique ID
- Requirements must be testable (binary: yes/no)
- No ambiguity allowed
-->

# Exigences Techniques
## US-UI-01 - Modernisation du layout de connexion multi-device

### Version
1.1

### Statut
Approved

### Référence
[US-UI-01](../../backlog/US-UI-01-modernisation-login.md)

---

# 1. Exigences d'Architecture (ARCH)
- **REQ-ARCH-01** : Un layout dédié `_AuthLayout.cshtml` doit être utilisé pour toutes les vues d'authentification.
- **REQ-ARCH-02** : Le layout `_AuthLayout.cshtml` doit être totalement indépendant du layout administratif.
- **REQ-ARCH-03** : Le header et le footer globaux ne doivent pas être rendus sur les pages d'authentification.
- **REQ-ARCH-04** : La structure doit utiliser `@RenderBody()` pour l'injection des formulaires.

# 2. Exigences d'Interface (UI)
- **REQ-UI-01** : L'interface doit être responsive via les breakpoints Tailwind CSS.
- **REQ-UI-02** : Mode **Single-Column** obligatoire pour les viewports `< 768px`.
- **REQ-UI-03** : Mode **Split-Screen** obligatoire pour les viewports ≥ 768px.
- **REQ-UI-04** : L'image `f2b3193647d82c98bb785a6637a1a5b04b79a501.png` doit être intégrée avec un overlay dégradé.
- **REQ-UI-05** : Le logo `skoruba-icon.svg` doit être positionné en haut du formulaire.
- **REQ-UI-06** : Aucun débordement horizontal ne doit être présent sur les résolutions supportées.

# 3. Exigences de Style et Pipeline (STY)
- **REQ-STY-01** : Utilisation exclusive de classes utilitaires Tailwind CSS.
- **REQ-STY-02** : Génération du CSS via la commande `npm run build:css`.
- **REQ-STY-03** : Le fichier `wwwroot/css/app.css` doit être le seul point d'entrée CSS.

# 4. Critères de Validation (VAL)
- **VAL-01** : Conformité visuelle avec le design Figma sur Desktop, Tablette et Mobile.
- **VAL-02** : Fluidité du basculement responsive.
- **VAL-03** : Maintien total des fonctionnalités de connexion et d'inscription.
- **VAL-04** : Accessibilité tactile garantie sur mobile.

---

# 5. Traçabilité
- **US Source** : [US-UI-01](../../backlog/US-UI-01-modernisation-login.md)