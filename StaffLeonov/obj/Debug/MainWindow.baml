   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   
   F BStaffLeonov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:StaffLeonovStaffLeonov 5   	      StaffLeonov.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   
   +localclr-namespace:StaffLeonov     5   	   -   5        $��
mainWindow��5
   	     � Title$  
MainWindow��5	   	   $	��389��5
       � 	Resources 5       �� DataType  StaffLeonov.Department �� Orientation��%�   (��       5      *, +)�� 6
   "  6   .R�5      �� $ 
Horizontal=�6   .+�5      �� ��6   �� *DepartmentName+�� 5      $!�� Руководитель -��6   �� 5      ��6   �� *DepartmentHead+5      5      5      .��5      � $��0,0,2,-3q�6    J� RenderTransformOrigin$ 0.291,0.495&�6    � ColumnDefinitions 5   
   �� 5      $
��105* �6   �� 5      $
��274* �6   .+�5   
   �� -   5         ��Name$ lv��5      $��10,32,10,10q�5      $ 1.007,0.501&�5      $��2��6C    �� View 5      �� 5      .P�5      ��  �� Width$ 50��6&   $��Id��5   &   	 �� DisplayMemberBinding	 5    &   �� *Number+�� 5!      $	 100��6&   $��Фамилия��62   	 6C   �� *
LastName+�� 5"      $	 100��6&   $��Имя��62   	 6?   �� *	FirstName+�� 5#      $	 100��6&   $��Отчество��62   	 6D   �� *
Patronymic+5$      5&      �� 5'   
   -   5        
 ��Name$
 comboBox��5'      $��
10,10,10,0q�5(      $	��Top=�5)      $��22��6+   $��2��67   6K   5+      5,      