   M S B A M L   `   `   `  ����  SourceIt    SourceIt.projectDashboard   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          N� Title$  projectDashboard��5      $	��375��6   $	��729��6(    � 	Resources 5	         InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel	 �� AncestorType
 �� Value��%�   &	        �� 5
   
   " ��6&   .�5      ��  � ��
 �   �6+    5      �� 5       6   �� *IsMouseOver+ �� $ 1��"	 ��
 True6�   .a�5      ��  � ��
 �����63   5      5      5      .��5      � -   5        $��projectDashboardMainGrid��5   "   ���	#FFE4E4E4 � Triggers 5   
   :� 5       :� RoutedEvent$ Grid.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ projectDashboardMainGrid��6*    �� TargetProperty$ Opacity�6[    W� From$	 0.0X�6   	 W� To$	 1.0X�6�    g� Duration$ 0:0:0.5D�6�   5      5      5       � RowDefinitions 5   
   �� 5       $	��13* �6   �� 5!      $
��112* �6   .+�5#   
   �� $
��Auto=�6   ��. $��-1,0,1,0q�6R   $��1��6d   .��5$      �� -   5         ��Name$ allPostsPanel��5$      5%      �� 5&   
   -   5         ��Name$ DividerMain��5&      $��2��6%   $��1��60   $	��Top=�6=   $
��None=�6U   $ ��Images/DividerMainBlue.png��6d   � 5'   
   -   5         �Name$ loader��5'      $��2��6   
���   � J� Opacity$	 0.7Q�6C    K� ZIndex$	 100��6Q   .+�5(      �� -   5         ��Name$ loaderLable��5(      $
��Wrap=�6-   ���	#FFE4E4E4$��36(�6X   $+��%Взимане на постове...��6f   $��Segoe UI Light)�6�   $��CharacterEllipsis=�6�   $��Center=�6�   $��Center=�6�   $��0,116,0,207q�6�   � 5)      $��Center=�6   $��29��67   $��Center=�6C   $	��226��6^   ���	#FFE4E4E4���	#FFE4E4E4 � IsIndeterminate . ��6j   Z� 6�   5*      �� 5+   
   -   5         ��Name$ newPostButton��5+       � Cursor$
 Hand��6(   ���	#FF3A3A3A���	#FF0080FF$��18(�6e   ���	#FFE4E4E4$��Segoe UI Light)�6�    � UseLayoutRounding .    ButtonStyleOne#���  6�   $��0,0,1,0q�6�   .��5,      � .+�5-      �� -   5         ��Name$ newPostLabel��5-      $$��+ Създай нов пост��6.   $��0q�6J   $��Center=�6U   $��Center=�6r   #��[  6�    J� Effect 5.      3  -System.Windows.Media.Effects.DropShadowEffect  5/         
BlurRadius$ 5Q�6+       Color$  	#FF3A3A3A��6:   !   	Direction$	! 315Q�6L   "   ShadowDepth$	" 1.5Q�6\   51      52      53      � 54   
   -	   5        $ newPostPanel��54      $	��108��6%   $	��Top=�62   $��2��6J   ���	#FFE4E4E4$y�Hidden=�6r   .+�55      �� -
   5        $ projectNameBlock��55      $��20,0,0,0q�62   $
��Wrap=�6D   $	��Top=�6X   ���	#FF3A3A3A$��18(�6�   $.��(Създаване на нов пост:��6�   $��Segoe UI Light)�6�   $��CharacterEllipsis=�6�   $
��Left=�6�   $	��378��6  �� 56      -   5        # ��Name$# newPostContent��56      $
��Left=�6.   $��68��6I   $��	20,29,0,0q�6U   $ �� TextWrapping$
$ Wrap=�6h   $G��AНапишете съдържанието на поста тук.��6|   $	��Top=�6�   $	��569��6�   $��18(�6�   ���	#FF0080FF���	#FFA6A6A6% �� SelectionBrush% �	#FFB6B6B6��6�   Z� 6\  �� 57      -   5        $ createPostButton��57      $
��Left=�6/   $
 Hand��6J   $	��135��6X   ���	#FF3A3A3A���	#FF0080FF$��18(�6�   ���	#FFE4E4E4$��Segoe UI Light)�6�   $��	594,0,0,0q�6�    .  #���  6  $��1,0,0,0q�6*  $��54��6D  $	��Top=�6P  .��58      � .+�59      �� -   5        $ dashboardTabLabel��59      $��Създаване��67   $��0q�6K   $��Center=�6V   $��Center=�6s   #��[  6�    5:        5;      $ 5Q�6/   $  	#FF3A3A3A��6>   $	! 315Q�6P   $	" 1.5Q�6`   5=      5>      5?      �� 5@      -   5        $ cancelPostCreationButton��5@      $
 Hand��67   $	��135��6E   ���	#FF3A3A3A���	#FF0080FF$��18(�6�   ���	#FFE4E4E4$��Segoe UI Light)�6�   $��
594,54,0,0q�6�    .  #���  6�   $��1,0,0,0q�6  $��54��62  $
��Left=�6>  $	��Top=�6Y  .��5A      � .+�5B      �� -   5        $ dashboardTabLabel1��5B      $��
Отказ��68   $��0q�6H   $��Center=�6S   $��Center=�6p   #��[  6�    5C        5D      $ 5Q�6/   $  	#FF3A3A3A��6>   $	! 315Q�6P   $	" 1.5Q�6`   5F      5G      5H      �� 5I      -   5        $ DividerMain_Copy��5I      $
��Left=�6.   $��2��6I   $��	0,106,0,0q�6T   $��Bottom=�6g   $	��729��6�   $
��None=�6�   $ ��Images/DividerMainBlue.png��6�   5J      5L      5M      