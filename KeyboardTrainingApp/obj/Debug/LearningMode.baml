   M S B A M L   `   `   `  ����N  JKeyboardTrainingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:KeyboardTrainingAppKeyboardTrainingApp  5      &     KeyboardTrainingApp.LearningMode   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:KeyboardTrainingApp     5        N� Title$  LearningMode��5	       � 	Resources 5
         HoverAnimation �� 
TargetName �� TargetProperty t� From	 t� To g� Duration  HoverButtonStyle �� 
TargetType �� Property	 �� Value
 �� 
TargetType ��Name �� Triggers :� RoutedEvent��%�  &	        &	 �     7   �� 5   
   .��5      t� $ myBorder��6!   $ Margin�6B   $ 0,0,0,0X�5      $ 10,10,-12,-12X�6,   $ 0:0:0.2D�6?   5      �� 5   
   " ��6)   .�5      ��  � ��
	 �����6,   �� 5       � ��$	 0q�60   �� 5       � ��
	 ���� 6+   �� 5       � ��$	 0,0,30,0q�6'   �� 5       � ��	 5      �� 5      "
 ��6&   .R�5      � .+�5      �� $ myBorder��6%   ���#306585$��0,0,0,0q�6L   �� 5      $��Center=�6/   $��Center=�6J   5       5      :� 5      $ Button.MouseEnter��6+   .[�5   "   �� 8��  62   5      :� 5       $ Button.MouseLeave��6+   .[�5!   "   �� .��5"   &   �� .��5#   *   t� $ myBorder��6=   $ Margin�6^   $ 10,10,-12,-12X�5$   9   $ 0,0,0,0X�6N   $ 0:0:0.2D�6[   5%   '   5&   #   5'      5)      5+      5,      5-      .��5.      � -   5        $��LearningModeGrid��5.      .+�5/   
   �� -   5        $��SelectionMode��5/      $y�Visible=�6*   .+�50      � $��Center=�6   $��Bottom=�65   $��0,20,0,0q�6P   .+�51      �� -   5        $��
BackToMenu��51      $��Center=�6E   $��0,0,30,0q�6b   $	��Top=�6u   #��[ 6�   $��60��6�   $��60��6�   .��52      �� 
�������$��60��60   $��60��6;   ._�53      �� $��bin/back.png��6    $��10,10q�66   54      55      �� 56      -   5        $��TypingSelectButton��56      $	��350��6T   #��[ 6`   ��57      � 58      .+�59      �� $��bin/typing.png��6    $��UniformToFill=�68   $	��350��6P   $	��250��6\   $
��Left=�6i   �� 5:      
�������$	��250��64   $��Right=�6@    �� CornerRadius$ 	10,0,0,10��6\   $��Bottom=�6u   $��0,0,0,15q�6�   ._�5;      �� $��Набор текста��6$   $
��Bold"�6;   $��25(�6M   $��	Open Sans)�6[   $��Center=�6r   $��0,0,0,0q�6�   6�   5<      5=      5?      �� 5@      -   5        $��LetterSelectButton��5@      $	��350��6T   #��[ 6`   ��5A      � 5B      .+�5C      �� $��bin/keyboardletters.png��6$   $��UniformToFill=�6E   $	��350��6]   $	��250��6i   $
��Left=�6v   �� 5D      
�������$	��300��68   $��Right=�6D   $ 	10,0,0,10��6`   $��Bottom=�6y   $��0,0,0,15q�6�   ._�5E   "   �� $+��%Расположение клавиш��6(   $
��Bold"�6F   $��25(�6X   $��	Open Sans)�6f   $��Center=�6}   $��0,0,0,0q�6�   6�   5F      5G      5I      5J      5K      �� 5M   
   -   5        $��
LetterMode��5M      $y�	Collapsed=�6'   .+�5N      � -   5        $��	StatusBar��5N      ���#306585$	��Top=�6@    � Value$ 0Q�6X   6e   � 5O      $��Center=�6   $��	100,0,0,0q�65   .+�5P      �� $	��100��6   $	��100��6%   
�������$��0,80,0,0q�6E   $	 100��6W   ._�5Q      �� $��90��6   
�������$��90��6?   $	 100��6K   ._�5R      �� -   5         ��Name$ 	TypeLabel��5R       
���   �$�� ��6F   $��Center=�6Q   $��Microsoft YaHei UI Light)�6n   $��Center=�6�   $��40(�6�   5S      5T      �� 5U      $��Center=�6   $��Center=�6:   $��20,0,0,0q�6U   .+�5V      	� -	   5        $��EnglishCheck��5V   "    d� 	IsChecked$
 TrueY�66   $��Microsoft YaHei UI Light)�6f   $��20(�6�   .��5W      �� 
�������$	��150��64   $��30��6@   $ 	0,10,10,0��6L   ._�5X      �� $%��Английские буквы��6%   $��Microsoft YaHei UI Light)�6@   $��15(�6f   5Y      5Z      	� 5[      -
   5        $��RussianCheck��5[   "   $��10,5,0,0q�6U   .��5\      �� 
�������$	��150��64   $��30��6@   $ 	0,10,10,0��6L   ._�5]      �� $��Русские буквы��6%   $��Microsoft YaHei UI Light)�6=   $��15(�6c   5^      5_      5`      5a      � 5c      $��Center=�6   $��Bottom=�65   $��0,0,0,0q�6P   .+�5d      �� -   5        $��CounterSlider��5d       � Minimum$ 30Q�6X    � Maximum$	 200Q�6e   $
��Left=�6s   $��	0,0,10,15q�6�   $��Bottom=�6�   $	��187��6�   �� 5e      -   5        $��CounterLabel��5e      $��50��6,   $��30��68   $��Center=�6E   $��Bottom=�6b   $��Microsoft YaHei UI Light)�6~   $��30(�6�   6�   �� 5f      $��50��6   $��символов��6%   $��Center=�68   $��Bottom=�6U   $��Microsoft YaHei UI Light)�6q   $��30(�6�   6�   5g      � 5h      $��Center=�6   .+�5k      �� -   5        $��BackButton2��5k      $��Center=�6C   $��0,10,0,0q�6`   $��Bottom=�6s   #��[ 6�   $	��200��6�   $��60��6�   .��5l      �� 
�������$	��200��6,   $��60��68   ._�5m      �� $��
Назад��6   $��Center=�6,   $��Center=�6I   $��Microsoft YaHei UI Light)�6d   $��30(�6�   5n      5o      �� 5p      -   5        $��StartLetterButton��5p      $��Center=�6O   $��	20,10,0,0q�6l   $��Bottom=�6�   #��[ 6�   $	��400��6�   $��60��6�   .��5q      �� 
�������$	��400��6,   $��60��68   ._�5r      �� $��Начать��6   $��Center=�6-   $��Center=�6J   $��Microsoft YaHei UI Light)�6e   $��30(�6�   5s      5t      5u      5v      �� 5x   
   -   5        $��
TypingMode��5x      $y�	Collapsed=�6'   .+�5z      � -   5        $��	TypingBar��5z      ���#306585$	��Top=�6@   $ 0Q�6X   6e   � 5{      $��Center=�6   $��Bottom=�65   $��	0,120,0,0q�6P   .+�5|      	� -   5        $��RussianText��5|      $��10,5,0,0q�61   .��5}      �� 
�������$	��150��6,   $��30��68   $ 	0,20,0,20��6D   ._�5~      �� $��Русский текст��6   $��Microsoft YaHei UI Light)�65   $��15(�6[   5      5�      	� 5�      -   5        $��EnglishText��5�      $
 TrueY�6-   $��10,5,0,0q�6?   .��5�      �� 
�������$	��150��6,   $��30��68   $ 	0,20,0,20��6D   ._�5�      �� $%��Английский текст��6   $��Microsoft YaHei UI Light)�68   $��15(�6^   5�      5�      5�      �� 5�      $��Bottom=�6   
�������$ 30��6C   $��Center=�6U   $��0,20,0,0q�6r   $	��500��6�   $��50��6�   ._�5�      �� -   5        $��TypeTextBox��5�       �� TextAlignment$ Center=�6-   $	��430��6F   $��Center=�6R   $��Center=�6m   $��0q�6�   {�.  $��Microsoft YaHei UI Light)�6�   $��30(�6�   6�   5�      � 5�      $��Center=�6   .+�5�      �� -   5        $��
BackButton��5�      $��Center=�6E   $��0,10,0,0q�6b   $��Bottom=�6u   #��[ 6�   $	��200��6�   $��60��6�   .��5�      �� 
�������$	��200��60   $��60��6<   ._�5�      �� $��
Назад��6    $��Center=�60   $��Center=�6M   $��Microsoft YaHei UI Light)�6h   $��30(�6�   5�      5�      �� 5�      -   5        $��StartTypeButton��5�      $��Center=�6O   $��20,0,0,0q�6l   $��Bottom=�6   #��[ 6�   $	��300��6�   $��60��6�   .��5�      �� 
�������$	��300��60   $��60��6<   ._�5�      �� $��Начать��6    $��Center=�61   $��Center=�6N   $��Microsoft YaHei UI Light)�6i   $��30(�6�   5�      5�      5�      5�      5�      5�      