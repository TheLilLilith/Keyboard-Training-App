   M S B A M L   `   `   `  ����N  JKeyboardTrainingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:KeyboardTrainingAppKeyboardTrainingApp  5      "    KeyboardTrainingApp.MainMenu   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:KeyboardTrainingApp     5        N� Title$  MainMenu��5	       � 	Resources 5
         HoverAnimation �� 
TargetName �� TargetProperty t� From	 t� To g� Duration  HoverButtonStyle �� 
TargetType �� Property	 �� Value
 �� 
TargetType ��Name �� Triggers :� RoutedEvent��%�  &	        &	 �     7   �� 5   
   .��5      t� $ myBorder��6!   $ Margin�6B   $ 0,0,0,0X�5      $ 10,10,-12,-12X�6,   $ 0:0:0.2D�6?   5      �� 5   
   " ��6)   .�5      ��  � ��
	 �����6,   �� 5       � ��$	 0q�60   �� 5       � ��
	 ���� 6+   �� 5       � ��$	 0,0,30,0q�6'   �� 5       � ��	 5      �� 5      "
 ��6&   .R�5      � .+�5      �� $ myBorder��6%   ���#306585$��0,0,0,0q�6L   �� 5      $��Center=�6/   $��Center=�6J   5       5      :� 5      $ Button.MouseEnter��6+   .[�5    "   �� 8��  62   5!      :� 5"      $ Button.MouseLeave��6+   .[�5#   "   �� .��5$   &   �� .��5%   *   t� $ myBorder��6=   $ Margin�6^   $ 10,10,-12,-12X�5&   9   $ 0,0,0,0X�6N   $ 0:0:0.2D�6[   5'   '   5(   #   5)      5+      5-      5.      5/      .��50      � .+�51   
   � -   5        $��	wrapPanel��51      $��Center=�6%   $��Center=�6B   .+�52      �� -   5        $��LearningModeButton��52      $	��350��6Q   #��[ 6]   ��53      � 54      .+�55      �� $��bin/typing.png��6    $��UniformToFill=�68   $	��350��6P   $	��250��6\   $
��Left=�6i   �� 56      
�������$	��250��64   $��Right=�6@    �� CornerRadius$ 	10,0,0,10��6\   $��Bottom=�6u   $��0,0,0,15q�6�   ._�57      �� $!��Режим Обучения��6$   $
��Bold"�6=   $��25(�6O   $��	Open Sans)�6]   $��Center=�6t   $��0,0,0,0q�6�   6�   58      59      5;      �� 5=      -   5        $��TrainingModeButton��5=      $	��350��6P   #��[ 6\   ��5>      � 5?      .+�5@      �� $��bin/training.png��6    $��UniformToFill=�6:   $	��350��6R   $	��250��6^   $
��Left=�6k   �� 5A      
�������$	��280��64   $��Right=�6@   $ 	10,0,0,10��6\   $��Bottom=�6u   $��0,0,0,15q�6�   ._�5B      �� $%��Режим Тренировки��6$   $
��Bold"�6?   $��25(�6Q   $��	Open Sans)�6_   $��Center=�6v   $��0,0,0,0q�6�   6�   5C      5D      5F      5I      5K      5L      