   M S B A M L   `   `   `  ����J  FProjetGraphique, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProjetGraphiqueProjetGraphique  5   	   %    ProjetGraphique.AjoutPersonnage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ProjetGraphique     5   	     � Title$(  "Informations du nouveau personnage��5   	   $	��400��64   $	��500��6A   $	��500��6M   $	��400��6\   .��5
      � $��0,0,0,0q�6   ��5   
   �� 5      .��5      �  � Color$ 	LightBlue��6    � Offset$	 0.0Q�61   � 5      $ Thistle��6   $	 1.0Q�6/   5       � RowDefinitions 5   
   �� 5      $	��47* �6   �� 5      $
��169* �6   �� 5      $
��153* �6   .+�5   
   ]� $��0��6   .+�5      �� -   5         ��Name$ LabelNomNewPersonnage��5      $��Nom du personnage :��63   $��Center=�6Q   $��20,0,0,0q�6l   �� 5      -   5         ��Name$ TextBoxNomNewPersonnage��5      $��Center=�67   $��
10,0,180,0q�6R   $��30��6f    �� TextWrapping$
 Wrap=�6u   5      �� 5   
   $��1��6   .+�5      �� -   5        $# LabelDescriptionNewPersonnage��5      $!��Description du personnage :��6;   $��	20,10,0,0q�6a   �� 5      -   5        $% TextBoxDescriptionNewPersonnage��5      $��
10,10,10,0q�6?    �� 	MaxLength$	 300��6S   $	��110��6d   $	��110��6t   $
 Wrap=�6�    �� AcceptsReturn . 6�   5      � 5!   
   $��2��6   	 � ColumnDefinitions	 5"      �� 5#      $��1* �6#   �� 5$      $��1* �6#   .+�5'      �� -   5        $��
ImagePerso��5'      $��0��6'   $	��120��67   $��0,0,0,30q�6G   �� 5(      -   5        $��0��5(      $*��$Choisir une photo pour le personnage��6%   $��Center=�6T   $��Bottom=�6q   $��0,0,0,10q�6�   6�   � 5*      $��1��6   .+�5+      �� -   5        $��1��5+      $'��!Enregistrer le nouveau personnage��6)   $��Center=�6U   $��Center=�6r   $��	0,-30,0,0q�6�   
 �� 	IsDefault
 . 6�   �� 5,      -   5        $��1��5,      $��Annuler��6)   $��Center=�6;   $��Center=�6X   $��0,60,0,0q�6s    �� IsCancel . 6�   5-      5/      51      52      