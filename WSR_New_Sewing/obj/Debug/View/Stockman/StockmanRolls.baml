   M S B A M L   `   `   `  ����I  EWSR_New_Sewing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:WSR_New_Sewing.View.StockmanWSR_New_Sewing.View.Stockman  5   	   0    *WSR_New_Sewing.View.Stockman.StockmanRolls   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:WSR_New_Sewing.View.Stockman     5   	     � Title$  Рулоны��5   	   $	��450��5	   	   $	��820��5
   	   .��5      � 
������� � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��70 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��
stock_grid��5      
�������   
IsReadOnly .    AutoGenerateColumns .  $��16(�5         CanUserAddRows .  ��5      �� *StockmanModels+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Материал��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Материал+  5      $ Цвет��6%    63   �� *
Цвет+  5      $ Ширина��6%    65   �� *Ширина+  5      $ 
Длина��6%    64   �� *
Длина+5       �� 5"   
   $��1��6    �� Orientation$ 
Horizontal=�5#      .+�5$      �� -   5        $	��150��5%      $��60��5&      
���   �$��
Назад��5(      $��20(�5)      $��10, 0, 0, 0q�5*      
�������5+   (   �� 5-      -   5        $	��150��5.      $��60��5/      
���   �$��Обновить��51      $��20(�52      $��10, 0, 0, 0q�53      
�������54   (   �� 58      -   5        $	��150��59      $��60��5:      
���   �$��Добавить��5<      $��20(�5=      $��10, 0, 0, 0q�5>      
�������5?   (   �� 5A      -   5        $	��150��5B      $��60��5C      
���   �$��Удалить��5E      $��20(�5F      $��10, 0, 0, 0q�5G      
�������5H   (   �� 5J      -   5        $	��150��5K      $��60��5L      
���   �$��
Выход��5N      $��20(�5O      $��10, 0, 0, 0q�5P      
�������5Q   (   5S      5T      5U      