   M S B A M L   `   `   `  ����   SourceIt"    SourceIt.downloadFilesWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  downloadFilesWindow��$	��509��$	��435�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=����	#FF0080FF$��1q� � Icon$ Images/NewLogo.png�� � 
ResizeMode$ NoResize=� � Topmost .  � TaskbarItemInfo *  $System.Windows.Shell.TaskbarItemInfo   � 	Resources    InButtonLabel �� 
TargetType	 �� Property
 �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� " ��.��� 	 � ��

 �   � ��  �� *IsMouseOver+ �� $ 1��" �� True.a��� 	 � ��

 �����.��� ���	#FFE4E4E4.+��� $��
10,10,10,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��48(�$��↓ Сваляне��$��Segoe UI Light)��� $��
10,124,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Папка:��$
��Left=��� -    ��Name$ folderNameBox��$
��Left=�$��31��$��
79,124,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��239��$��20(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q���Z� �� -   $
��Left=� � Cursor$
 Hand��$��74.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��322.652,124,0,352q� � UseLayoutRounding .    ButtonStyleOne#���  $��0q���Z� .��� .+��� -    ��Name$ helpFindLabel1��$��Намери��#��[  $��20(�$��-9,-4,-10,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� $��10,163,314,0q�$
��Wrap=�$	��Top=�$��31�����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��Дневник:���� -   $ logBox��$
��Left=�$	��147��$��
10,199,0,0q�$ WrapWithOverflow=�$	��Top=�$	��413��$��16(����	#FF0080FF���	#FF3A3A3A$��1q�$��1,0,1,1q� �� AcceptsReturn . ��.  �� 
IsReadOnly . " �� VerticalScrollBarVisibility$
 Auto=���Z� �� -    ��Name$ closeWindowButton��$
��Left=�$
 Hand��$��113.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��309.652,456.803,0,10.876q� .  #���  $��0q���Z� .��� .+��� -   $ helpFindLabel3��$��Затвори��#��[  $��20(�$��0,-2,2,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $
��Left=�$
 Hand��$��107.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��309.652,420.803,0,55.197q� .  #���  $��0q���Z� .��� .+��� -	   $ helpFindLabel2��$��Сваляне��#��[  $��20(�$��-9,-8,-10,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�� -
    �Name$ uploadProgress��$
��Left=�$��31��$��
10,358,0,0q�$	��Top=�$	��413��$��1q����	#FF0080FF���	#FF0080FF��Z� �� $��	10,79,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Проект:��$��Segoe UI Light)�$
��Left=��� -     ��Name$  projectNameBox��$��	88,79,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$
��Left=��� -   $ minimizeWindowButton��$
��Left=�$
 Hand��$��163.348�����	#FF3A3A3A$��18(����	#FFE4E4E4$��Segoe UI Light)�$��121.304,456.803,0,10.876q� .  #���  $��0q���Z� .��� .+��� -   $ helpFindLabel4��$��Минимизирай��#��[  $��20(�$��0,-2,2,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�