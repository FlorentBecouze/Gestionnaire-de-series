   M S B A M L   `   `   `  ����J  FProjetGraphique, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProjetGraphiqueProjetGraphique  5   	   %    ProjetGraphique.ModifCetEpisode   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ProjetGraphique     5   	     � Title$,  &Informations de l'épisode à modifier��5   	   $	��350��66   $	��480��6C   $	��480��6O   $	��350��6^   .��5
      � $��0,0,0,0q�6   ��5   
   �� 5      .��5      �  � Color$ 	LightBlue��6    � Offset$	 0.0Q�61   � 5      $ Thistle��6   $	 1.0Q�6/   5       � RowDefinitions 5   
   �� 5      $	��41* �6   �� 5      $
��167* �6   �� 5      $
��111* �6   .+�5   
   ]� $��0��6   .+�5      �� -   5         ��Name$ LabelNomEpisodeAModif��5      $��Nom de l'épisode :��63   $��Center=�6P   $��20,0,0,0q�6k   �� 5      -   5         ��Name$ TextBoxNomEpisodeAModif��5      $��Center=�6Y   $��
10,0,180,0q�6t   $��30��6�    �� TextWrapping$
 Wrap=�6�   ��67   �� *Nom+ �� Mode$ OneWay=�.��6�   5      5      �� 5   
   $��1��6   .+�5      �� -   5        $# LabelDescriptionEpisodeAModif��5      $!��Description de l'épisode :��6;   $��	20,10,0,0q�6`   �� 5      -   5        $% TextBoxDescriptionEpisodeAModif��5       �� 	MaxLength$	 300��5       $��
10,10,10,0q�6&   $	��110��6:   $	��110��6J   	 �� TextAlignment$	 Center=�6Z   $
 Wrap=�6q   
 �� AcceptsReturn
 . ��5   ?   �� *DescriptionEpisode+$ OneWay=�5    �   5"      � 5$   
   $��2��6   .+�5%      �� -   5        $#��Enregistrer les modifications��5%      $��Center=�6=   $��Center=�6Z   $��	0,-30,0,0q�6u    �� 	IsDefault . 6�   �� 5&      -   5        $��Annuler��5&      $��Center=�6'   $��Center=�6D   $��0,60,0,0q�6_    �� IsCancel . 6�   5'      5*      5+      