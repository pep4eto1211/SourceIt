   M S B A M L   `   `   `  ����   SourceIt    SourceIt.projectStore   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     N� Title$  projectStore��$	��375��$	��729�� � 	Resources    InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel	 �� AncestorType
 �� Value��%�   &	        �� " ��.���  � ��
 �   � ��  �� *IsMouseOver+ �� $ 1��"	 ��
 True.a���  � ��
 �����.��� ���	#FFE4E4E4.+��� $
��Auto=���. .���� -    ��Name$ allPostsPanel��.+��� -    ��Name$ storeUploadButton��$��Center=� � Cursor$
 Hand��$��178.25�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)� � UseLayoutRounding .    ButtonStyleOne#���  $��0q�$	��Top=�$��0,20,0,0q�.��� .+��� $"��Качи в магазина��$��31,0,0,0q�$��Center=�$��Center=�#��[   J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� $
��Left=�$��33��$��Center=�$��33��$��Images/uploadStore.png��$��UniformToFill=�$��0,-2,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�� -    �Name$ storeDetailsGrid��$	��375��.+��� -    ��Name$ itemScreenshot��$
��Left=�$	��200��$	��Top=�$	��200��$��	5,5,0,-54q�$
 Hand���� -    ��Name$ itemNameLabel��$��	210,5,5,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��30��$��CharacterEllipsis=��� -   $ itemDescriptionLabel��$��210,39,5,105q�$
��Wrap=����	#FF3A3A3A$��16(�$��Segoe UI Light)�$��CharacterEllipsis=�$	��261���� -   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���   K� ZIndex$ -5��$��0q����	#FF0080FF$	��101�� � ToolTip$ Сваляне��$��0q�.��� $	��101��.+��� $��Images/downloadStore.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -	    ��Name$ helpFindLabel_Copy��$��Сваляне��#��[  $��16(�$��30,-4,-94,1q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -
   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���  $ -5��$��0q����	#FF0080FF$	��111��$, &Премахни от магазина��$��	0,0,101,0q�.��� $	��124��.+��� $��Images/newCloseIcon.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ helpFindLabel_Copy1��$��Премахни��#��[  $��16(�$��30,-4,-94,1q�$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ DividerMain_Copy1��$��2��$��
205,34,0,0q�$	��Top=�$
��None=�$ ��Images/DividerMainBlue.png���� -   $ DividerMain_Copy2��$��2��$��0,0,0,30q�$��Bottom=�$
��None=�$ ��Images/DividerMainBlue.png���� -   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���  $ -5��$��0q����	#FF0080FF$	��156��$M GПромени данните за елемента в магазина��$��
0,0,212,-1q�.��� .+��� $��Images/editIcon.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ helpFindLabel_Copy2��$��Промени инфо��#��[  $��16(�$��	30,-4,0,1q�$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ downloadsLabel��$
��Wrap=�$��Bottom=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��30��$��CharacterEllipsis=�$
��Left=�$��5,0,0,0q�� -   $ loader��
���   � J� Opacity$	 0.7Q�$	 100��.+��� -   $ loaderLable��$
��Wrap=����	#FFE4E4E4$��36(�$+��%Взимане на постове...��$��Segoe UI Light)�$��CharacterEllipsis=�$��Center=�$��Center=�$��0,116,0,207q�� $��Center=�$��29��$��Center=�$	��226�����	#FFE4E4E4���	#FFE4E4E4 � IsIndeterminate . ��Z� 