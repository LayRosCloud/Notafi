   M S B A M L   `   `   `  ����F  BNotafiThree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:NotafiThree.View.WindowPagesNotafiThree.View.WindowPages  5      :    4NotafiThree.View.WindowPages.AddingServiceOnDealPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:NotafiThree.View.WindowPages     5        N� Title$  AddingServiceOnDealPage��5	      .��5      �� $��Center=�6   $��Center=�6.   $	��400��6I   .+�5   
   �� $%��Выберите услугу: ��6   $��16(�6-   $
��bold"�6;   �� 5   
   -   5         ��Name$ services��5      $��0q�6%    �� DisplayMemberPath$ Title��69    �� SelectedIndex$ 0��6S   6e   � 5   
    � ColumnDefinitions 5      �� 5      �� 5       � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� $��0��6   $��0��6%   $
��Bold"�65   $��Название: ��6G   �� 5      -   5         ��Name$ title��5      $��0��6'   $��1��64   $
��Bold"�6D   
�������6V   �� 5      $��1��6   $��0��6%   $
��Bold"�65   $��Описание: ��6G   �� 5      -   5        $ description��5      $��1��6-   $��1��6:   $�� ��6J   $
��Wrap=�6R   
�������6f   �� 5       $��2��6   $��0��6%   $
��Bold"�65   $��
Цена: ��6G   �� 5!      -   5        $ price��5!      $��2��6'   $��1��64   $�� ��6D   $
��Wrap=�6L   
�������6`   �� 5#      $��3��6   $��0��6%   $
��Bold"�65   $��Скидка: ��6G   �� 5$      -   5        $ discount��5$      $��3��6*   $��1��67   $�� ��6G   $
��Wrap=�6O   
�������6c   �� 5&      $��4��6   $��0��6%   $
��Bold"�65   $!��Тип документа: ��6G   �� 5'      -   5        $ typeDoc��5'      $��4��6)   $��1��66   $�� ��6F   $
��Wrap=�6N   
�������6b   5(      � 5)   
   $��0 10 0 0q�6    5*      �� 5+      �� 5,       5.      �� 5/      .+�52      �� $��0��6   $��0��6%   $
��Bold"�65   $+��%Введите количество: ��6G   �� 53      -   5         ��Name$ number��53      $��0��6&   $��1��63   $��0��6C    �� TextWrapping$
 Wrap=�6L   
�������$��0q�6t   54      �� 55   
   -   5           DefaultButton#��[  55      $��Добавить��68   $��0 20 0 0q�6K   6]   57      58      