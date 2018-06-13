Ce projet pr�sente des fonctionnalit�s plus ou moins pouss�es de Vuforia via la th�matique �gyptienne pour le magazine Programmez.

********** Pr�requis pour le fonctionnement du projet **********

- Unity 2017.4.0f1 
- Vuforia 7
- android minimum API 4.1 "Jelly Bean"

****************************************************************

Parcourez les diff�rents objets de la sc�ne unity afin de mieux saisir 
le fonctionnement de Vuforia avec Unity.

********** G�n�ration de l'APK sur Unity **********

Sous l'onglet "File" 
	1) aller dans Build Settings
	  -> Si la plateforme s�lectionn�e n'est pas android, cliquer sur Android puis "Switch Plateform"
	  -> V�rifier bien que sous "Player Settings" > "Other Settings" > "Identification" que les noms et num�ros de versions soient bien conforme aux conventions de nommages Android

	2) Votre t�l�phone doit pouvoir installer des apk non sign�, n'oubliez pas d'autorisation les installations d'apk ne provenant pas du google play store. 
	   Pour cela dans les param�tre de votre t�l�phone sous "Param�tres avanc�s" > "S�curit�", activez "Source inconnue"
	   - option 1: cliquer sur "build" pour g�n�rer un apk (vous pourrez choisir l'emplacement) et vous devrez l'installer manuellement sur votre t�l�phone.
	   - option 2: cliquer sur "build and run" si votre smartphone est connect� � votre ordinateur (mode d�veloppeur et debbogage USB activ�s), l'apk s'installera automatique sur votre smartphone et se lancera, une fois l'installation termin�e.


***************************************************