   M S B A M L   `   `   `  ����   SourceIt    SourceIt.serverExplorer   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$  serverExplorer��$	��509��$	��800�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=����	#FF0080FF$��1q� � Icon$ Images/NewLogo.png�� � 
ResizeMode$ NoResize=� � Topmost .  � ShowInTaskbar .   � 	Resources    InButtonLabel �� 
TargetType	 �� Property
 �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value  
canvasMenu��%  &	        &	 �     �� " ��.��� 	 � ��

 �   � ��  �� *IsMouseOver+ �� $ 1��" �� True.a��� 	 � ��

 ������� .@�m� -   $��Създай папка��m� -   $��Качи файл��m� -   $��Начало��.��� ���	#FFE4E4E4.+��� -    ��Name$ 
titleLabel��$'��!Файлове на проект:��$
��Left=�$��	40,-3,0,0q�$	��Top=����	#FF3A3A3A$��18(�$��Segoe UI Light)��� -   $�� ��$��Right=�$��0,3,0,0q�$	��Top=�$��25��$��25�� � ToolTip$' !Затвори прозореца��
�������$��18(�  TitleBarButton#���  $��1q���Z� ����  �� ImageSource$ Images/newCloseIcon.png���� -    ��Name$ DividerMain_Copy1��$��2��$��0,32,0,0q�$	��Top=�$
��None=�$ ��Images/DividerMainBlue.png���� $��	10,45,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��18(�$��Път:��$��Segoe UI Light)�$
��Left=��� -    ��Name$ locationBlock��$��
47,45,10,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��18(�$��Segoe UI Light)�$
��Left=�$	��741��$��24���� -	   $��Right=�$	��Top=�$��18(�$��Segoe UI Light)�$��32�����	#FFE4E4E4 � Cursor$
 Hand��  ButtonStyleOne#���  $��	0,74,10,0q� K� ZIndex$ -5��$��0q����	#FF0080FF$	��127��.��� $	��158��$��33��.+��� $
��Left=�$��33��$	��Top=�$��33��$��Images/upload.png��$��UniformToFill=�$��0,-2,0,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� $��Качи файл��$
��Left=�$��	34,-3,0,2q�#���      $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -
   $
��Left=�$	��Top=�$��18(�$��Segoe UI Light)�$��32�����	#FFE4E4E4$
 Hand��#���  $��	10,74,0,0q�$ -5��$��0q����	#FF0080FF$	��109��.��� $	��158��$��33��.+��� $
��Left=�$��33��$	��Top=�$��33��$��Images/home.png��$��UniformToFill=�$��0,-2,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $��Начало��$
��Left=�$��	34,-3,0,2q�#���      $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -    ��Name$ 
backButton��$
��Left=�$	��Top=�$��18(�$��Segoe UI Light)�$��32�����	#FFE4E4E4$
 Hand��#���  $��
124,74,0,0q�$ -5��$��0q����	#FF0080FF$��90��$y�Hidden=�.��� $	��158��$��33��.+��� $
��Left=�$��22��$	��Top=�$��22��$��Images/backButton.png�� J� RenderTransformOrigin$ 0.5,0.5&�$��UniformToFill=�$��0,3,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	 1.5Q��� $��
Назад��$
��Left=�$��	26,-3,0,2q�#���      $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ DividerMain_Copy��$��2��$��	0,111,0,0q�$	��Top=�$
��None=�$ ��Images/DividerMainBlue.png���� $
��Left=�$��33��$	��Top=�$��33��$��Images/Network.png��$��UniformToFill=�$��6,0,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $��	0,111,0,2q�$
��Auto=���.  � ContextMenu# �  .���� -     ��Name$  explorerCanvas��$	��394��$	��798��.+��� -   $ foldersLabel��$��Папки:��$
��Left=�$	��Top=����	#FF3A3A3A$��18(�$��Segoe UI Light)�$��	20,10,0,0q��� -   $ 
filesLabel��$��Файлове:��$
��Left=�$	��Top=����	#FF3A3A3A$��18(�$��Segoe UI Light)�$��	20,10,0,0q��� -   $ 
emptyLabel��$)��#Тази папка е празна��$��Center=�$	��Top=����	#FF3A3A3A$��36(�$��Segoe UI Light)�$��0,50,0,0q�� -   ! �Name$! Loader��
���   �" J� Opacity$	" 0.7Q�$��0q�$y�Hidden=�.+��� -   $ loadingMessage��$��0,191,0,268q�$
��Wrap=����	#FFE4E4E4$��36(�$(��"Качване на файлове��$��Segoe UI Light)�$��CharacterEllipsis=�$��Center=�$	��Top=�� $��Center=�$��29��$��	0,262,0,0q�$	��Top=�$	��226�����	#FFE4E4E4���	#FFE4E4E4# � IsIndeterminate# . ��Z� �� -   $��Right=�$	��Top=�$��18(�$��Segoe UI Light)�$��32�����	#FFE4E4E4$
 Hand��#���  $��
0,74,142,0q�$ -5��$��0q����	#FF0080FF$	��147��.��� $	��158��$��33��.+��� $
��Left=�$��25��$	��Top=�$��25��$��Images/addIcon.png��$��UniformToFill=�$��0,1,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $��Създай папка��$
��Left=�$��	30,-3,0,0q�#���      $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�