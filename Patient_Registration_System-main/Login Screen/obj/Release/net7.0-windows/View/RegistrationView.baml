   M S B A M L   `   `   `  ����   Login_Screen7    1Student_Registration_System.View.RegistrationView   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/    � Title$  RegistrationView��$	��650��$
��1000��
������  � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � AllowsTransparency$
 True��.���  � ColumnDefinitions �� $	��350 ��� $��* �.+��� 
����  � �� Padding$ 10q� �� CornerRadius$ 	25 0 0 25��._��� $��Center=�.+���  �� TextAlignment$ Center=�$
��Bold"�$��35(�
��������� $�Patient���� �� $�Registration Form���� $��/Images/patient.png��$	��160��$	��160��$��	0 20 0 40q��� $ ��Let's fill your details...��$ Center=�$��SemiBold"�$��22(�
��������� -   $��1��$ 20q�
����ح�$ 	0 25 25 0���� $��1��$
��Left=�$��	42,48,0,0q�$
��Wrap=�$��
First Name��$	��Top=�   text#��[  $��16(��� $��1��$
��Left=�$��	42,98,0,0q�$
��Wrap=�$��	Last Name��$	��Top=�#��[  $��16(��� $��1��$
��Left=�$��
42,148,0,0q�$
��Wrap=�$��Gender��$	��Top=�#��[  $��16(��� $��1��$
��Left=�$��
42,198,0,0q�$
��Wrap=�$��Date of Birth��$	��Top=�#��[  $��16(��� $��1��$
��Left=�$��
42,248,0,0q�$
��Wrap=�$	��Age��$	��Top=�#��[  $��16(��� $��1��$
��Left=�$��
42,298,0,0q�$
��Wrap=�$��Address��$	��Top=�#��[  $��16(��� $��1��$��
45,389,0,0q�$
��Wrap=�$��Email��$	��Top=�#��[  $��16(��� $��1��$��
42,437,0,0q�$
��Wrap=�$��
Mobile No.��$	��Top=�#��[  $��16(�G� -    G�Name$ teacherPassBox��$��1��$
��Left=�$��205,502,0,0q�$	��Top=�$	��230��$��14(�$��Medium"�
��������� $��1��.+�	� -   	 	�Name$	 female��$��1��$��Female��$��14(�$
��Bold"�$
��Left=�$��205,156,0,0q�$	��Top=�	� -   $
	 male��$��1��$
��Male��$��14(�$
��Bold"�$��Center=�$��
30,-16 0,0q�$	��Top=��� -   
 ��Name$
 fnametxt��$��1��$
��Left=�$��
205,48,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��250��
���   �$��14(�$��Medium"�
����������� *FName+�� -   $
 lnametxt��$��1��$
��Left=�$��
205,98,0,0q�$
 Wrap=�$	��Top=�$	��250��
���   �$��14(�$��Medium"�
����������� *LName+(  "System.Windows.Controls.DatePicker  -     Name$ dobDatePicker��$��1��$
��Left=�$��205,198,0,0q�$	��Top=�$	��120��
���   �$��14(�$��Medium"�
�������   SelectedDate �� *dob+�� -   $
 agetxt��$��1��$
��Left=�$��205,248,0,0q�$
 Wrap=�$	��Top=�$	��100��
���   �$��14(�$��Medium"�
����������� *age+�� -	   $
 
addresstxt��$��1��$
��Left=�$��	205,0,0,0q�$
 Wrap=�$	��250��$��56��
���   �$��14(�$��Medium"�
����������� *	address+�� -
   $
 emaitxt��$��1��$
��Left=�$��205,379,0,0q�$
 Wrap=�$	��Top=�$	��230��
���   �$��14(�$��Medium"�
����������� *email+�� -   $
 mobtxt��$��1��$
��Left=�$��205,438,0,0q�$
 Wrap=�$	��Top=�$	��150��
���   �$��14(�$��Medium"�
����������� *mob+�� $��1��$��
44,502,0,0q�$
��Wrap=�$��	Password.��$	��Top=�#��[  $��16(��� -    ��Name$ teacherImage��$��1��$	��120��$	��100��$��
40,531,0,0q�$
��Left=�$	��Top=�$��UniformToFill=��� -    ��Name$ chooseImageButton��$��Choose Image��$��16(�$
��Bold"�$
��Left=�$��205,556,0,0q�$	��Top=�$	��150��  
buttonMain#��[ 
���   �
�������$��1��$��28���� -   $ savebtn��$��1��$
��Save��$��20(�$
��Bold"�$
��Left=�$��517,578,0,0q�$	��Top=� J� RenderTransformOrigin$ -0.227,2.48&�$��47��$	��102��  
buttonsrow#��[ 
�������
����  ��� -   $ 	cancelbtn��$��1��$��Cancel��$��20(�$
��Bold"�$
��Left=�$��377,578,0,0q�$	��Top=�$ -0.227,2.48&�$��48��$	��102��#��[ 
���   �
�������