# REST-SOAP_WS

## Fonctionalités :
MVP
Graphic user interface
Cache

## Fonctionnement :
Ouvrir Wcf-WS.sln avec Visual studio.

### Test console :
1. Définir ConsoleApp1 comme projet de démarrage. Démarrer.
2. Entrer le nom d'une ville (pour savoir le nom de toutes les villes, entrer help).
3. Entrer ensuite le nom d'une station de cette ville (pour soir le nom de toutes les stations de la ville, entrer help).
4. Le nombre de vélo à cette station s'affiche alors. 
5. Pour savoir le nombre de vélos dans une autre station, entrer y, et répéter les étapes 2 et 3. Pour fermer la console, entrer n.

### Test Interface graphique :
1. Définir WindowsFormsApp1 comme projet de démarrage. Démarrer.
2. Choisir dans le premier menu déroulant une des villes. Appuyer sur Valider.
3. Choisir dans le deuxième menu déroulant une des stations. Appuyer sur Valider.
4. Le nombre de vélos dans la station s'affiche alors.
5. Pour savoir le nombre de vélos dans une autre station dans la même ville, il suffit de répéter l'étape 3.
6. Pour savoir le nombre de vélos dans une autre station d'une autre ville, répéter les étapes 2 et 3.
7. A tout moment, on accède à une aide grâce au bouton Aide.

### Chargement du serveur (déjà fait) :
1. Définir Wcf-WS comme projet de démarrage. Démarrer.
2. Exécuter la commande svcutil.exe http://localhost:8733/Design_Time_Addresses/Wcf_WS/Service1/?wsdl
3. Copier coller le fichier Service.cs résultant de cette exécution dans les classes Service.cs de WindowsFormsApp1 et ConsoleApp1
4. Ajouter maxReceivedMessageSize="655360" dans la balise binding du fichier outpout.config, puis le copier coller dans les fichiers App.config de WindowsFormsApp1 et ConsoleApp1

### Events
1. Pour démarrer, il faut définir ConsoleApp1 et EvenHost comme projet de démarrage, puis lancer le projet.
