   M S B A M L   `   `   `  ����   SourceIt    SourceIt.projectHelp   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     N� Title$  projectHelp��$	��375��$	��729�� � 	Resources    InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel	 �� AncestorType
 �� Value��%�   &	        �� " ��.���  � ��
 �   � ��  �� *IsMouseOver+ �� $ 1��"	 ��
 True.a���  � ��
 �����.��� ���	#FFE4E4E4.+��� $
��Auto=���. $��0,30,0,0q�.���� -    ��Name$ allPostsPanel��.+�� -    �Name$ questionsLabelGrid��$	��Top=�$	��5,0q�$��46��.+��� $=��7Всички въпроси по този проект:��$
��Left=�$	��Top=����	#FF3A3A3A$��24(�$��Segoe UI Light)�$��0q��� -    ��Name$ DividerMain_Copy1��$��2��$��Bottom=�$
��None=�$ ��Images/DividerMainBlue.png���� -    ��Name$ 
emptyLabel��$.��(Няма зададени въпроси��$��Center=�$	��Top=����	#FF3A3A3A$��24(�$��Segoe UI Light)�$��0,20,0,0q�� -   $ loader��
���   � J� Opacity$	 0.7Q� K� ZIndex$	 100��.+��� -    ��Name$ loaderLable��$
��Wrap=����	#FFE4E4E4$��36(�$+��%Взимане на постове...��$��Segoe UI Light)�$��CharacterEllipsis=�$��Center=�$��Center=�$��0,116,0,207q�� $��Center=�$��29��$��Center=�$	��226�����	#FFE4E4E4���	#FFE4E4E4 � IsIndeterminate . ��Z� �� -   $��Right=�$	��Top=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4 � Cursor$
 Hand��  ButtonStyleOne#���  $ -5��$��0q����	#FF0080FF$	��171��.��� $	��165��.+��� $��Images/editIcon.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� -	   $ helpFindLabel_Copy2��$$��Задай нов въпрос��#��[  $��16(�$��30,-4,-94,1q�$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�� -
   $ openQuestionGrid�����	#FFE4E4E4$��0,30,0,0q�$y�Hidden=�.+��� -   $ DividerMain_Copy3��$��2��$��Bottom=�$
��None=�$ ��Images/DividerMainBlue.png��$��	0,0,0,396q��� -    ��Name$ questionContent�� �� TextWrapping$
 Wrap=�$��Question content�� �� 
IsReadOnly . $ Arrow�����	#FF0080FF���	#FF3A3A3A" �� VerticalScrollBarVisibility$
 Auto=�$��0q�  PostTextBoxStyle#���  $��18(�$��71����. $��79��$	��Top=���Z� �� $��	0,72,0,30q���. $
��Auto=�.���� -   $ answersStackPanel��.+�� -   $ answersLabelGrid��$	��Top=�$��5,20,5,0q�$��46��.+��� $$��Всички отговори:��$
��Left=�$	��Top=����	#FF3A3A3A$��24(�$��Segoe UI Light)�$��0q��� -   $ DividerMain_Copy2��$��2��$��Bottom=�$
��None=�$ ��Images/DividerMainBlue.png���� -   $ DividerMain_Copy��$��2��$	��Top=�$
��None=�$ ��Images/DividerMainBlue.png��$��0q��� -   $ DividerMain_Copy4��$��2��$��Bottom=�$
��None=�$ ��Images/DividerMainBlue.png��$��0,0,0,30q��� -   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���  $ -5��$��0q����	#FF0080FF$	��193��$��0q�.��� $	��187��.+��� $��Images/editIcon.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ helpFindLabel_Copy1��$*��$Отговори на въпроса��#��[  $��16(�$��30,-4,-94,1q�$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���  $ -5��$��0q����	#FF0080FF$��86��$��	0,0,193,0q�.��� $��80��.+��� $��Images/newCloseIcon.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ helpFindLabel_Copy3��$��
Отказ��#��[  $��16(�$��30,-4,-94,1q�$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�