   M S B A M L   `   `   `  ���� @  <DBApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DBAppDBApp       DBApp.MainInterfaceCitizen   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     %localclr-namespace:DBApp       � Title$  MainInterfaceCitizen��$	��450��$	��800�� � 
ResizeMode$ NoResize=�.��� .+��� -   $��	NewAppeal�� � ToolTip$4 .Создайте новое обращение��$	��120��$#��Новое обращение��$��Right=�$	��Top=�$��	0,0,102,0q�����  �� 
TargetType" �� �� Triggers P�  P� Property �@J�IsMouseOver P� Value .  N� EnterActions �� .���� .��t�  g� Duration$ 	0:0:0.250D�		 t� To$	 0X�
 �� TargetProperty$
 BorderThickness�W� $ 	0:0:0.550D�	 W� To$	 100X�$
 Width� N� ExitActions �� .���� .��t� $ 	0:0:0.250D�$	 1X�$
 BorderThickness�W� $ 	0:0:0.550D�$	 120X�$
 Width��� -   $��LogOff��$	��110��$$��Выйти из системы��$��Right=�$	��Top=����� " �� P�  �@J�IsMouseOver .  �� .���� .��t� $ 	0:0:0.250D�$	 0X�$
 BorderThickness�W� $ 	0:0:0.550D�$	 100X�$
 Width� �� .���� .��t� $ 	0:0:0.250D�$	 1X�$
 BorderThickness�W� $ 	0:0:0.550D�$	 110X�$
 Width��� -   $��username_label��$��Вы вошли как: ��$
��Left=�$	��Top=��� -   $ ��Appeals_active_or_on_watch��$��
0,25,600,0q�$)��#Активные обращения��.��&   System.Windows.Controls.DataGrid  -   $��Appeals��   
IsReadOnly .    AutoGenerateColumns .  � 	Resources *  $System.Windows.Controls.DataGridCell��%   '        �� "  .�-   