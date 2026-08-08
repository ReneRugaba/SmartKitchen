# Specifications: US-UI-01 - Modernisation du Layout de Connexion

## Status
Draft

---

## Technical Overview

L'objectif est de transformer la vue de connexion standard en une interface moderne de type "Split-Screen".

### Layout Structure
- **Container Principal**: `display: flex` (ou `grid`) occupant 100% de la hauteur du viewport (`100vh`).
- **Zone Visuelle (Gauche)**: 
    - Largeur: 50% sur desktop, 0% sur mobile (cachée ou réduite).
    - Fond: Image `f2b3193647d82c98bb785a6637a1a5b04b79a501.png`.
    - Overlay: Dégradé linéaire pour assurer la lisibilité d'éventuels textes.
- **Zone Formulaire (Droite)**:
    - Largeur: 50% sur desktop, 100% sur mobile.
    - Alignement: Centrage vertical et horizontal du bloc de connexion.

### UI Components
- **Logo**: `skoruba-icon.svg` positionné en haut du formulaire.
- **Champs de saisie**: Intégration d'icônes Lucide (via `wwwroot/icons/lucide/`) à l'intérieur des inputs.
- **Décorations**: Positionnement absolu des fichiers `vector.svg`, `vector2.svg`, `vector-5.svg` en arrière-plan pour dynamiser la composition.

### Responsiveness
- Point de rupture à 768px.
- Passage en `flex-direction: column`.
- La zone visuelle est masquée ou déplacée en haut de page.

---

## Data & Contracts
L'US est purement visuelle. Aucun changement de contrat API ou de schéma de base de données n'est requis. Les données postées par le formulaire restent identiques.

---

## Links
- **US**: [US-UI-01](../../backlog/US-UI-01-modernisation-login.md)
- **Domain**: [Utilisateur](../../docs/01_model/domain/entities/utilisateur/entity.md)
- **Architecture**: [STS Identity](../../docs/01_model/architecture/containers/sts-identity/component.md)