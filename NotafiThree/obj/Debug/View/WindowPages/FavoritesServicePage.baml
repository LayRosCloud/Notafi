   M S B A M L   `   `   `  ����F  BNotafiThree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:NotafiThree.View.WindowPagesNotafiThree.View.WindowPages  5      7    1NotafiThree.View.WindowPages.FavoritesServicePage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:NotafiThree.View.WindowPages     5        N� Title$  FavoritesServicePage��5	      .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      $	��100 �6   .+�5   
   �� -   5         ��Name$ lvFavoriteServices��5      $��Stretch=�6/   $��Stretch=�6M   $��0q�6r   
������ ��5      �� 5      .R�5      � $��Stretch=�6   .+�5      � .+�5      �� ��6$   �� �� 5      $��5 0 0 0q�6)   .+�5   "   �� $��20(�6K   $
��Bold"�6Y   ��6,   �� *Service.Title+6Y   �� 5   "    J� Opacity$	 0.7Q�6Q   ��6,   �� *Service.Description+6Q   5      �� 5      $��5 0 0 0q�6)   .+�5   "   �� $��Strikethrough{�6u   $��Right=�6�   ��6,   �� *Service.Price.Number+y�6R   �� *VisibleDisc+6�   �� 5   "   $
��Wrap=�6W   $��Right=�6k   $��14(�6�      red-200#���   6�   ��6,   �� *Service.PriceWithDiscount+6�   5      5      �� 5       -   5          DefaultButton#��[ 5    !   $��Right=�6H   $��0 0 50 0q�6d   ��5!      �� 5"   "   $��/Res/Images/musorka.png��6(   5$      5%      5&      5(      �� 5)   
   -   5         ��Name$ backBtn��5)      #��[ 6"   $	��Top=�6I   $��Right=�6a   $��50��6}   6�   �� 5+   
   $��1��6   
������� �� CornerRadius$ 10��61    J� Effect 5,      3  -System.Windows.Media.Effects.DropShadowEffect  5-         
BlurRadius$ 20Q�6#      ShadowDepth$ 1Q�63   	   Opacity$		 0.5Q�6C   5/      � 50   
   $��1��6   $��Center=�6!   $��Right=�6<   $��0 0 30 0q�6X   .+�51      �� $��Сумма услуг: ��6   $��25(�6-   $
��Bold"�6;   �� 52      -   5        
 ��Name$
 tbSum��52      $��0 ��6'   $��25(�61   #���   6?   $
��Bold"�6f   53      54      55      