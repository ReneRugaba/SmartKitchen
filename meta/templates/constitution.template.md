<!--
  INSTRUCTIONS POUR L'AGENT — NE PAS INCLURE DANS LA CONSTITUTION FINALE

  Tu vas générer `meta/constition.md` en conduisant un entretien guidé avec le propriétaire du workspace.
  Suis le protocole ci-dessous à la lettre.
  Supprime ce commentaire du fichier final.
-->

# Constitution — Entretien guidé

## Protocole d'entretien

Pose les questions **une section à la fois**. Pour chaque section :
1. Présente les options disponibles sous forme de choix numérotés.
2. Permets à l'utilisateur de sélectionner une ou plusieurs options **et/ou** d'ajouter ses propres éléments.
3. Note les réponses. Ne génère pas de règles avant d'avoir terminé **toutes** les sections.
4. Une fois toutes les sections complétées, génère la constitution et remplace ce fichier.

---

## Section 1 — Niveau de prudence général

> Calibre la rigueur globale des règles.

**Q1.1 — Quelle est la conséquence d'une erreur de génération non détectée ?**

```
[ ] 1. Faible — erreur facilement corrigeable, pas d'impact critique
[ ] 2. Modérée — ralentit le projet, nécessite une correction manuelle
[ ] 3. Élevée — impacte des décisions ou des livrables en aval
[ ] 4. Critique — peut causer des pertes de données, des incidents ou des livraisons incorrectes
```

**Q1.2 — Des agents ont-ils déjà causé des problèmes sur ce projet ou des projets similaires ?**

```
[ ] 1. Non, premier projet avec des agents
[ ] 2. Oui — invention de faits non sourcés
[ ] 3. Oui — modification d'un artifact approuvé sans autorisation
[ ] 4. Oui — génération d'un artifact avant ses prérequis
[ ] 5. Oui — autre : ___
```

---

## Section 2 — Invention et sources

> Définit ce que l'agent peut ou ne peut pas inférer.

**Q2.1 — Que doit faire l'agent face à une information absente de tout artifact upstream ?**

```
[ ] 1. Bloquer et demander — ne rien générer tant que l'information n'est pas fournie
[ ] 2. Marquer et continuer — utiliser ❓ et lister en Open Questions, mais poursuivre la génération
[ ] 3. Inférer avec prudence — proposer une valeur plausible, clairement marquée comme hypothèse
[ ] 4. Autre : ___
```

**Q2.2 — Y a-t-il des catégories d'information que l'agent ne doit jamais supposer, même partiellement ?**

```
[ ] 1. Choix technologiques (langages, frameworks, cloud providers)
[ ] 2. Règles métier et invariants domaine
[ ] 3. Acteurs et parties prenantes
[ ] 4. Contraintes réglementaires ou de conformité
[ ] 5. Estimations de coût ou de délai
[ ] 6. Toutes les catégories ci-dessus
[ ] 7. Autre : ___
```

---

## Section 3 — Statuts et immuabilité

> Définit ce que l'agent peut modifier selon le statut d'un artifact.

**Q3.1 — Quels statuts sont utilisés dans ce projet ?**

```
[ ] 1. Draft / Review / Approved / Deprecated  (recommandé)
[ ] 2. Draft / Approved / Deprecated
[ ] 3. Brouillon / Validé / Archivé
[ ] 4. Autre : ___
```

**Q3.2 — Un artifact au statut "Approved" peut-il être modifié par un agent ?**

```
[ ] 1. Jamais — toute modification nécessite une intervention humaine et un ADR
[ ] 2. Uniquement pour corriger une faute de frappe ou un lien cassé
[ ] 3. Oui, si la modification est tracée dans le traceability matrix
[ ] 4. Autre : ___
```

**Q3.3 — Un artifact en statut "Review" peut-il servir de source à un artifact downstream ?**

```
[ ] 1. Non — uniquement les artifacts "Approved"
[ ] 2. Oui, avec une mention explicite du risque dans l'artifact downstream
[ ] 3. Oui, sans restriction
```

---

## Section 4 — Flux documentaire

> Définit l'ordre de génération et les dépendances.

**Q4.1 — Quel flux documentaire s'applique à ce projet ?**

```
[ ] 1. Flux BMAD complet : context → domain → architecture → analyse → décisions → backlog → src
[ ] 2. Flux allégé : context → architecture → backlog → src
[ ] 3. Flux personnalisé : ___
```

**Q4.2 — Des artifacts peuvent-ils être générés en parallèle ?**

```
[ ] 1. Non — génération strictement séquentielle
[ ] 2. Oui — domain et architecture peuvent être produits en parallèle après context
[ ] 3. Oui — les artifacts d'analyse peuvent être produits en parallèle entre eux
[ ] 4. Autre : ___
```

---

## Section 5 — Traçabilité et duplication

**Q5.1 — Comment gérer une information déjà présente dans un artifact upstream ?**

```
[ ] 1. Référencer uniquement (lien relatif) — ne jamais copier
[ ] 2. Copier si c'est un résumé court, référencer si c'est long
[ ] 3. Pas de contrainte
```

**Q5.2 — La traceability matrix doit-elle être mise à jour automatiquement ?**

```
[ ] 1. Oui — après chaque création ou modification d'artifact
[ ] 2. Oui — uniquement lors de la complétion d'une section majeure
[ ] 3. Non — mise à jour manuelle uniquement
```

---

## Section 6 — Périmètre d'autorité

**Q6.1 — Existe-t-il des fichiers que l'agent ne doit jamais modifier ?**

```
[ ] 1. Oui — meta/constition.md lui-même (après génération)
[ ] 2. Oui — les ADR approuvés
[ ] 3. Oui — autre : ___
[ ] 4. Non — aucune restriction de fichier
```

**Q6.2 — Le dossier `docs/` est la source de vérité du projet. Qui peut le modifier ?**

```
[ ] 1. LLM supervisé par un humain uniquement — toute modification doit être revue et approuvée par un humain avant d'être considérée valide
[ ] 2. LLM autonome autorisé — l'agent peut modifier docs/ sans supervision si le statut de l'artifact est Draft
[ ] 3. Humain uniquement — aucun agent ne doit écrire directement dans docs/
[ ] 4. Autre : ___
```

**Q6.3 — Que doit faire l'agent si une instruction lui demande de modifier un artifact dans `docs/` sans supervision humaine explicite ?**

```
[ ] 1. Refuser et signaler — bloquer l'opération et expliquer la règle
[ ] 2. Proposer le contenu mais ne pas écrire — soumettre le changement pour approbation humaine
[ ] 3. Autoriser uniquement pour les artifacts en statut Draft
[ ] 4. Autre : ___
```

**Q6.4 — En cas de conflit entre ce fichier et un template ou un prompt, que doit faire l'agent ?**

```
[ ] 1. La constitution prime toujours — appliquer la règle de la constitution
[ ] 2. Signaler le conflit à l'utilisateur avant de continuer
[ ] 3. Appliquer le document le plus récent
```

---

## Génération de la constitution

Une fois toutes les questions répondues, génère `meta/constitution.md` selon le format suivant.

### Structure de la constitution

```markdown
# Agent Constitution

> [Déclaration d'autorité — 1 à 2 phrases]

---

## 1. Directives primaires
[Règles R-01, R-02, ... issues des sections 2 et 1.2]

## 2. Discipline de statut
[Règles issues de la section 3]

## 3. Flux documentaire
[Schéma et règles issues de la section 4]

## 4. Protocole d'incertitude
[Règles issues de Q2.1]

## 5. Périmètre d'autorité
[Règles issues de la section 6]
```

### Format de chaque règle

```markdown
### R-XX — [Titre court]

[Énoncé en une ou deux phrases, ton impératif.]

**Justification :** [Ce qu'elle protège.]
**Violation :** [Ce qui constitue une violation explicite.]
```

> Règles de rédaction : ton impératif uniquement · une règle = une intention · sans ambiguïté · sans exception inline
