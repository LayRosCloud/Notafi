   M S B A M L   `   `   `  ����F  BNotafiThree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:NotafiThree.View.WindowPagesNotafiThree.View.WindowPages  5      3clr-namespace:NotafiThree.ViewNotafiThree.View  5      5    /NotafiThree.View.WindowPages.UserControllerPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:NotafiThree.View.WindowPages     5      -uiclr-namespace:NotafiThree.View     5      -   5          N�Name$
  root��5
   "    N� Title$ UserControllerPage��6   .��5      �  � RowDefinitions 5   
   �� 5      $��75 �6   �� 5      .+�5   
   � $��Center=�6   .+�5      %   NotafiThree.View.TextBoxControl  -   5          Name$ finder��5          	Thickness$ 0 0 3 0q�60      
WidthImage$ 30��6D   $	��200��6T      Placeholder$ Поиск...��6`   �� 5      -   5           DefaultButton#��[  5      $��
Найти��6<   6L   5      � 5   
   $��Right=�6   $��Center=�60   .+�5      �� -   5        #��[  5      $��Изменить��6<   6O   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ users��5      $��1��6"      AutoGenerateColumns .    rowStyle	   RowStyle#	 [ 6K     	cellStyle
   	CellStyle#
 [ 6p      
IsReadOnly .    GridLinesVisibility$
 None=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Person.LastName+  5      $ Имя��6%    62   �� *Person.FirstName+  5      $ Отчество��6%    67   �� *Person.Patronymic+  5      $ 
Серия��6%    64   �� *Person.Series+  5      $ 
Номер��6%    64   �� *Person.NumberOfPassport+  5      $ Телефон��6%    66   �� *Person.Phone+  5       $ Роль��6%    63   �� *	Role.Name+5"      5#      5$      