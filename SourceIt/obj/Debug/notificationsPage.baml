   M S B A M L   `   `   `  ����  SourceIt     SourceIt.notificationsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          N� Title$  notificationsPage��5   0   $	��525��6J   $	��729��6X   .��5	      � -   5        $��notificationsMainGrid��5	   "   ���	#FFE4E4E4 � Triggers 5
   
   :� 5       :� RoutedEvent$ Grid.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ notificationsMainGrid��6*    �� TargetProperty$ Opacity�6X    W� From$	 0.0X�6|   	 W� To$	 1.0X�6�    g� Duration$ 0:0:0.5D�6�   5      5      5      .+�5   
   �� $��40,1,0,0q�6   $
��Wrap=�6&   $	��Top=�6:   ���	#FF3A3A3A$��36(�6i   $$��Всички известия:��6w   $��Segoe UI Light)�6�   $��CharacterEllipsis=�6�   $
��Left=�6�   $	��378��6�   �� 5   
   -   5        $
��Left=�5      $	��Top=�6,   $��25��6D   $��18(�6O   $��Segoe UI Light)�6]   $��25��6�   ���	#FFE4E4E4 � Cursor$
 Hand��6�      ButtonStyleOne#���   6�   $��	10,15,0,0q�6�   	 K� ZIndex$	 -5��6�   
 � ToolTip$
 Go back to startup page��6  ��6y   Z� .��5      � $��25��6   $��25��6   .+�5      �� $��Images/backButton.png��6   $��25��67   $��25��6B   $��UniformToFill=�6N   $��0,-4,0,0q�6f    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6+      Color$ 	#FF3A3A3A��6:      	Direction$	 315Q�6L      ShadowDepth$	 1.5Q�6\   5      5      5      �� 5   
   $��0,50,0,0q�6   ��. $
��Auto=�6A   .��5      �� -   5         ��Name$ notificationsPanel��5      5       � 5!   
   -   5         �Name$ loader��5!      
���   � J� Opacity$	 0.7Q�62   $		 100��6@   .+�5"      �� -   5         ��Name$ loaderLable��5"      $
��Wrap=�6-   ���	#FFE4E4E4$��36(�6X   $��Fetching notifications...��6f   $��Segoe UI Light)�6�   $��CharacterEllipsis=�6�   $��Center=�6�   $��Center=�6�   $��0,116,0,207q�6�   � 5#      $��Center=�6   $��29��67   $��Center=�6C   $	��226��6^   ���	#FFE4E4E4���	#FFE4E4E4 � IsIndeterminate . ��6j   Z� 6�   5$      5&      5'      