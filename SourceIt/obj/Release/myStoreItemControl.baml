   M S B A M L   `   `   `  ����   SourceIt!    SourceIt.myStoreItemControl   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   $	��Top=�$��
10,20,10,0q�$	��135�����	#FF0080FF$��0,0,0,1q�  � 	Resources     InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType	 �� Value��%�   &	        �� " ��.���  � ��
 �   � ��  �� *IsMouseOver+ �� $ 1��" ��	 True.a���  � ��
 �����.��� ���	#FFE4E4E4.+��� -   
 ��Name$
 itemNameLabel��$��105,5,105,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��30��$��CharacterEllipsis=��� -    ��Name$ itemIcon��$
��Left=�$	��100��$	��Top=�$	��100��$��0q�$
��Fill=��� -   $
 itemDescriptionLabel��$��105,39,5,35q�$
��Wrap=����	#FF3A3A3A$��16(�$��Segoe UI Light)�$��56��$��CharacterEllipsis=��� -   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4 � Cursor$
 Hand��  ButtonStyleOne#���   K� ZIndex$ -5��$��0q����	#FF0080FF$	��101�� � ToolTip$ Сваляне��.��� $	��124��.+��� $��Images/downloadStore.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� -    ��Name$ helpFindLabel_Copy��$��Сваляне��#��[  $��16(�$��30,-4,-94,1q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���  $ -5��$��0q����	#FF0080FF$	��124��$ Виж повече��$��	0,0,101,0q�.��� .+��� $��Info.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ helpFindLabel��$��Виж повече��#��[  $��16(�$��	30,-4,0,1q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -	   $
 downloadsLabel��$
��Wrap=�$��Bottom=����	#FF3A3A3A$��18(�$��Segoe UI Light)�$��30��$��CharacterEllipsis=�$
��Left=�$��5,0,0,3q�$��Сваляния:���� -
   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���  $ -5��$��0q����	#FF0080FF$	��111��$, &Премахни от магазина��$��	0,0,228,0q�.��� $	��124��.+��� $��Images/newCloseIcon.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ helpFindLabel_Copy1��$��Премахни��#��[  $��16(�$��30,-4,-94,1q�$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���  $ -5��$��0q����	#FF0080FF$	��156��$1 +Промени инфо за елемент��$��	0,0,339,0q�.��� .+��� $��Images/editIcon.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ helpFindLabel_Copy2��$��Промени инфо��#��[  $��16(�$��	30,-4,0,1q�$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�