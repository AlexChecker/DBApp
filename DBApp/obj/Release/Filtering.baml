   M S B A M L   `   `   `  ���� @  <DBApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DBAppDBApp      DBApp.Filtering   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     %localclr-namespace:DBApp     X TXceed.Wpf.Toolkit, Version=4.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44wptk)http://schemas.xceed.com/wpf/xaml/toolkit  -     � Title$  	Filtering�� � SizeToContent$ WidthAndHeight=�.���� .+��� $0��*Сортировать по столбцу��$
��Left=�$	��Top=��� -   $��Columns�� � ToolTip$A ;Выберите столбец для фильтрации��$	��345��$
��Left=��� -   $	��Box��
�������$%��Режим фильтрации��$	��345��$
��Left=�$
��auto��.���� .+�	� -   $��	DoNotSort�� 	� 	GroupName$
 Sort�� d� 	IsChecked$
 TrueY�$!��Не сортировать��	� -   $��SortAscending��$
 Sort��$8��2Сортировать по возрастанию��$
��Left=�$	��Top=�	� -   $��SortDescending��$
 Sort��$2��,Сортировать по убыванию��	� -   $��IncludeString��$ Filter��$y�	Collapsed=�$&�� По наличию строки��	� -   $��ExcludeString��$ Filter��$y�	Collapsed=�$,��&По отсутствию строки��	� -	   $��NumberGreater��$ Filter��$y�	Collapsed=�$*��$Значение больше чем��	� -
   $��NumberSmaller��$ Filter��$y�	Collapsed=�$*��$Значение меньше чем��	� -   $��NotEqual��$ Filter��$y�	Collapsed=�$!��Значение равно��	� -   $��Equal��$��
Равно��$y�	Collapsed=�$ Filter��	� -   $��isNull��$ Filter��$&�� Значение равно null��(  "Xceed.Wpf.Toolkit.WatermarkTextBox  -   $��StringFilterBox��$y�	Collapsed=�   	Watermark$= 7Введите строку для фильтрации��  -   $��NumberFilterBox��$y�	Collapsed=�$J DВведите числовое значение для поиска���� -   $��ApplyFilter��$	��345��$%��Применить фильтр������  �� 
TargetType" �� �� Triggers P�  P� Property �@J�IsMouseOver	 P� Value	 . 
 N� EnterActions
 �� .���� .��t�  g� Duration$ 	0:0:0.250D�	 t� To$ 0X� �� TargetProperty$ BorderThickness�W� $ 	0:0:0.550D�	 W� To$	 100X�$ Width� N� ExitActions �� .���� .��t� $ 	0:0:0.250D�$ 1X�$ BorderThickness�W� $ 	0:0:0.550D�$	 345X�$ Width�