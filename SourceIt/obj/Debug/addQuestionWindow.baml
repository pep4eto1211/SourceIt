   M S B A M L   `   `   `  ����  SourceIt     SourceIt.addQuestionWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  addQuestionWindow��5   	   $	��334��6#   $	��435��60    � WindowStartupLocation$ CenterScreen=�6=    � WindowStyle$
 None=�6b   ���	#FF0080FF$��1q�6�    � Icon$ Images/NewLogo.png��6�    � 
ResizeMode$ NoResize=�6�    � ShowInTaskbar .   � 	Resources 5         InButtonLabel �� 
TargetType �� Property	 �� Value
 �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� 5   
   " ��6&   .�5      ��  � ��
	 �   �6+   
 5      �� 5	       6   �� *IsMouseOver+ �� $ 1��" �� True6�   .a�5
      ��  � ��
	 �����63   5      5      5      .��5      � ���	#FFE4E4E4.+�5   
   �� $��
10,10,10,0q�6   $
��Wrap=�6(   $	��Top=�6<   $��65��6T   ���	#FF3A3A3A$��48(�6w   $!��+ Добави въпрос��6�   $��Segoe UI Light)�6�   �� 5   
   $��10,95,322,0q�6   $
��Wrap=�6)   $	��Top=�6=   $��31��6U   ���	#FF3A3A3A$��22(�6x   $��Segoe UI Light)�6�   $��Текст:��6�   �� 5   
   -   5         ��Name$ newQuestionContentBox��5      $	��165��61    �� TextWrapping$ WrapWithOverflow=�6>   $	��Top=�6^   $��20(�6v   ���	#FF0080FF���	#FF3A3A3A$��1q�6�   $��1,0,1,1q�6�    �� AcceptsReturn . ��. $��10,130,10,0q�6)  ��6�   Z� 6)  �� 5   
   -   5        $��Right=�5       � Cursor$
 Hand��6-   $��74.348��6;   ���	#FF3A3A3A$��18(�6x   ���	#FFE4E4E4$��Segoe UI Light)�6�    � UseLayoutRounding .    ButtonStyleOne#���  6�   $��0q�6�   $��Bottom=�6%  ��6a   Z� .��5      � .+�5      �� -   5         ��Name$ helpFindLabel1��5      $��Добави��60   #��[  6A   $��20(�6h   $��-9,-2,-10,0q�6v    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6+      Color$ 	#FF3A3A3A��6:      	Direction$	 315Q�6L      ShadowDepth$	 1.5Q�6\   5      5      5      �� 5   
   -   5        $��Right=�5      $
 Hand��6-   $��65.348��6;   ���	#FF3A3A3A$��18(�6x   ���	#FFE4E4E4$��Segoe UI Light)�6�    .  #���  6�   $��0q�6�   $��Bottom=�6'  $��0,0,74.348,0q�6B  ��6a   Z� .��5      � .+�5      �� -   5        $ helpFindLabel2��5      $��
Отказ��60   #��[  6@   $��20(�6g   $��-9,-2,-10,0q�6u    5         5!      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   5#      5$      5%      5'      5(      