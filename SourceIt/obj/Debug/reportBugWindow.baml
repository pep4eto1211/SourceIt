   M S B A M L   `   `   `  ����  SourceIt    SourceIt.reportBugWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  reportBugWindow��5   	   $	��366��6!   $	��435��6.    � WindowStartupLocation$ CenterScreen=�6;    � WindowStyle$
 None=�6`   ���	#FF0080FF$��1q�6�    � Icon$ Images/NewLogo.png��6�    � 
ResizeMode$ NoResize=�6�    � ShowInTaskbar .   � 	Resources 5         InButtonLabel �� 
TargetType �� Property	 �� Value
 �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� 5   
   " ��6&   .�5      ��  � ��
	 �   �6+   
 5      �� 5	       6   �� *IsMouseOver+ �� $ 1��" �� True6�   .a�5
      ��  � ��
	 �����63   5      5      5      .��5      � ���	#FFE4E4E4.+�5   
   �� $��
58,10,10,0q�6   $
��Wrap=�6(   $	��Top=�6<   $��65��6T   ���	#FF3A3A3A$��48(�6w   $��Докладвай��6�   $��Segoe UI Light)�6�   �� 5   
   $��Images/bug.png��6   $��UniformToFill=�6(   $��	10,27,0,0q�6@   $��40��6S   $��40��6^   $
��Left=�6j    K� ZIndex$ -5��6�   $	��Top=�6�   �� 5   
   $��10,100,314,0q�6   $
��Wrap=�6*   $	��Top=�6>   $��31��6V   ���	#FF3A3A3A$��22(�6y   $��Segoe UI Light)�6�   $��Описание:��6�   �� 5   
   -   5         ��Name$ errorDescription��5      $
��Left=�6,   $	��214��6G   $��124,100,0,0q�6T    �� TextWrapping$ WrapWithOverflow=�6i   $	��Top=�6�   $	��272��6�   $��20(�6�   ���	#FF0080FF���	#FF3A3A3A$��1q�6   $��1,0,1,1q�6   �� AcceptsReturn . ��. ��6�   Z� 6;  �� 5   
   -   5        $��Right=�5       � Cursor$
 Hand��6-   $��88.348��6;   ���	#FF3A3A3A$��18(�6x   ���	#FFE4E4E4$��Segoe UI Light)�6�    � UseLayoutRounding .    ButtonStyleOne#���  6�   $��0q�6�   $��Bottom=�6'  ��6a   Z� .��5      � .+�5      �� -   5         ��Name$ helpFindLabel1��5      $��Изпрати��60   #��[  6B   $��20(�6i   $��-9,-2,-10,0q�6w    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6+      Color$ 	#FF3A3A3A��6:      	Direction$	 315Q�6L      ShadowDepth$	 1.5Q�6\   5      5      5      �� 5   
   -   5        $��Right=�5      $
 Hand��6-   $��74.348��6;   ���	#FF3A3A3A$��18(�6x   ���	#FFE4E4E4$��Segoe UI Light)�6�    .  #���  6�   $��0q�6�   $��Bottom=�6%  $��0,0,88.348,0q�6@  ��6a   Z� .��5      � .+�5       �� -   5        $ helpFindLabel2��5       $��
Отказ��60   #��[  6@   $��20(�6g   $��-9,-2,-10,0q�6u    5!        5"      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   5$      5%      5&      � 5'   
   -   5         �Name$ loader��5'       J� Opacity$	 0.7Q�6   
���   �$y�Hidden=�6@   5)      5*      