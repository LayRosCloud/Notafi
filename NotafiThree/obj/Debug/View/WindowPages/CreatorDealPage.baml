   M S B A M L   `   `   `  ����F  BNotafiThree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:NotafiThree.View.WindowPagesNotafiThree.View.WindowPages  5      3clr-namespace:NotafiThree.ViewNotafiThree.View  5      2    ,NotafiThree.View.WindowPages.CreatorDealPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:NotafiThree.View.WindowPages     5      -uiclr-namespace:NotafiThree.View     5        N� Title$  CreatorDealPage��5
      .��5      � .+�5   
   �� $��Center=�6   .+�5      � $��40��6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��2��6   
������� �� CornerRadius$ 5��6@    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 1Q�6+      
BlurRadius$ 20Q�6;   5      �� 5      $'��!Выберите клиента: ��6   $
��Bold"�66   $��Center=�6H   �� 5      -   5         ��Name$ 
allClients��5       �� 
IsEditable .  �� DisplayMemberPath$ FullName��6A   $��Center=�6^   	 �� SelectedIndex$	 0��6�   $��0q�6�   $��1��6�   6�   5      �� 5      -   5        
 ��Name$
 fullDataOfClient��5      $
��10 0q�62   � 5       5      �� 5      �� 5       � RowDefinitions 5!      �� 5"      �� 5#      .+�5%      �� $��2��6   $��2��6-   
�������$ 5��6Q    5&        5'      $ 1Q�6+   $ 20Q�6;      Opacity$	 0.5Q�6K   5)      �� 5*      $C��=Выберите дату заключения сделки: ��6   $
��Bold"�6E   (  "System.Windows.Controls.DatePicker  5+      -   5          Name$ dpDate��5+      $��1��6-   $��0q�6=   
�������$��0 0 0 5q�6d   �� 5,      $��1��6   $-��'Введите коммисионные��6)   $
��Bold"�6E   $��Center=�6W   %   NotafiThree.View.TextBoxControl  5-      -   5          Name$ commisionValue��5-   $   $��1��6<   $��1��6L   $��30��6Y   5.      5/      �� 50   
   -   5        $��Добавить��50         DefaultButton#��[  6$   $��0 5 0 0q�6K   $��Bottom=�6o   51      52      