   M S B A M L   `   `   `  ����J  FProjetGraphique, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProjetGraphiqueProjetGraphique  5   	   "    ProjetGraphique.AjoutEpisode   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ProjetGraphique     5   	     � Title$%  Informations du nouvel épisode��5   
   $	��350��61   $	��480��6>   $	��480��6J   $	��350��6Y   .��5
      � $��0,0,0,0q�6   ��5   
   �� 5      .��5      �  � Color$ 	LightBlue��6    � Offset$	 0.0Q�61   � 5      $ Thistle��6   $	 1.0Q�6/   5       � RowDefinitions 5   
   �� 5      $	��41* �6   �� 5      $
��169* �6   �� 5      $
��109* �6   .+�5   
   ]� $��0��6   .+�5      �� -   5         ��Name$ LabelNomNewEpisode��5      $��Nom de l'épisode :��60   $��Center=�6M   $��20,0,0,0q�6h   �� 5      -   5         ��Name$ TextBoxNomNewEpisode��5      $��Center=�64   $��
10,0,180,0q�6O   $��30��6c    �� TextWrapping$
 Wrap=�6r   5      �� 5   
   $��1��6   .+�5      �� -   5        $  LabelDescriptionNewEpisode��5      $!��Description de l'épisode :��68   $��	20,10,0,0q�6]   �� 5      -   5        $" TextBoxDescriptionNewEpisode��5      $��
10,10,10,0q�6<   $	��110��6P   $	��110��6`    �� 	MaxLength$	 300��6p   $
 Wrap=�6�    �� AcceptsReturn . 6�   5      � 5!   
   $��2��6   .+�5"      �� -   5        $#��Enregistrer le nouvel episode��5"      $��Center=�6=   $��Center=�6Z   $��	0,-30,0,0q�6u   	 �� 	IsDefault	 . 6�   �� 5#      -   5        $��Annuler��5#      $��Center=�6'   $��Center=�6D   $��0,60,0,0q�6_   
 �� IsCancel
 . 6�   5$      5'      5(      