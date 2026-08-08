# US-UI-01: Modernisation du Layout de Connexion (idp-login-desktop)

**Statut**: To Do
**Priorité**: Haute
**Estimation**: ❓

---

## Description
**En tant qu'** Utilisateur, **je veux** une interface de connexion moderne et visuelle **afin de** percevoir immédiatement le professionnalisme du système SmartKitchen.

## Contexte
L'interface actuelle est fonctionnelle mais manque d'identité visuelle. Nous souhaitons passer à un layout "Split-Screen" intégrant les nouveaux assets graphiques.

## Critères d'Acceptation
- [ ] L'écran est divisé en deux zones : une zone visuelle (gauche) et une zone formulaire (droite).
- [ ] L'image `f2b3193647d82c98bb785a6637a1a5b04b79a501.png` est utilisée comme fond de la zone visuelle avec un overlay dégradé.
- [ ] Le logo `skoruba-icon.svg` est positionné en haut du formulaire de connexion.
- [ ] Les vecteurs décoratifs (`vector.svg`, `vector2.svg`, `vector-5.svg`) sont intégrés pour dynamiser le fond de page.
- [ ] Le layout est responsive (adaptation pour tablettes et mobiles).

## Liens
- **Domaine**: [Utilisateur](docs/01_model/domain/entities/utilisateur/entity.md)
- **Architecture**: [STS Identity](docs/01_model/architecture/containers/sts-identity/component.md)
- **Figma**: ❓ (À lier via MCP)

---

## Notes Techniques
- Modifier la vue `.cshtml` correspondante dans `src/MyProject.STS.Identity/Views/Account/`.
- Ajouter les styles CSS nécessaires pour le split-screen.
- Utiliser les assets présents dans `wwwroot/images` et `wwwroot/icons`.