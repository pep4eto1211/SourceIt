   M S B A M L   `   `   `  ����   SourceIt    SourceIt.messageBox   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   ���	#FF0080FF$��0,0,0,1q�$��
20,10,20,0q�$	��325��  � 	Resources     InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType	 �� Value��%�   &	        �� " ��.���  � ��
 �   � ��  �� *IsMouseOver+ �� $ 1��" ��	 True.a���  � ��
 �����.��� ���	#FFE4E4E4.+��� $��	10,20,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��От:��$
��Left=��� -   
 ��Name$
 	fromLabel��$��	50,20,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$
��Left=��� $��	10,54,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Съобщение:��$
��Left=��� -    ��Name$ messageContentBox�� �� TextWrapping$ WrapWithOverflow=�$��20(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q� �� AcceptsReturn . ��. $��10,88,10,40q� �� 
IsReadOnly . ��Z� �� -   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4 � Cursor$
 Hand��  ButtonStyleOne#���   K� ZIndex$ -5��$��0q����	#FF0080FF$	��158�� � ToolTip$ Виж повече��.��� .+��� $��Images/Messaging.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� -    ��Name$ helpFindLabel��$!��Напиши отговор��#��[  $��16(�$��	30,-4,0,1q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���  $ -5��$��0q����	#FF0080FF$��94��$ Виж повече��$��	0,0,158,0q�.��� .+��� $��Images/newCloseIcon.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ helpFindLabel1��$��Изтрий��#��[  $��16(�$��	30,-4,0,1q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�