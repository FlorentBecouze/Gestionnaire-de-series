   M S B A M L   `   `   `  ����J  FProjetGraphique, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ProjetGraphiqueProjetGraphique  5      '    !ProjetGraphique.OngletPersonnages   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ProjetGraphique     5      .��5	      � ��5
   
   �� 5      .��5      �   � Color$  Thistle��6    � Offset$	 0.0Q�6/   � 5      $  	LightBlue��6   $	 1.0Q�61   5       � ColumnDefinitions 5   
   �� 5      $
��401* �6    � RowDefinitions 5   
   �� 5      $	��55* �6   �� 5      $
��272* �6   .+�5   
   � $��0��6    5      �� 5      $��1* �6#   �� 5      $��1* �6#   .+�5      �� -   5         ��Name$ BoutonAjoutPersonnage��5   R   $��0��6B   $��Ajouter un personnage��6q   $��24��6�   $��Center=�6�   $��Center=�6�    � DataContext 6   �� *collectionComposants+6�   �� 5      -   5        $ BoutonModifPersonnage��5   %   $��1��6   $��Modifier ce personnage��6D   $��24��6e   $��Center=�6q   $��Center=�6�   6�   5       � 5#   
   -   5         �Name$ 	GridPerso��5#      $��1��6"   .+�5$      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridPerso��5$      $ �� IsSynchronizedWithCurrentItem$
 TrueY�6W   	   AutoGenerateColumns	 .  
 �� TextAlignment$
 Center=�5%         GridLinesVisibility$
 None=�6<      HeadersVisibility$
 None=�6W      
IsReadOnly . ��5$   .   �� *ListePersonnages+��5&      �� 5'       �� EndPoint$	 1,1&�6*    �� 
StartPoint$	 0,0&�69   .��5(      � $  Thistle��6'   $ 0Q�67   � 5)      $  	LightBlue��6'   $ 1Q�69   5*         RowStyle 5,      �� 5-       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    �� Triggers 5.      P� 5/       P� Property �@ 
IsSelected P� Value . . �50   "   ��  �� Property � �� �� Value
 ���� 6?   51      53         	CellStyle 55      �� 56      *  $System.Windows.Controls.DataGridCell"  6   .�57      ��  � ��
 ���� 67   �� 58       � ��$ 0q�6<   �� 59       � ��
 �   �67   5:         Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6A      CanUserResize .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *Nom+   ElementStyle 5B      �� 5C      .�5D   "   ��  � ��$
 Wrap=�6K   �� 5E   "    � ��$ Center=�6R   �� 5F   "    � ��$ Center=�6P   5G      5I      4  .System.Windows.Controls.DataGridTemplateColumn  5L      $ * 6-    .     CellTemplate 5M      �� 5N      .R�5O   "   �� $	��250��6A   ��6(   �� *Photo+6A   5P      5R        5V      $ * 6)    .   63   �� *DescriptionPersonnage+ 5W      �� 5X      .�5Y   "   ��  � ��$
 Wrap=�6K   �� 5Z   "    � ��$ Center=�6R   �� 5[   "    � ��$ Center=�6P   5\      5^      5a      5b      5d      5e      