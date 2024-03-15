# TP2

## Simulation de crédit immobilier

## Étude du sujet

$Mensualité = \frac{Capital Emprunté * \frac{Taux Annuel}{12}}{1 - (1+\frac{Taux Annuel}{12}) - Durée en mois}$

Paramètres variable :
- Capital Emprunté : Montant de l'emprunt, supérieur ou égal à 50 000
- Durée : Durée du remboursement, entre 9 et 25 ans
- Taux nominal : Taux d'intérêt du crédit

Output : fichier CSV
- 1ère ligne : Coût total du crédit
- Lignes suivantes : numéro de mensualité, capital remboursé, restant dû

Programme console, prend 3 arguments montant, durée, taux.