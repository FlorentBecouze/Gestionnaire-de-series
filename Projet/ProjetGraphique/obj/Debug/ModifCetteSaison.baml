   M S B A M L   `   `   `  ����J  FProjetGraphique, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProjetGraphiqueProjetGraphique  5   	   &     ProjetGraphique.ModifCetteSaison   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ProjetGraphique     5   	     � Title$+  %Informations de la saison à modifier��5      $	��350��65   $	��480��6B   $	��480��6N   $	��350��6]   .��5
      � $��0,0,0,0q�6   ��5   
   �� 5      .��5      �  � Color$ 	LightBlue��6    � Offset$	 0.0Q�61   � 5      $ Thistle��6   $	 1.0Q�6/   5       � RowDefinitions 5   
   �� 5      $	��41* �6   �� 5      $
��167* �6   �� 5      $
��111* �6   .+�5   
   ]� $��0��6   .+�5      �� -   5         ��Name$ LabelNomSaisonAModif��5      $��Nom de la saison :��62   $��Center=�6O   $��20,0,0,0q�6j   �� 5      -   5         ��Name$ TextBoxNomSaisonAModif��5      $��Center=�6X   $��
10,0,180,0q�6s   $��30��6�    �� TextWrapping$
 Wrap=�6�   ��66   �� *Nom+ �� Mode$ OneWay=�6�   5      �� 5   
   $��1��6   .+�5      �� -   5        $" LabelDescriptionSaisonAModif��5      $"��Informations sur la saison :��6:   $��	20,10,0,0q�6a   �� 5      -   5        $$ TextBoxDescriptionSaisonAModif��5      $��
10,10,10,0q�6n   $	��110��6�   $	��110��6�    �� TextAlignment$ Center=�6�   $
 Wrap=�5      	 �� AcceptsReturn	 . 
 �� 	MaxLength$	
 746��6?   ��5   >   �� *DescriptionSaison+$ OneWay=�5   ?   5       � 5"   
   $��2��6   .+�5#      �� -   5        $#��Enregistrer les modifications��5#      $��Center=�6=   $��Center=�6Z   $��	0,-30,0,0q�6u    �� 	IsDefault . 6�   �� 5$      -   5        $��Annuler��5$      $��Center=�6'   $��Center=�6D   $��0,60,0,0q�6_    �� IsCancel . 6�   5%      5(      5)      