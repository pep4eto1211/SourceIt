   M S B A M L   `   `   `  ����   SourceIt    SourceIt.addUserWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$  addUserWindow��$	��509��$	��435�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=����	#FF0080FF$��1q� � Icon$ Images/NewLogo.png�� � 
ResizeMode$ NoResize=� � Topmost .  � ShowInTaskbar .   � 	Resources    InButtonLabel �� 
TargetType	 �� Property
 �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� " ��.��� 	 � ��

 �   � ��  �� *IsMouseOver+ �� $ 1��" �� True.a��� 	 � ��

 �����.��� ���	#FFE4E4E4.+��� $��	10,10,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��48(�$'��!+ Добавяне на хора ��$��Segoe UI Light)��� -    ��Name$ allUseresPanel��$��10,88,10,50q����	#FF0080FF��Z� �� -    ��Name$ 	addButton��$
��Left=� � Cursor$
 Hand��$��127.488�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��295.512,462,0,5.679q� � UseLayoutRounding .    ButtonStyleOne#���  $��0q�$y�Hidden=���Z� .��� .+��� -    ��Name$ helpFindLabel1��$��Добави��#��[  $��20(� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q�� -    �Name$ loader��
���   � J� Opacity$ 0.705Q��� -   $ cancelButton��$
��Left=�$
 Hand��$��127.488�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��163.024,462,0,5.679q� .  #���  $��0q���Z� .��� .+��� -   $ helpFindLabel2��$��
Отказ��#��[  $��20(�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�