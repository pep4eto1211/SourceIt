   M S B A M L   `   `   `  ����  SourceIt    SourceIt.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   -   5          � Title$  SourceIt��5   	   $��674.737��6   $
��1177��6+    � WindowStartupLocation$ CenterScreen=�68   ���	#FF0080FF$��1q�6u    � Icon$ Images/NewLogo.png��6�    � 
ResizeMode$ NoResize=�6�    � WindowStyle$
 None=�6�    � 	Resources 5         onlineStatusMenu m� Icon  InButtonLabel �� 
TargetType �� Property	 �� Value
 �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%  &	        &	     �� 5   
   .@�5      m� -   5        $��Online��5       5	      �� 5
      $��Images/connected.png��6   5      �� 5      m� 5      -   5        $��Offline��5       5      �� 5      $��Images/disconnected.png��6   5      5      �� 5   
   " ��6&   .�5      ��  � ��
	 �   �6+   
 5      �� 5       6   �� *IsMouseOver+ �� $ 1��" �� True6�   .a�5      ��  � ��
	 �����63   5      5      5      .��5      � ���	#FFE4E4E4 � RowDefinitions 5   
   �� 5      $	��36* �6   �� 5       $
��112* �6   �� 5!      $
��525* �6   .+�5#   
   � -   5         �Name$ titleBar��5#      $��35��6!   $	��Top=�6-   ���	#FFE4E4E4 K� ZIndex$ -1��6{   .+�5$      �� -   5        $�� ��5$      $��Right=�6    $��0,4,25,0q�6<   $	��Top=�6N   $��25��6f   $��25��6q    � ToolTip$ Minimise the app��6}   
�������$��18(�6�     TitleBarButton#���  6�    J� RenderTransformOrigin$ 0.5,0.5&�6  ��6�   Z� ��5%      �� 5&       �� ImageSource$  Images/newMinimiseIcon.png��6!   5(      �� 5)      -   5        $�� ��5)      $��Right=�6    $��0,4,0,0q�6<   $	��Top=�6M   $��25��6e   $��25��6p   $ Close the app��6|   
�������$��18(�6�   #���  6�   ��6�   Z� ��5*      �� 5+      $ Images/newCloseIcon.png��6!   5-      �� 5.      $
��Left=�6   $��30��6/   $��6,0,0,5q�6;   $��Bottom=�6L   $��30��6g   $��Images/TitleBarLogo.png��6r   $
��Fill=�6�   �� 5/      -   5         ��Name$ DividerMain_Copy1��5/      $
��Left=�6/   $��2��6J   $��0,32,0,0q�6U   $	��Top=�6g   $
��1175��6   $
��None=�6�   $ ��Images/DividerMainBlue.png��6�   50      �� 51   
   $��SourceIt��6   $
��Left=�6#   $��	40,-3,0,0q�6>   $	��Top=�6Q   $��35��6i   ���	#FF3A3A3A$��18(�6�   $��75��6�   $��Segoe UI Light)�6�   � 52   
   -   5        $ LeftContentHolder��52      $
��Left=�6*   $��2��6E   $	��446��6R   $��0q�6^    53      �� 54      $	��94* �6    �� 55      $
��385* �6    .+�57      �� -	   5        $��0,0,0,1q�57      ���	#FFE4E4E4���	#FF0080FF  ButtonStyleOne#���  6^    � Cursor$
 Hand��6�   ���	#FF303030.��58      � .+�59      �� $&�� Добави нов проект��6   $��30,0,0,0q�68   $��Segoe UI Light)�6J   $��30(�6f   #���  6t   $
��Left=�6�   $��52��6�    J� Effect 5:      3  -System.Windows.Media.Effects.DropShadowEffect  5;         
BlurRadius$ 5Q�6/      Color$ 	#FF3A3A3A��6>      	Direction$	 315Q�6P      ShadowDepth$	 1.5Q�6`   5=      �� 5>      $
��Left=�6   $��0q�67   $��Images/smallAddIcon.png��6B   $��30��6c   $��30��6n    5?        5@      $ 5Q�6/   $ 	#FF3A3A3A��6>   $	 315Q�6P   $	 1.5Q�6`   5B      5C      5D      �� 5E      $��0q�6   $��1��6&   $
��Auto=�63   ��. .��5F      �� -
   5         ��Name$ projectsList��5F       �� CanVerticallyScroll .  �� CanHorizontallyScroll . $��Visible=�6k   ��. 6�   5G      5H       � 5I   
   -   5           �Name$  	mainFrame��5I      $�� ��6#   $��
446,1,-1,0q�6.   $��2��6B   !  � NavigationUIVisibility$! Hidden=�6O   � 5J   
   -   5        $ 
topBarGrid��5J      $��2��6#   $ -1��64   $��0,34,0,0q�6F   $	��Top=�6X   .+�5K      � -   5        $ servicesGrid��5K      $
��Left=�6)   $	��587��6D   $ 0.479,0.272&�6P   $��0q�6t    5L      �� 5M      $	��43* �6$   �� 5N      $	��82* �6$   .+�5P      �� $��Услуги:��6   $
��Left=�6*   $	��282��6E   $��Segoe UI Light)�6Q   $��18(�6m   $
��Thin"�6{   $��0,5,0,0q�6�   ���	#FF3A3A3A  BigLabel#���  6�   �� 5Q      -   5        $
��Left=�5Q      $
 Hand��64   $	��199��6B   ���	#FF3A3A3A���	#FF0080FF$��18(�6}   ���	#FFE4E4E4$��Segoe UI Light)�6�   $��0,10,0,0q�6�   $��1��6�   " � UseLayoutRounding" .  #���  6�   $��0,1,1,0q�6   .��5R      � $��Center=�6   $��Center=�68   .+�5S      �� -   5        # ��Name$# helpFindLabel��5S       $��
Помощ��67   $��41,0,0,2q�6G   $
��Left=�6Y   $��Center=�6t   #��[ 6�    5T        5U   "   $ 5Q�63   $ 	#FF3A3A3A��6B   $	 315Q�6T   $	 1.5Q�6d   5W      �� 5X      $
��Left=�6    $��34��6;   $��Center=�6G   $��34��6b   $��Images/fixerIcon.png��6m   $��0q�6�   $
��Fill=�6�    5Y        5Z   "   $ 5Q�63   $ 	#FF3A3A3A��6B   $	 315Q�6T   $	 1.5Q�6d   5\      5]      5^      �� 5_      -   5        $
��Left=�5_      $
 Hand��64   $	��199��6B   ���	#FF3A3A3A���	#FF0080FF$��18(�6}   $��
199,10,0,0q�6�   ���	#FFE4E4E4#���  6�   $��Segoe UI Light)�6�   $��1��6�   $��0,1,1,0q�6  .��5`      � $��Center=�6   $��Center=�68   .+�5a      �� $��Упр. на работи��6    $��34,0,0,2q�69   $
��Left=�6K   $��Center=�6f   $	��130��6�   #��[ 6�    5b        5c   "   $ 5Q�63   $ 	#FF3A3A3A��6B   $	 315Q�6T   $	 1.5Q�6d   5e      �� 5f      $
��Left=�6    $��34��6;   $��Center=�6G   $��34��6b   $��Images/jobs.png��6m   $��0q�6�   $
��Fill=�6�    5g        5h   "   $ 5Q�63   $ 	#FF3A3A3A��6B   $	 315Q�6T   $	 1.5Q�6d   5j      5k      5l      �� 5m      -   5        ���	#FF3A3A3A���	#FF0080FF$
 Hand��5m   H   $��18(�6V   $��
398,10,0,0q�6d   ���	#FFE4E4E4$��Segoe UI Light)�6�   $��1��6�   #���  6�   $��0q�6�   $��0,1,0,0q�6�   .��5n      � $��Center=�6   $��Center=�68   .+�5o      �� $��Магазин��6    $��34,0,0,2q�62   $��Center=�6D   $��77��6_   $
��Left=�6j   #��[ 6�    5p        5q   "   $ 5Q�63   $ 	#FF3A3A3A��6B   $	 315Q�6T   $	 1.5Q�6d   5s      �� 5t      $
��Left=�6    $��34��6;   $��Center=�6G   $��34��6b   $��Images/storeIcon.png��6m   $��0q�6�   $
��Fill=�6�    5u        5v   "   $ 5Q�63   $ 	#FF3A3A3A��6B   $	 315Q�6T   $	 1.5Q�6d   5x      5y      5z      � 5{      -   5        $ offlineMessage��5{      $
��Left=�6/   $	��115��6J   $��2��6W   $	��Top=�6h   $	��587��6�   ���	#FFE4E4E4$y�Hidden=�6�   .+�5|      �� $��0,10,0,0q�6    $
��Wrap=�62   $	��Top=�6F   $��45��6^   ���	#FF3A3A3A$��30(�6�   $)��#You are not connected to the server��6�   $��Segoe UI Light)�6�   $��Center=�6�   �� 5}      -   5        $��Center=�5}      $��0,60,0,0q�6:   $	��Top=�6L   $	��135��6d   $��18(�6p   $��Segoe UI Light)�6~   $��33��6�   ���	#FFE4E4E4$
 Hand��6�   #���  6�   ��6�   Z� .��5~      � $	��145��6   $��33��6+   .+�5      �� $:��4Try to reconnect                                    ��6$   $��Right=�6c   $��0,-3,0,0q�6   $	��Top=�6�   $	��145��6�   #���  6�    5�   "     5�   &   $ 5Q�67   $ 	#FF3A3A3A��6F   $	 315Q�6X   $	 1.5Q�6h   5�      5�      5�      5�      5�      � 5�      -   5        $ NotificationsGrid��5�      $
��Left=�6.   $��	587,0,0,0q�6I   $	��Top=�6\   $	��221��6t   $ 1��6�   .+�5�      �� $��Известия:��6   $��Segoe UI Light)�6,   $��18(�6H   $
��Thin"�6V   ���	#FF3A3A3A#���  6   $y�	Collapsed=�6�   �� 5�      -   5        $ notificationsDivider��5�      $
��Left=�66   $	��116��6Q   $��0,-2,0,0q�6^   $	��Top=�6p   $��1��6�   $��2��6�   $
��None=�6�   $#��Images/dividerRotatedBlue.png��6�   �� 5�      -   5        $ notificationsDivider_Copy��5�      $��Right=�6;   $��0,-2,0,0q�6W   $��1��6i   $��2��6s   $
��None=�6�   $#��Images/dividerRotatedBlue.png��6�   $	��116��6�   �� 5�      -   5        $ notificationsPanel��5�      $��1��69   $
 Hand��6k   $y�	Collapsed=�6y   �� 5�      -   5        $
 Hand��5�      ���	#FF3A3A3A���	#FF0080FF$��18(�6V   ���	#FFE4E4E4$��Segoe UI Light)�6{   " .  #���  6�   $��0,0,0,1q�6�   $	��Top=�6  $	��1,0q�6$  $��57��61  .��5�      � $��Center=�6   $��Center=�68   .+�5�      �� -   5        $# helpFindLabel1��5�       $��Съобщения��68   $��41,0,0,2q�6L   $
��Left=�6^   $��Center=�6y   #��[ 6�    5�        5�   "   $ 5Q�63   $ 	#FF3A3A3A��6B   $	 315Q�6T   $	 1.5Q�6d   5�      �� 5�      $
��Left=�6    $��34��6;   $��Center=�6G   $��34��6b   $��Images/Messaging.png��6m   $��0q�6�   $
��Fill=�6�    5�        5�   "   $ 5Q�63   $ 	#FF3A3A3A��6B   $	 315Q�6T   $	 1.5Q�6d   5�      5�      5�      �� 5�      -   5        $
 Hand��5�      ���	#FF3A3A3A���	#FF0080FF$��18(�6V   ���	#FFE4E4E4$��Segoe UI Light)�6{   " .  #���  6�   $��0q�6�   $��Bottom=�6  $	��1,0q�6   $��57��6-  .��5�      � $��Center=�6   $��Center=�68   .+�5�      �� -   5        $# helpFindLabel2��5�       $��Известия��68   $��41,0,0,2q�6K   $
��Left=�6]   $��Center=�6x   #��[ 6�    5�        5�   "   $ 5Q�63   $ 	#FF3A3A3A��6B   $	 315Q�6T   $	 1.5Q�6d   5�      �� 5�      $
��Left=�6    $��34��6;   $��Center=�6G   $��34��6b   $"��Images/notificationsIcon.png��6m   $��0q�6�   $
��Fill=�6�    5�        5�   "   $ 5Q�63   $ 	#FF3A3A3A��6B   $	 315Q�6T   $	 1.5Q�6d   5�      5�      5�      5�      � 5�      -   5        $ ProfileGrid��5�      $
��Left=�6(   $	��115��6C   $��
808,0,0,-1q�6P   $	��Top=�6d   $	��226��6|   $ 1��6�   $ � ColumnDefinitions$ 5�      �� 5�      .+�5�      �� $
��Left=�6   $��30��63   $	��Top=�6?   $��30��6W   $��Images/userDefault.png��6b   $��5,3,0,0q�6�   �� 5�      -   5        $# usernameLabel��5�      $��Username��6/   $
��Left=�6B   $��Segoe UI Light)�6]   $��18(�6y   $
��Thin"�6�   ���	#FF3A3A3A#���  6�   $ 4��6�   $	��Top=�6�   $��35,0,0,0q�6�   $��33��6  �� 5�      -   5        $��0,74,0,0q�5�      $	��Top=�6+   $��18(�6C   $��Segoe UI Light)�6Q   $��33��6�   ���	#FFE4E4E4$
 Hand��6�   #���  6�   $
��Left=�6�   $	��226��6�   ��6m   Z� .��5�      � $	��226��6   .+�5�      �� $
��Left=�6    $��33��6;   $	��Top=�6G   $��33��6_   $��Images/settingsIcon.png��6j   $��UniformToFill=�6�   $��0,-2,0,0q�6�    5�        5�   "   $ 5Q�63   $ 	#FF3A3A3A��6B   $	 315Q�6T   $	 1.5Q�6d   5�      �� 5�      $��Настройки��6    $
��Left=�64   $	��Top=�6O   #���  6g   $��	33,-2,0,0q�6�    5�        5�   "   $ 5Q�63   $ 	#FF3A3A3A��6B   $	 315Q�6T   $	 1.5Q�6d   5�      5�      5�      �� 5�      -   5        $ 
statusIcon��5�      $
��Left=�6,   $��33��6G   $	��Top=�6S   $��33��6k   $��Images/disconnected.png��6v   $��5,40,0,0q�6�    5�        5�      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   5�      �� 5�      -    5        $# onlineStatusLabel��5�      $��Офлайн��63   $
��Left=�6D   $��	35,39,0,0q�6_   $	��Top=�6r   $��86��6�   #���  6�   $��18(�6�   ���	#FF3A3A3A6�   5�      5�      �� 5�   
   -!   5        $ DividerMain��5�      $
��Left=�6%   $��2��6@   $��0q�6K   $��2��6V   $	��Top=�6c   $
��1175��6{   $
��None=�6�   $ ��Images/DividerMainBlue.png��6�   �� 5�   
   -"   5        $  notificationsDivider_Copy3��5�      $
��Left=�64   $	��525��6O   $��
445,1,0,-1q�6\   $	��Top=�6p   $��5��6�   $
��None=�6�   $#��Images/dividerRotatedBlue.png��6�   $��2��6�   �� 5�   
   -#   5        % ��Name$% hider��5�      
���   �$
��Left=�60   $	��673��6K   
���   �$	��Top=�6g   $
��1175��6   $��3��6�   & J� Opacity$	& 0.7Q�6�   $y�Hidden=�6�   5�      5�      