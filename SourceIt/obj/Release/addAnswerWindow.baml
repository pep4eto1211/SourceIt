   M S B A M L   `   `   `  ����   SourceIt    SourceIt.addAnswerWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  addAnswerWindow��$	��334��$	��435�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=����	#FF0080FF$��1q� � Icon$ Images/NewLogo.png�� � 
ResizeMode$ NoResize=� � ShowInTaskbar .   � 	Resources    InButtonLabel �� 
TargetType �� Property	 �� Value
 �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� " ��.���  � ��
	 �   �
 ��  �� *IsMouseOver+ �� $ 1��" �� True.a���  � ��
	 �����.��� ���	#FFE4E4E4.+��� $��
10,10,10,0q�$
��Wrap=�$	��Top=�$��65�����	#FF3A3A3A$��48(�$#��+ Добави отговор��$��Segoe UI Light)��� $��10,95,322,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Текст:���� -    ��Name$ newQuestionContentBox��$	��165�� �� TextWrapping$ WrapWithOverflow=�$	��Top=�$��20(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q� �� AcceptsReturn . ��. $��10,130,10,0q���Z� �� -   $��Right=� � Cursor$
 Hand��$��74.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)� � UseLayoutRounding .    ButtonStyleOne#���  $��0q�$��Bottom=���Z� .��� .+��� -    ��Name$ helpFindLabel1��$��Добави��#��[  $��20(�$��-9,-2,-10,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� -   $��Right=�$
 Hand��$��65.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)� .  #���  $��0q�$��Bottom=�$��0,0,74.348,0q���Z� .��� .+��� -   $ helpFindLabel2��$��
Отказ��#��[  $��20(�$��-9,-2,-10,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�