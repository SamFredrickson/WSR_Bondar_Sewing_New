   M S B A M L   `   `   `  ����I  EWSR_New_Sewing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:WSR_New_Sewing.View.StockmanWSR_New_Sewing.View.Stockman  5   	   -    'WSR_New_Sewing.View.Stockman.UpdateForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:WSR_New_Sewing.View.Stockman     5   	   -   5          � Title$  Вход��5   	   $	��450��5	   	   $	��400��5
   	   .��5      � 
������� � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��60 �6   .+�5   
   �� $��Обновление��6   $��Center=�5      $��Center=�5      $��25(�5      $
��Bold"�5      
�������5      �� 5   
   $��1��6   $��Center=�5      $��Center=�5      .+�5      �� $��	Цвет:��6   $��20(�5       
�������5!      �� 5#      -   5        $��color��5#       �� 
IsReadOnly .  �� DisplayMemberPath$ Value��5&       �� SelectedValuePath$ Value��5'      $��20(�5(      $��Center=�5)      $	��160��5*      ��5%      �� *Colors+5*      �� 5,      $��Материал:��6   $��20(�5-      
�������5.      �� 50      -   5        $��material��50       . $ Value��53      $ Value��54      $��20(�55      $��Center=�56      $	��160��57      ��52      �� *	Materials+57      �� 5:      $��Длина:��6   $��20(�5;      
�������5<      �� 5>      -   5        $��Width��5>      $��20(�5?      $��Center=�5@      $	��160��5A      �� 5C      $��Высота:��6   $��20(�5D      
�������5E      �� 5G      -   5        $��length��5G      $��20(�5H      $��Center=�5I      $	��160��5J      5L      � 5N   
   $��2��6    � ColumnDefinitions 5O      �� 5P      �� 5Q      .+�5T      �� -   5        $��1��5T      
���   �$��Обновить��5V      $��20(�5W      
�������5X   (   �� 5Z      -   5        $��1��5Z      $��1��5[      
���   �$��
Назад��5]      $��20(�5^      
�������5_   (   5a      5c      5d      