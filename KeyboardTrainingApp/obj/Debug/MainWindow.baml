   M S B A M L   `   `   `  ����N  JKeyboardTrainingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:KeyboardTrainingAppKeyboardTrainingApp  5   	   $    KeyboardTrainingApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:KeyboardTrainingApp     5   	   -   5          � Title$/  )Клавиатурный тренажер��5	   	   $	��700��6'   $
��1280��64   
������  � WindowStyle$
 None=�6Z    � 
ResizeMode$ NoResize=�6�    � WindowStartupLocation$ CenterScreen=�6�   .��5      � -   5        $��MainMenuGrid��5      
������ .+�5   
   r� -   5         r� Source$ bin/backgroundv.mp4?�5       r� Stretch$
 Fill=�64    r� LoadedBehavior$ Manual=�6D   6�   �� 5   
   
������� �� CornerRadius$ 20��6(   $��0,0,0,20q�6:   
�������$��2q�6_   $��Center=�6s   $��Bottom=�6�   $	��800��6�   $	��300��6�   ._�5      )   #KeyboardTrainingApp.KeyboardControl  -   5          Name$ keyboardControl��5   L   )   #KeyboardTrainingApp.KeyboardControl	   Loaded$	 Window_Loaded��6e   
���   �$��1q�68   $��Center=�6|   $��27,30,27,14q�6�   6�   5      �� 5   
   $	��Top=�6   $��60��6)   
�������._�5      � $��Right=�6   $��20q�66   .+�5      �� -   5        $��
HideButton��5      $��bin/minimize.png��6*   $��UniformToFill=�6D   $��20��6\   $��20��6g   $��0,0,30,0q�6s   6�   �� 5      -   5        $��CloseButton��5      $��bin/close.png��6+   $��20��6B   $��20��6M   6�   5      5       � 5   
   -   5        $��ContentFrame��5      
  � NavigationUIVisibility$
 Hidden=�6$   $	��Top=�6D   $��Center=�6\   $
��1280��6y   $	��320��6�   $��0,60,0,0q�6�   5      5      5      