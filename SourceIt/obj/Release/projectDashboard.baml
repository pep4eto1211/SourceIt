   M S B A M L   `   `   `  ����   SourceIt    SourceIt.projectDashboard   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     N� Title$  projectDashboard��$	��375��$	��729�� � 	Resources    InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel	 �� AncestorType
 �� Value��%�   &	        �� " ��.���  � ��
 �   � ��  �� *IsMouseOver+ �� $ 1��"	 ��
 True.a���  � ��
 �����.��� -   $��projectDashboardMainGrid�����	#FFE4E4E4 � Triggers :�  :� RoutedEvent$ Grid.Loaded��.[��� .���� .��W�  �� 
TargetName$ projectDashboardMainGrid�� �� TargetProperty$ Opacity� W� From$	 0.0X�	 W� To$	 1.0X� g� Duration$ 0:0:0.5D� � RowDefinitions �� $	��13* ��� $
��112* �.+��� $
��Auto=���. $��-1,0,1,0q�$��1��.���� -    ��Name$ allPostsPanel���� -    ��Name$ DividerMain��$��2��$��1��$	��Top=�$
��None=�$ ��Images/DividerMainBlue.png��� -    �Name$ loader��$��2��
���   � J� Opacity$	 0.7Q� K� ZIndex$	 100��.+��� -    ��Name$ loaderLable��$
��Wrap=����	#FFE4E4E4$��36(�$+��%Взимане на постове...��$��Segoe UI Light)�$��CharacterEllipsis=�$��Center=�$��Center=�$��0,116,0,207q�� $��Center=�$��29��$��Center=�$	��226�����	#FFE4E4E4���	#FFE4E4E4 � IsIndeterminate . ��Z� �� -    ��Name$ newPostButton�� � Cursor$
 Hand�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)� � UseLayoutRounding .    ButtonStyleOne#���  $��0,0,1,0q�.��� .+��� -    ��Name$ newPostLabel��$$��+ Създай нов пост��$��0q�$��Center=�$��Center=�#��[   J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�    Color$  	#FF3A3A3A��!   	Direction$	! 315Q�"   ShadowDepth$	" 1.5Q�� -	   $ newPostPanel��$	��108��$	��Top=�$��2�����	#FFE4E4E4$y�Hidden=�.+��� -
   $ projectNameBlock��$��20,0,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��18(�$.��(Създаване на нов пост:��$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=�$	��378���� -   # ��Name$# newPostContent��$
��Left=�$��68��$��	20,29,0,0q�$ �� TextWrapping$
$ Wrap=�$G��AНапишете съдържанието на поста тук.��$	��Top=�$	��569��$��18(����	#FF0080FF���	#FFA6A6A6% �� SelectionBrush% �	#FFB6B6B6��Z� �� -   $ createPostButton��$
��Left=�$
 Hand��$	��135�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)�$��	594,0,0,0q� .  #���  $��1,0,0,0q�$��54��$	��Top=�.��� .+��� -   $ dashboardTabLabel��$��Създаване��$��0q�$��Center=�$��Center=�#��[     $ 5Q�$  	#FF3A3A3A��$	! 315Q�$	" 1.5Q��� -   $ cancelPostCreationButton��$
 Hand��$	��135�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)�$��
594,54,0,0q� .  #���  $��1,0,0,0q�$��54��$
��Left=�$	��Top=�.��� .+��� -   $ dashboardTabLabel1��$��
Отказ��$��0q�$��Center=�$��Center=�#��[     $ 5Q�$  	#FF3A3A3A��$	! 315Q�$	" 1.5Q��� -   $ DividerMain_Copy��$
��Left=�$��2��$��	0,106,0,0q�$��Bottom=�$	��729��$
��None=�$ ��Images/DividerMainBlue.png��