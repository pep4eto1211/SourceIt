   M S B A M L   `   `   `  ����   SourceIt    SourceIt.helpFinder   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     N� Title$  
helpFinder��$	��525��$	��729�� � 	Resources    InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel	 �� AncestorType
 �� Value��%�   &	        �� " ��.���  � ��
 �   � ��  �� *IsMouseOver+ �� $ 1��"	 ��
 True.a���  � ��
 �����.��� -   $��helpFinderMainGrid�����	#FFE4E4E4 � RowDefinitions �� $	��56* ��� $	��53* ��� $
��411* � � Triggers :�  :� RoutedEvent$ Grid.Loaded��.[��� .���� .��W�  �� 
TargetName$ helpFinderMainGrid�� �� TargetProperty$ Opacity� W� From$	 0.0X�	 W� To$	 1.0X� g� Duration$ 0:0:0.5D�.+��� $��40,1,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��36(�$��
Помощ��$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=�$	��378��$��48��$	��138���� -   $
��Left=�$	��Top=�$��25��$��18(�$��Segoe UI Light)�$��25�����	#FFE4E4E4 � Cursor$
 Hand��  ButtonStyleOne#���  $��	10,15,0,0q� K� ZIndex$ -5�� � ToolTip$ Go back to startup page����Z� .��� $��25��$��25��.+��� $��Images/backButton.png��$��25��$��25��$��UniformToFill=�$��0,-4,0,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q�� $��1��.+��� -    ��Name$ allTab��$
 Hand�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)� � UseLayoutRounding .  #���  $��0,1,1,1q�$��1��$��	0,0,-76,0q�$
��Left=�$��364.5��.��� .+��� -    ��Name$ allTabLabel��$��Всички��$��0q�$��Center=�$��Center=�#��[     $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ mineTab��$
 Hand�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)� .  #���  $��0,1,1,1q�$��364.5,0,0,0q�.��� .+��� -   $ mineTabLabel��$��Мои��$��0q�$��Center=�$��Center=�#��[     $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $��2����. $
��Auto=�$ -3��.���� -    ��Name$ itemsStackPanel��� -	    �Name$ loader��$��3��$ 20��
���   �  J� Opacity$	  0.7Q�.+��� -
   ! ��Name$! loadingMessage��$��174.346,191,173.653,0q�$
��Wrap=����	#FFE4E4E4$��36(�$.��(Зареждане на елементи��$��Segoe UI Light)�$��CharacterEllipsis=�$��Center=�$	��Top=�� $��Center=�$��29��$��251.5,262,251.5,0q�$	��Top=�$	��226�����	#FFE4E4E4���	#FFE4E4E4" � IsIndeterminate" . ��Z� �� -   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���  $ -5��$��0q����	#FF0080FF$	��171��$��	0,0,10,11q�.��� $	��165��.+��� $��Images/editIcon.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ helpFindLabel_Copy2��$$��Задай нов въпрос��#��[  $��16(�$��30,-4,-94,1q�$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�� -   $ openQuestionGrid��$��2�����	#FFE4E4E4$��1��$y�Hidden=�.+��� -   # ��Name$# DividerMain_Copy3��$��2��$��Bottom=�$
��None=�$ ��Images/DividerMainBlue.png��$��	0,0,0,396q��� -   $ ��Name$$ questionContent��% �� TextWrapping$
% Wrap=�$��Question content��& �� 
IsReadOnly& . $ Arrow�����	#FF0080FF���	#FF3A3A3A"' �� VerticalScrollBarVisibility$
' Auto=�$��0q�  PostTextBoxStyle#���  $��18(�$��71����. $��79��$	��Top=���Z� �� $��	0,72,0,30q���. $
��Auto=�.���� -   $ answersStackPanel��.+�� -   $ answersLabelGrid��$	��Top=�$��5,20,5,0q�$��46��.+��� $$��Всички отговори:��$
��Left=�$	��Top=����	#FF3A3A3A$��24(�$��Segoe UI Light)�$��0q��� -   $# DividerMain_Copy1��$��2��$��Bottom=�$
��None=�$ ��Images/DividerMainBlue.png���� -   $# DividerMain_Copy��$��2��$	��Top=�$
��None=�$ ��Images/DividerMainBlue.png��$��0q��� -   $# DividerMain_Copy2��$��2��$��Bottom=�$
��None=�$ ��Images/DividerMainBlue.png��$��0,0,0,30q��� -   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���  $ -5��$��0q����	#FF0080FF$	��193��$��0q�.��� $	��187��.+��� $��Images/editIcon.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ helpFindLabel_Copy1��$*��$Отговори на въпроса��#��[  $��16(�$��30,-4,-94,1q�$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���  $ -5��$��0q����	#FF0080FF$��86��$��	0,0,193,0q�.��� $��80��.+��� $��Images/newCloseIcon.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ helpFindLabel_Copy3��$��
Отказ��#��[  $��16(�$��30,-4,-94,1q�$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�