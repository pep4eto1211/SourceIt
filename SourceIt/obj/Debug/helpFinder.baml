   M S B A M L   `   `   `  ����  SourceIt    SourceIt.helpFinder   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          N� Title$  
helpFinder��5      $	��525��6   $	��729��6$    � 	Resources 5	         InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel	 �� AncestorType
 �� Value��%�   &	        �� 5
   
   " ��6&   .�5      ��  � ��
 �   �6+    5      �� 5       6   �� *IsMouseOver+ �� $ 1��"	 ��
 True6�   .a�5      ��  � ��
 �����63   5      5      5      .��5      � -   5        $��helpFinderMainGrid��5   "   ���	#FFE4E4E4 � RowDefinitions 5   
   �� 5      $	��56* �6   �� 5      $	��53* �6   �� 5      $
��411* �6    � Triggers 5   
   :� 5       :� RoutedEvent$ Grid.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ helpFinderMainGrid��6*    �� TargetProperty$ Opacity�6U    W� From$	 0.0X�6y   	 W� To$	 1.0X�6�    g� Duration$ 0:0:0.5D�6�   5       5!      5"      .+�5$   
   �� $��40,1,0,0q�6   $
��Wrap=�6&   $	��Top=�6:   ���	#FF3A3A3A$��36(�6i   $��
Помощ��6w   $��Segoe UI Light)�6�   $��CharacterEllipsis=�6�   $
��Left=�6�   $	��378��6�   $��48��6�   $	��138��6�   �� 5%   
   -   5        $
��Left=�5%      $	��Top=�6,   $��25��6D   $��18(�6O   $��Segoe UI Light)�6]   $��25��6�   ���	#FFE4E4E4 � Cursor$
 Hand��6�     ButtonStyleOne#���  6�   $��	10,15,0,0q�6�    K� ZIndex$ -5��6�    � ToolTip$ Go back to startup page��6  ��6y   Z� .��5&      � $��25��6   $��25��6   .+�5'      �� $��Images/backButton.png��6   $��25��67   $��25��6B   $��UniformToFill=�6N   $��0,-4,0,0q�6f    J� Effect 5(      3  -System.Windows.Media.Effects.DropShadowEffect  5)         
BlurRadius$ 5Q�6+      Color$ 	#FF3A3A3A��6:      	Direction$	 315Q�6L      ShadowDepth$	 1.5Q�6\   5+      5-      5.      � 5/   
   $��1��6   .+�50      �� -   5         ��Name$ allTab��50      $
 Hand��6%   ���	#FF3A3A3A���	#FF0080FF$��18(�6b   ���	#FFE4E4E4$��Segoe UI Light)�6�    � UseLayoutRounding .  #���  6�   $��0,1,1,1q�6�   $��1��6   $��	0,0,-76,0q�6%  $
��Left=�68  $��364.5��6S  .��51      � .+�52      �� -   5         ��Name$ allTabLabel��52      $��Всички��61   $��0q�6B   $��Center=�6M   $��Center=�6j   #��[  6�    53        54      $ 5Q�6/   $ 	#FF3A3A3A��6>   $	 315Q�6P   $	 1.5Q�6`   56      57      58      �� 59      -   5        $ mineTab��59      $
 Hand��6&   ���	#FF3A3A3A���	#FF0080FF$��18(�6c   ���	#FFE4E4E4$��Segoe UI Light)�6�    .  #���  6�   $��0,1,1,1q�6�   $��364.5,0,0,0q�6  .��5:      � .+�5;      �� -   5        $ mineTabLabel��5;      $��Мои��62   $��0q�6@   $��Center=�6K   $��Center=�6h   #��[  6�    5<        5=      $ 5Q�6/   $ 	#FF3A3A3A��6>   $	 315Q�6P   $	 1.5Q�6`   5?      5@      5A      5B      �� 5C   
   $��2��6   ��. $
��Auto=�6<   $ -3��6_   .��5D      �� -   5         ��Name$ itemsStackPanel��5D      5E      � 5F   
   -	   5         �Name$ loader��5F      $��3��6   $ 20��60   
���   �  J� Opacity$	  0.7Q�6U   .+�5G      �� -
   5        ! ��Name$! loadingMessage��5G      $��174.346,191,173.653,0q�60   $
��Wrap=�6O   ���	#FFE4E4E4$��36(�6z   $.��(Зареждане на елементи��6�   $��Segoe UI Light)�6�   $��CharacterEllipsis=�6�   $��Center=�6�   $	��Top=�6�   � 5H      $��Center=�6   $��29��67   $��251.5,262,251.5,0q�6C   $	��Top=�6^   $	��226��6v   ���	#FFE4E4E4���	#FFE4E4E4" � IsIndeterminate" . ��6�   Z� 6�   5I      �� 5J   
   -   5        $��Right=�5J      $��Bottom=�6-   $��18(�6H   $��Segoe UI Light)�6V   $��30��6r   ���	#FFE4E4E4$
 Hand��6�   #���  6�   $ -5��6�   $��0q�6�   ���	#FF0080FF$	��171��6
  $��	0,0,10,11q�6-  .��5K      � $	��165��6   .+�5L      �� $��Images/editIcon.png��6   $��UniformToFill=�65   $��0,-2,0,0q�6M   $��30��6_   $��30��6j   $
��Left=�6v    5M        5N      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   5P      �� 5Q      -   5        $ helpFindLabel_Copy2��5Q      $$��Задай нов въпрос��65   #��[  6P   $��16(�6w   $��30,-4,-94,1q�6�   $
��Left=�6�    5R        5S      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   5U      5W      5X      � 5Y   
   -   5        $ openQuestionGrid��5Y      $��2��6)   ���	#FFE4E4E4$��1��6Q   $y�Hidden=�6^   .+�5Z      �� -   5        # ��Name$# DividerMain_Copy3��5Z      $��2��6/   $��Bottom=�6:   $
��None=�6U   $ ��Images/DividerMainBlue.png��6d   $��	0,0,0,396q�6�   �� 5[      -   5        $ ��Name$$ questionContent��5[      % �� TextWrapping$
% Wrap=�6/   $��Question content��6C   & �� 
IsReadOnly& . $ Arrow��6�   ���	#FF0080FF���	#FF3A3A3A"' �� VerticalScrollBarVisibility$
' Auto=�6�   $��0q�6�     PostTextBoxStyle#���  6�   $��18(�6#  $��71��61  ��. $��79��6b  $	��Top=�6q  ��6[   Z� 6q  �� 5\      $��	0,72,0,30q�6   ��. $
��Auto=�6F   .��5]      �� -   5        $ answersStackPanel��5]      .+�5^      � -   5        $ answersLabelGrid��5^      $	��Top=�65   $��5,20,5,0q�6M   $��46��6_   .+�5_      �� $$��Всички отговори:��6    $
��Left=�6;   $	��Top=�6V   ���	#FF3A3A3A$��24(�6�   $��Segoe UI Light)�6�   $��0q�6�   �� 5`      -   5        $# DividerMain_Copy1��5`       $��2��6;   $��Bottom=�6F   $
��None=�6a   $ ��Images/DividerMainBlue.png��6p   5a      5b      5c      �� 5d      -   5        $# DividerMain_Copy��5d      $��2��6.   $	��Top=�69   $
��None=�6Q   $ ��Images/DividerMainBlue.png��6`   $��0q�6�   �� 5e      -   5        $# DividerMain_Copy2��5e      $��2��6/   $��Bottom=�6:   $
��None=�6U   $ ��Images/DividerMainBlue.png��6d   $��0,0,0,30q�6�   �� 5f      -   5        $��Right=�5f      $��Bottom=�61   $��18(�6L   $��Segoe UI Light)�6Z   $��30��6v   ���	#FFE4E4E4$
 Hand��6�   #���  6�   $ -5��6�   $��0q�6�   ���	#FF0080FF$	��193��6  $��0q�67  .��5g      � $	��187��6   .+�5h      �� $��Images/editIcon.png��6   $��UniformToFill=�69   $��0,-2,0,0q�6Q   $��30��6c   $��30��6n   $
��Left=�6z    5i        5j      $ 5Q�6/   $ 	#FF3A3A3A��6>   $	 315Q�6P   $	 1.5Q�6`   5l      �� 5m      -   5        $ helpFindLabel_Copy1��5m      $*��$Отговори на въпроса��69   #��[  6W   $��16(�6~   $��30,-4,-94,1q�6�   $
��Left=�6�    5n        5o      $ 5Q�6/   $ 	#FF3A3A3A��6>   $	 315Q�6P   $	 1.5Q�6`   5q      5s      5t      �� 5u      -   5        $��Right=�5u      $��Bottom=�61   $��18(�6L   $��Segoe UI Light)�6Z   $��30��6v   ���	#FFE4E4E4$
 Hand��6�   #���  6�   $ -5��6�   $��0q�6�   ���	#FF0080FF$��86��6  $��	0,0,193,0q�60  .��5v      � $��80��6   .+�5w      �� $��Images/newCloseIcon.png��6   $��UniformToFill=�6=   $��0,-2,0,0q�6U   $��30��6g   $��30��6r   $
��Left=�6~    5x        5y      $ 5Q�6/   $ 	#FF3A3A3A��6>   $	 315Q�6P   $	 1.5Q�6`   5{      �� 5|      -   5        $ helpFindLabel_Copy3��5|      $��
Отказ��69   #��[  6I   $��16(�6p   $��30,-4,-94,1q�6~   $
��Left=�6�    5}        5~      $ 5Q�6/   $ 	#FF3A3A3A��6>   $	 315Q�6P   $	 1.5Q�6`   5�      5�      5�      5�      5�      5�      