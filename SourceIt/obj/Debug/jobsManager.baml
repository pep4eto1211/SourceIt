   M S B A M L   `   `   `  ����  SourceIt    SourceIt.jobsManager   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          N� Title$  jobsManager��5      $	��525��6   $	��729��6$    � 	Resources 5	         InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel	 �� AncestorType
 �� Value��%�   &	        �� 5
   
   " ��6&   .�5      ��  � ��
 �   �6+    5      �� 5       6   �� *IsMouseOver+ �� $ 1��"	 ��
 True6�   .a�5      ��  � ��
 �����63   5      5      5      .��5      � -   5        $��jobsManagerMainGrid��5   "   ���	#FFE4E4E4 � Triggers 5   
   :� 5       :� RoutedEvent$ Grid.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ jobsManagerMainGrid��6*    �� TargetProperty$ Opacity�6V    W� From$	 0.0X�6z   	 W� To$	 1.0X�6�    g� Duration$ 0:0:0.5D�6�   5      5      5      .+�5   
   �� $��40,1,0,0q�6   $
��Wrap=�6&   $	��Top=�6:   ���	#FF3A3A3A$��36(�6i   $,��&Управление на работа��6w   $��Segoe UI Light)�6�   $��CharacterEllipsis=�6�   $
��Left=�6�   $	��378��6�   �� 5    
   -   5        $
��Left=�5       $	��Top=�6,   $��25��6D   $��18(�6O   $��Segoe UI Light)�6]   $��25��6�   ���	#FFE4E4E4 � Cursor$
 Hand��6�     ButtonStyleOne#���  6�   $��	10,15,0,0q�6�    K� ZIndex$ -5��6�    � ToolTip$ Go back to startup page��6  ��6y   Z� .��5!      � $��25��6   $��25��6   .+�5"      �� $��Images/backButton.png��6   $��25��67   $��25��6B   $��UniformToFill=�6N   $��0,-4,0,0q�6f    J� Effect 5#      3  -System.Windows.Media.Effects.DropShadowEffect  5$         
BlurRadius$ 5Q�6+      Color$ 	#FF3A3A3A��6:      	Direction$	 315Q�6L      ShadowDepth$	 1.5Q�6\   5&      5(      5)      �� 5*   
   $
��Auto=�6   ��. $��0,58,0,0q�6R   .��5+      �� -   5         ��Name$ allPostsPanel��5+      .+�5,      �� -   5         ��Name$ 
emptyLabel��5,      $,��&В момента няма обяви ��6,   $��Center=�6L   $	��Top=�6i   ���	#FF3A3A3A$��24(�6�   $��Segoe UI Light)�6�   $��0,20,0,0q�6�   5-      5.      � 5/   
   -   5         �Name$ loader��5/      
���   � J� Opacity$	 0.7Q�62   $��0q�6@   .+�50      �� -   5         ��Name$ loadingMessage��50      $��174.693,191,173.306,0q�60   $
��Wrap=�6O   ���	#FFE4E4E4$��36(�6z   $.��(Зареждане на елементи��6�   $��Segoe UI Light)�6�   $��CharacterEllipsis=�6�   $��Center=�6�   $	��Top=�6�   � 51      $��Center=�6   $��29��67   $��251.5,262,251.5,0q�6C   $	��Top=�6^   $	��226��6v   ���	#FFE4E4E4���	#FFE4E4E4 � IsIndeterminate . ��6�   Z� 6�   52      �� 53   
   -   5          ��Name$  DividerMain_Copy3��53      $��2��6+   $	��Top=�66   $
��None=�6N   $ ��Images/DividerMainBlue.png��6]   $��0,57,0,0q�6�   $ -4��6�   �� 54   
   -	   5        $��Right=�54      $��Bottom=�6-   $��18(�6H   $��Segoe UI Light)�6V   $��30��6r   ���	#FFE4E4E4$
 Hand��6�   #���  6�   $ -5��6�   $��0q�6�   ���	#FF0080FF$	��168��6
  $��
0,0,10,479q�6-  .��55      � .+�56      �� -
   5        $ helpFindLabel_Copy2��56      $(��"+ Добави нова обява��65   #��[  6S   $��16(�6z   $��0,-4,0,1q�6�    57        58      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   5:      5<      5=      5>      5?      