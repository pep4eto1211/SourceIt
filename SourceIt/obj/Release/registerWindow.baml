   M S B A M L   `   `   `  ����   SourceIt    SourceIt.registerWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  registerWindow��$	��509��$	��435�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=����	#FF0080FF$��1q� � Icon$ Images/NewLogo.png�� � 
ResizeMode$ NoResize=� � Topmost .  � 	Resources    InButtonLabel �� 
TargetType �� Property	 �� Value
 �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� " ��.���  � ��
	 �   �
 ��  �� *IsMouseOver+ �� $ 1��" �� True.a���  � ��
	 �����.��� ���	#FFE4E4E4.+��� -    ��Name$ userBox��$
��Left=�$��37��$��
87,135,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��288��$��22(����	#FF0080FF���	#FF3A3A3A$��1����Z� �� -   $ emailBox��$
��Left=�$��37��$��
87,337,0,0q�$
 Wrap=�$	��Top=�$	��288��$��22(����	#FF0080FF���	#FF3A3A3A$��4����Z� G� -    G�Name$ passBox��$
��Left=�$��
87,203,0,0q�$	��Top=�$	��288�����	#FF0080FF���	#FF3A3A3A$��22(�$��38��$��2����Z� G� -   $ confPass��$
��Left=�$��
87,270,0,0q�$	��Top=�$	��288�����	#FF0080FF���	#FF3A3A3A$��22(�$��38��$��3����Z� �� -   $
��Left=� � Cursor$
 Hand��$��133.691�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��289.309,463,0,10q� � UseLayoutRounding .    ButtonStyleOne#���  $��0q���Z� .��� .+��� -    ��Name$ helpFindLabel��$��Регистрация��$��0q�#��[  $��5����.  J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� -    ��Name$ 	userError��$
��Left=�$��38��$��383,134,0,0q�$	��Top=�$��38��$��Images/errorIcon.png��$
 Hand��$y�Hidden=��� -	   $ 	passError��$
��Left=�$��38��$��383,203,0,0q�$	��Top=�$��38��$��Images/errorIcon.png��$
 Hand��$y�Hidden=��� -
   $ 	confError��$
��Left=�$��38��$��384,270,0,0q�$	��Top=�$��38��$��Images/errorIcon.png��$
 Hand��$y�Hidden=��� -   $ 
emailError��$
��Left=�$��38��$��383,337,0,0q�$	��Top=�$��38��$��Images/errorIcon.png��$
 Hand��$y�Hidden=��� $��10,10,158,0q�$
��Wrap=�$	��Top=�$��62�����	#FF3A3A3A$��48(�$��Регистрация��$��Segoe UI Light)��� $��10,104,322,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Потр. име:���� $��10,172,322,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Парола:���� $��
10,241,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$$��Потвърди парола:��$
��Left=��� $��
10,308,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��И-мейл:��$
��Left=��� -   $
��Left=�$
 Hand��$��78.691�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��210.618,463,0,10q� .  #���  $��0q���Z� .��� .+��� -   $ helpFindLabel1��$��
Отказ��$��0q�#��[  $��5����.    $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�