   M S B A M L   `   `   `  ����F  BNotafiThree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:NotafiThree.View.AuthNotafiThree.View.Auth  5      3clr-namespace:NotafiThree.ViewNotafiThree.View  5      $    NotafiThree.View.Auth.AuthPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:NotafiThree.View.Auth     5      /myUIclr-namespace:NotafiThree.View     5        N� Title$  AuthPage��5
      .��5      �� $��Center=�6   $
��10 0q�6,   .+�5   
   �� -   5         ��Name$ errorBorder��5      $y�	Collapsed=�6&    �� CornerRadius$ 5��6=      red-200#���   6N   $��75��6u    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6#      Opacity$	 0.5Q�63      ShadowDepth$ 1Q�6A   ._�5      �� .+�5      �� 
�������$��Ошибка!��6/   $
��Bold"�6>   $��20(�6P   �� 5      -   5         ��Name$ 	errorText��5      
������� J� Opacity$	 0.7Q�6B   $��13(�6P   $
��Wrap=�6^   5      5      �� 5   
    
 logTxt#��[ 6   $!��Введите логин: ��60   %   NotafiThree.View.TextBoxControl  5   
   -   5        	  Name$	 login��5      
   Placeholder$
 Ваш логин*��6-      	Thickness$ 0 0 0 3q�6F      ImageSource$" /Res/Images/profileImage.png��6Z   �� 5   
   -   5         ��Name$ passContainer��5      $y�	Collapsed=�6,   .+�5      �� #��[ 6   $#��Введите пароль: ��64   � 5      .+�5      ��   bord#��[ 6   $��2��5      $��60��5       5        5      $	 0.5Q�6+   $ 1Q�5    +   $ 10Q�5!   +   5#      G� 5$      -   5         G�Name$
 pass��5$       G� 	MaxLength$ 30��5%      $	��5 0q�5&      $��25(�5'      $��0 0 0 3q�5(      $��50��5)      
������ #���   5+      5,      5-      � 5.   
   $��Right=�6   .+�5/      �� -   5         ��Name$
 back��5/        DefaultButton#��[ 50      $��
Назад��51      $��0 15 0 0q�52      $	��200��53      $y�	Collapsed=�54      55      �� 56      -   5        $ enter��56      #��[ 57      $��
Далее��58      $��0 15 0 0q�59      $	��200��5:      5;      5<      �� 5=   
   -   5        
������ $��0q�5>      #���   5?      $/��)Вы новый пользователь?��5@      $
��Bold"�5A      $
��Left=�5B      5C      5D      5E      