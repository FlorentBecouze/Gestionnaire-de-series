   M S B A M L   `   `   `  ����J  FProjetGraphique, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProjetGraphiqueProjetGraphique  5   	        ProjetGraphique.AjoutSerie   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ProjetGraphique     5   	     � Title$(  "Informations de la nouvelle série��5   	   $	��400��63   $	��500��6@   $	��500��6L   $	��400��6[   .��5
      � $��0,0,0,0q�6   ��5   
   �� 5      .��5      �  � Color$ 	LightBlue��6    � Offset$	 0.0Q�61   � 5      $ Thistle��6   $	 1.0Q�6/   5       � RowDefinitions 5   
   �� 5      $	��47* �6   �� 5      $
��169* �6   �� 5      $
��153* �6   .+�5   
   ]� $��0��6   .+�5      �� -   5         ��Name$ LabelNomNewSerie��5      $��Nom de la série :��6.   $��Center=�6J   $��20,0,0,0q�6e   �� 5      -   5         ��Name$ TextBoxNomNewSerie��5      $��Center=�62   $��
10,0,180,0q�6M   $��30��6a    �� TextWrapping$
 Wrap=�6p   
���   �6�   5      �� 5   
   $��1��6   .+�5      �� -   5        $ LabelDescriptionNewSerie��5      $ ��Description de la série :��66   $��	20,10,0,0q�6Z   �� 5      -   5        $ TextBoxDescritionNewSerie��5      $��
10,10,10,0q�69   $	��110��6M   $	��110��6]   $
 Wrap=�6m   
���   � �� AcceptsReturn .  �� 	MaxLength$	 600��5   ?   5       � 5"   
   $��2��6   	 � ColumnDefinitions	 5#      �� 5$      $��1* �6#   �� 5%      $��1* �6#   .+�5(      �� -   5        $��
ImagePerso��5(      $��0��6'   $	��120��67   $��0,0,0,30q�6G   �� 5)      -   5        $��0��5)      $&�� Choisir une image pour la série��6%   $��Center=�6O   $��Bottom=�6l   $��0,0,0,10q�6�   6�   � 5+      $��1��6   .+�5,      �� -   5        $��1��5,      $$��Enregistrer la nouvelle série��6)   $��Center=�6Q   $��Center=�6n   $��	0,-30,0,0q�6�   
 �� 	IsDefault
 . 6�   �� 5-      -   5        $��1��5-      $��Annuler��6)   $��Center=�6;   $��Center=�6X   $��0,60,0,0q�6s    �� IsCancel . 6�   5.      50      52      53      