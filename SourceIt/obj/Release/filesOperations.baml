   M S B A M L   `   `   `  ����   SourceIt    SourceIt.filesOperations   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     �Name$  fileOperationsWindow�� � Title$ filesOperations��$	��509��$	��435�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=����	#FF0080FF$��1q� � Icon$ Images/NewLogo.png�� � 
ResizeMode$ NoResize=� � Topmost .  � ShowInTaskbar .   � 	Resources    InButtonLabel	 �� 
TargetType
 �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� "	 ��.��� 
 � ��
 �   � ��  �� *IsMouseOver+ �� $ 1��" �� True.a��� 
 � ��
 ����� � Triggers :�  :� RoutedEvent$ Window.Loaded��.[��� .���� .��W�  �� 
TargetName$ fileOperationsWindow�� �� TargetProperty$ Opacity� W� From$	 0.0X�	 W� To$	 1.0X� g� Duration$ 0:0:0.5D�.��� -   $��fileOperationsGrid�����	#FFE4E4E4.+��� $��
56,10,10,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��48(�$��Файлове��$��Segoe UI Light)��� $��	10,79,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Трансфер:��$��Segoe UI Light)�$
��Left=��� $��
10,178,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$5��/Разглеждане на файловете:��$��Segoe UI Light)�$
��Left=��� $��
10,277,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$'��!Връщане на версия:��$��Segoe UI Light)�$
��Left=��� -    ��Name$ closeWindowButton��$
��Left=� � Cursor$
 Hand��$��113.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��309.652,456.803,0,10.876q� � UseLayoutRounding .    ButtonStyleOne#���  $��0q���Z� .��� .+��� -    ��Name$ helpFindLabel3��$��Затвори��#��[  $��20(�$��0,-2,2,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��    	Direction$	  315Q�!   ShadowDepth$	! 1.5Q��� -   $��Right=�$	��Top=�$��18(�$��Segoe UI Light)�$��32�����	#FFE4E4E4$
 Hand��#���  $��0,127,253,0q�" K� ZIndex$" -5��$��0q����	#FF0080FF.��� $	��158��$��33��.+��� $
��Left=�$��33��$	��Top=�$��33��$��Images/upload.png��$��UniformToFill=�$��0,-2,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	  315Q�$	! 1.5Q��� $��Качи файлове��$��Right=�$��0,-3,0,2q�#���      $ 5Q�$ 	#FF3A3A3A��$	  315Q�$	! 1.5Q��� -   $��Right=�$	��Top=�$��18(�$��Segoe UI Light)����	#FFE4E4E4$
 Hand��#���  $��
0,127,63,0q�$" -5��$��0q����	#FF0080FF$	��170��.��� .+��� $
��Left=�$��33��$	��Top=�$��33��$��Images/upload.png��$��UniformToFill=�$��0,-2,0,0q�# J� RenderTransformOrigin$# 0.5,0.5&�z�V� .~��� �� �� $ �� Angle$	$ 180Q�T�    $ 5Q�$ 	#FF3A3A3A��$	  135Q�$	! 1.5Q��� $��Свали файлове��$��Right=�$��	33,-3,0,2q�#���      $ 5Q�$ 	#FF3A3A3A��$	  315Q�$	! 1.5Q��� -   $��Right=�$	��Top=�$��18(�$��Segoe UI Light)�$��32�����	#FFE4E4E4$
 Hand��#���  $��0,227,297,0q�$" -5��$��0q����	#FF0080FF$	��116��.��� .+��� $
��Left=�$��33��$	��Top=�$��33��$��Images/Computer.png��$��UniformToFill=�$��0,-2,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	  315Q�$	! 1.5Q��� $��Локално��$��Right=�$��	32,-3,0,2q�#���      $ 5Q�$ 	#FF3A3A3A��$	  315Q�$	! 1.5Q��� -   $��Right=�$	��Top=�$��18(�$��Segoe UI Light)�$��32�����	#FFE4E4E4$
 Hand��#���  $��
0,227,96,0q�$" -5��$��0q����	#FF0080FF$	��137��.��� .+��� $
��Left=�$��33��$	��Top=�$��33��$��Images/Network.png��$��UniformToFill=�$��0,-2,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	  315Q�$	! 1.5Q��� $��На сървъра��$��Right=�$��	32,-3,0,2q�#���      $ 5Q�$ 	#FF3A3A3A��$	  315Q�$	! 1.5Q��� -	   % ��Name$% beckupAvailableBlock��$��
20,321,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$
��Left=��� -
   $ 
undoButton��$��Right=�$	��Top=�$��18(�$��Segoe UI Light)����	#FFE4E4E4$
 Hand��#���  $��
0,385,96,0q�$" -5��$��0q����	#FF0080FF$	��137��$y�Hidden=�.��� .+��� $
��Left=�$��33��$	��Top=�$��33��$��Images/undo.png��$��UniformToFill=�$��0,-2,0,0q�$# 0.5,0.5&�   $ 5Q�$ 	#FF3A3A3A��$	! 1.5Q��� $��Върни сега��$��Right=�$��	33,-3,0,2q�#���      $ 5Q�$ 	#FF3A3A3A��$	  315Q�$	! 1.5Q��� $
��Left=�$��40��$��	10,27,0,0q�$	��Top=�$��40��$��Images/folder.png��