   M S B A M L   `   `   `  ����   SourceIt    SourceIt.store   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     N� Title$  store��$	��525��$	��729�� � 	Resources    InButtonLabel �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorLevel	 �� AncestorType
 �� Value��%�   &	        �� " ��.���  � ��
 �   � ��  �� *IsMouseOver+ �� $ 1��"	 ��
 True.a���  � ��
 �����.��� -   $��storeMainGrid�����	#FFE4E4E4 � Triggers :�  :� RoutedEvent$ Grid.Loaded��.[��� .���� .��W�  �� 
TargetName$ storeMainGrid�� �� TargetProperty$ Opacity� W� From$	 0.0X�	 W� To$	 1.0X� g� Duration$ 0:0:0.5D�.+��� $��40,1,0,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��36(�$��Магазин��$��Segoe UI Light)�$��CharacterEllipsis=�$
��Left=�$	��378���� -   $
��Left=�$	��Top=�$��25��$��18(�$��Segoe UI Light)�$��25�����	#FFE4E4E4 � Cursor$
 Hand��  ButtonStyleOne#���  $��	10,15,0,0q� K� ZIndex$ -5�� � ToolTip$ Go back to startup page����Z� .��� $��25��$��25��.+��� $��Images/backButton.png��$��25��$��25��$��UniformToFill=�$��0,-4,0,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Color$ 	#FF3A3A3A��   	Direction$	 315Q�   ShadowDepth$	 1.5Q��� -    ��Name$ DividerMain��$
��Left=�$��2��$��0,55,0,0q�$	��Top=�$	��729��$
��None=�$ ��Images/DividerMainBlue.png���� -    ��Name$ 	searchBox��$��Right=�$��31�� �� TextWrapping$
 Wrap=�$	��Top=�$	��272��$��20(����	#FF0080FF���	#FFA6A6A6$��1q�$��1,0,1,1q�$��	0,12,40,0q�$��Търсене����Z� �� -   $��Right=�$	��Top=�$��18(�$��Segoe UI Light)�$��33�����	#FFE4E4E4$
 Hand��#���  $��0,11,3,0q�$ -5��$��0q����	#FF0080FF$��33��.��� .+��� $
��Left=�$��33��$	��Top=�$��33��$��Images/Search.png��$��UniformToFill=�$��0,-2,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -    ��Name$ 	newestTab��$
��Left=�$
 Hand��$��182.25�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)�$��0,56,0,0q� � UseLayoutRounding .  #���  $��0q�$	��Top=�.��� $	��145��$��50��.+��� -    ��Name$ newestTabLabel��$��Най- нови��$��0q�$��Center=�$��Center=�#��[     $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -	   $ mostDownloadsTab��$
��Left=�$
 Hand��$��182.25�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)�$��182.25,56,0,0q� .  #���  $��0q�$	��Top=�.��� $	��145��$��50��.+��� -
   $ mostDownloadsTabLabel��$��Най- сваляни��$��0q�$��Center=�$��Center=�#��[     $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ allTab��$
��Left=�$
 Hand��$��182.25�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)�$��364.5,56,0,0q� .  #���  $��0q�$	��Top=�.��� $	��145��$��50��.+��� -   $ allTabLabel��$��Всички��$��0q�$��Center=�$��Center=�#��[     $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ mineTab��$��Right=�$
 Hand��$��182.25�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)�$��0,56,0,0q� .  #���  $��0q�$	��Top=�.��� $	��145��$��50��.+��� -   $ mineTabLabel��$��Мои��$��0q�$��Center=�$��Center=�#��[     $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ DividerMain_Copy��$
��Left=�$��2��$��	0,107,0,0q�$	��Top=�$	��729��$
��None=�$ ��Images/DividerMainBlue.png���� $��	0,108,0,0q���. $
��Auto=�.���� -     ��Name$  storeItemsPanel��.+��� -   $ 
emptyLabel��$>��8Няма елементи в тази категория��$��Center=�$	��Top=����	#FF3A3A3A$��36(�$��Segoe UI Light)�$��0,50,0,0q�� -   ! �Name$! searchResultsGrid��$	��Top=�$��5,20,5,0q�$��72��.+��� $1��+Резултати от търсенето:��$
��Left=�$	��Top=����	#FF3A3A3A$��24(�$��Segoe UI Light)�$��0q��� -   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���  $ -5��$��0q����	#FF0080FF$��83��$  ��.��� $	��124��.+��� $��Images/newCloseIcon.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ helpFindLabel_Copy2��$��
Отказ��#��[  $��16(�$��30,-4,-94,1q�$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ DividerMain_Copy3��$��2��$��Bottom=�$
��None=�$ ��Images/DividerMainBlue.png���� -   $ storeUploadButton��$
 Hand�����	#FF3A3A3A���	#FF0080FF$��18(����	#FFE4E4E4$��Segoe UI Light)� .  #���  $��0,0,0,1q�$	��Top=�$��5,20,5,0q�.��� .+��� $(��"Качване в магазина��$��42,0,0,0q�$��Center=�$��Center=�#��[  $��24(�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� $
��Left=�$��42��$��Center=�$��42��$��Images/uploadStore.png��$��UniformToFill=�$��0,-2,0,0q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q�� -   $! Loader��
���   �" J� Opacity$	" 0.7Q�$y�Visible=�.+��� -   # ��Name$# loadingMessage��$��0,191,0,268q�$
��Wrap=����	#FFE4E4E4$��36(�$.��(Зареждане на елементи��$��Segoe UI Light)�$��CharacterEllipsis=�$��Center=�$	��Top=�� $��Center=�$��29��$��	0,262,0,0q�$	��Top=�$	��226�����	#FFE4E4E4���	#FFE4E4E4$ � IsIndeterminate$ . ��Z� � -   $! itemInfoGrid��$��0,56,0,0q����	#FFE4E4E4$y�Hidden=�.+��� -   $ itemScreenshot��$
��Left=�$	��350��$	��Top=�$	��350��$��5,5,0,0q�$
 Hand���� -   $# itemNameLabel��$��	365,5,5,0q�$
��Wrap=�$	��Top=����	#FF3A3A3A$��22(�$��Segoe UI Light)�$��30��$��CharacterEllipsis=��� -   $# itemDescriptionLabel��$��365,39,5,169q�$
��Wrap=����	#FF3A3A3A$��16(�$��Segoe UI Light)�$��CharacterEllipsis=�$	��261���� -   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���  $ -5��$��0q����	#FF0080FF$	��101��$ Сваляне��.��� $	��124��.+��� $��Images/downloadStore.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $ helpFindLabel_Copy��$��Сваляне��#��[  $��16(�$��30,-4,-94,1q�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -   $��Right=�$��Bottom=�$��18(�$��Segoe UI Light)�$��30�����	#FFE4E4E4$
 Hand��#���  $ -5��$��0q����	#FF0080FF$��83��$ 
Отказ��$��	0,0,101,0q�.��� $	��124��.+��� $��Images/newCloseIcon.png��$��UniformToFill=�$��0,-2,0,0q�$��30��$��30��$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -    $ helpFindLabel_Copy1��$��
Отказ��#��[  $��16(�$��30,-4,-94,1q�$
��Left=�   $ 5Q�$ 	#FF3A3A3A��$	 315Q�$	 1.5Q��� -!   $ DividerMain_Copy1��$
��Left=�$��2��$��
355,34,0,0q�$	��Top=�$	��374��$
��None=�$ ��Images/DividerMainBlue.png���� -"   $ DividerMain_Copy2��$��2��$��0,0,0,30q�$��Bottom=�$
��None=�$ ��Images/DividerMainBlue.png��