   M S B A M L   `   `   `  ����  SourceIt    SourceIt.screenshotViewer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  screenshotViewer��5   	   $	��509��6"   $	��800��6/    � WindowStartupLocation$ CenterScreen=�6<    � WindowStyle$
 None=�6a   ���	#FF0080FF$��1q�6�    � Icon$ Images/NewLogo.png��6�    � 
ResizeMode$ NoResize=�6�    � Topmost .  � ShowInTaskbar .  .��5      � ���	#FFE4E4E4.+�5   
   �� -   5         ��Name$ 
titleLabel��5      $��Снимка от:��6$   $
��Left=�69   $��	40,-3,0,0q�6T   $	��Top=�6g   ���	#FF3A3A3A$��18(�6�   $��Segoe UI Light)�6�   �� 5   
   -   5        $�� ��5      $��Right=�6   $��0,3,0,0q�68   $	��Top=�6I   $��25��6a   $��25��6l    � ToolTip$' !Затвори прозореца��6x   
�������$��18(�6�      TitleBarButton#���   6�   $��1q�6
  ��6�   Z� ��5      �� 5	      	 �� ImageSource$	 Images/newCloseIcon.png��6   5      �� 5   
   -   5        
 ��Name$
 DividerMain_Copy1��5      $��2��6+   $��0,32,0,0q�66   $	��Top=�6H   $
��None=�6`   $ ��Images/DividerMainBlue.png��6o   �� 5   
   $
��Left=�6   $��33��6+   $	��Top=�67   $��33��6O   $��Images/image.png��6Z   $��UniformToFill=�6t   $��6,0,0,0q�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6#      Color$ 	#FF3A3A3A��62      	Direction$	 315Q�6D      ShadowDepth$	 1.5Q�6T   5      �� 5   
   -   5        $
 currentScreenshotImage��5      $��0,33,0,0q�60   5      5      