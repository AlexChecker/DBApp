   M S B A M L   `   `   `  ���� @  <DBApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DBAppDBApp      DBApp.RegistrationWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     %localclr-namespace:DBApp     X TXceed.Wpf.Toolkit, Version=4.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44wptk)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$  RegistrationWindow�� � SizeToContent$ WidthandHeight=� � 
ResizeMode$ NoResize=�.��� .+��� $��Ваше имя:��$
��Left=�$	��Top=��� $��Ваша фамилия:��$
��Left=�$	��Top=�$��0,26,0,0q��� $<��6Ваше отчество(необязательно):��$
��Left=�$	��Top=�$��0,52,0,0q��� $
��Left=�$	��Top=�$��0,78,0,0q�$0��*Серия паспорта (4 цифры)���� $
��Left=�$	��Top=�$��	0,104,0,0q�$.��(Номер паспорта (6 цифр)���� $
��Left=�$	��Top=�$��	0,130,0,0q�$;��5Кем выдан паспорт (отделение)���� $
��Left=�$	��Top=�$��	0,156,0,0q�$I��CКод подразделения (в формате ХХХ-ХХХ)���� $
��Left=�$	��Top=�$��	0,182,0,0q�$��Дата выдачи���� $
��Left=�$	��Top=�$��	0,208,0,0q�$��Дата рождения���� $
��Left=�$	��Top=�$��	0,260,0,0q�$!��Номер телефона���� $
��Left=�$	��Top=�$��	0,286,0,0q�$%��Адрес проживания��%  Xceed.Wpf.Toolkit.MaskedTextBox  -   $��Division_Code��   Mask$ 000-000��$
��Left=�$��237,160,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��200���� -   $��	Issued_By��$
��Left=�$��237,134,0,0q�$
 Wrap=�$	��Top=�$	��200��  -   $��Passport_Number��$ 000000��$
��Left=�$��237,108,0,0q�$
 Wrap=�$	��Top=�$	��200��  -   $��Passport_Series��$
 0000��$
��Left=�$��
237,82,0,0q�$
 Wrap=�$	��Top=�$	��200���� -   $��Middle_Name��$
��Left=�$��
237,56,0,0q�$
 Wrap=�$	��Top=�$	��200���� -   $��Second_Name��$
��Left=�$��
237,30,0,0q�$
 Wrap=�$	��Top=�$	��200���� -   $��
First_Name��$
��Left=�$��	237,4,0,0q�$
 Wrap=�$	��Top=�$	��200��  -   $��
Issue_Date��$ 
0000-00-00��$
��Left=�$��237,186,0,0q�$
 Wrap=�$	��Top=�$	��200��  -	   $��	Birth_Day��$ 
0000-00-00��$
��Left=�$��237,212,0,0q�$
 Wrap=�$	��Top=�$	��200��  -
   $��Phone_Number��$ +7(000)000-00-00��$
��Left=�$��237,264,0,0q�$
 Wrap=�$	��Top=�$	��200���� -   $��Residential_Adress��$
��Left=�$��237,290,0,0q�$
 Wrap=�$	��Top=�$	��200���� -   $��Verify��$W��QИспользовать двухфакторную аутентификацию?��$
��Left=�$��	0,364,0,0q�$	��Top=� d� 	IsChecked$ FalseY��� -   $��Email_Label��$y�	Collapsed=�$'��!Электронная почта��$
��Left=�$��	0,379,0,0q�$	��Top=��� -   $��Email��$y�	Collapsed=�$
��Left=�$��237,379,0,0q�$
 Wrap=�$	��Top=�$	��200���� -   $��Accept��$��Bottom=�$��20��$��Подтвердить!��$��	0,402,0,0q�$	��440������  �� 
TargetType" �� �� Triggers P�  P� Property �@J�IsMouseOver	 P� Value	 . 
 N� EnterActions
 �� .���� .��t�  g� Duration$ 	0:0:0.250D�	 t� To$ 0X� �� TargetProperty$ BorderThickness�W� $ 	0:0:0.550D�	 W� To$	 100X�$ Width� N� ExitActions �� .���� .��t� $ 	0:0:0.250D�$ 1X�$ BorderThickness�W� $ 	0:0:0.550D�$	 440X�$ Width��� $'��!Адрес регистрации��$
��Left=�$��	0,234,0,0q�$	��Top=��� -    ��Name$ Registration_Address��$
��Left=�$��237,238,0,0q�$
 Wrap=�$	��Top=�$	��200���� $��
Логин��$
��Left=�$��	0,312,0,0q�$	��Top=��� $J��DПароль(должен содержать спецсимволы)��$
��Left=�$��	0,338,0,0q�$	��Top=��� -   $��Login�� � ToolTip$� �Уникальное имя пользователя, которое вы будете использовать для входа в сиситему��$
��Left=�$��237,316,0,0q�$
 Wrap=�$	��Top=�$	��200���� -   $��Password��$
��Left=�$��237,342,0,0q�$
 Wrap=�$	��Top=�$	��200��