   M S B A M L   `   `   `  ����J  FProjetGraphique, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProjetGraphiqueProjetGraphique  5      (    "ProjetGraphique.OngletCommentaires   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ProjetGraphique     5      .��5	      � ��5
   
   �� 5      .��5      �   � Color$  Thistle��6    � Offset$	 0.0Q�6/   � 5      $  	LightBlue��6   $	 1.0Q�61   5       � RowDefinitions 5   
   �� 5      $	��79* �6   �� 5      $
��121* �6   �� 5      $	��51* �6   �� 5      $
��149* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��1* �6#   .+�5      �� $��0��6   .+�5      �� -   5         ��Name$ 	LabelNote��5      $��Note :��6+   $��22,10,140,0q�6<   ]� 5       $��	26,0,60,0q�6   .+�5!      �� -   5         ��Name$ NoteCheckBox1��5!      $��0,0,0,0q�66   6G   �� 5"      -   5        $ NoteCheckBox2��5"      $��10,0,0,0q�66   6H   �� 5#      -   5        $ NoteCheckBox3��5#      $��10,0,0,0q�66   6H   �� 5$      -   5        $ NoteCheckBox4��5$      $��10,0,0,0q�66   6H   �� 5%      -   5        $ NoteCheckBox5��5%      $��10,0,0,0q�66   6H   5&      5'      �� 5)      $��1��6   .+�5*      �� -   5        $ LabelNomCommentaire��5*      $��Nom :��65   $��Center=�6E   $��0,10,0,0q�6b   �� 5+      -   5         ��Name$ TextBoxNomCommentaire��5+      $��Center=�69   $	��120��6V   $��30��6b    �� TextWrapping$
 Wrap=�6q   5,      5-      � 51   
   $��1��6    52      �� 53      $
��303* �6#   �� 54      $
��112* �6#   .+�57      �� $��0��6   .+�58      �� -	   5        $ LabelCommentaire��58      $��Commentaire :��62   $��
22,5,140,0q�6J   �� 59      -
   5        $ TextBoxCommentaire��59      $��70��66   $	��180��6E   $��	26,0,26,0q�6U   $
 Wrap=�6h    �� 	MaxLength$	 300��6|   	 �� AcceptsReturn	 . 6�   5:      �� 5<      -   5        
 ��Name$
 BoutonEnvoyerCommentaire��5<   R   $��1��6B   $��Envoyer��6t   $��5q�6�   $��Center=�6�   $��Center=�6�    � DataContext 6   �� *collectionComposants+6�   5=      �� 5A   
   $��2��6   $��Liste des commentaires :��6   $��Center=�6@   $��15,0,0,0q�6[   $��26��6m   � 5E   
   $��3��6   .+�5F      �� -   5        $ LabelTousLesCommentaires��5F      $��Tous les commentaires :��66   $��10,5,265,85q�6X   � 5H      -   5         �Name$ GridComs��5H      .+�5I      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridComs��5I         AutoGenerateColumns .   �� TextAlignment$ Center=�6w      GridLinesVisibility$
 None=�6�      HeadersVisibility$
 None=�6�      
IsReadOnly . ��61   �� *ListeCommentaires+��5J      �� 5K       �� EndPoint$	 1,1&�6.    �� 
StartPoint$	 0,0&�6=   .��5L      � $  Thistle��6+   $ 0Q�6;   � 5M      $  	LightBlue��6+   $ 1Q�6=   5N         RowStyle 5P      �� 5Q       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6     �� Triggers 5R      P� 5S   "    P� Property �@ 
IsSelected P� Value . . �5T   &   ��  �� Property � �� �� Value
 ���� 6C   5U   #   5W         	CellStyle 5Y      �� 5Z      *  $System.Windows.Controls.DataGridCell"  6    .�5[      ��  � ��
 ���� 6;   �� 5\       � ��$ 0q�6@   �� 5]       � ��
 �   �6;   5_         Columns 5c      0  *System.Windows.Controls.DataGridTextColumn  5f      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6E      CanUserResize .  1  +System.Windows.Controls.DataGridBoundColumn    Binding  6-   �� *Nom+!   ElementStyle! 5g      �� 5h   "   .�5i   &   ��  � ��$
 Wrap=�6O   �� 5j   &    � ��$ Center=�6V   �� 5k   &    � ��$ Center=�6T   �� 5l   &    � ��$ 0,5,0,5q�6I   5m   #   5o        5s      $ * 6-    .    67   �� *Texte+! 5t      �� 5u   "   .�5v   &   ��  � ��$
 Wrap=�6O   �� 5w   &    � ��$ Center=�6V   �� 5x   &    � ��$ Center=�6T   5y   #   5{        5~      $ 40 6F    .    6-   �� *Note+! 5      �� 5�   "   .�5�   &   ��  � ��$ Center=�6V   �� 5�   &    � ��$ Center=�6T   5�   #   5�      5�      5�      5�      5�      5�      