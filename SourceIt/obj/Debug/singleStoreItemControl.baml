   M S B A M L   `   `   `  ����  SourceIt%    SourceIt.singleStoreItemControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        $	��Top=�5   7   $��
10,20,10,0q�6O   $	��135��6c   ���	#FF0080FF$��0,0,0,1q�6�     � 	Resources  5         InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType	 �� Value��%�   &	        �� 5	   
   " ��6&   .�5
      ��  � ��
 �   �6+    5      �� 5       6   �� *IsMouseOver+ �� $ 1��" ��	 True6�   .a�5      ��  � ��
 �����63   5      5      5      .��5      � ���	#FFE4E4E4.+�5   
   �� -   5        
 ��Name$
 itemNameLabel��5      $��105,5,105,0q�6+   $
��Wrap=�6@   $	��Top=�6T   ���	#FF3A3A3A$��22(�6�   $��Segoe UI Light)�6�   $��30��6�   $��CharacterEllipsis=�6�   �� 5   
   -   5         ��Name$ itemIcon��5      $
��Left=�6"   $	��100��6=   $	��Top=�6J   $	��100��6b   $��0q�6n   $
��Fill=�6y   �� 5   
   -   5        $
 itemDescriptionLabel��5      $��105,39,5,35q�62   $
��Wrap=�6G   ���	#FF3A3A3A$��16(�6r   $��Segoe UI Light)�6�   $��56��6�   $��CharacterEllipsis=�6�   �� 5   
   -   5        $��Right=�5      $��Bottom=�6-   $��18(�6H   $��Segoe UI Light)�6V   $��30��6r   ���	#FFE4E4E4 � Cursor$
 Hand��6�     ButtonStyleOne#���  6�    K� ZIndex$ -5��6�   $��0q�6�   ���	#FF0080FF$	��101��6
   � ToolTip$ Сваляне��6  .��5      � $	��124��6   .+�5      �� $��Images/downloadStore.png��6   $��UniformToFill=�6:   $��0,-2,0,0q�6R   $��30��6d   $��30��6o   $
��Left=�6{    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6+      Color$ 	#FF3A3A3A��6:      	Direction$	 315Q�6L      ShadowDepth$	 1.5Q�6\   5      �� 5      -   5         ��Name$ helpFindLabel_Copy��5      $��Сваляне��64   #��[  6F   $��16(�6m   $��30,-4,-94,1q�6{    5        5       $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   5"      5$      5%      �� 5&   
   -   5        $��Right=�5&      $��Bottom=�6-   $��18(�6H   $��Segoe UI Light)�6V   $��30��6r   ���	#FFE4E4E4$
 Hand��6�   #���  6�   $ -5��6�   $��0q�6�   ���	#FF0080FF$	��124��6
  $ Виж повече��6  $��	0,0,101,0q�6+  .��5'      � .+�5(      �� $��Info.png��6   $��UniformToFill=�6*   $��0,-2,0,0q�6B   $��30��6T   $��30��6_   $
��Left=�6k    5)        5*      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   5,      �� 5-      -   5        $ helpFindLabel��5-      $��Виж повече��6/   #��[  6D   $��16(�6k   $��	30,-4,0,1q�6y    5.        5/      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   51      53      54      56      57      