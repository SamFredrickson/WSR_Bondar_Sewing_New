   M S B A M L   `   `   `  ����I  EWSR_New_Sewing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:WSR_New_Sewing.View.StockmanWSR_New_Sewing.View.Stockman  5   	   *    $WSR_New_Sewing.View.Stockman.AddForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:WSR_New_Sewing.View.Stockman     5   	     � Title$  Вход��5      $	��450��5	   	   $	��400��5
   	   .��5      � 
������� � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��60 �6   .+�5   
   �� $��Добавление��6   $��Center=�5      $��Center=�5      $��25(�5      $
��Bold"�5      
�������5      �� 5   
   $��1��6   $��Center=�5      $��Center=�5      .+�5      �� $��	Цвет:��6   $��20(�5      
�������5       �� 5"      -   5        $��color��5"       �� 
IsReadOnly .  �� DisplayMemberPath$ Value��5%       �� SelectedValuePath$ Value��5&      $��20(�5'      $��Center=�5(      $	��160��5)      ��5$      �� *Colors+5)      �� 5+      $��Материал:��6   $��20(�5,      
�������5-      �� 5/      -   5        $��material��5/       . $ Value��52      $ Value��53      $��20(�54      $��Center=�55      $	��160��56      ��51      �� *	Materials+56      �� 59      $��Длина:��6   $��20(�5:      
�������5;      �� 5=      -   5        $��Width��5=      $��20(�5>      $��Center=�5?      $	��160��5@      �� 5B      $��Высота:��6   $��20(�5C      
�������5D      �� 5F      -   5        $��length��5F      $��20(�5G      $��Center=�5H      $	��160��5I      5K      � 5M   
   $��2��6    � ColumnDefinitions 5N      �� 5O      �� 5P      .+�5S      �� -   5        $��1��5S      
���   �$��Добавить��5U      $��20(�5V      
�������5W   (   �� 5Y      -   5        $��1��5Y      $��1��5Z      
���   �$��
Назад��5\      $��20(�5]      
�������5^   (   5`      5b      5c      