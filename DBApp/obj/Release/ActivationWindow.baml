   M S B A M L   `   `   `  ���� @  <DBApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DBAppDBApp      DBApp.ActivationWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     %localclr-namespace:DBApp       � Title$  ActivationWindow�� � SizeToContent$ Height=�$	��600��.���� .+��� $����Пожалуйста, введите лицензионный ключ, или воспользуйтесь бесплатной 30-дневной пробной версией���� -   $��
LicenseKey�� � ToolTip$? 9Введите лицензионный ключ сюда���� -   $��Activate��$' !Активировать ключ��$��20��$	��600��$��Активировать!������  �� 
TargetType" �� �� Triggers P�  P� Property �@J�IsMouseOver P� Value .  N� EnterActions �� .���� .��t�  g� Duration$ 	0:0:0.250D�		 t� To$	 0X�
 �� TargetProperty$
 BorderThickness�W� $ 	0:0:0.550D�	 W� To$	 100X�$
 Width� N� ExitActions �� .���� .��t� $ 	0:0:0.250D�$	 1X�$
 BorderThickness�W� $ 	0:0:0.550D�$	 600X�$
 Width��� -   $��Trial��$/ )Попробовать бесплатно��$��20��$	��600��$%��Триальная версия������ " �� P�  �@J�IsMouseOver .  �� .���� .��t� $ 	0:0:0.250D�$	 0X�$
 BorderThickness�W� $ 	0:0:0.550D�$	 100X�$
 Width� �� .���� .��t� $ 	0:0:0.250D�$	 1X�$
 BorderThickness�W� $ 	0:0:0.550D�$	 600X�$
 Width�