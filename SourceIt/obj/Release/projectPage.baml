   M S B A M L   `   `   `  ����   SourceIt    SourceIt.projectPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     N� Title$  projectPage��$	��525��$	��729�� � 	Resources    InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel	 �� AncestorType
 �� Value��%�   &	        �� " ��.���  � ��
 �   � ��  �� *IsMouseOver+ �� $ 1��"	 ��
 True.a���  � ��
 �����.��� -   $��projectPageMainGrid�����	#FFE4E4E4 � Triggers :�  :� RoutedEvent$ Grid.Loaded��.[��� .���� .��W�  �� 
TargetName$ projectPageMainGrid�� �� TargetProperty$ Opacity� W� From$	 0.0X�	 W� To$	 1.0X� g� Duration$ 0:0:0.5D� � RowDefinitions �� $	��98* ��� $	��51* ��� $
��376* �.+��� -    ��Name$ projectNameBlock��$��40,1,0,0q�$
��Wrap=�$	��Top=�$��52�����	#FF3A3A3A$��36(�$*��$Зареждане на проект��$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=�$	��378���� -   $ descriptionBlock��$��
9,52,299,0q�$
��Wrap=�$	��Top=�$��46�����	#FF3A3A3A$��16(�$��Segoe UI Light)�$��CharacterEllipsis=�$!��Моля изчакайте��$
��Left=�$	��421���� -   $��Right=�$	��Top=�$	��170��$��18(�$��Segoe UI Light)����	#FF0080FF$��33�����	#FFE4E4E4 � Cursor$
 Hand��  ButtonStyleOne#���  $��1,0,0,0q�.��� $	��158��$��33��.+��� $
��Left=�$��33��$	��Top=�$��33��$��Images/settingsIcon.png��$��UniformToFill=�$��0,-2,0,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� $��Настройки��$��Right=�$��0,-3,0,2q�$	��125��#���      $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $��Right=�$��0,65,0,0q�$	��Top=�$	��170��$��18(�$��Segoe UI Light)����	#FF0080FF$��33�����	#FFE4E4E4$
 Hand��#���  $��1,0,0,0q�.��� $	��158��$��33��.+��� $
��Left=�$��33��$	��Top=�$��33��$��UniformToFill=�$��0,-2,0,0q�$"��Images/notificationsIcon.png��   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -    ��Name$ projectNotifications��$��0 Известия��$��Right=�$��0,-3,0,0q�$	��Top=�$	��125��#���      $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -    ��Name$ DividerMain��$
��Left=�$��2��$��0,50,0,0q�$��1��$	��Top=�$	��729��$
��None=�$ ��Images/DividerMainBlue.png��$��2���� -    ��Name$ dashboardTab��$
��Left=�$
 Hand��$��182.25�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)�$��0,0,0,1q� � UseLayoutRounding .  #���  $��0q�$��1��.��� $	��145��$��50��.+��� -	   $ dashboardTabLabel��$��Начало��$��0q�$��Center=�$��Center=�#��[     $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -
   $ storeTab��$
��Left=�$
 Hand��$��182.25�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)�$��182.25,0,0,1q� .  #���  $��0q�$��1��.��� $	��145��$��50��.+��� -   $ storeTabLabel��$��Магазин��$��0q�$��Center=�$��Center=�#��[     $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ teamTab��$
��Left=�$
 Hand��$��182.25�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)�$��364.5,0,0,1q� .  #���  $��0q�$��1��.��� $	��145��$��50��.+��� -   $ teamTabLabel��$��Екип��$��0q�$��Center=�$��Center=�#��[     $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ helpTab��$��Right=�$
 Hand��$��182.25�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)�$��	439,0,0,1q� .  #���  $��0q�$��1��.��� $	��145��$��50��.+��� -   $ helpTabLabel��$��
Помощ��$��0q�$��Center=�$��Center=�#��[     $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ DividerMain_Copy��$
��Left=�$��2��$��1��$	��Top=�$	��729��$
��None=�$ ��Images/DividerMainBlue.png�� � -     �Name$ mainSubFrame��$�� ��$��0q�$��2��  � NavigationUIVisibility$ Hidden=����	#FFE4E4E4� -     �Name$  Loader��$
��Left=�$	��525��$	��Top=�$	��729��$��3��
���   �! J� Opacity$	! 0.7Q�.+��� -   $ projectNameBlock_Copy��$��0,205,0,268q�$
��Wrap=����	#FFE4E4E4$��36(�$$��Моля изчакайте...��$��Segoe UI Light)�$��CharacterEllipsis=�$��Center=�� $��Center=�$��29��$��	0,262,0,0q�$	��Top=�$	��226�����	#FFE4E4E4���	#FFE4E4E4" � IsIndeterminate" . ��Z� �� -   # ��Name$# projectSettingsPanel��$��Right=�$��0,2,0,0q�$	��Top=�$	��170�����	#FF303030$��3��$y�Hidden=�.+�� -   $  settingsCloseButton��$��33��$��0,0,2,0q�$
 Hand��.+��� $
��Left=�$��33��$	��Top=�$��33��$"��Images/settingsIconLight.png��$��UniformToFill=�$��6,-2,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $��Настройки��$��Right=�$��0,-3,2,0q�$	��Top=�$	��126��#���   $��18(����	#FFE4E4E4$��Segoe UI Light)�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ editInfoButton��$
 Hand�����	#FF3A3A3A$��18(�$��Segoe UI Light)� .  #���  $��0q�$y�	Collapsed=���Z� ��Z� .��� $	��145��$��27��.+��� -   $ helpFindLabel6��$��Промени инфо��$��0q�$��Center=�$��Center=�#��[  ���	#FFE4E4E4$��14(�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ setDeadlineButton��$
 Hand�����	#FF3A3A3A$��18(�$��Segoe UI Light)� .  #���  $��0q�$y�	Collapsed=���Z� ��Z� .��� $	��145��$��27��.+��� -   $ helpFindLabel7��$$��Задай краен срок��$��0q�$��Center=�$��Center=�#��[  ���	#FFE4E4E4$��14(�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ viewProjectFilesButton��$
 Hand�����	#FF3A3A3A$��18(�$��Segoe UI Light)� .  #���  $��0q�$y�	Collapsed=���Z� ��Z� .��� $	��145��$��27��.+��� -   $ helpFindLabel8��$+��%Разгледай файловете��$��0q�$��Center=�$��Center=�#��[  ���	#FFE4E4E4$��14(�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ deleteProjectButton��$
 Hand�����	#FF3A3A3A$��18(�$��Segoe UI Light)� .  #���  $��0q�$y�	Collapsed=���Z� ��Z� .��� $	��145��$��27��.+��� -   $ helpFindLabel5��$��Изтрий проект��$��0q�$��Center=�$��Center=�#��[  ���	#FFE4E4E4$��14(�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $# additionalInfoPanel��$��98��$��	0,0,170,0q�$	��Top=�$	��129��$��Right=�$ K� ZIndex$$ -5��$��98��.+��� -   $ deadlineLabel��$
��Wrap=�$	��Top=����	#FF3A3A3A$��16(�$��Segoe UI Light)�$��CharacterEllipsis=�$��Краен срок:��$
��Left=�$	��421���� -    $ deadlineBox��$
��Wrap=�$	��Top=����	#FF3A3A3A$��20(�$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=�$	��421��$��10,5,0,0q��� -!   $ timeLeftBox��$
��Wrap=�$	��Top=����	#FF3A3A3A$��20(�$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=�$	��421��$��10,5,0,0q�$��27���� -"   $
��Left=�$	��Top=�$��25��$��18(�$��Segoe UI Light)�$��25�����	#FFE4E4E4$
 Hand��#���  $��	10,15,0,0q�$$ -5��% � ToolTip$% Go back to startup page����Z� .��� $��25��$��25��.+��� $��Images/backButton.png��$��25��$��25��$��UniformToFill=�$��0,-4,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -#   $��Right=�$	��Top=�$	��170��$��18(�$��Segoe UI Light)�$��32�����	#FFE4E4E4$
 Hand��#���  $��0,33,0,0q�$$ -5��$��1,0,0,0q����	#FF0080FF.��� $	��158��$��33��.+��� $
��Left=�$��33��$	��Top=�$��33��$��Images/folder.png��$��UniformToFill=�$��0,-2,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $��Файлове��$��Right=�$��0,-3,0,2q�$	��125��#���      $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�