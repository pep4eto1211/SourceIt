   M S B A M L   `   `   `  ����   SourceIt    SourceIt.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$  SourceIt��$��674.737��$
��1177�� � WindowStartupLocation$ CenterScreen=����	#FF0080FF$��1q� � Icon$ Images/NewLogo.png�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � 	Resources    onlineStatusMenu m� Icon  InButtonLabel �� 
TargetType �� Property	 �� Value
 �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%  &	        &	 �     �� .@�m� -   $��Online�� �� $��Images/connected.png���� m� -   $��Offline�� �� $��Images/disconnected.png���� " ��.���  � ��
	 �   �
 ��  �� *IsMouseOver+ �� $ 1��" �� True.a���  � ��
	 �����.��� ���	#FFE4E4E4 � RowDefinitions �� $	��36* ��� $
��112* ��� $
��525* �.+�� -    �Name$ titleBar��$��35��$	��Top=����	#FFE4E4E4 K� ZIndex$ -1��.+��� -   $�� ��$��Right=�$��0,4,25,0q�$	��Top=�$��25��$��25�� � ToolTip$ Minimise the app��
�������$��18(�  TitleBarButton#���   J� RenderTransformOrigin$ 0.5,0.5&���Z� ����  �� ImageSource$  Images/newMinimiseIcon.png���� -   $�� ��$��Right=�$��0,4,0,0q�$	��Top=�$��25��$��25��$ Close the app��
�������$��18(�#���  ��Z� ���� $ Images/newCloseIcon.png���� $
��Left=�$��30��$��6,0,0,5q�$��Bottom=�$��30��$��Images/TitleBarLogo.png��$
��Fill=��� -    ��Name$ DividerMain_Copy1��$
��Left=�$��2��$��0,32,0,0q�$	��Top=�$
��1175��$
��None=�$ ��Images/DividerMainBlue.png���� $��SourceIt��$
��Left=�$��	40,-3,0,0q�$	��Top=�$��35�����	#FF3A3A3A$��18(�$��75��$��Segoe UI Light)�� -   $ LeftContentHolder��$
��Left=�$��2��$	��446��$��0q� �� $	��94* ��� $
��385* �.+��� -	   $��0,0,0,1q����	#FFE4E4E4���	#FF0080FF  ButtonStyleOne#���   � Cursor$
 Hand�����	#FF303030.��� .+��� $&�� Добави нов проект��$��30,0,0,0q�$��Segoe UI Light)�$��30(�#���  $
��Left=�$��52�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� $
��Left=�$��0q�$��Images/smallAddIcon.png��$��30��$��30��   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $��0q�$��1��$
��Auto=���. .���� -
    ��Name$ projectsList�� �� CanVerticallyScroll .  �� CanHorizontallyScroll . $��Visible=���.  � -      �Name$  	mainFrame��$�� ��$��
446,1,-1,0q�$��2��!  � NavigationUIVisibility$! Hidden=�� -   $ 
topBarGrid��$��2��$ -1��$��0,34,0,0q�$	��Top=�.+�� -   $ servicesGrid��$
��Left=�$	��587��$ 0.479,0.272&�$��0q� �� $	��43* ��� $	��82* �.+��� $��Услуги:��$
��Left=�$	��282��$��Segoe UI Light)�$��18(�$
��Thin"�$��0,5,0,0q����	#FF3A3A3A  BigLabel#���  �� -   $
��Left=�$
 Hand��$	��199�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)�$��0,10,0,0q�$��1��" � UseLayoutRounding" .  #���  $��0,1,1,0q�.��� $��Center=�$��Center=�.+��� -   # ��Name$# helpFindLabel��$��
Помощ��$��41,0,0,2q�$
��Left=�$��Center=�#��[    $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $
��Left=�$��34��$��Center=�$��34��$��Images/fixerIcon.png��$��0q�$
��Fill=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $
��Left=�$
 Hand��$	��199�����	#FF3A3A3A���	#FF0080FF$��18(�$��
199,10,0,0q����	#FFE4E4E4#���  $��Segoe UI Light)�$��1��$��0,1,1,0q�.��� $��Center=�$��Center=�.+��� $��Упр. на работи��$��34,0,0,2q�$
��Left=�$��Center=�$	��130��#��[    $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $
��Left=�$��34��$��Center=�$��34��$��Images/jobs.png��$��0q�$
��Fill=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   ���	#FF3A3A3A���	#FF0080FF$
 Hand��$��18(�$��
398,10,0,0q����	#FFE4E4E4$��Segoe UI Light)�$��1��#���  $��0q�$��0,1,0,0q�.��� $��Center=�$��Center=�.+��� $��Магазин��$��34,0,0,2q�$��Center=�$��77��$
��Left=�#��[    $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $
��Left=�$��34��$��Center=�$��34��$��Images/storeIcon.png��$��0q�$
��Fill=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�� -   $ offlineMessage��$
��Left=�$	��115��$��2��$	��Top=�$	��587�����	#FFE4E4E4$y�Hidden=�.+��� $��0,10,0,0q�$
��Wrap=�$	��Top=�$��45�����	#FF3A3A3A$��30(�$)��#You are not connected to the server��$��Segoe UI Light)�$��Center=��� -   $��Center=�$��0,60,0,0q�$	��Top=�$	��135��$��18(�$��Segoe UI Light)�$��33�����	#FFE4E4E4$
 Hand��#���  ��Z� .��� $	��145��$��33��.+��� $:��4Try to reconnect                                    ��$��Right=�$��0,-3,0,0q�$	��Top=�$	��145��#���     $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�� -   $ NotificationsGrid��$
��Left=�$��	587,0,0,0q�$	��Top=�$	��221��$ 1��.+��� $��Известия:��$��Segoe UI Light)�$��18(�$
��Thin"����	#FF3A3A3A#���  $y�	Collapsed=��� -   $ notificationsDivider��$
��Left=�$	��116��$��0,-2,0,0q�$	��Top=�$��1��$��2��$
��None=�$#��Images/dividerRotatedBlue.png���� -   $ notificationsDivider_Copy��$��Right=�$��0,-2,0,0q�$��1��$��2��$
��None=�$#��Images/dividerRotatedBlue.png��$	��116���� -   $ notificationsPanel��$��1��$
 Hand��$y�	Collapsed=��� -   $
 Hand�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)�" .  #���  $��0,0,0,1q�$	��Top=�$	��1,0q�$��57��.��� $��Center=�$��Center=�.+��� -   $# helpFindLabel1��$��Съобщения��$��41,0,0,2q�$
��Left=�$��Center=�#��[    $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $
��Left=�$��34��$��Center=�$��34��$��Images/Messaging.png��$��0q�$
��Fill=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $
 Hand�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)�" .  #���  $��0q�$��Bottom=�$	��1,0q�$��57��.��� $��Center=�$��Center=�.+��� -   $# helpFindLabel2��$��Известия��$��41,0,0,2q�$
��Left=�$��Center=�#��[    $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $
��Left=�$��34��$��Center=�$��34��$"��Images/notificationsIcon.png��$��0q�$
��Fill=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�� -   $ ProfileGrid��$
��Left=�$	��115��$��
808,0,0,-1q�$	��Top=�$	��226��$ 1��$ � ColumnDefinitions$ �� .+��� $
��Left=�$��30��$	��Top=�$��30��$��Images/userDefault.png��$��5,3,0,0q��� -   $# usernameLabel��$��Username��$
��Left=�$��Segoe UI Light)�$��18(�$
��Thin"����	#FF3A3A3A#���  $ 4��$	��Top=�$��35,0,0,0q�$��33���� -   $��0,74,0,0q�$	��Top=�$��18(�$��Segoe UI Light)�$��33�����	#FFE4E4E4$
 Hand��#���  $
��Left=�$	��226����Z� .��� $	��226��.+��� $
��Left=�$��33��$	��Top=�$��33��$��Images/settingsIcon.png��$��UniformToFill=�$��0,-2,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $��Настройки��$
��Left=�$	��Top=�#���  $��	33,-2,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ 
statusIcon��$
��Left=�$��33��$	��Top=�$��33��$��Images/disconnected.png��$��5,40,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -    $# onlineStatusLabel��$��Офлайн��$
��Left=�$��	35,39,0,0q�$	��Top=�$��86��#���  $��18(����	#FF3A3A3A�� -!   $ DividerMain��$
��Left=�$��2��$��0q�$��2��$	��Top=�$
��1175��$
��None=�$ ��Images/DividerMainBlue.png���� -"   $  notificationsDivider_Copy3��$
��Left=�$	��525��$��
445,1,0,-1q�$	��Top=�$��5��$
��None=�$#��Images/dividerRotatedBlue.png��$��2���� -#   % ��Name$% hider��
���   �$
��Left=�$	��673��
���   �$	��Top=�$
��1175��$��3��& J� Opacity$	& 0.7Q�$y�Hidden=�