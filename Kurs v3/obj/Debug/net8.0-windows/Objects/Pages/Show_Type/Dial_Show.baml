   M S B A M L   `   `   `  ����B  >Kurs v3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Kurs_v3.Objects.Pages.Show_TypeKurs_v3.Objects.Pages.Show_Type  5      /    )Kurs_v3.Objects.Pages.Show_Type.Dial_Show   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Kurs_v3.Objects.Pages.Show_Type     5      -   5          N� Title$  	Dial_Show��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��163 �6   6+   �� 5      .+�5   
   �� $��1��6    �� Orientation$ 
Horizontal=�6#   $��Center=�6<   $��0,0,0,53q�6Y   .+�5      �� -   5         ��Name$ 
Delete_Btn��5      $��1��6C   $
��Left=�6P   $��10q�6k   $!��Удалить датчик��6w   $��13(�6�   $	��120��6�    � Cursor$
 Hand��6�   5      �� 5      -   5        $ AddBtn��5      $#��Добавить датчик��6;   $��1��6V   $
��Left=�6c   $��10q�6�   $
 Hand��6�   $	��120��6�   5      5      �� 5   
   -   5         ��Name$ ID_input_text��5      $��1��6)   $	��200��66   $��0,84,440,34q�6B   $&�� Введите ID датчика��6W    K� ZIndex$ 0��6q   �� 5   
   -   5        $ 
IdInputbtn��5      $��1��6?   $��213,84,307,33q�6L   $��Ввод��6c   $ 0��6r   6�   &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ DGrid��5       $��0��6"      AutoGenerateColumns$ False��6/   	   
IsReadOnly$
	 True��6K   $��10q�6]   
   SelectionMode$
 Single=�6i      Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      -   5        id��,  &System.Windows.Controls.DataGridColumn   Header$ id��5"   1   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Id+5$        5%      -   5        Name��$ Название��5%   3      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6E    6O   �� *Name+5'        5(      -	   5        id_2��$! Серийный номер��5(   3   $ * 6K    6U   �� *SerialNumber+5*      5-      5/      50      