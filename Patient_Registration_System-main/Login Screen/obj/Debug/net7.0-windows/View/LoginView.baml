   M S B A M L   `   `   `  ����G  CLogin_Screen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Student_Registration_System.View Student_Registration_System.View  5   	   0    *Student_Registration_System.View.LoginView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Student_Registration_System.View     5   	   -   5          � Title$  	LoginView��5   	   $	��550��6   $	��800��6(    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      ��  �� CornerRadius$ 75��6   ��5   
   �� 5       �� ImageSource$" /Images/Background_image.jpg��6   ._�5   
   �� $ 50��6   $��1q�6#    J� Opacity$
 0.75Q�67   ��5      �� 5       �� 
StartPoint$	 0,0&�6&   	 �� EndPoint$		 1,1&�67   .��5      � 
 � Color$
 Azure��6#    � Offset$ 0Q�61   � 5      $
 Black��6#   $
 0.75Q�61   � 5      $
 DarkSlateBlue��6#   $ 1Q�69   5      ��5      �� 5      $	 0,1&�6&   $		 1,0&�67   .��5      � $
 Black��6#   $ 0Q�61   � 5      $
 Black��6#   $
 0.80Q�61   5!      ._�5#      �  � RowDefinitions 5$      �� 5%      $��20 �6$   .+�5)      �  � ColumnDefinitions 5*      �� 5+      �� 5,      $��25 �6+   �� 5-      $��25 �6+   �� 5.      $��5 �6+   .+�52      �� -   5         ��Name$ btnMinimize��52      
���   �$��0q�53   1   $��-��6E   
�������$��16(�6d   $��
Montserrat)�6r    � Cursor$
 Hand��54      $��1��6+   $��22��6U   $��Center=�6a   �� 55      -   5        $ btnClose��55      
���  ��$��0q�56   .   $��x��6B   
�������$��12(�6a   $��
Montserrat)�6o   $
 Hand��57      $��2��6+   6;   58      �� 5:      $	��250��6    �� Orientation$ Vertical=�6)   $��274,35,274,-464q�6@   .+�5;      �� $��/Images/Symbol.png��6   $��86��68   $��77��6C    J� RenderTransformOrigin$ 0.892,3.012&�6O   �� 5<      $��NEO HOSPITAL��6    
�������$��25(�6G   $
��Bold"�6U   $��
Montserrat)�6g   $��Center=�6   $��0,20,0,0q�6�   �� 5=      $��
Username :��6    
�������$��18(�6E   $��Medium"�6S   $��
Montserrat)�6g   $��0,35,0,0q�6   �� 5@      -   5         ��Name$ txtUser��5@      $��18(�6/   $��Medium"�6=   
������ $��
Montserrat)�6j   
������� �� 
CaretBrush
 �����
�������$��0 0 0 2q�5A   5   $��28��6O   $��Center=�6[   $��0 5 0 0q�6v   $��0 0 0 0q�6�   .��6�   5C      �� 5G      $��
Password :��6    
�������$��18(�6E   $��Medium"�6S   $��
Montserrat)�6g   $��0,15,0,0q�6   G� 5H      -   5         G�Name$ txtPassword��5H   "   $��18(�67   $��Medium"�6E   
������ $��
Montserrat)�6r   
������� G� 
CaretBrush
 �����
�������$��0,0,0,2q�5I   K   $��28��6e   $��0,5,0,0q�6q   $	��250��6�   5K      �� 5L      $��Role:��6    
�������$��18(�6@   $��Medium"�6N   $��
Montserrat)�6b   $��0,15,0,0q�6z   �� 5M      -   5         ��Name$ roleListBox��5M       $��0,10,0,0q�65   .@�5N      �� $��Select a role��6'   $��14(�6@   6P   �� 5O      $��Admin��6'   $��14(�68   6H   �� 5P      $��Doctor��6'   $��14(�68   6H   5Q      �� 5R      -   5        $ btnLogin��5R      $��0q�5S      $��LOG IN��6/   
���   �$��18(�6S   $��
Montserrat)�6a   $
 Hand��5T      $��2��6+   $��0,40,0,0q�6;   $
��Bold"�6d   ��5U      �� 5V       �� 
TargetType" ��6$   .�5W   "   ��  �� Property � �� �� Value
 �����6?    �� Triggers 5X   "   P� 5Y   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5Z   *   ��  � ��
 �� ��6G   5\   '   5^      ��5`      �� 5a       �� 
TargetType" ��6.   .R�5b   "   �� $	��150��6)   $��40��65   $ 20��6A   #��z��6S   ._�5c   &   �� $��Center=�67   $��Center=�6R   5d   #   5e      5g      5i      � 5j      � 5k      $
��Left=�6   $	��365��62   $��227,119,0,0q�6?   $	��Top=�6T   $	��332��6l   �� 5l      $
��Left=�6   $��34��68   $��227,167,0,0q�6D   $	��Top=�6Y   $	��166��6q   �� 5m      $
��Left=�6   $	��384��68   $��227,119,0,0q�6E   $	��Top=�6Z   $	��332��6r    � 5n      $��Frame��6   $
��Left=�6(   $	��389��6C   $��227,114,0,0q�6P   $	��Top=�6e   $	��354��6}    � 5o      $��Frame��6   $
��Left=�6(   $	��184��6C   $��113,149,0,0q�6P   $	��Top=�6e   $	��114��6}   5q      5r      5s      5w      