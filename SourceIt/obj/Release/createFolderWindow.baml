   M S B A M L   `   `   `  ����   SourceIt!    SourceIt.createFolderWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  createFolderWindow��$��208.247��$	��435�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=����	#FF0080FF$��1q� � Icon$ Images/NewLogo.png�� � 
ResizeMode$ NoResize=� � Topmost .  � ShowInTaskbar .   � 	Resources    InButtonLabel �� 
TargetType	 �� Property
 �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� " ��.��� 	 � ��

 �   � ��  �� *IsMouseOver+ �� $ 1��" �� True.a��� 	 � ��

 �����.��� ���	#FFE4E4E4.+��� $��
10,10,10,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��48(�$��+ Създай папка��$��Segoe UI Light)��� $��
11,101,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Име:��$
��Left=��� -    ��Name$ folderNameBox��$��31��$��62,101,20,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��20(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q���Z� �� -   $��Right=� � Cursor$
 Hand��$��77.266�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��0,0,87.833,20q� � UseLayoutRounding .    ButtonStyleOne#���  $��0q�$��Bottom=���Z� .��� .+��� -    ��Name$ helpFindLabel3��$��Създай��#��[  $��20(�$��0,-2,2,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� -   $��Right=�$
 Hand��$��62.833�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��	0,0,20,20q� .  #���  $��0q�$��Bottom=���Z� .��� .+��� -   $ helpFindLabel1��$��
Отказ��#��[  $��20(�$��0,-2,2,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�