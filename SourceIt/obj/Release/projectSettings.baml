   M S B A M L   `   `   `  ����   SourceIt    SourceIt.projectSettings   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     N� Title$  projectSettings��$	��375��$	��729�� � 	Resources    InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel	 �� AncestorType
 �� Value��%�   &	        �� " ��.���  � ��
 �   � ��  �� *IsMouseOver+ �� $ 1��"	 ��
 True.a���  � ��
 �����.��� -   $��projectSettingsMainGrid�����	#FFE4E4E4 � Triggers :�  :� RoutedEvent$ Grid.Loaded��.[��� .���� .��W�  �� 
TargetName$ projectSettingsMainGrid�� �� TargetProperty$ Opacity� W� From$	 0.0X�	 W� To$	 1.0X� g� Duration$ 0:0:0.5D�.+��� -    ��Name$ 
titleBlock��$��25,0,0,0q�$
��Wrap=�$	��Top=�$��39�����	#FF3A3A3A$��28(�$7��1Настройки на информацията:��$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=��� $��
77,263,0,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��20(�$��Описание:��$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=��� -    ��Name$ projectDescription��$
��Left=�$	��102��$��174,263,0,0q� �� TextWrapping$ WrapWithOverflow=�$	��Top=�$	��272��$��20(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q� �� AcceptsReturn . ��. " �� VerticalScrollBarVisibility$
 Auto=���Z� �� $��	78,95,0,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��20(�$��Категория:��$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=��� -    ��Name$ projectCategory��$
��Left=�$��
174,95,0,0q�$	��Top=�$	��272��$��1,0,1,1q�$��20(����	#FF0080FF���	#FF3A3A3A$��31�����	#FFE4E4E4.@��� $��Books���� $��Music���� $��Productivity tools���� $��	Utilities���� $��Entertainment���� $��	3D Models���� $��	3D Movies���� $��Other���� $��
31,143,0,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��20(�$ ��Включени хора:��$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=��� -    ��Name$ usersIncludedListBox��$
��Left=�$	��102��$��174,143,0,0q�$	��Top=�$	��272�����	#FF0080FF���	#FF3A3A3A � Cursor$
 Hand����Z� �� $��
128,49,0,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��20(�$��Име:��$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=��� -   $
��Left=�$
 Hand��$��183.385�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��451,205.679,0,130q� � UseLayoutRounding .    ButtonStyleOne#���  $��0q���Z� .��� $	��183��$��37��.+��� -    ��Name$ helpFindLabel1��$$��+ Добави още хора��$��Center=�$��Center=�#��[  $��39��$	��183��$��20(�$��0,0,0,-2q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�    ShadowDepth$	  1.5Q��� -	   $
��Left=�$
 Hand��$��163.581�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��555.419,281.417,0,54.262q� .  #���  $��0q���Z� .��� .+��� -
   $ helpFindLabel2��$!��Запази промени��#��[  $��20(�$��0,0,0,-2q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	  1.5Q��� -   $
��Left=�$
 Hand��$��68.22�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��650.78,325.738,0,9.941q� .  #���  $��0q���Z� .��� $��37��.+��� -   $ helpFindLabel3��$��
Отказ��#��[  $��20(�$��0,0,0,-2q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	  1.5Q��� -   ! ��Name$! removeUserButton��$
��Left=�$
 Hand��$��199.385�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��451,146.417,0,189.262q� .  #���  $��0q�$y�Hidden=���Z� .��� $	��198��$��37��.+��� -   $ helpFindLabel4��$��- Remove from project��$
��Left=�$��Center=�#��[  $��39��$	��201��$��20(�$��0,0,0,-2q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	  1.5Q�� -   " �Name$" hider��$
��Left=�$	��375��$	��Top=�$	��729��
���   �# J� Opacity$	# 0.7Q�.+��� -   $ projectNameBlock_Copy��$��270,100,269,223q�$
��Wrap=�$��52�����	#FFE4E4E4$��36(�$��Please wait...��$��Segoe UI Light)�$��CharacterEllipsis=�$��Center=�$	��190��$��Center=�� $��Center=�$��29��$��0,157,0,189q�$��Center=�$	��226�����	#FFE4E4E4���	#FFE4E4E4$ � IsIndeterminate$ . ��Z� �� -   % ��Name$% descriptionError��$
��Left=�$��31��$��451,263,0,0q�$	��Top=�$��31��$��Images/errorIcon.png��$
 Hand��& J� RenderTransformOrigin$& 0.419,0.516&�$y�Hidden=��� -   $ projectNameBox��$��
174,49,0,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��20(�$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=�