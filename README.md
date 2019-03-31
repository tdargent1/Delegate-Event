# Delegate Event

Le but est de créer un événement sur une classe. Cet événement sera alors disponible pour être utilisé dans une environnement graphique par exemple ou dans un autre développement lié à l'application qui utilise notre objet métier.

### De quoi disposons nous

* FMAIN : Fenêtre principale de démarrage de l'application
Instanciée au moment du démarrage. Elle ne comporte qu'un bouton permettant d'instancier un objet : Livre.
- Instancie un livre.
- Instancie la fenêtre FLIVRE et l'affiche.
- Instancie la fenêtre FHISTORIQUE et l'affiche.
![Capture.png](https://image.noelshack.com/fichiers/2019/13/7/1554037540-capture.png)

* FLIVRE : Fenêtre permettant de modifier un livre
- Le constructeur permet de s'abonneraux variations du prix du livre.
- Toute action dans l'interface graphique doit se répercuter sur l'objet livre.
![Capture.png](https://image.noelshack.com/fichiers/2019/13/7/1554037543-capture2.png)

* FHISTORIQUE : Fenêtre présentant l'historique de mise à jour des prix
- Le constructeur permet de s'abonner aux variations du prix du livre.
- Lorsque la fenêtre détecte par évenement une variation du prix, elle ajoute le nouveau prix dans la ListBox.
![Capture.png](https://image.noelshack.com/fichiers/2019/13/7/1554037547-capture3.png)

* Livre : Classe livre (classe métier)


### Cinématique de l'application 

![Capture.png](https://image.noelshack.com/fichiers/2019/13/7/1554038062-img-5085.jpg)
