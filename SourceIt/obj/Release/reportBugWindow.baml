   M S B A M L   `   `   `  ����   SourceIt    SourceIt.reportBugWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  reportBugWindow��$	��366��$	��435�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=����	#FF0080FF$��1q� � Icon$ Images/NewLogo.png�� � 
ResizeMode$ NoResize=� � ShowInTaskbar .   � 	Resources    InButtonLabel �� 
TargetType �� Property	 �� Value
 �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� " ��.���  � ��
	 �   �
 ��  �� *IsMouseOver+ �� $ 1��" �� True.a���  � ��
	 �����.��� ���	#FFE4E4E4.+��� $��
58,10,10,0q�$
��Wrap=�$	��Top=�$��65�����	#FF3A3A3A$��48(�$��Докладвай��$��Segoe UI Light)��� $��Images/bug.png��$��UniformToFill=�$��	10,27,0,0q�$��40��$��40��$
��Left=� K� ZIndex$ -5��$	��Top=��� $��10,100,314,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Описание:���� -    ��Name$ errorDescription��$
��Left=�$	��214��$��124,100,0,0q� �� TextWrapping$ WrapWithOverflow=�$	��Top=�$	��272��$��20(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q� �� AcceptsReturn . ��. ��Z� �� -   $��Right=� � Cursor$
 Hand��$��88.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)� � UseLayoutRounding .    ButtonStyleOne#���  $��0q�$��Bottom=���Z� .��� .+��� -    ��Name$ helpFindLabel1��$��Изпрати��#��[  $��20(�$��-9,-2,-10,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� -   $��Right=�$
 Hand��$��74.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)� .  #���  $��0q�$��Bottom=�$��0,0,88.348,0q���Z� .��� .+��� -   $ helpFindLabel2��$��
Отказ��#��[  $��20(�$��-9,-2,-10,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�� -    �Name$ loader�� J� Opacity$	 0.7Q�
���   �$y�Hidden=�