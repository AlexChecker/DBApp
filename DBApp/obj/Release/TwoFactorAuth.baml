   M S B A M L   `   `   `  ���� @  <DBApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DBAppDBApp      DBApp.TwoFactorAuth   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     %localclr-namespace:DBApp       � Title$  TwoFactorAuth��$	��120��$	��640�� � 
ResizeMode$ NoResize=�.���� .+��� $����Пожалуйста, вставьте код из письма, пришедшего на вашу электронную почту с адреса mvddatabase@gmail.com���� -   $��AuthCode�� � ToolTip$E ?Введите вашу действительную почту���� -   $
��Send��$%��Отправить письмо��$��20��$	��640������  �� 
TargetType" �� �� Triggers P�  P� Property �@J�IsMouseOver P� Value .  N� EnterActions �� .���� .��t�  g� Duration$ 	0:0:0.250D�		 t� To$	 0X�
 �� TargetProperty$
 BorderThickness�W� $ 	0:0:0.550D�	 W� To$	 100X�$
 Width� N� ExitActions �� .���� .��t� $ 	0:0:0.250D�$	 1X�$
 BorderThickness�W� $ 	0:0:0.550D�$	 640X�$
 Width��� -   $��Accept��$��20��$��Подтвердить��$	��640������ " �� P�  �@J�IsMouseOver .  �� .���� .��t� $ 	0:0:0.250D�$	 0X�$
 BorderThickness�W� $ 	0:0:0.550D�$	 100X�$
 Width� �� .���� .��t� $ 	0:0:0.250D�$	 1X�$
 BorderThickness�W� $ 	0:0:0.550D�$	 640X�$
 Width�