   M S B A M L   `   `   `  ����@  <DBApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DBAppDBApp  5   	       DBApp.RegistrationWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   %localclr-namespace:DBApp     5   	   X TXceed.Wpf.Toolkit, Version=4.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44wptk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  RegistrationWindow��5	   	    � SizeToContent$ WidthandHeight=�6$    � 
ResizeMode$ NoResize=�6C   .��5
      � .+�5   
   �� $��Ваше имя:��6   $
��Left=�6$   $	��Top=�6?   �� 5   
   $��Ваша фамилия:��6   $
��Left=�6(   $	��Top=�6C   $��0,26,0,0q�6[   �� 5   
   $<��6Ваше отчество(необязательно):��6   $
��Left=�68   $	��Top=�6S   $��0,52,0,0q�6k   �� 5   
   $
��Left=�6   $	��Top=�6,   $��0,78,0,0q�6D   $0��*Серия паспорта (4 цифры)��6V   �� 5   
   $
��Left=�6   $	��Top=�6,   $��	0,104,0,0q�6D   $.��(Номер паспорта (6 цифр)��6W   �� 5   
   $
��Left=�6   $	��Top=�6,   $��	0,130,0,0q�6D   $;��5Кем выдан паспорт (отделение)��6W   �� 5   
   $
��Left=�6   $	��Top=�6,   $��	0,156,0,0q�6D   $I��CКод подразделения (в формате ХХХ-ХХХ)��6W   �� 5   
   $
��Left=�6   $	��Top=�6,   $��	0,182,0,0q�6D   $��Дата выдачи��6W   �� 5   
   $
��Left=�6   $	��Top=�6,   $��	0,208,0,0q�6D   $��Дата рождения��6W   �� 5   
   $
��Left=�6   $	��Top=�6,   $��	0,260,0,0q�6D   $!��Номер телефона��6W   �� 5   
   $
��Left=�6   $	��Top=�6,   $��	0,286,0,0q�6D   $%��Адрес проживания��6W   %  Xceed.Wpf.Toolkit.MaskedTextBox  5   
   -   5        $��Division_Code��5   G      Mask$ 000-000��6   $
��Left=�6,   $��237,160,0,0q�6\    �� TextWrapping$
 Wrap=�6q   $	��Top=�6�   $	��200��6�   �� 5   
   -   5        $��	Issued_By��5   -   $
��Left=�6   $��237,134,0,0q�6>   $
 Wrap=�6S   $	��Top=�6h   $	��200��6�     5   
   -   5        $��Passport_Number��5   F   $ 000000��6   $
��Left=�6+   $��237,108,0,0q�6]   $
 Wrap=�6r   $	��Top=�6�   $	��200��6�     5   
   -   5        $��Passport_Series��5   D   $
 0000��6   $
��Left=�6)   $��
237,82,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $	��200��6�   �� 5   
   -   5        $��Middle_Name��5   -   $
��Left=�6   $��
237,56,0,0q�6@   $
 Wrap=�6U   $	��Top=�6j   $	��200��6�   �� 5   
   -   5        $��Second_Name��5   -   $
��Left=�6   $��
237,30,0,0q�6@   $
 Wrap=�6U   $	��Top=�6j   $	��200��6�   �� 5   
   -   5        $��
First_Name��5   -   $
��Left=�6   $��	237,4,0,0q�6?   $
 Wrap=�6T   $	��Top=�6i   $	��200��6�     5   
   -   5        $��
Issue_Date��5   J   $ 
0000-00-00��6   $
��Left=�6/   $��237,186,0,0q�6\   $
 Wrap=�6q   $	��Top=�6�   $	��200��6�     5   
   -	   5        $��	Birth_Day��5   J   $ 
0000-00-00��6   $
��Left=�6/   $��237,212,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $	��200��6�     5   
   -
   5        $��Phone_Number��5   P   $ +7(000)000-00-00��6   $
��Left=�65   $��237,264,0,0q�6d   $
 Wrap=�6y   $	��Top=�6�   $	��200��6�   �� 5    
   -   5        $��Residential_Adress��5    -   $
��Left=�6   $��237,290,0,0q�6G   $
 Wrap=�6\   $	��Top=�6q   $	��200��6�   �� 5!   
   -   5        $��Verify��5!   �   $W��QИспользовать двухфакторную аутентификацию?��62   $
��Left=�6g   $��	0,364,0,0q�6�   $	��Top=�6�    d� 	IsChecked$ FalseY�6�   6�   �� 5"   
   -   5        $��Email_Label��5"   '   $y�	Collapsed=�6   $'��!Электронная почта��6:   $
��Left=�6W   $��	0,379,0,0q�6r   $	��Top=�6�   �� 5#   
   -   5        $��Email��5#   )   $y�	Collapsed=�6   $
��Left=�66   $��237,379,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6{   $	��200��6�   �� 5$   
   -   5        $��Accept��5$   8   $��Bottom=�6   $��20��6,   $��Подтвердить!��6]   $��	0,402,0,0q�6t   �� 5%   
   $'��!Адрес регистрации��6   $
��Left=�6,   $��	0,234,0,0q�6G   $	��Top=�6Z   �� 5&   
   -   5         ��Name$ Registration_Address��5&   -   $
��Left=�6   $��237,238,0,0q�6K   $
 Wrap=�6`   $	��Top=�6u   $	��200��6�   �� 5'   
   $��
Логин��6   $
��Left=�6    $��	0,312,0,0q�6;   $	��Top=�6N   �� 5(   
   $J��DПароль(должен содержать спецсимволы)��6   $
��Left=�6?   $��	0,338,0,0q�6Z   $	��Top=�6m   �� 5)   
   -   5        $��Login��5)      $
��Left=�6   $��237,316,0,0q�6:   $
 Wrap=�6O   $	��Top=�6c   $	��200��6{   �� 5*   
   -   5        $��Password��5*      $
��Left=�6"   $��237,342,0,0q�6=   $
 Wrap=�6R   $	��Top=�6f   $	��200��6~   5+      5,      