   M S B A M L   `   `   `  ����B  >Kurs v3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Kurs_v3.Objects.PagesKurs_v3.Objects.Pages  5      $    Kurs_v3.Objects.Pages.MainPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Kurs_v3.Objects.Pages     5      -   5          N� Title$  MainPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��163 �6   6+   �� 5      .+�5   
   �� $��1��6    �� Orientation$ 
Horizontal=�6#   $��Center=�6<   $��0,0,0,53q�6Y   .+�5      �� -   5         ��Name$ 
Delete_Btn��5      $��1��6B   $
��Left=�6O   $��10q�6j   $!��Удалить сборку��6v   $��13(�6�   $	��120��6�    � Cursor$
 Hand��6�   5      �� 5      -   5        $ AddBtn��5      $#��Добавить сборку��6;   $��1��6V   $
��Left=�6c   $��10q�6�   $
 Hand��6�   $	��120��6�   5      5      �� 5   
   -   5         ��Name$ ID_input_text��5      $��1��6)   $	��200��66   $��0,84,440,34q�6B   $$��Введите ID сборки��6W    K� ZIndex$ 0��6p   �� 5   
   -   5        $ 
IdInputbtn��5      $��1��6>   $��213,84,307,33q�6K   $��Ввод��6b   $ 0��6q   6�   &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ DGrid��5       $��0��6"      AutoGenerateColumns$ False��6/   	   
IsReadOnly$
	 True��6K   $��10q�6]   
   Columns
 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      -   5        id��,  &System.Windows.Controls.DataGridColumn   Header$ id��5"   1   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Id+5$        5%      -   5        Name��$ Сборка��5%   3      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6C    6M   �� *Name+5'      5*      5+      5,      