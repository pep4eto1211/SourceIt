   M S B A M L   `   `   `  ����   SourceIt    SourceIt.jobsManager   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     N� Title$  jobsManager��$	��525��$	��729�� � 	Resources    InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel	 �� AncestorType
 �� Value��%�   &	        �� " ��.���  � ��
 �   � ��  �� *IsMouseOver+ �� $ 1��"	 ��
 True.a���  � ��
 �����.��� -   $��jobsManagerMainGrid�����	#FFE4E4E4 � Triggers :�  :� RoutedEvent$ Grid.Loaded��.[��� .���� .��W�  �� 
TargetName$ jobsManagerMainGrid�� �� TargetProperty$ Opacity� W� From$	 0.0X�	 W� To$	 1.0X� g� Duration$ 0:0:0.5D�.+��� $��40,1,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��36(�$,��&Управление на работа��$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=�$	��378���� -   $
��Left=�$	��Top=�$��25��$��18(�$��Segoe UI Light)�$��25�����	#FFE4E4E4 � Cursor$
 Hand��  ButtonStyleOne#���  $��	10,15,0,0q� K� ZIndex$ -5�� � ToolTip$ Go back to startup page����Z� .��� $��25��$��25��.+��� $��Images/backButton.png��$��25��$��25��$��UniformToFill=�$��0,-4,0,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� $
��Auto=���. $��0,58,0,0q�.���� -    ��Name$ allPostsPanel��.+��� -    ��Name$ 
emptyLabel��$,��&В момента няма обяви ��$��Center=�$	��Top=����	#FF3A3A3A$��24(�$��Segoe UI Light)�$��0,20,0,0q�� -    �Name$ loader��
���   � J� Opacity$	 0.7Q�$��0q�.+��� -    ��Name$ loadingMessage��$��174.693,191,173.306,0q�$
��Wrap=����	#FFE4E4E4$��36(�$.��(Зареждане на елементи��$��Segoe UI Light)�$��CharacterEllipsis=�$��Center=�$	��Top=�� $��Center=�$��29��$��251.5,262,251.5,0q�$	��Top=�$	��226�����	#FFE4E4E4���	#FFE4E4E4 � IsIndeterminate . ��Z� �� -     ��Name$  DividerMain_Copy3��$��2��$	��Top=�$
��None=�$ ��Images/DividerMainBlue.png��$��0,57,0,0q�$ -4���� -	   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���  $ -5��$��0q����	#FF0080FF$	��168��$��
0,0,10,479q�.��� .+��� -
   $ helpFindLabel_Copy2��$(��"+ Добави нова обява��#��[  $��16(�$��0,-4,0,1q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�