   M S B A M L   `   `   `  ����F  BNotafiThree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:NotafiThree.View.WindowPagesNotafiThree.View.WindowPages  5      3clr-namespace:NotafiThree.ViewNotafiThree.View  5      /    )NotafiThree.View.WindowPages.ServicesPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:NotafiThree.View.WindowPages     5      /myUIclr-namespace:NotafiThree.View     5        N� Title$  ServicesPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ listServices��5      $��1��6)   $��Disabled=�66   
������ ��5      �� 5      .R�5      � $	��150��6   $	��200��6'    5      �� 5      $	��100 �6,   �� 5      $��1* �6,   .+�5      �� 
������� �� CornerRadius$ 10��64   $��2��6F    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   "      
BlurRadius$ 10Q�63      Opacity$	 0.5Q�6C      ShadowDepth$ 2Q�6Q   5      �� 5      $	��100��6!   $	��100��6-   $ 10��6:   ��5       �� 5!   "    j� Stretch$
 Fill=�6-   	 �� ImageSource	 6<   �� *
ImageUri+5#      �� 5%      -   5           DefaultButton#��[  5%   !   $��15 0 0 0q�6H   $��Right=�6Z   $	��Top=�6v   ��5&      �� 5'   "   $��/Res/Images/heart.png��6(   5)      � 5+      
 � Orientation$
 Vertical=�6$   $��1��6;   .+�5,      �� $
��Wrap=�6?   $��15(�6S    �� TextAlignment$ Center=�6a   $
��Bold"�6x   ��6(   �� *Title+6x   �� 5-      $
��Wrap=�6E    J� Opacity$	 0.9Q�6Y   $��5q�6g   $��Center=�6r   ��6(   �� *Description+6r   �� 5.      $��Strikethrough{�6i   $��Right=�6�   ��6(   �� *Price.Number+y�6F   �� *VisibleDisc+6�   �� 5/      $
��Wrap=�6K   $��Right=�6_   $��14(�6{     red-200#���  6�   ��6(   �� *PriceWithDiscount+6�   50      51      52      ��54      �� 55      .R�56      � $
 
Horizontal=�6    $��Center=�69   57      59      �� 5;   
   
�������$ 5��6$    5<        5=      $ 10Q�6#   $	 0.5Q�63   $ 2Q�6A   5?      �� 5A   
   $��Center=�6    �� Orientation$ 
Horizontal=�60   .+�5B      %   NotafiThree.View.TextBoxControl  -   5          Name$ finder��5B   "   %   NotafiThree.View.TextBoxControl   TextChanged$ finder_TextChanged��6�   $	��250��62      Placeholder$ поиск...��6>      	Thickness$ 0 0 3 0q�6U      ImageSource$ /Res/Images/loop.png��6i      
WidthImage$ 30��6�   6�   �� 5C      -   5        #��[  5C      $��15 0 0 0q�6<   ��5D      �� 5E      -   5         ��Name$ orderby��5E      $��/Res/Images/generic.png��6-   $	��5 0q�6N   5G      �� 5H      -   5         ��Name$ countWrites��5H      $��Center=�6-   $
��Bold"�6H   5I      �� 5J   
   -   5        #��[  5J      $��15 0 0 0q�68   $��Right=�6J   ��5K      �� 5L      $��/Res/Images/heart.png��6   $	��5 0q�67   $��30��6D   5N      �� 5O   
   -   5         ��Name$ viewChanged��5O      $y�	Collapsed=�6&   $��1��6=   $��10 20q�6J   $
��Left=�6Y   $	��Top=�6t   #��[  6�   $��Показать��6�     	wheat-200#���  6�   $	��200��6�   6�   5P      5Q      