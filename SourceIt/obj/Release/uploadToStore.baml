   M S B A M L   `   `   `  ����   SourceIt    SourceIt.uploadToStore   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  uploadToStore��$	��509��$	��435�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=����	#FF0080FF$��1q� � Icon$ Images/NewLogo.png�� � 
ResizeMode$ NoResize=� � ShowInTaskbar .   � 	Resources    InButtonLabel �� 
TargetType �� Property	 �� Value
 �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� " ��.���  � ��
	 �   �
 ��  �� *IsMouseOver+ �� $ 1��" �� True.a���  � ��
	 �����.��� ���	#FFE4E4E4.+��� $��
10,10,10,0q�$
��Wrap=�$	��Top=�$��65�����	#FF3A3A3A$��48(�$"��+ Качи в магазин��$��Segoe UI Light)��� $��10,93,322,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Име:���� -    ��Name$ projectNameBox��$
��Left=�$��31��$��
124,93,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��272��$��20(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q���Z� �� $��10,134,314,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Описание:���� -   $ projectDescription��$
��Left=�$	��147��$��124,134,0,0q�$ WrapWithOverflow=�$	��Top=�$	��272��$��20(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q� �� AcceptsReturn . ��. ��Z� �� $��10,290,314,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Категория:���� -    ��Name$ projectCategory��$
��Left=�$��124,290,0,0q�$	��Top=�$	��272��$��1,0,1,1q�$��20(����	#FF0080FF���	#FF3A3A3A$��31�����	#FFE4E4E4.@��� $��Books���� $��Music���� $��Productivity tools���� $��	Utilities���� $��Entertainment���� $��	3D Models���� $��	3D Movies���� $��Other���� -   $��Right=� � Cursor$
 Hand��$��58�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)� � UseLayoutRounding .    ButtonStyleOne#���  $��0q�$��Bottom=���Z� .��� .+��� -    ��Name$ helpFindLabel1��$��Качи��#��[  $��20(�$��-9,-2,-10,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� -   $��Right=�$
 Hand��$��74.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)� .  #���  $��0q�$��Bottom=�$��0,0,58,0q���Z� .��� .+��� -   $ helpFindLabel3��$��
Отказ��#��[  $��20(�$��0,-2,2,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -	    ��Name$ 	nameError��$
��Left=�$��31��$��396,125,0,0q�$	��Top=�$��31��$��Images/errorIcon.png��$
 Hand�� J� RenderTransformOrigin$ 0.419,0.516&�$y�Hidden=��� -
   $ descriptionError��$
��Left=�$��31��$��396,183,0,0q�$	��Top=�$��31��$��Images/errorIcon.png��$
 Hand��$ 0.419,0.516&�$y�Hidden=��� -   $ categoryError��$
��Left=�$��31��$��396,351,0,0q�$	��Top=�$��31��$��Images/errorIcon.png��$
 Hand��$ 0.419,0.516&�$y�Hidden=��� $��
10,334,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Файлове:��$
��Left=��� -   $ selectedFilesBox��$
��Left=�$��31��$��103,334,0,0q�$
 Wrap=�$	��Top=�$	��214��$��20(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q� �� 
IsReadOnly . ��Z� �� -   $
��Left=�$
 Hand��$��74.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��322,334,0,142q� .  #���  $��0q���Z� .��� .+��� -   $ helpFindLabel2��$��Избери��#��[  $��20(�$��-9,-4,-10,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $��
10,376,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Икона:��$
��Left=��� -   $ selectedIconBox��$
��Left=�$��31��$��103,376,0,0q�$
 Wrap=�$	��Top=�$	��214��$��20(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q� . ��Z� �� -   $
��Left=�$
 Hand��$��74.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��322,376,0,100q� .  #���  $��0q���Z� .��� .+��� -   $ helpFindLabel4��$��Избери��#��[  $��20(�$��-9,-4,-10,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $��
10,415,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Снимка:��$
��Left=��� -   $ selectedScreenshotBox��$
��Left=�$��31��$��103,415,0,0q�$
 Wrap=�$	��Top=�$	��214��$��20(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q� . ��Z� �� -   $
��Left=�$
 Hand��$��74.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��322,415,0,61q� .  #���  $��0q���Z� .��� .+��� -   $ helpFindLabel5��$��Избери��#��[  $��20(�$��-9,-4,-10,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�� -    �Name$ loader��
���   �  J� Opacity$	  0.7Q�$y�Hidden=�.+��� -   ! ��Name$! loaderLable��$
��Wrap=����	#FFE4E4E4$��36(�$(��"Качване в магазина��$��Segoe UI Light)�$��CharacterEllipsis=�$��Center=�$��Center=�$��	0,0,0,101q�� $��Center=�$��29��$��Center=�$	��226�����	#FFE4E4E4���	#FFE4E4E4" � IsIndeterminate" . ��Z� 