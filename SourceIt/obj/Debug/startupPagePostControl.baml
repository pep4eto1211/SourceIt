   M S B A M L   `   `   `  ����  SourceIt%    SourceIt.startupPagePostControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        ���	#FF0080FF$��1q�5   O   $��
20,10,20,0q�6c   $	��140��6w     � 	Resources  5         InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType	 �� Value��%�   &	        �� 5	   
   " ��6&   .�5
      ��  � ��
 �   �6+    5      �� 5       6   �� *IsMouseOver+ �� $ 1��" ��	 True6�   .a�5      ��  � ��
 �����63   5      5      5      
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      
BlurRadius$ 5Q�6      Color$ 	#FF3A3A3A��6*      	Direction$	 315Q�6<      ShadowDepth$	 1.5Q�6L   .��5      � ���	#FFE4E4E4 � ColumnDefinitions 5   
   �� 5      $��75 �6   �� 5      .+�5   
   �� -   5         ��Name$ postTextBox��5      $��1��6'   $��10,30q�67    �� TextWrapping$
 Wrap=�6F   $��	Post Text��6Z    �� 
IsReadOnly .  � Cursor$ Arrow��6�   ���	#FF0080FF���	#FF3A3A3A" �� VerticalScrollBarVisibility$
 Auto=�6�   ��. $��1q�6    PostTextBoxStyle#���  6-  $��18(�6X  ��6k   Z� 6X  �� 5   
   $��1��6   $
��Left=�6    $��10��6;   $��0,64,0,0q�6G   $	��Top=�6Y   $��10��6q   $��Images/smallArrow.png��6|   � 5   
   $
��Left=�6   $��75��6*   $	��Top=�66   $��75��6N    J� OpacityMask
 �   ����	#FF303030$��2��6�   .+�5      �� -   5         ��Name$ userAvatarLabel��5      $
��Wrap=�61   ���	#FFE4E4E4$��36(�6\   $��Segoe UI Semibold)�6j   $��CharacterEllipsis=�6�   $��Center=�6�   $��Center=�6�    K� ZIndex$ 9��6�   $��0q�6�   5"      5#      �� 5$   
   $
��Left=�6   $��1��62   ���	#FF0080FF$��1��6S   $��2��6c   �� 5%   
   -   5        $ postUsername��5%      $
��Wrap=�6*   $��Bottom=�6>   ���	#FF3A3A3A$��16(�6p   $��Segoe UI Light)�6~   $��CharacterEllipsis=�6�    � ToolTip$ azsamsan4oidaotgorica��6�   $��20��6�   $��
0,0,222,15q�6�   $��2��6�   $��76��6  $
��Left=�6  $��76��68  �� 5&   
   -   5        $ postProject��5&      $
��Wrap=�6)   ���	#FF3A3A3A$��16(�6T   $��Segoe UI Light)�6b   $��CharacterEllipsis=�6~   $��20��6�   $��	10,5,40,0q�6�   $��1��6�   $	��Top=�6�   �� 5'   
   $
��Wrap=�6   $��Bottom=�6(   ���	#FF3A3A3A$��16(�6Z   $��Segoe UI Light)�6h   $��CharacterEllipsis=�6�   $��20��6�   $��10,0,222,35q�6�   $��2��6�   $��	Юзър:��6�   �� 5(   
   -   5         ��Name$ openProjectButton��5(      $��Right=�6,   $
 Hand��6H   $	��142��6V   ���	#FF3A3A3A���	#FF0080FF$��18(�6�   ���	#FFE4E4E4$��Segoe UI Light)�6�   $��0,0,1,0q�6�    � UseLayoutRounding .    ButtonStyleOne#���  6�   $��1,0,0,0q�6&  $��1��6@  $��Bottom=�6P  $��30��6k  .��5)      � .+�5*      �� -   5         ��Name$ helpFindLabel��5*      $!��Отвори проекта��6/   #��[  6H   $��16(�6o   $��0,-4,0,0q�6}   
 5+        5,      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   5.      5/      50      �� 51   
   -   5        $ deletePostButton��51      $��Right=�6+   $
 Hand��6G   $��20��6U   ���	#FF3A3A3A���	#FF303030$��18(�6�   ���	#FFE4E4E4$��Segoe UI Light)�6�   $��0,5,10,0q�6�    .  #���  6�   $��0q�6%  $��1��69  $	��Top=�6I  $��20��6a  $ Delete post��6m  $y�Hidden=�6�  .��52      � .+�53      �� $��30��6   $��30��6#   $��Images/closeIconSmall.png��6/   $��UniformToFill=�6R   $��	-6,-5,0,0q�6j   
 54        55      $ 5Q�6+   $ 	#FF3A3A3A��6:   $	 315Q�6L   $	 1.5Q�6\   57      58      59      5:      5;      