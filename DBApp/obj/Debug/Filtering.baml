   M S B A M L   `   `   `  ����@  <DBApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DBAppDBApp  5   	       DBApp.Filtering   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   %localclr-namespace:DBApp     5   	   X TXceed.Wpf.Toolkit, Version=4.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44wptk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  	Filtering��5	   	    � SizeToContent$ WidthAndHeight=�6   .��5      �� .+�5   
   �� $0��*Сортировать по столбцу��6   $
��Left=�61   $	��Top=�6L   �� 5   
   -   5        $��Columns��5   c   $	��345��6r   $
��Left=�6~   �� 5   
   $%��Режим фильтрации��6   $	��345��6-   $
��Left=�69   $
��auto��5      .��5      �� .+�5      	� -   5        $��	DoNotSort��5       	� 	GroupName$
 Sort��6/    d� 	IsChecked$
 TrueY�6@   $!��Не сортировать��6Q   	� 5      -   5        $��SortAscending��5      $
 Sort��63   $8��2Сортировать по возрастанию��6E   $
��Left=�6j   $	��Top=�6�   	� 5      -   5        $��SortDescending��5      $
 Sort��64   $2��,Сортировать по убыванию��6E   	� 5      -   5        $��IncludeString��5      $ Filter��6Q   $y�	Collapsed=�6d   $&�� По наличию строки��6{   	� 5      -   5        $��ExcludeString��5      $ Filter��6Q   $y�	Collapsed=�6d   $,��&По отсутствию строки��6{   	� 5      -   5        $��NumberGreater��5      $ Filter��6Q   $y�	Collapsed=�6d   $*��$Значение больше чем��6{   	� 5      -   5        $��NumberSmaller��5      $ Filter��6Q   $y�	Collapsed=�6d   $*��$Значение меньше чем��6{   	� 5      -	   5        $��NotEqual��5      $ Filter��6L   $y�	Collapsed=�6_   $!��Значение равно��6v   	� 5      -
   5        $��Equal��5      $��
Равно��6I   $y�	Collapsed=�6Y   $ Filter��6p   	� 5      -   5        $��isNull��5      $ Filter��6,   $&�� Значение равно null��6?   5      5      (  "Xceed.Wpf.Toolkit.WatermarkTextBox  5   
   -   5        $��StringFilterBox��5   a   $y�	Collapsed=�6       	Watermark$= 7Введите строку для фильтрации��67   6a     5   
   -   5        $��NumberFilterBox��5   h   $y�	Collapsed=�6    $J DВведите числовое значение для поиска��67   6h   �� 5   
   -   5        $��ApplyFilter��5   H   $%��Применить фильтр��6-   6H   5       5!      