   M S B A M L   `   `   `  ����F  BNotafiThree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:NotafiThree.View.WindowPagesNotafiThree.View.WindowPages  5      3    -NotafiThree.View.WindowPages.MoreInfoDealPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:NotafiThree.View.WindowPages     5        N� Title$  MoreInfoDealPage��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $��75 �6   �� 5      $��* �6   .+�5   
   � $��Center=�6   .+�5      �� -   5         ��Name$ btnBack��5         DefaultButton#��[  6&   $
��Left=�6M   $��
Назад��6h   6x   �� 5      -   5         ��Name$ infoAboutDeal��5      $
��Bold"�6/   $��Center=�6A   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ allDealService��5      $��1��6+   $��0q�68      
IsReadOnly .    SelectionMode$ Single=�6^      GridLinesVisibility$
 None=�6u     rowStyle   RowStyle# [ 6�     	cellStyle	   	CellStyle#	 [ 6�   
   AutoGenerateColumns
 .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Наименование��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Service.Title+  5      $ Описание��6%    67   �� *Service.Description+  5      $ Количество��6%    69   �� *Number+  5      $ Цена��6%    63   �� *Service.Price.Number+  5      $ Скидка��6%     gray-700   
Foreground# �  6v    65   �� *Service.Discount.Number+ �� StringFormat$
 {0}%��6v     5      $ 
Сумма��6%    64   �� *Sum+5      � 5   
   $��Right=�6   $��Center=�60   .+�5       �� -   5        #��[  5       $��Добавить��6<   
��� � �
�������$	��150��6u   $��0 0 20 0q�6�   6�   �� 5!      -   5        #��[  5!      $��Удалить��6<     red-200#���  6N   
�������$	��150��6�   6�   5"      � 5$   
   $��Center=�6   $��Center=�61   $��0 0 50 0q�6L   .+�5%      �� $��Сумма: ��6   $
��Bold"�6'   $��25(�69   �� 5&      -   5        $	 sum��5&      $��0��6%   $
��Bold"�6.   $��25(�6@   #���  6N   5'      5(      5)      