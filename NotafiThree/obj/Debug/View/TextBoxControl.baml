   M S B A M L   `   `   `  ����F  BNotafiThree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:NotafiThree.ViewNotafiThree.View  5      %    NotafiThree.View.TextBoxControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:NotafiThree.View     5      -   5          >�Name$
  root��5   7   .��5	      ��    bord#��[  6   $��60��6+    J� Effect 5
   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         Opacity$	 0.5Q�6      ShadowDepth$ 1Q�6-      
BlurRadius$ 10Q�6=   ._�5   
   �  � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      ��6#   ��  �� ElementName$
 root�� �� Path$ 
WidthImage�.+�5      �� -   5         ��Name$ login��5      $	��5 0q�6�   $��25(�6�   $��50��6  
������   red-200#���  6>  	 �� 
IsReadOnly	 6%   �� $
 root��$ 
IsReadOnly�
 �� 	MaxLength
 6^   �� $
 root��$ 	MaxLength���6�   �� $
 root��$
 Text���6�   �� $
 root��$ 	Thickness�6f  �� 5       �� CornerRadius$	 100��6   $��1��6(   $��Center=�68   $��Center=�6S   ��6p   �� $
 root��$ 
WidthImage���6�   �� $
 root��$ 
WidthImage���5      �� 5       j� Stretch$
 Fill=�6!    �� ImageSource 60   �� $
 root��$ ImageSource�5      �� 5      -   5         ��Name$ 	placehold��5      $��Center=�6�    J� Opacity$	 0.5Q�6�   ��6+   �� $
 root��$ Placeholder���6_   �� $ login��$ FontSize�6�   �� 5      -   5         ��Name$ btnVis��5       � Cursor$ IBeam��6%     DefaultButton#��[ 65   
������ 6u   5      5      5      