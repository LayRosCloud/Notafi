   M S B A M L   `   `   `  ����F  BNotafiThree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:NotafiThree.View.WindowPagesNotafiThree.View.WindowPages  5      3clr-namespace:NotafiThree.ViewNotafiThree.View  5      5    /NotafiThree.View.WindowPages.DealControllerPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:NotafiThree.View.WindowPages     5      -uiclr-namespace:NotafiThree.View     5        N� Title$  DealControllerPage��5
      .��5      �  � Cursor$  ��6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgDeals��5      $��0q�6$      headerStyle   ColumnHeaderStyle# [  68      SelectionMode$ Single=�6i   $��1��6�     rowStyle   RowStyle# [ 6�      AutoGenerateColumns .     GridLinesVisibility$
 None=�6�   	   
IsReadOnly	 .   	cellStyle
   	CellStyle#
 [ 6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Deal.Person.LastName+  5      $ Имя��6%    62   �� *Deal.Person.FirstName+  5      $ Отчество��6%    67   �� *Deal.Person.Patronymic+  5      $! Серия паспорта��6%    6=   �� *Deal.Person.Series+  5      $! Номер паспорта��6%    6=   �� *Deal.Person.NumberOfPassport+  5      $# Дата заключения��6%    6>   �� *	Deal.Date+ �� StringFormat$ {0:d}��  5      $ Статус��6%    65   �� *Result.Name+4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� -   5          DefaultButton#���  5   )   
���  ����5   &   �� 5    *   $��/Res/Images/musorka.png��60   $��20��6Q   5"   #   �� 5#   "   -   5        
�������#��[ 5#   <     gray-700#���  6c   $��5 0 0 0q�6�   ��5$   &   �� 5%   *   $��/Res/Images/more.png��60   $��20��6N   5'   #   5(      5)      5+      5-      �� 5/   
   -   5        
������ $��0q�5/   *   $��1��6>   $��Bottom=�6K   $��Right=�6f   $��10q�6�   .��50      ��   red-200#���  6    �� CornerRadius$ 20��6<   $��50��6N   $��50��6Y    J� Effect 51      3  -System.Windows.Media.Effects.DropShadowEffect  52         
BlurRadius$ 20Q�6'      ShadowDepth$ 1Q�67      Opacity$	 0.5Q�6G   ._�54      �� $��+��6   $��Center=�6%   $��Center=�6@   $��35(�6]   $
��Bold"�6k     	white-200#���  6}   55      56      � 58   
   .+�59      %   NotafiThree.View.TextBoxControl  -   5          Name$ finder��59       $	��200��60      	Thickness$ 0 0 3 0q�6<      
WidthImage$ 30��6P      ImageSource$ /Res/Images/loop.png��6`   �� 5:      $��Center=�6   $	��С ��63   $
��Bold"�6=   (  "System.Windows.Controls.DatePicker  5;      -   5          Name$ 
beforeDate��5;      $��Center=�6-   $	��100��6H      SelectedDate$ 10/10/10X�6T   �� 5<      $��Center=�6   $�� По ��63   $
��Bold"�6?     5=      -   5        $ 	afterDate��5=      $��Center=�6,   $	��100��6G   $ 10/30/23X�6S   �� 5>      -   5        #��[ 5>      $��
Найти��6<   6L   5?      � 5@   
   $��Right=�6   .+�5A      �  � Orientation$ Vertical=�6   $��30��6/   .+�5B      �� -	   5        $��0q�5B      $��20��6-   $��20��69   
���  ��6U   �� 5C      -
   5        $��0q�5C      $��20��6-   $��20��69   
��� ���6X   �� 5D      -   5        $��0q�5D      $��20��6-   $��20��69   
��� � �6W   5E      �� 5F      -   5        #��[ 5F      $	��100��6=   $��Печать��6I   6Z   �� 5G      -   5        #��[ 5G      $	��100��6=   $��Excel��6I   6Y   5H      5I      5J      