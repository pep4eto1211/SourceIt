   M S B A M L   `   `   `  ����   SourceIt    SourceIt.LoginWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$  LoginWindow��$	��509��$	��435�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=����	#FF0080FF$��1q� � Icon$ Images/NewLogo.png�� � 
ResizeMode$ NoResize=� � Topmost .  � 	Resources    InButtonLabel �� 
TargetType �� Property	 �� Value
 �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� " ��.���  � ��
	 �   �
 ��  �� *IsMouseOver+ �� $ 1��" �� True.a���  � ��
	 �����.��� ���	#FFE4E4E4$��0,0,0,-2q�.+��� $��10,10,158,0q�$
��Wrap=�$	��Top=�$��62�����	#FF3A3A3A$��48(�$��</> SourceIt��$��Segoe UI Light)��� $��10,106,45,0q�$
��Wrap=�$	��Top=�$��59�����	#FF3A3A3A$��22(�$n��hЗа да използвате приложението трябва да сте в профила си:��$��Segoe UI Light)��� $��10,203,322,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Потр. име:���� $��17,275,322,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Парола:���� -    ��Name$ userNameBox��$
��Left=�$��31��$��116,203,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��272��$��20(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q���Z� G� -    G�Name$ passwordBox��$
��Left=�$��116,275,0,0q�$	��Top=�$	��272��$��20(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q�$��31����Z� �� -   $
��Left=� � Cursor$
 Hand��$��57.385�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��357.615,354.985,0,114.694q� � UseLayoutRounding .    ButtonStyleOne#���  $��0q���Z� .��� $��57��$��37��.+��� -    ��Name$ helpFindLabel1��$��Вход��$��Center=�$��Center=�#��[  $��39��$��67��$��20(�$��
0,-2,-10,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� -   $
��Left=�$
 Hand��$��166.979�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��248.021,397.306,0,72.373q� .  #���  $��0q���Z� .��� $	��168��$��37��.+��� -   $ helpFindLabel2��$%��Нова регистрация��$��Right=�$��Center=�#��[  $��39��$	��174��$��20(�$��
-4,-2,-2,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $
��Left=�$
 Hand��$��67.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��347.652,439.627,0,30.052q� .  #���  $��0q���Z� .��� $��69��$��37��.+��� -	   $ helpFindLabel3��$��
Отказ��$��Center=�$��Center=�#��[  $��39��$��67��$��20(�$��0,-2,2,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -
    ��Name$ 	userError��$
��Left=�$��31��$��393,203,0,0q�$	��Top=�$��31��$��Images/errorIcon.png��$
 Hand�� J� RenderTransformOrigin$ 0.419,0.516&�$y�Hidden=��� -   $ 	passError��$
��Left=�$��31��$��393,275,0,0q�$	��Top=�$��31��$��Images/errorIcon.png��$
 Hand��$ 0.419,0.516&�$y�Hidden=��� -   $
��Left=�$��Bottom=�$��18(�$��Segoe UI Light)�$��32�����	#FFE4E4E4$
 Hand��#���   K� ZIndex$ -5��$��0q����	#FF0080FF$	��161��$��	10,0,0,37q�.��� .+��� $
��Left=�$��33��$	��Top=�$��33��$��Images/Network.png��$��UniformToFill=�$��0,-2,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $��Смени сървър��$��Right=�$��	32,-3,0,2q�#���      $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�