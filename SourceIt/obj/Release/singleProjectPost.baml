   M S B A M L   `   `   `  ����   SourceIt     SourceIt.singleProjectPost   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   ���	#FF0080FF$��1q�$��
20,10,20,0q�$	��110��  � 	Resources     InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType	 �� Value��%�   &	        �� " ��.���  � ��
 �   � ��  �� *IsMouseOver+ �� $ 1��" ��	 True.a���  � ��
 �����.��� ���	#FFE4E4E4
 � ColumnDefinitions
 �� $��75 ��� .+��� -    ��Name$ postTextBox��$��1��$��10,30,10,10q� �� TextWrapping$
 Wrap=�$��	Post Text�� �� 
IsReadOnly .  � Cursor$ Arrow�����	#FF0080FF���	#FF3A3A3A" �� VerticalScrollBarVisibility$
 Auto=���. $��1q�  PostTextBoxStyle#���  $��18(���Z� �� $��1��$
��Left=�$��10��$��0,50,0,0q�$	��Top=�$��10��$��Images/smallArrow.png��� $
��Left=�$��75��$	��Top=�$��75�� J� OpacityMask
 �   ����	#FF303030$��2��.+��� -    ��Name$ userAvatarLabel��$
��Wrap=����	#FFE4E4E4$��36(�$��Segoe UI Semibold)�$��CharacterEllipsis=�$��Center=�$��Center=� K� ZIndex$ 9��$��0q��� $
��Left=�$��1�����	#FF0080FF$��1��$��2���� -   $ postUsername��$
��Wrap=�$��Center=����	#FF3A3A3A$��16(�$��Segoe UI Light)�$��CharacterEllipsis=� � ToolTip$ azsamsan4oidaotgorica��$��20��$��0,84,0,4q��� -    ��Name$ deletePostButton��$��Right=�$
 Hand��$��20�����	#FF3A3A3A���	#FF303030$��18(����	#FFE4E4E4$��Segoe UI Light)� � UseLayoutRounding .    ButtonStyleOne#���  $��0q�$	��Top=�$��20��$ Delete post��$��1��$��0,5,10,0q�$y�Hidden=�.��� .+��� $��30��$��30��$��Images/closeIconSmall.png��$��UniformToFill=�$��	-6,-5,0,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� -   $ postTitleLabel��$
��Wrap=�$	��Top=����	#FF3A3A3A$��16(�$��Segoe UI Light)�$��CharacterEllipsis=�$��	10,5,40,0q�$��1��$
��Left=�