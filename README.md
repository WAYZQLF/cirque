le constructeur devrait avoir 5 paramètres



Les listes (List<T>) permettent de garder en mémoire tous les objets créés pendant l'exécution du programme. Sans elles, on perdrait les données dès qu'on quitte un événement. Elles servent aussi à repeupler les comboboxes et à retrouver un objet par son nom.
Il est rempli dans btnValiderP_Click, après chaque ajout d'un personnel
Il vide tous les éléments affichés dans la combobox, sans toucher à listPersonnel. C'est une remise à zéro visuelle de la liste déroulante.
Parce qu'on ne peut pas juste ajouter le nouvel élément directement — on risquerait d'avoir des doublons. On vide d'abord la combobox, puis on la reremplit entièrement depuis la liste, ce qui garantit que l'affichage est toujours synchronisé avec les données.
