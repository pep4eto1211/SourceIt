   M S B A M L   `   `   `  ����   SourceIt    SourceIt.confirmWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  confirmWindow��$��317.712��$��539.114�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=����	#FF0080FF$��1q� � Icon$ Images/NewLogo.png�� � 
ResizeMode$ NoResize=� � Topmost .  � 	Resources    InButtonLabel �� 
TargetType �� Property	 �� Value
 �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� " ��.���  � ��
	 �   �
 ��  �� *IsMouseOver+ �� $ 1��" �� True.a���  � ��
	 �����.��� ���	#FFE4E4E4 � RowDefinitions �� �� $��48 �.+��� -    ��Name$ confirmationText��$
��Wrap=�$	��Top=����	#FF3A3A3A$��48(�$
��Text��$��Segoe UI Light)�$��Center=�$	��517���� -    � Cursor$
 Hand�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)�$��0,0,81,0q� � UseLayoutRounding .    ButtonStyleOne#���  $	��1,0q�$��Right=�$��Bottom=� J� RenderTransformOrigin$ 	0.5,0.514&� �� 	IsDefault . $��48��$��81��$��1��.��� .+��� -    ��Name$ helpFindLabel1��$
��Да��#��[  $��24(�$��0,0,0,-2q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� -   $
 Hand�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)� .  #���  $��0q�$��Right=�$��Bottom=�$ 	0.5,0.514&�$��48��$��81�� �� IsCancel . $��1��.��� .+��� -   $ helpFindLabel2��$
��Не��#��[  $��24(�$��0,0,0,-2q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -    ��Name$ DividerMain_Copy��$
��Left=�$��2��$	��Top=�$	��537��$
��None=�$ ��Images/DividerMainBlue.png��$��1��