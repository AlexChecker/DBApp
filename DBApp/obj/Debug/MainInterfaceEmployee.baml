   M S B A M L   `   `   `  ����@  <DBApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DBAppDBApp  5   	   !    DBApp.MainInterfaceEmployee   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:DBApp     5   	     � Title$  MainInterfaceEmployee��5   	   $	��450��6'   $	��800��64    � 
ResizeMode$ NoResize=�6@   .��5	      � .+�5
   
   �� -   5        $��LogOff��5
   C   $$��Выйти из системы��6   $��Right=�6Q   $	��Top=�6m   �� 5   
   -   5        $��username_label��5   )   $��Вы вошли как: ��6   $
��Left=�6?   $	��Top=�6Z   �� 5   
   -   5        $��AppealsInProgress��5      $��
0,25,600,0q�6-   $)��#Открытые обращения��6A   .��5      &   System.Windows.Controls.DataGrid  -   5        $��Appeals��5         
IsReadOnly .  � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType��%E   '        �� 5      "  6   .�5      -   5        5      5      5      5      �� 5   
   $%��Табельное оружие��6   $��200,25,400,0q�6.   .��5        -   5        $��ServiceWeapon��5       . 5      5      �� 5   
   $4��.Отдел, звание и должность��6   $��400,25,200,0q�66   .��5        -   5        $��Department_Post_Run��5         AutoGenerateColumns .  . 5      5      �� 5   
   $��Дела��6   $��
600,25,0,0q�6!   .��5        -   5        $��Investigations��5       .  .  5      ��%E   '        �� 5       "  6   .�5!      -	   5        5"      5#      5$      5%      5&      5'      