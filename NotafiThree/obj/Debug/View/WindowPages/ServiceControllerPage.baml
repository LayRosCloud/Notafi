   M S B A M L   `   `   `  ����F  BNotafiThree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:NotafiThree.View.WindowPagesNotafiThree.View.WindowPages  5      3clr-namespace:NotafiThree.ViewNotafiThree.View  5      8    2NotafiThree.View.WindowPages.ServiceControllerPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:NotafiThree.View.WindowPages     5      -uiclr-namespace:NotafiThree.View     5        N� Title$  ServiceControllerPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��75 �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ services��5      $��1��6%      SelectionMode$ Single=�62      
IsReadOnly .    GridLinesVisibility$
 None=�6\      rowStyle   RowStyle# [  6w     	cellStyle   	CellStyle# [ 6�      AutoGenerateColumns .  	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Название��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Title+  5      $
 Описание��6%    67   �� *Description+  5      $
 Тип документа��6%    6<   �� *TypeOfDocument+  5      $
 Цена��6%    63   �� *Price.Number+  5      $
 Скидка��6%    65   �� *Discount.Number+5      � 5   
   $��Center=�6   .+�5      %   NotafiThree.View.TextBoxControl  -   5          Name$ finder��5       $	��200��60      Placeholder$ Поиск...��6<      
WidthImage$ 30��6S      	Thickness$ 0 0 3 0q�6c   $
��Left=�6w   �� 5      -   5          DefaultButton#��[ 5      $��
Найти��6<   $	��120��6L   6X   5      � 5   
   $��Right=�6   $��Center=�60   .+�5      �� -   5        #��[ 5      $��Добавить��6<   $	��120��6O   6[   �� 5      -   5        #��[ 5      $��Изменить��6<   $��5 0 0 0q�6O   $	��120��6`   6l   �� 5       -   5        #��[ 5       $��Удалить��6<   $��5 0 0 0q�6N   $	��120��6_   6k   5!      5"      5#      