   M S B A M L   `   `   `  ����G  CLogin_Screen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Student_Registration_System.View Student_Registration_System.View  5   	   4    .Student_Registration_System.View.TeacherOption   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   :local.clr-namespace:Student_Registration_System.View  5   	   -   5          �Name$  	AppWindow��5	   	    � Title$ TeacherOption��5
   	   $	��650��6   $
��1000��6,    � WindowStartupLocation$ CenterScreen=�69    � WindowStyle$
 None=�6^    � AllowsTransparency$
 True��6q   
������ .��5      � .+�5   
   �  � ColumnDefinitions 5      �� 5      $	��350 �6#   �� 5      $��* �6#   .+�5      �� 
����  � �� Padding$ 10q�6+    �� CornerRadius$ 
25 10 0 25��68   $	��574��6R   $	��Top=�6_   $��0,0,64,0q�6w   ._�5      �� $	��Top=�6   $	��740��65   .+�5      �� $��Patients Details��6     �� TextAlignment$ Center=�68   $
��Bold"�6O   $��25(�6a   
�������$��71��6�   $��	0 65 0 40q�6�   �� 5      $��/Images/patient.png��6   $	��160��69   $	��160��6E   $��
0 -30 0 40q�6R   �� 5      $��Welcome to the NEO !��6    $ Center=�6<   $��SemiBold"�6S   $��22(�6i   
�������6w   �� 5      -   5        	 ��Name$	 registerbtn��5      $��
]-> Logout��62   $��	0,120,0,0q�6J   $��14(�6]   $
��Bold"�6k   $	��202��6}      
buttonsrow#��[  6�   
�������6�   5      5      �� 5      5      �� 5!      -   5        $ 20q�5!      
����ح�$ 	0 25 25 0��69   $��
0,0,126,76q�6o   $��Right=�6�   $	��588��6�   $��2��6�   ._�5"      �� -   5        
 ��Name$
 InformationList��5"      $	��384��64   $��Center=�6A   
����ح�
����  �$��15(�6�   $��SemiBold"�6�   $��Center=�6�   $	��568��6�    �� View 5#      �� 5$      ! �� ColumnHeaderContainerStyle 5%      �� 5&   "    �� 
TargetType" ��6(   .�5'   &   ��  �� Property � �� �� Value$ 16(�6A   5)   #   .P�5,      �� $��Id��6-    �� Width$ 38��69    �� DisplayMemberBinding 6D   �� *Id+�� 5-      $��
First Name��6-   $	 100��6A    6M   �� *FName+�� 5.      $��	Last Name��6-   $	 100��6@    6L   �� *LName+�� 5/      $��Gender��6-   $ 70��6=    6H   �� *gender+�� 50      $��Date of Birth��6-   $	 120��6D    6P   �� *dob+�� 51      $	��Age��6-   $ 50��6:    6E   �� *age+�� 52      $��Address��6-   $	 180��6>    6J   �� *	address+�� 53      $��Email��6-   $	 160��6<    6H   �� *email+�� 54      $��Mob No.��6-   $	 170��6>    6J   �� *mob+�� 55      $��Password��6-   $	 120��6?    �� CellTemplate 56      �� 57   &   .R�58   *   �� $��********��64   59   '   5;      5=      ��5?      �� 5@      " ��6    .�5A      ��  � ��$ 16(�69   5C      5F      5I      �� 5J      -   5        $	 	updatebtn��5J   %   $��1��6   $��Update��68   $��16(�6I   $
��Bold"�6W   $
��Left=�6i   $��
342,0,0,94q�6�   $��Bottom=�6�   $	��160��6�   $��50��6�   #��[  6�   
�������
����  �6  �� 5K      -   5        $	 	deletebtn��5K      $��Delete��6(   $��16(�69   $
��Bold"�6G   $
��Left=�6Y   $��312,506,0,0q�6t   $	��Top=�6�   $	��160��6�   $��50��6�   #��[  6�   
�������
����  � J� RenderTransformOrigin$ 
2.231,0.66&�6  $��2��6A  �� 5L      -   5        $	 	resultbtn��5L   %   $��1��6   $��+ Add Patient��68   $��16(�6P   $
��Bold"�6^   $
��Left=�6p   $��305,0,0,569q�6�   $��Bottom=�6�   $	��200��6�   $��50��6�   #��[  6�   
�������
����  �$ 0.466,-0.338&�6:  z�5M      V� 5N      .~�5O      �� �� 5P       �� AngleX$ 0.042Q�6(   �� 5Q       �� Angle$
 0.59Q�6*   T� 5R       T� X$ 0.381Q�6-    T� Y$ -0.069Q�67   5S      5U      5[      5\      5]      