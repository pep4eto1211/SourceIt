   M S B A M L   `   `   `  ����  SourceIt    SourceIt.theQuestion   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        ���	#FF0080FF$��1q�5   O   $��
20,10,20,0q�6c   $	��121��6�     � 	Resources  5         InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel �� AncestorType	 �� Value��%�   &	        �� 5   
   " ��6&   .�5	      ��  � ��
 �   �6+    5
      �� 5       6   �� *IsMouseOver+ �� $ 1��" ��	 True6�   .a�5      ��  � ��
 �����63   5      5      5      .��5      � ���	#FFE4E4E4.+�5   
   �� -   5        
 ��Name$
 questionContent��5      $��100,10,10,30q�6+    �� TextWrapping$
 Wrap=�6A   $��Question content��6U    �� 
IsReadOnly .  � Cursor$ Arrow��6�   ���	#FF0080FF���	#FF3A3A3A" �� VerticalScrollBarVisibility$
 Auto=�6�   $��1q�6�     PostTextBoxStyle#���  6
  $��18(�65  $��79��6C  ��. $��79��6t  ��6m   Z� 6t  �� 5   
   -   5         ��Name$ openProjectButton��5      $��Right=�6,   $
 Hand��6H   $	��142��6V   ���	#FF3A3A3A���	#FF0080FF$��18(�6�   ���	#FFE4E4E4$��Segoe UI Light)�6�   $��0q�6�    � UseLayoutRounding .    ButtonStyleOne#���  6�   $��1,0,0,0q�6   $��Bottom=�6:  $��30��6U  .��5      � .+�5      �� -   5         ��Name$ helpFindLabel��5      $!��Отвори въпроса��6/   #��[  6H   $��16(�6o   $��0,-4,0,0q�6}    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6+      Color$ 	#FF3A3A3A��6:      	Direction$	 315Q�6L      ShadowDepth$	 1.5Q�6\   5      5      5      � 5   
   $
��Left=�6   $��90��6*   $	��Top=�66   $��90��6N    J� OpacityMask
 �   ����	#FF303030.+�5      �� -   5         ��Name$ userAvatarLabel��5      $
��Wrap=�61   ���	#FFE4E4E4$��36(�6\   $��Segoe UI Semibold)�6j   $��CharacterEllipsis=�6�   $��Center=�6�   $��Center=�6�    K� ZIndex$ 9��6�   $��0q�6�   5"      5#      �� 5$   
   $
��Left=�6   $��10��6+   $��	90,50,0,0q�67   $	��Top=�6J   $��10��6b   $��Images/smallArrowBlue.png��6m   �� 5%   
   -   5        $ postUsername��5%      $
��Wrap=�6*   $��Bottom=�6>   ���	#FF3A3A3A$��16(�6p   $��Segoe UI Light)�6~   $��CharacterEllipsis=�6�    � ToolTip$  ��6�   $��20��6�   $
��Left=�6�   $��0,0,0,4q�6�   5'      5(      