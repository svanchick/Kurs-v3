   M S B A M L   `   `   `  ����B  >Kurs v3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Kurs_v3.Objects.Pages.Show_TypeKurs_v3.Objects.Pages.Show_Type  5      0    *Kurs_v3.Objects.Pages.Show_Type.Show_Users   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Kurs_v3.Objects.Pages.Show_Type     5      -   5          N� Title$  
Show_Users��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��163 �6   6+   �� 5      .+�5   
   �� $��1��6    �� Orientation$ 
Horizontal=�6#   $��Center=�6<   $��0,0,0,53q�6Y   .+�5      �� -   5         ��Name$ 
Delete_Btn��5      $��1��6C   $
��Left=�6P   $��10q�6k   $-��'Удалить пользователя��6w   $��13(�6�   $	��120��6�    � Cursor$
 Hand��6�   5      �� 5      -   5        $ AddBtn��5      $/��)Добавить пользователя��6;   $��1��6\   $
��Left=�6i   $��10q�6�   $
 Hand��6�   $	��120��6�   5      5      �� 5   
   -   5         ��Name$ ID_input_text��5      $��1��6)   $	��200��66   $��0,84,440,34q�6B   $0��*Введите ID пользователя��6W    K� ZIndex$ 0��6v   �� 5   
   -   5        $ 
IdInputbtn��5      $��1��6?   $��213,84,307,33q�6L   $��Ввод��6c   $ 0��6r   6�   &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ DGrid��5       $��0��6"      AutoGenerateColumns$ False��6/   	   
IsReadOnly$
	 True��6K   $��10q�6]   
   SelectionMode$
 Single=�6i      Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      -   5        id��,  &System.Windows.Controls.DataGridColumn   Header$ id��5"   1   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Id+5$        5%      -   5        Name��$ Имя��5%   3      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6@    6J   �� *Name+5&        5(      -	   5        Surname��$ Фамилия��5(   6   $ * 6H    6R   �� *	Surname+5)        5+      -
   5        patr��$ Отчество��5+   3   $ * 6E    6O   �� *
Patronymic+5,        5.      -   5        LogInOfUser��$ 
Логин��5.   :   $ * 6I    6S   �� *Login+5/        51      -   5        Password��$ Пароль��51   7   $ * 6G    6Q   �� *
Password+52      54      56      57      