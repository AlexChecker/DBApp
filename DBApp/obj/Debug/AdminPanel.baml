   M S B A M L   `   `   `  ����@  <DBApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DBAppDBApp  5   	       DBApp.AdminPanel   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   %localclr-namespace:DBApp     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ 
AdminPanel��6    � SizeToContent$ Height=�62   $	��800��6I   .��5	      �� .+�5
   
   �� -   5        $��Tables��5
   @    �� SelectedIndex$ 0��6N   6`   �� 5   
   -   5        $��AddEntry��5      $��20��6!   $S��MДобавить новую запись в выбранную таблицу��6-   6a   �� 5   
   -   5        $��Filter��5      $��20��6   $��Фильтры��6+   6=   �� 5   
   -   5        $��DeleteEntry��5      $��20��6$   $O��IУдалить выбранную запись из базы данных��60   6b   &   System.Windows.Controls.DataGrid  5   
   -   5        $��Table��5         
IsReadOnly .  � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType��%E   '        �� 5      "  6   .�5      -   5        5      5      5      5      5      