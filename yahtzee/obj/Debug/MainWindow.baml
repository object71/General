   M S B A M L   `   `   `  ����B  >yahtzee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:yahtzee.UserControlsyahtzee.UserControls  5   	       yahtzee.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   1ui"clr-namespace:yahtzee.UserControls     5   	     � Title$  
MainWindow��5   	    � WindowStartupLocation$ CenterScreen=�6    � SizeToContent$ WidthAndHeight=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ yahtzee��5   ,   $��Images/yahtzee.png��6   $��3��6=   $��2��6M   $��0��6a   $
��0, 7q�6n   $
��Fill=�5      � 5   
   $��0��6   $��3��6   $��2��63   $��10q�6D    5      �� 5      $��* �6#   6/   �� 5      $��* �6#   6/   .+�5      �� -   5        $��listBoxUpper��5      $��0��6`   ��6*   ��  �� Path$ ActivePlayer.UpperScores���5       �� 5!      .R�5"      *   $yahtzee.UserControls.ScoringHandView  60   5#      5%      �� 5&      -   5        $��listBoxLower��5&      $��1��6`   ��6*   �� $ ActivePlayer.LowerScores���5'      �� 5(      .R�5)        60   5*      5,      5.      �� 50   
   -   5         ��Name$ 
scoreboard��50      $��3��6K   $��1��6[   $
��10,5q�6h   $	��200��6v   ��6&   �� $ Players���51      �� 52      .R�53      &    yahtzee.UserControls.PlayersView  6(   54      56      �� 58   
   $��4��6   $��1��6%   .+�59      �� -   5         ��Name$ start��59      $��4��6$   $��75��64   $��Start!��6@   $��32(�6Q   $��10,20q�6s   $��1��6�   �� 5;      -   5        $
��roll��5;      $��4��6!   $��1��61   $��75��6>   $
��Roll��6J   $��32(�6Y   $��10q�6z   5<         yahtzee.UserControls.Dice  5>   
   $��0��6   $��2��6"   $��2��6n   	 � DataContext	 6/   �� $&  ActivePlayer.CurrentHand.Dice[0]�6�     5?   
   $��1��6   $��2��6"   $��2��6n   	 6/   �� $&  ActivePlayer.CurrentHand.Dice[1]�6�     5@   
   $��2��6   $��2��6"   $��2��6n   	 6/   �� $&  ActivePlayer.CurrentHand.Dice[2]�6�     5A   
   $��3��6   $��2��6"   $��2��6n   	 6/   �� $&  ActivePlayer.CurrentHand.Dice[3]�6�     5B   
   $��4��6   $��2��6"   $��2��6n   	 6/   �� $&  ActivePlayer.CurrentHand.Dice[4]�6�   5D      5E      