   M S B A M L   `   `   `  ����J  FProjetGraphique, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProjetGraphiqueProjetGraphique  5   	   "    ProjetGraphique.FenetreSerie   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ProjetGraphique     5   	   -   5        $��NomFenetreSerie��5        � Title$  Fenêtre Série��6	   $	��540��66   $	��740��6C   $	��740��6O   $	��540��6^   .��5
      � -   5        $��mGrid��5
      $��0,0,0,0q�6   ��5   
   �� 5      .��5      �  � Color$ 	LightBlue��6    � Offset$	 0.0Q�61   � 5      $ Thistle��6   $	 1.0Q�6/   5       � ColumnDefinitions 5   
   �� 5      $	��36* �6   $	��168��6+   �� 5      $
��100* �6   .+�5   
   �� -   5         ��Name$ LabelListeSeries��5       $��0��6   $��Liste des séries :��6:   $	��Top=�6W   $��
20,13,31,0q�6o   �� 5   
   -   5         ��Name$ MasterSeries��5   #   $��0��6   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6d   $	��150��6�   $
��Left=�6�   $��	8,50,0,64q�6�   $��Center=�6�   $��Disabled=�6�   ��69   �� *ListeComposantsApp+��5      �� 5      .R�5      ��  �� TextAlignment$ Center=�65   $
��Wrap=�6L   ��6    �� *Nom+6L   5      5       �� 5#   
   -   5         ��Name$ BoutonAjoutSerie��5#   !   $��0��6   $��Ajouter une série��6;   $��Center=�6W   $��Bottom=�6t   $��24��6�   $��0,0,0,35q�6�   6�   �� 5$   
   -   5        $ BoutonModifCetteSerie��5$   !   $��0��6   $��Modifier cette série��6@   $��Center=�6_   $��Bottom=�6|   $��24��6�   $��0,0,0,5q�6�   6�   �� 5(   
   -   5        	 ��Name$	 ContentControl��5(   )   $��1��6   ��6A   �� 
 �� ElementName$
 MasterSeries�� �� Path$ ItemsSource���5)      �� 5*      .R�5+      � $��1��6   .+�5,      ��  ��Name$ 
tabControl��6%   $��21,12,23,16q�69   .@�5/      �� $��Série��6&   .��50   "   !   ProjetGraphique.OngletSerie  51      �� 55      $��Saisons��6&   .��56   "   #   ProjetGraphique.OngletSaisons  57      �� 5;      $��Personnages��6&   .��5<   "   '   !ProjetGraphique.OngletPersonnages  5=      �� 5A      $��Commentaires��6&   .��5B   "   (   "ProjetGraphique.OngletCommentaires  5C      5E      5F      5G      5I      5K      5L      