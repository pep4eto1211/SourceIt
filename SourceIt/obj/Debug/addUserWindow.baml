   M S B A M L   `   `   `  ����  SourceIt    SourceIt.addUserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   -   5          � Title$  addUserWindow��5   	   $	��509��6    $	��435��6-    � WindowStartupLocation$ CenterScreen=�69    � WindowStyle$
 None=�6^   ���	#FF0080FF$��1q�6�    � Icon$ Images/NewLogo.png��6�    � 
ResizeMode$ NoResize=�6�    � Topmost .  � ShowInTaskbar .   � 	Resources 5         InButtonLabel �� 
TargetType	 �� Property
 �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� 5   
   " ��6&   .�5      �� 	 � ��

 �   �6+    5	      �� 5
       6   �� *IsMouseOver+ �� $ 1��" �� True6�   .a�5      �� 	 � ��

 �����63   5      5      5      .��5      � ���	#FFE4E4E4.+�5   
   �� $��	10,10,0,0q�6   $
��Wrap=�6'   $	��Top=�6;   ���	#FF3A3A3A$��48(�6j   $'��!+ Добавяне на хора ��6x   $��Segoe UI Light)�6�   �� 5   
   -   5         ��Name$ allUseresPanel��5      $��10,88,10,50q�6*   ���	#FF0080FF��6W   Z� 6m   �� 5   
   -   5         ��Name$ 	addButton��5      $
��Left=�6$    � Cursor$
 Hand��6?   $��127.488��6M   ���	#FF3A3A3A$��18(�6�   ���	#FFE4E4E4$��Segoe UI Light)�6�   $��295.512,462,0,5.679q�6�    � UseLayoutRounding .    ButtonStyleOne#���  6  $��0q�6,  $y�Hidden=�6V  ��6t   Z� .��5      � .+�5      �� -   5         ��Name$ helpFindLabel1��5      $��Добави��60   #��[  6A   $��20(�6h    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6+      Color$ 	#FF3A3A3A��6:      	Direction$	 315Q�6L      ShadowDepth$	 1.5Q�6\   5      5      5      � 5   
   -   5         �Name$ loader��5      
���   � J� Opacity$ 0.705Q�62   �� 5   
   -   5        $ cancelButton��5      $
��Left=�6'   $
 Hand��6B   $��127.488��6P   ���	#FF3A3A3A$��18(�6�   ���	#FFE4E4E4$��Segoe UI Light)�6�   $��163.024,462,0,5.679q�6�    .  #���  6  $��0q�6/  ��6w   Z� .��5      � .+�5       �� -   5        $ helpFindLabel2��5       $��
Отказ��60   #��[  6@   $��20(�6g    5!        5"      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   5$      5%      5&      5(      5)      