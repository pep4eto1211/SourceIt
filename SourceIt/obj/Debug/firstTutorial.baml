   M S B A M L   `   `   `  ����  SourceIt    SourceIt.firstTutorial   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  firstTutorial��5      $	��594��6   $	��275��6$    � 	Resources 5	         InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel	 �� AncestorType
 �� Value��%�   &	        �� 5
   
   " ��6&   .�5      ��  � ��
 �   �6+    5      �� 5       6   �� *IsMouseOver+ �� $ 1��"	 ��
 True6�   .a�5      ��  � ��
 �����63   5      5      5      .��5      � ���	#FFE4E4E4$	��593��6"   $	��274��6.   .+�5   
   �� $��0,15,0,0q�6   $
��Wrap=�6&   $��Добре дошли��6:   $	��Top=�6M   ���	#FF3A3A3A$��48(�6|   $��Center=�6�   �� 5   
   $��99,107,98,0q�6   $
��Wrap=�6)   $?��9Нека ви покажем първите стъпки.��6=   $	��Top=�6d   $	��108��6|   ���	#FF3A3A3A$��36(�6�   $��Center=�6�   �� 5   
   -   5        $
��Left=�5       � Cursor$
 Hand��6,   $��79��6:   ���	#FF3A3A3A$��18(�6s   ���	#FFE4E4E4$��Segoe UI Light)�6�   $��507,230,0,10q�6�    � UseLayoutRounding .    ButtonStyleOne#���  6�   $��0q�6  ��6\   Z� .��5      � .+�5      �� -   5         ��Name$ helpFindLabel��5      $��Напред��6/   $��0,1,-1,0q�6@   #��[  6R    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6+      Color$ 	#FF3A3A3A��6:      	Direction$	 315Q�6L      ShadowDepth$	 1.5Q�6\   5      5      5      �� 5    
   -   5        $
��Left=�5       $
 Hand��6,   $��78��6:   ���	#FF3A3A3A$��18(�6s   ���	#FFE4E4E4$��Segoe UI Light)�6�   $��420,231,0,9q�6�    .  #���  6�   $��0q�6   �� IsCancel . ��6\   Z� .��5!      � .+�5"      �� -   5        $ helpFindLabel1��5"      $��
Отказ��60   $��0,0,0,1q�6@   #��[  6Q    5#        5$      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   5&      5'      5(      5*      5+      