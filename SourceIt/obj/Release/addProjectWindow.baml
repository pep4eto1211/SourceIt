   M S B A M L   `   `   `  ����   SourceIt    SourceIt.addProjectWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  addProjectWindow��$	��509��$	��435�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=����	#FF0080FF$��1q� � Icon$ Images/NewLogo.png�� � 
ResizeMode$ NoResize=� � ShowInTaskbar .   � 	Resources    InButtonLabel �� 
TargetType �� Property	 �� Value
 �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� " ��.���  � ��
	 �   �
 ��  �� *IsMouseOver+ �� $ 1��" �� True.a���  � ��
	 �����.��� ���	#FFE4E4E4.+��� $��
10,10,10,0q�$
��Wrap=�$	��Top=�$��65�����	#FF3A3A3A$��48(�$!��+ Добави проект��$��Segoe UI Light)��� $��10,125,322,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Име:���� -    ��Name$ projectNameBox��$
��Left=�$��31��$��124,125,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��272��$��20(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q���Z� �� $��10,183,314,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Описание:���� -   $ projectDescription��$
��Left=�$	��147��$��124,183,0,0q�$ WrapWithOverflow=�$	��Top=�$	��272��$��20(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q� �� AcceptsReturn . ��. ��Z� �� $��10,351,314,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Категория:���� -    ��Name$ projectCategory��$
��Left=�$��124,351,0,0q�$	��Top=�$	��272��$��1,0,1,1q�$��20(����	#FF0080FF���	#FF3A3A3A$��31�����	#FFE4E4E4.@��� $��Books���� $��Music���� $��Productivity tools���� $��	Utilities���� $��Entertainment���� $��	3D Models���� $��	3D Movies���� $��Other���� -   $
��Left=� � Cursor$
 Hand��$��74.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��348.652,417.482,0,50.197q� � UseLayoutRounding .    ButtonStyleOne#���  $��0q���Z� .��� .+��� -    ��Name$ helpFindLabel1��$��Създай��#��[  $��20(�$��-9,-2,-10,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� -   $
��Left=�$
 Hand��$��74.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��348.652,456.803,0,10.876q� .  #���  $��0q���Z� .��� .+��� -   $ helpFindLabel3��$��
Отказ��#��[  $��20(�$��0,-2,2,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -	    ��Name$ 	nameError��$
��Left=�$��31��$��396,125,0,0q�$	��Top=�$��31��$��Images/errorIcon.png��$
 Hand�� J� RenderTransformOrigin$ 0.419,0.516&�$y�Hidden=��� -
   $ descriptionError��$
��Left=�$��31��$��396,183,0,0q�$	��Top=�$��31��$��Images/errorIcon.png��$
 Hand��$ 0.419,0.516&�$y�Hidden=��� -   $ categoryError��$
��Left=�$��31��$��396,351,0,0q�$	��Top=�$��31��$��Images/errorIcon.png��$
 Hand��$ 0.419,0.516&�$y�Hidden=�