   M S B A M L   `   `   `  ����   SourceIt    SourceIt.settings   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   $	��729��$	��525��  N� Title$  settings�� � 	Resources    InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel	 �� AncestorType
 �� Value��%�   &	        �� " ��.���  � ��
 �   � ��  �� *IsMouseOver+ �� $ 1��"	 ��
 True.a���  � ��
 �����.��� -   $��settingsMainGrid�����	#FFE4E4E4 � Triggers :�  :� RoutedEvent$ Grid.Loaded��.[��� .���� .��W�  �� 
TargetName$ settingsMainGrid�� �� TargetProperty$ Opacity� W� From$	 0.0X�	 W� To$	 1.0X� g� Duration$ 0:0:0.5D�.+��� $��40,1,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��36(�$��Настройки��$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=�$	��378���� -   $
��Left=�$	��Top=�$��25��$��18(�$��Segoe UI Light)�$��25�����	#FFE4E4E4 � Cursor$
 Hand��  ButtonStyleOne#���  $��	10,15,0,0q� K� ZIndex$ -5�� � ToolTip$ Go back to startup page����Z� .��� $��25��$��25��.+��� $��Images/backButton.png��$��25��$��25��$��UniformToFill=�$��0,-4,0,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� $��	40,86,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��36(�$+��%Настройки на сървър:��$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=�$	��378���� -    ��Name$ mainServerBox��$
��Left=�$��
95,139,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��24(�$	��565�����	#FF0080FF���	#FF1E1E1E��Z� �� $��
40,237,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��36(�$+��%Настройки на профил:��$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=�$	��378���� -    ��Name$ usernameBox��$��
95,290,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��36(�$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=�$	��378���� -   $
��Left=�$
 Hand��$	��216�����	#FF3A3A3A���	#FF303030$��18(�$��95,343,0,137q����	#FFE4E4E4#���  $��Segoe UI Light)�$��0q�.��� $��Center=�$��Center=�.+��� $"��Изход от профил��$��0,0,0,2q�$
��Left=�$��Center=�#��[  $��24(�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $
��Left=�$
 Hand��$	��216�����	#FF3A3A3A���	#FF303030$��18(�$��444,178,0,302q����	#FFE4E4E4#���  $��Segoe UI Light)�$��0q�.��� $��Center=�$��Center=�.+��� $"��Смяна на сървър��$��0,0,0,2q�$
��Left=�$��Center=�#��[  $��24(�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $
��Left=�$
 Hand��$	��230�����	#FF3A3A3A���	#FF303030$��18(�$��	95,0,0,42q����	#FFE4E4E4#���  $��Segoe UI Light)�$��0q�$��Bottom=�.��� $��Center=�$��Center=�.+��� $'��!Докладвай проблем��$��0,0,0,2q�$
��Left=�$��Center=�#��[  $��24(�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�