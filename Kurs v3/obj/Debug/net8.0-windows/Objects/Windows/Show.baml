   M S B A M L   `   `   `  ����B  >Kurs v3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Kurs_v3.Objects.WindowsKurs_v3.Objects.Windows  5   	   "    Kurs_v3.Objects.Windows.Show   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Kurs_v3.Objects.Windows     5   	     � Title$  Cyclop release��5   
   $	��450��6!   $	��800��6.    � 
ResizeMode$ NoResize=�6:    � WindowStyle$
 None=�6P   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   6*   �� 5      $��* �6   6)   �� 5      $��50 �6   6*   .+�5   
   � $��1��6    � ColumnDefinitions 5      �� 5      $	��150 �6#   61   �� 5      $��* �6#   6/   .+�5      �� $��0��6    �� Orientation$ Vertical=�6)   $��10q�6@   .+�5      �� -   5         ��Name$ Show_Display��5      $��	0,10,0,10q�6K   $#��Список дисплеев��6^    � Cursor$
 Hand��6x   5       �� 5"      -   5        $ 	Show_Dial��5"      $��	0,10,0,10q�6E   $#��Список датчиков��6X   $
 Hand��6r   5$      �� 5&      -   5        $ 
Show_Plate��5&      $��	0,10,0,10q�6F   $
 Hand��6Y   $��Список плат��6g   5(      �� 5*      -   5        $ BackBtn��5*      $��
Назад��6@   $��	0,10,0,10q�6Q   $
 Hand��6d   5,      �� 5.      -   5        $ To_MainPage_btn��5.      $��На главную��6P   $��	0,10,0,10q�6e   $
 Hand��6x   50      �� 51      -   5        $ CloseAppBtn��51      $*��$Выйти из приложения��6H   $��	0,10,0,10q�6f   $
 Hand��6y   53      �� 55      -   5        $ CheckUserBtn��55      $-��'Список пользователей��6/   $��	0,10,0,10q�6N   $
 Hand��6a   57      59       � 5<      -   5          �Name$ 	MainFrame��5<      	  � NavigationUIVisibility$	 Hidden=�6'   $��1��6I   $	��640��6Z   $	��300��6f   5>      5?      � 5B   
   -	   5        $��0��5B      ��5C      �� 5D      
 �� EndPoint$
 0.3,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5E      �  � Color$	 Red��6#    � Offset$ 0Q�6/   � 5F      $ White��6#   $ 1Q�61   5G      .+�5J      �� $��Циклоп��6   $��20(�6&   
�������$��Center=�6G   $��Center=�6d   5L      5M      � 5N   
   $��2��6   
���  ��5P      5R      5S      