# AR-pyramid

Téléchargez l'application avec le QRCode :

![alt text](https://image.noelshack.com/fichiers/2018/26/7/1530455319-frame.png)

Ce projet présente des fonctionnalités plus ou moins poussées de Vuforia via la thématique égyptienne pour le magazine Programmez.

### Prérequis pour le fonctionnement du projet 

- Unity 2017.4.0f1 
- Vuforia 7
- android minimum API 4.1 "Jelly Bean"

Parcourez les différents objets de la scène unity afin de mieux saisir 
le fonctionnement de Vuforia avec Unity.

### Génération de l'APK sur Unity 

Sous l'onglet "File" :
1. aller dans Build Settings
	  - Si la plateforme sélectionnée n'est pas android, cliquer sur Android puis "Switch Plateform"
	  - Vérifier bien que sous "Player Settings" > "Other Settings" > "Identification" que les noms et numéros de versions soient bien conforme aux conventions de nommages Android

2. Votre téléphone doit pouvoir installer des apk non signé, n'oubliez pas d'autorisation les installations d'apk ne provenant pas du google play store. 
	- Pour cela dans les paramètre de votre téléphone sous "Paramètres avancés" > "Sécurité", activez "Source inconnue"
	   - option 1: cliquer sur "build" pour générer un apk (vous pourrez choisir l'emplacement) et vous devrez l'installer manuellement sur votre téléphone.
	   - option 2: cliquer sur "build and run" si votre smartphone est connecté à votre ordinateur (mode développeur et debbogage USB activés), l'apk s'installera automatique sur votre smartphone et se lancera, une fois l'installation terminée.
     
### Politique de protection des données personnelles

L'application a besoin, pour pouvoir fonctionner, de la caméra de votre smartphone Android. 
Cependant AUCUNES données n'est stockée, ni sur le smartphone ni sur nos serveurs.

