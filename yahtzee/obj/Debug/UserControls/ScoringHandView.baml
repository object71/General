   M S B A M L   `   `   `  ����B  >yahtzee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:yahtzee.UserControlsyahtzee.UserControls  5      *    $yahtzee.UserControls.ScoringHandView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1ui"clr-namespace:yahtzee.UserControls     5      .��5	      � -   5        $��mainGrid��5	      
�������$��2q�6/     � 	Resources  5   
   /   )yahtzee.UserControls.PipsToImageConverter   PipsToImageConverter6   0yahtzee.UserControls.BoolToOppositeBoolConverter  BoolTooppositeBoolConverter��%:   &	        &	        5      6E     5      6S   5       � ColumnDefinitions 5   
   �� 5      $	��130 �6   6-   �� 5      $	��100 �6   6-   �� 5      $��45 �6   6,   �� 5      $��45 �6   6,   �� 5      $��45 �6   6,   .+�5   
   �� $��0��6   $��20(�6:   $
��Bold"�6H   $��Right=�6Z   $��5q�6v   $��Center=�6�   ��6$   �� *Name+6�   �� 5   
   -   5         ��Name$
 dice��5   ]   $��1��6k    �� BitmapScalingMode$
 Fant=�6{   $
��Fill=�6�   $��40��5      $��40��6   $
��10,0q�6(   $
��Left=�66   ��5      �� *	BasePip+ �� 	Converter# [  5   S   �� 5    
   $��2��6   $��20(�6H   $��SemiBold"�6V   
���  ��$��5q�6}   $��Center=�6�   $��Right=�6�   ��6$   �� *Score+ �� Mode$ TwoWay=�6�   �� 5"   
   $��3��6   $��20(�6A   $��SemiBold"�6O   
�������$��5q�6w   $��Center=�6�   $��Right=�6�   ��6$   �� *LockedScore+6�   �� 5$   
   -   5        $��	lockClick��5$      $��4��6"   $��8q�62   $
��Lock��6=   {�6d   �� *Locked+# [ 5&      5(      5)      