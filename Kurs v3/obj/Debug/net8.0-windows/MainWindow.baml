   M S B A M L   `   `   `  ����B  >Kurs v3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Kurs_v3Kurs_v3  5   	       Kurs_v3.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Kurs_v3     5   	     � Title$  Launcher��5      $	��450��6   $	��800��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H    � WindowStyle$
 None=�6m   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$	 0.9Q�6-   � 5      $ 	#FFFF0707��6   $ 0Q�61   5       � RowDefinitions 5   
   �� 5      $	��81* �6   6+   �� 5      $
��136* �6   6,   �� 5      $
��136* �6   6,   �� 5      $	��89* �6   6+   .+�5   
   � -   5        $��0��5      
���  ��$��	0,0,0,136q�6-   $��2��6@   .+�5      �� $��Циклоп��6   $��50(�6&   $��Center=�64   $��Center=�6Q   
�������6�   5      �� 5   
   $��1��6   	 �� Orientation$	 
Horizontal=�6"   .+�5      �� $��Center=�6   .��6/   Логин:67   �� 5      -   5        
 ��Name$
 
LogIn_text��5      $��1��6*   $	��700��67   $��30��6C   5      �� 5   
   $��2��6   $	 
Horizontal=�6"   .+�5      �� $��Center=�6   .��6/   Пароль67   �� 5      -   5        $
 Password_text��5      $��2��6-   $��30��6:   $	��700��6F   6U   5       �� 5"   
   $��3��6   $	 
Horizontal=�6"   $��Center=�6;   .+�5#      �� -   5         ��Name$ 	LogIn_btn��5#      $��3��6(   $��Ввод��65   $��5q�6\   6i   �� 5$      -   5        $ CloseApp_btn��5$      $'��!Закрыть программу��6F   $��3��6b   $��5q�6o   6|   5%      5&      5'      