   M S B A M L   `   `   `  ����N  JMeal Suggestion App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Meal_Suggestion_AppMeal_Suggestion_App  5   	   &     Meal_Suggestion_App.ManageDishes   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Meal_Suggestion_App     5   	   -   5          � Title$  ManageDishes��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   �� -   5         ��Name$ backBtn��5
      $��Back to Main��6"   $
��Left=�69   $��	26,26,0,0q�6T   $	��Top=�6g   $	��140��6   $��45��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dishDataGrid��5      $
��Left=�6)   $	��365��6D   $��
393,26,0,0q�6Q   $	��Top=�6e   $	��357��6}   6�   �� 5   
   $��Name of the dish:��6   $
��Left=�6,   $��
26,100,0,0q�6G   $	��Top=�6[   $	��116��6s   �� 5   
   -   5         ��Name$ nameTxt��5      $
��Left=�6#   $��23��6>   $��147,104,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��195��6�   �� 5   
   $��Is it breakfast?��6   $
��Left=�6+   $��
26,143,0,0q�6F   $	��Top=�6Z   	� 5   
   -   5         	�Name$ yesRbtn��5       	� 	GroupName$ 	breakfast��6'   $	��Yes��6=    d� 	IsChecked$
 TrueY�6K   $
��Left=�6\   $��147,149,0,0q�6w   $	��Top=�6�   	� 5   
   $ 	breakfast��6   $��No��6,   $
��Left=�69   $��266,149,0,0q�6T   $	��Top=�6i   �� 5   
   -   5        $ 
addDishBtn��5      $��Add Dish��6%   $
��Left=�68   $��
26,186,0,0q�6S   $	��Top=�6g   $	��316��6   $��45��6�   6�   �� 5   
   $8��2To delete a dish, please click one from the table.��6   $
��Left=�6N   $��
26,276,0,0q�6i   $
��Wrap=�6}   $	��Top=�6�   $��27��6�   $	��316��6�   �� 5   
   $��Dish ID to delete:��6   $
��Left=�6.   $��
26,308,0,0q�6I   $
��Wrap=�6]   $	��Top=�6q   �� 5   
   -   5         ��Name$ idToDeleteTxt��5      $�� ��6+   $
��Left=�63   $��133,308,0,0q�6N   $
��Wrap=�6c   $	��Top=�6w   �� 5   
   -   5        $ deleteDishBtn��5      $��Delete Dish��6(   $
��Left=�6>   $��
26,346,0,0q�6Y   $	��Top=�6m   $	��316��6�   $��45��6�   6�   5      5      