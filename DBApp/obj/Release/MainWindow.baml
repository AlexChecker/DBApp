   M S B A M L   `   `   `  ���� @  <DBApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DBAppDBApp      DBApp.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:DBApp       � Title$  
MainWindow�� � SizeToContent$ WidthAndHeight=� � 
ResizeMode$ NoResize=�.��� .+��� -   $��LoginBox�� � ToolTip$= 7Введите ваше имя пользователя��$
��Left=�$��	61,14,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��$��2���� $��
Логин��$
��Left=�$��	10,10,0,0q�$	��Top=��� $��Пароль��$
��Left=�$��	10,32,0,0q�$	��Top=��� -   $��PasswordBox��$( "Введите ваш пароль��$
��Left=�$��	61,40,0,0q�$
 Wrap=�$	��Top=�$	��120��$��2���� -   $��Войти!��$
��Left=�$��	10,63,0,0q�$	��Top=�$	��171��$��2������  �� 
TargetType" �� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . 	 N� EnterActions	 �� .���� .��t� 
 g� Duration$
 	0:0:0.250D�	 t� To$ 0X� �� TargetProperty$ BorderThickness�W� $
 	0:0:0.550D�	 W� To$	 100X�$ Width� N� ExitActions �� .���� .��t� $
 	0:0:0.250D�$ 1X�$ BorderThickness�W� $
 	0:0:0.550D�$	 171X�$ Width��� -   $��Register��$*��$Зарегестрироваться��$
��Left=�$��	10,86,0,0q�$	��Top=�$	��171������ " �� P�  �@J�IsMouseOver . 	 �� .���� .��t� $
 	0:0:0.250D�$ 0X�$ BorderThickness�W� $
 	0:0:0.550D�$	 100X�$ Width� �� .���� .��t� $
 	0:0:0.250D�$ 1X�$ BorderThickness�W� $
 	0:0:0.550D�$	 171X�$ Width�