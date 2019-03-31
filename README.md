# Delegate Event

Le but est de créer un événement sur une classe. Cet événement sera alors disponible pour être utilisé dans une environnement graphique par exemple ou dans un autre développement lié à l'application qui utilise notre objet métier.

### De quoi disposons nous

* FMAIN : Fenêtre principale de démarrage de l'application<br><br><br>
Instanciée au moment du démarrage. Elle ne comporte qu'un bouton permettant d'instancier un objet : Livre.<br>
  Instancie un livre.<br>
  Instancie la fenêtre FLIVRE et l'affiche.<br>
  Instancie la fenêtre FHISTORIQUE et l'affiche.<br>
![Capture.png](https://image.noelshack.com/fichiers/2019/13/7/1554037540-capture.png)

* FLIVRE : Fenêtre permettant de modifier un livre<br>
  Le constructeur permet de s'abonneraux variations du prix du livre.<br>
  Toute action dans l'interface graphique doit se répercuter sur l'objet livre.<br>
![Capture.png](https://image.noelshack.com/fichiers/2019/13/7/1554037543-capture2.png)

* FHISTORIQUE : Fenêtre présentant l'historique de mise à jour des prix<br><br>
  Le constructeur permet de s'abonner aux variations du prix du livre.<br>
  Lorsque la fenêtre détecte par évenement une variation du prix, elle ajoute le nouveau prix dans la ListBox.<br>
![Capture.png](https://image.noelshack.com/fichiers/2019/13/7/1554037547-capture3.png)

* Livre : Classe livre (classe métier)<br>


### Cinématique de l'application 

![Capture.png](https://image.noelshack.com/fichiers/2019/13/7/1554038062-img-5085.jpg)
