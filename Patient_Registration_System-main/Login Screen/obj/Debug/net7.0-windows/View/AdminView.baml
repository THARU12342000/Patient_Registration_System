   M S B A M L   `   `   `  ����G  CLogin_Screen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Student_Registration_System.View Student_Registration_System.View  5   	   0    *Student_Registration_System.View.AdminView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   
   :local.clr-namespace:Student_Registration_System.View  5   	     � Title$  	AdminView��5	   	   $	��650��6   $
��1100��6(    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�6.   
������  � AllowsTransparency$
 True��6Z   .��5      �� -   5         �� CornerRadius$	 100��5      ._�5   
   �� $ 5��6   $��1q�6"    J� Opacity$
 0.95Q�66   ._�5      �  � ColumnDefinitions 5      �� 5      $	��350 �6'   �� 5      $��* �6'   .+�5      �� 
����  � �� Padding$ 10q�6/   $ 	25 0 0 25��6<   $��	0,0,54,44q�6U   ._�5      �� $	��Top=�6!   $	��740��69   .+�5      �� $��Doctor Details��6$    �� TextAlignment$ Center=�6:   $
��Bold"�6Q   $��30(�6c   
�������$��71��6�   $��	0 30 0 40q�6�   �� 5      $��/Images/doctor.png��6    $	��160��6<   $	��160��6H   $��
0 -20 0 40q�6U   �� 5      $��Welcome to the NEO !��6$   $ Center=�6@   $��SemiBold"�6X   $��22(�6n   
�������$��49��6�   $��	0 10 0 40q�6�   5      5      �� 5      5!      �� 5"      -   5        $ 20q�5"      
����ح�$ 	0 25 25 0��6=   $��296,0,223,44q�6s   $��2��6�   ._�5$      �� -   5        	 ��Name$	 InformationList��5$      $��-20,56,-10,54q�68   
����ح�$��12(�6f   $��SemiBold"�6t   
 �� View
 5%      �� 5&      ! �� ColumnHeaderContainerStyle 5'   "   �� 5(   &    �� 
TargetType" ��6,   .�5)   *   ��  �� Property � �� �� Value$ 16(�6E   5+   '   .P�5.   "   �� $��Id��61    �� Width$ 30��6=    �� DisplayMemberBinding 6H   �� *Id+�� 5/   "   $��
First Name��61   $	 150��6E    6Q   �� *FName+�� 50   "   $��	Last Name��61   $	 150��6D    6P   �� *LName+�� 51   "   $��Gender��61   $ 80��6A    6L   �� *gender+�� 52   "   $��Date of Birth��61   $	 120��6H    6T   �� *dob+�� 53   "   $	��Age��61   $ 60��6>    6I   �� *age+�� 54   "   $��Address��61   $	 200��6B    6N   �� *	address+�� 55   "   $��Email��61   $	 150��6@    6L   �� *email+�� 56   "   $��
Mobile No.��61   $	 120��6E    6Q   �� *mob+�� 59   "   $��Password��61   $	 120��6C    �� CellTemplate 5:   &   �� 5;   *   .R�5<   .   �� $��********��68   5=   +   5?   #   5B      ��5D      �� 5E      " ��6$   .�5F   "   ��  � ��$ 16(�6=   5H      5K      5M      �� 5O      -   5         ��Name$ 	createbtn��5O      $��+ Add Doctor��6,   $��14(�6C   $
��Bold"�6Q   $
��Left=�6d   $	��Top=�6   $	��206��6�      
buttonsrow#��[  6�   
�������
����  �$��
301,10,0,0q�6  $��1��6  �� 5Q      -   5        $ 	updatebtn��5Q      $��Update��6,   $��14(�6=   $
��Bold"�6K   $��
Montserrat)�6]   $
��Left=�6u   $��374,546,0,0q�6�   $	��Top=�6�   $	��130��6�   #��[  6�   $��1��6  
�������
����  � J� RenderTransformOrigin$ 
1.364,0.62&�6@  �� 5R      -   5        $ dltebtn��5R      $��Delete��6*   $��14(�6;   $
��Bold"�6I   $
��Left=�6\   $��
10,546,0,0q�6w   $	��Top=�6�   $	��110��6�   #��[  6�   $��1��6�   
�������
����  �6  �� 5S      -   5        $ 	logoutbtn��5S      $��
]-> Logout��6,   $��14(�6A   $
��Bold"�6O   $��Center=�6a   $��-45,540,0,0q�6~   $	��Top=�6�   $	��202��6�   #��[  6�   
�������6�   5X      5Y      5[      5\      