   M S B A M L   `   `   `  ����  SourceIt    SourceIt.settings   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        $	��729��5   0   $	��525��6<     N� Title$  settings��5       � 	Resources 5	         InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel	 �� AncestorType
 �� Value��%�   &	        �� 5
   
   " ��6&   .�5      ��  � ��
 �   �6+    5      �� 5       6   �� *IsMouseOver+ �� $ 1��"	 ��
 True6�   .a�5      ��  � ��
 �����63   5      5      5      .��5      � -   5        $��settingsMainGrid��5   "   ���	#FFE4E4E4 � Triggers 5   
   :� 5       :� RoutedEvent$ Grid.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ settingsMainGrid��6*    �� TargetProperty$ Opacity�6S    W� From$	 0.0X�6w   	 W� To$	 1.0X�6�    g� Duration$ 0:0:0.5D�6�   5      5      5      .+�5   
   �� $��40,1,0,0q�6   $
��Wrap=�6&   $	��Top=�6:   ���	#FF3A3A3A$��36(�6i   $��Настройки��6w   $��Segoe UI Light)�6�   $��CharacterEllipsis=�6�   $
��Left=�6�   $	��378��6�   �� 5    
   -   5        $
��Left=�5       $	��Top=�6,   $��25��6D   $��18(�6O   $��Segoe UI Light)�6]   $��25��6�   ���	#FFE4E4E4 � Cursor$
 Hand��6�     ButtonStyleOne#���  6�   $��	10,15,0,0q�6�    K� ZIndex$ -5��6�    � ToolTip$ Go back to startup page��6  ��6y   Z� .��5!      � $��25��6   $��25��6   .+�5"      �� $��Images/backButton.png��6   $��25��67   $��25��6B   $��UniformToFill=�6N   $��0,-4,0,0q�6f    J� Effect 5#      3  -System.Windows.Media.Effects.DropShadowEffect  5$         
BlurRadius$ 5Q�6+      Color$ 	#FF3A3A3A��6:      	Direction$	 315Q�6L      ShadowDepth$	 1.5Q�6\   5&      5(      5)      �� 5*   
   $��	40,86,0,0q�6   $
��Wrap=�6'   $	��Top=�6;   ���	#FF3A3A3A$��36(�6j   $+��%Настройки на сървър:��6x   $��Segoe UI Light)�6�   $��CharacterEllipsis=�6�   $
��Left=�6�   $	��378��6�   �� 5+   
   -   5         ��Name$ mainServerBox��5+      $
��Left=�6)   $��
95,139,0,0q�6D    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $��24(�6�   $	��565��6�   ���	#FF0080FF���	#FF1E1E1E��6�   Z� 6�   �� 5,   
   $��
40,237,0,0q�6   $
��Wrap=�6(   $	��Top=�6<   ���	#FF3A3A3A$��36(�6k   $+��%Настройки на профил:��6y   $��Segoe UI Light)�6�   $��CharacterEllipsis=�6�   $
��Left=�6�   $	��378��6�   �� 5-   
   -   5         ��Name$ usernameBox��5-      $��
95,290,0,0q�6)   $
��Wrap=�6=   $	��Top=�6Q   ���	#FF3A3A3A$��36(�6�   $��Segoe UI Light)�6�   $��CharacterEllipsis=�6�   $
��Left=�6�   $	��378��6�   �� 5.   
   -   5        $
��Left=�5.      $
 Hand��6,   $	��216��6:   ���	#FF3A3A3A���	#FF303030$��18(�6u   $��95,343,0,137q�6�   ���	#FFE4E4E4#���  6�   $��Segoe UI Light)�6�   $��0q�6�   .��5/      � $��Center=�6   $��Center=�60   .+�50      �� $"��Изход от профил��6   $��0,0,0,2q�62   $
��Left=�6C   $��Center=�6^   #��[  6y   $��24(�6�    51        52      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   54      55      56      �� 57   
   -   5        $
��Left=�57      $
 Hand��6,   $	��216��6:   ���	#FF3A3A3A���	#FF303030$��18(�6u   $��444,178,0,302q�6�   ���	#FFE4E4E4#���  6�   $��Segoe UI Light)�6�   $��0q�6�   .��58      � $��Center=�6   $��Center=�60   .+�59      �� $"��Смяна на сървър��6   $��0,0,0,2q�62   $
��Left=�6C   $��Center=�6^   #��[  6y   $��24(�6�    5:        5;      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   5=      5>      5?      �� 5@   
   -   5        $
��Left=�5@      $
 Hand��6,   $	��230��6:   ���	#FF3A3A3A���	#FF303030$��18(�6u   $��	95,0,0,42q�6�   ���	#FFE4E4E4#���  6�   $��Segoe UI Light)�6�   $��0q�6�   $��Bottom=�6  .��5A      � $��Center=�6   $��Center=�60   .+�5B      �� $'��!Докладвай проблем��6   $��0,0,0,2q�64   $
��Left=�6E   $��Center=�6`   #��[  6{   $��24(�6�    5C        5D      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   5F      5G      5H      5I      5J      