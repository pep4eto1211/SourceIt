   M S B A M L   `   `   `  ����   SourceIt%    SourceIt.startupPagePostControl   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   ���	#FF0080FF$��1q�$��
20,10,20,0q�$	��140��  � 	Resources     InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType	 �� Value��%�   &	        �� " ��.���  � ��
 �   � ��  �� *IsMouseOver+ �� $ 1��" ��	 True.a���  � ��
 �����
 J� Effect
 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q�.��� ���	#FFE4E4E4 � ColumnDefinitions �� $��75 ��� .+��� -    ��Name$ postTextBox��$��1��$��10,30q� �� TextWrapping$
 Wrap=�$��	Post Text�� �� 
IsReadOnly .  � Cursor$ Arrow�����	#FF0080FF���	#FF3A3A3A" �� VerticalScrollBarVisibility$
 Auto=���. $��1q�  PostTextBoxStyle#���  $��18(���Z� �� $��1��$
��Left=�$��10��$��0,64,0,0q�$	��Top=�$��10��$��Images/smallArrow.png��� $
��Left=�$��75��$	��Top=�$��75�� J� OpacityMask
 �   ����	#FF303030$��2��.+��� -    ��Name$ userAvatarLabel��$
��Wrap=����	#FFE4E4E4$��36(�$��Segoe UI Semibold)�$��CharacterEllipsis=�$��Center=�$��Center=� K� ZIndex$ 9��$��0q��� $
��Left=�$��1�����	#FF0080FF$��1��$��2���� -   $ postUsername��$
��Wrap=�$��Bottom=����	#FF3A3A3A$��16(�$��Segoe UI Light)�$��CharacterEllipsis=� � ToolTip$ azsamsan4oidaotgorica��$��20��$��
0,0,222,15q�$��2��$��76��$
��Left=�$��76���� -   $ postProject��$
��Wrap=����	#FF3A3A3A$��16(�$��Segoe UI Light)�$��CharacterEllipsis=�$��20��$��	10,5,40,0q�$��1��$	��Top=��� $
��Wrap=�$��Bottom=����	#FF3A3A3A$��16(�$��Segoe UI Light)�$��CharacterEllipsis=�$��20��$��10,0,222,35q�$��2��$��	Юзър:���� -    ��Name$ openProjectButton��$��Right=�$
 Hand��$	��142�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)�$��0,0,1,0q� � UseLayoutRounding .    ButtonStyleOne#���  $��1,0,0,0q�$��1��$��Bottom=�$��30��.��� .+��� -    ��Name$ helpFindLabel��$!��Отвори проекта��#��[  $��16(�$��0,-4,0,0q�
   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ deletePostButton��$��Right=�$
 Hand��$��20�����	#FF3A3A3A���	#FF303030$��18(����	#FFE4E4E4$��Segoe UI Light)�$��0,5,10,0q� .  #���  $��0q�$��1��$	��Top=�$��20��$ Delete post��$y�Hidden=�.��� .+��� $��30��$��30��$��Images/closeIconSmall.png��$��UniformToFill=�$��	-6,-5,0,0q�
   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�