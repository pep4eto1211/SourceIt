   M S B A M L   `   `   `  ����  SourceIt!    SourceIt.changeServerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  changeServerWindow��5   	   $��208.247��6$   $	��435��65    � WindowStartupLocation$ CenterScreen=�6B    � WindowStyle$
 None=�6g   ���	#FF0080FF$��1q�6�    � Icon$ Images/NewLogo.png��6�    � 
ResizeMode$ NoResize=�6�    � Topmost .  � ShowInTaskbar .   � 	Resources 5         InButtonLabel �� 
TargetType	 �� Property
 �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� 5   
   " ��6&   .�5      �� 	 � ��

 �   �6+    5      �� 5	       6   �� *IsMouseOver+ �� $ 1��" �� True6�   .a�5
      �� 	 � ��

 �����63   5      5      5      .��5      � ���	#FFE4E4E4.+�5   
   �� $��
55,10,10,0q�6   $
��Wrap=�6(   $	��Top=�6<   ���	#FF3A3A3A$��48(�6k   $��Смени сървър��6y   $��Segoe UI Light)�6�   �� 5   
   $
��Left=�6   $��40��6+   $��	10,27,0,0q�67   $	��Top=�6J   $��40��6b   $��Images/Network.png��6m   �� 5   
   $��
11,101,0,0q�6   $
��Wrap=�6(   $	��Top=�6<   ���	#FF3A3A3A$��22(�6k   $��Segoe UI Light)�6y   $��Адрес:��6�   $
��Left=�6�   �� 5   
   -   5         ��Name$ serverAddressBox��5      $��31��6,   $��79,101,20,0q�68    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $��20(�6y   ���	#FF0080FF���	#FF3A3A3A$��1q�6�   $��1,0,1,1q�6�   ��6�   Z� 6�   �� 5   
   -   5        $��Right=�5       � Cursor$
 Hand��6-   $��77.266��6;   ���	#FF3A3A3A$��18(�6x   ���	#FFE4E4E4$��Segoe UI Light)�6�   $��0,0,87.833,20q�6�    � UseLayoutRounding .    ButtonStyleOne#���  6�   $��0q�6  $��Bottom=�6'  ��6a   Z� .��5      � .+�5      �� -   5         ��Name$ helpFindLabel3��5      $��Запази��60   #��[  6A   $��20(�6h   $��0,-2,2,0q�6v    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6+      Color$ 	#FF3A3A3A��6:      	Direction$	 315Q�6L      ShadowDepth$	 1.5Q�6\   5      5      5      �� 5   
   -   5        $��Right=�5      $
 Hand��6-   $��62.833��6;   ���	#FF3A3A3A$��18(�6x   ���	#FFE4E4E4$��Segoe UI Light)�6�   $��	0,0,20,20q�6�    .  #���  6�   $��0q�6  $��Bottom=�6#  ��6a   Z� .��5      � .+�5       �� -   5        $ helpFindLabel1��5       $��
Отказ��60   #��[  6@   $��20(�6g   $��0,-2,2,0q�6u    5!        5"      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   5$      5%      5&      5(      5)      