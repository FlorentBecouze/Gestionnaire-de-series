   M S B A M L   `   `   `  ����J  FProjetGraphique, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProjetGraphiqueProjetGraphique  5   	   !    ProjetGraphique.AjoutSaison   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ProjetGraphique     5   	     � Title$(  "Informations de la nouvelle saison��5   	   $	��350��64   $	��480��6A   $	��480��6M   $	��350��6\   .��5      � $��0,0,0,0q�6   ��5   
   �� 5      .��5      �  � Color$ 	LightBlue��6    � Offset$	 0.0Q�61   � 5      $ Thistle��6   $	 1.0Q�6/   5       � RowDefinitions 5   
   �� 5      $	��41* �6   �� 5      $
��169* �6   �� 5      $
��109* �6   .+�5   
   ]� $��0��6   .+�5      �� -   5         ��Name$ LabelNomNewSaison��5      $��Nom de la saison :��6/   $��Center=�6L   $��20,0,0,0q�6g   �� 5      -   5         ��Name$ TextBoxNomNewSaison��5      $��Center=�63   $��
10,0,180,0q�6N   $��30��6b    �� TextWrapping$
 Wrap=�6q   5      �� 5   
   $��1��6   .+�5      �� -   5        $ LabelDescriptionNewSaison��5      $ ��Description de la saison :��67   $��	20,10,0,0q�6\   �� 5      -   5        $! TextBoxDescriptionNewSaison��5      $��
10,10,10,0q�6;   $	��110��6O   $	��110��6_    �� 	MaxLength$	 300��6o   $
 Wrap=�6    �� AcceptsReturn . 6�   5       � 5"   
   $��2��6   .+�5#      �� -   5        $$��Enregistrer la nouvelle saison��5#      $��Center=�6>   $��Center=�6[   $��	0,-30,0,0q�6v   	 �� 	IsDefault	 . 6�   �� 5$      -   5        $��Annuler��5$      $��Center=�6'   $��Center=�6D   $��0,60,0,0q�6_   
 �� IsCancel
 . 6�   5%      5(      5)      