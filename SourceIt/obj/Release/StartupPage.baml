   M S B A M L   `   `   `  ����   SourceIt    SourceIt.StartupPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     N� Title$  StartupPage��$	��729��$	��525��.��� -   $��startupPageMainGrid�����	#FFE4E4E4 � Triggers :�  :� RoutedEvent$ Grid.Loaded��.[��� .���� .��W�  �� 
TargetName$ startupPageMainGrid�� �� TargetProperty$ Opacity� W� From$	 0.0X�	 W� To$	 1.0X� g� Duration$ 0:0:0.5D� � ColumnDefinitions �� $	��70* ��� $
��655* �.+��� -   	 ��Name$	 notificationsDivider��$
��Left=�$	��525��$	��Top=�$��5��$
��None=�$#��Images/dividerRotatedBlue.png��$��1���� -   $
��Left=�$��	0,0,0,149q�$��Center=�$��70��$��74��   ButtonStyleOne#���   $	��0,1q����	#FFE4E4E4
 � Cursor$

 Hand�����	#FF0080FF � ToolTip$ Help Finder��$��2��.��� $��70��$��70��.+��� $
��Left=�$��70��$	��Top=�$��70��$
��Fill=�$��Images/fixerIcon.png��$��0,-1,0,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� -   $
��Left=�$��0,225,0,226q�$��Center=�$��70��$��74��#���   $��0,0,0,1q����	#FFE4E4E4$

 Hand�����	#FF0080FF$ Jobs manager��.��� $��70��$��70��.+��� $
��Left=�$��70��$	��Top=�$��70��$
��Fill=�$��Images/jobs.png��$��0,1,0,-1q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $
��Left=�$��0,299,0,156q�$��Center=�$��70��$��70��#���   $��0,0,0,1q����	#FFE4E4E4$

 Hand�����	#FF0080FF$ Store��.��� $��70��$��70��.+��� $
��Left=�$��70��$	��Top=�$��70��$
��Fill=�$��Images/storeIcon.png��$��0,1,0,-1q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $��1��$
��Auto=���. .���� -    ��Name$ 
postsPanel��$��1��� -    �Name$ loader��
���   � J� Opacity$	 0.7Q� K� ZIndex$	 100��$��2��.+��� -	    ��Name$ loaderLable��$
��Wrap=����	#FFE4E4E4$��36(�$+��%Вземане на постове...��$��Segoe UI Light)�$��CharacterEllipsis=�$��Center=�$��Center=�$��0,116,0,207q�� $��Center=�$��29��$��Center=�$	��226�����	#FFE4E4E4���	#FFE4E4E4 � IsIndeterminate . ��Z� 