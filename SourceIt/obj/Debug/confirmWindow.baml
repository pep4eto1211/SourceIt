   M S B A M L   `   `   `  ����  SourceIt    SourceIt.confirmWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  confirmWindow��5   	   $��317.712��6   $��539.114��60    � WindowStartupLocation$ CenterScreen=�6@    � WindowStyle$
 None=�6e   ���	#FF0080FF$��1q�6�    � Icon$ Images/NewLogo.png��6�    � 
ResizeMode$ NoResize=�6�    � Topmost .  � 	Resources 5         InButtonLabel �� 
TargetType �� Property	 �� Value
 �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType �� Value��%�   &	        �� 5   
   " ��6&   .�5      ��  � ��
	 �   �6+   
 5      �� 5	       6   �� *IsMouseOver+ �� $ 1��" �� True6�   .a�5
      ��  � ��
	 �����63   5      5      5      .��5      � ���	#FFE4E4E4 � RowDefinitions 5   
   �� 5      �� 5      $��48 �6   .+�5   
   �� -   5         ��Name$ confirmationText��5      $
��Wrap=�6.   $	��Top=�6B   ���	#FF3A3A3A$��48(�6q   $
��Text��6   $��Segoe UI Light)�6�   $��Center=�6�   $	��517��6�   �� 5   
   -   5         � Cursor$
 Hand��5      ���	#FF3A3A3A���	#FF0080FF$��18(�6N   ���	#FFE4E4E4$��Segoe UI Light)�6s   $��0,0,81,0q�6�    � UseLayoutRounding .    ButtonStyleOne#���  6�   $	��1,0q�6�   $��Right=�6�   $��Bottom=�6   J� RenderTransformOrigin$ 	0.5,0.514&�61   �� 	IsDefault . $��48��6y  $��81��6�  $��1��6�  .��5      � .+�5      �� -   5         ��Name$ helpFindLabel1��5      $
��Да��60   #��[  6=   $��24(�6d   $��0,0,0,-2q�6r    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6+      Color$ 	#FF3A3A3A��6:      	Direction$	 315Q�6L      ShadowDepth$	 1.5Q�6\   5      5      5      �� 5   
   -   5        $
 Hand��5      ���	#FF3A3A3A���	#FF0080FF$��18(�6N   ���	#FFE4E4E4$��Segoe UI Light)�6s    .  #���  6�   $��0q�6�   $��Right=�6�   $��Bottom=�6  $ 	0.5,0.514&�6  $��48��6V  $��81��6b   �� IsCancel . $��1��6}  .��5       � .+�5!      �� -   5        $ helpFindLabel2��5!      $
��Не��60   #��[  6=   $��24(�6d   $��0,0,0,-2q�6r    5"        5#      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   5%      5&      5'      �� 5(   
   -   5         ��Name$ DividerMain_Copy��5(      $
��Left=�6*   $��2��6E   $	��Top=�6P   $	��537��6h   $
��None=�6t   $ ��Images/DividerMainBlue.png��6�   $��1��6�   5*      5+      