   M S B A M L   `   `   `  ����N  JMeal Suggestion App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Meal_Suggestion_AppMeal_Suggestion_App  5   	   -    'Meal_Suggestion_App.MultipleSuggestions   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Meal_Suggestion_App     5   	     � Title$  MultipleSuggestions��5   	   $	��450��6%   $	��800��62   .��5	      � .+�5
   
   �� -   5         ��Name$ backBtn��5
      $��Back to Main��6"   $
��Left=�69   $��	26,26,0,0q�6T   $	��Top=�6g   $	��140��6   $��45��6�   6�   &   System.Windows.Controls.DataGrid  5   
      AutoGenerateColumns .  $
��Left=�6Q   $	��368��6l   $��
354,26,0,0q�6y   $	��Top=�6�   $	��417��6�   ��6   �� *	MealPlans+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Breakfast��6C      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	Breakfast+6V     5      $ Lunch��6?   $ * 6O    6%   �� *Lunch+6O     5      $ Dinner��6@   $ * 6Q    6%   �� *Dinner+6Q   5      �� 5   
   -   5         ��Name$ 
daysSlider��5       � Minimum$ 1Q�6%   	 � Maximum$	 30Q�61   
 �� IsSnapToTickEnabled
 .  �� TickFrequency$ 1Q�6Y   $
��Left=�6k   $��
26,166,0,0q�6�   $	��Top=�6�   $��19��6�   $	��306��6�   �� 5   
   -   5        $ getSuggestionBtn��5      $��Get Suggestions��6+   $
��Left=�6E   $��
26,244,0,0q�6`   $	��Top=�6t   $	��306��6�   $��53��6�   6�   �� 5   
   $
��Left=�6m   $��136,190,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $��25��6�   ��6   ��  �� ElementName$ 
daysSlider�� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��Day(s)��6   $
��Left=�6"   $��161,190,0,0q�6=   $
��Wrap=�6R   $	��Top=�6f   5      5      