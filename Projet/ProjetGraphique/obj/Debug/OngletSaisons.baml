   M S B A M L   `   `   `  ����J  FProjetGraphique, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProjetGraphiqueProjetGraphique  5      #    ProjetGraphique.OngletSaisons   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ProjetGraphique     5      .��5	      � ��5
   
   �� 5      .��5      �   � Color$  Thistle��6    � Offset$	 0.0Q�6/   � 5      $  	LightBlue��6   $	 1.0Q�61   5       � ColumnDefinitions 5   
   �� 5      $
��110* �6   $	��110��6,   �� 5      $
��312* �6    � RowDefinitions 5   
   �� 5      $
��283* �6   �� 5      $	��55* �6   .+�5   
   �� -   5         ��Name$ MasterSaisons��5   0   $��0��6   $��0��6#   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6l   $	��103��6�   $��0,1,0,1q�6�   $��Center=�6�   $��Disabled=�6�   ��6G   �� *ListeSaisons+��5      �� 5      .R�5      �� $��NomSerie��6    $
��Wrap=�6E   ��60   �� *Nom+6E   5      5      � 5"   
   -   5         �Name$ 
GridSaison��5"      $��1��6#   $��0��63    5#      �� 5$      $
��166* �6    �� 5%      $
��169* �6    .+�5)      � -   5        $ GridDescriptionSaison��5)      $��0��62    � DataContext 6?   ��  �� ElementName$ MasterSaisons��	 �� Path$	 ItemsSource�.+�5*      �� -   5        
 ��Name$
 TBInfosSeries��5*      $��Center=�6V   $	��Top=�6s    �� TextAlignment$ Center=�6�   $��0,10,0,0q�6�   $
��Wrap=�6�   ��63   �� *DescriptionSaison+6�   5+      � 5-      $��1��6    6    �� $ MasterSaisons��$	 ItemsSource�.+�5.      �� -   5         ��Name$ LabelListeEpisodes��5.      $��Liste des épisodes :��64   $��Center=�6S   $��0,10,0,0q�6p   $	��Top=�6�   �� 5/      -   5        $ MasterEpisodes��5/      $��90��6Y   $
 TrueY�6g   $��Center=�6�   $��Center=�6�   $��0,50,0,0q�6�   $��Center=�6�   ��63   �� *ListeEpisodes+��50      �� 51      .R�52      �� $��
NomEpisode��6(   -   5        $ Center=�52   i   $
��Wrap=�6�   ��6:   �� *Nom+6�   53      55      56      57      �� 59   
   -   5         ��Name$ BoutonAjoutSaison��59   [   $��0��6   $��1��6!   $��Ajouter une saison��6v   $��Center=�6�   $��Center=�6�   $��24��6�   $��1,0,0,0q�6�    6.   �� *collectionComposants+6�   � 5;   
   $��1��6   $��1��6    5<      �� 5=      $��1* �6#   �� 5>      $��1* �6#   .+�5A      �� -	   5        $ BoutonModifSaison��5A   %   $��0��6   $��Modifier cette saison��6@   $��24��6`   $��Center=�6l   $��Center=�6�   6�   �� 5B      -
   5        $ BoutonAjoutEpisode��5B   %   $��1��6   $��Ajouter un épisode��6A   $��24��6^   $��Center=�6j   $��Center=�6�   6�   5C      5E      5F      