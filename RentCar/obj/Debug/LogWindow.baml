   M S B A M L   `   `   `  ����B  >RentCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RentCarRentCar  5   	       RentCar.LogWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:RentCar     5   	     � Title$  RentCar��5   	   $	��480��6   $	��640��6&    � AllowsTransparency .   � Icon$ Resources/appIcon.png��5	   $    � WindowStartupLocation$ CenterScreen=�6A    � 
ResizeMode$ CanMinimize=�5
   	    � ShowInTaskbar . ��5      �� 5   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 2,2&�6/   .��5      �  � Color$ #70116B��6   	 � Offset$	 0Q�6+   � 5      $ White��6   $
	 0.52Q�6)   � 5      $ White��6   $	 1Q�6)   5      
 � 	Resources
 5       �� 
TargetType �� Property �� Value��%�   '��       '�� r     �� 5   
   " ��6   .�5      ��  � ��$ 16(�61   �� 5       � ��$ Do Hyeon)�63   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�61   �� 5       � ��$ Do Hyeon)�63   5      5      .��5      �  � RowDefinitions 5!   
   �� 5"      $	��360 �6   �� 5#      $
��Auto �6    � ColumnDefinitions 5%   
   �� 5&      $
��Auto �6   �� 5'      $
��Auto �6   .+�5*   
   �� $��0��6   $��0��6$   $��2��64   $��0,0,316.6,0q�6H   .��5+      �� .+�5,      �� -   5        $
��Auto��5,      $
��Auto��6'   ���#BE6AB5.��5-      �� $��Resources/Logos/audi.png��6   $	��120��6>   $	��199��6K   5.      �� 5/      ���#B264AA.��50      �� $��Resources/Logos/merc.png��6   $	��120��6>   $	��213��6K   51      �� 52      ���#A05799.��53      �� $��Resources/Logos/bmw.png��6   $	��107��6=   $	��136��6J   54      �� 55      ���#B264AA.��56      �� $��Resources/Logos/honda.png��6   $	��120��6?   $	��247��6L   57      �� 58      ���#BE6AB5.��59      �� $��Resources/Logos/vw.png��6   $	��120��6<   $	��236��6I   5:      5;      5<      �� 5>   
   -   5         ��Name$ userProfile��5>      $��1��6&   $��0��63   $��Do Hyeon)�5?      $��20(�6'   $	��127��5@      $��39��6   $��Center=�5A      $��Center=�5B      $��User profile��5C       �� 	IsDefault . 
�������$��10,31,179.8,20.4q�5E   (   ��5G      �� 5H       �� 
TargetType" ��6"   .R�5I      ��  ��Name$ buttonBorder��6    �� CornerRadius$ 25��63   #��z��5J      #��z��5K      #��z��5L      #��z��5M      #��z��5N      ._�5O      �� #��z��6)   #��z��5P      #��z��5Q      #��z��5R      5S       �� Triggers 5T      P� 5U       P� Property �@J�IsMouseOver P� Value . . �5V      ��  � ��$
 Bold"�6;   5W      P� 5X       � �� . . �5Y      ��  �� 
TargetName$ buttonBorder��6%    � ��
 �����6U   �� 5Z      $ buttonBorder��6%    � ��
 ��  �6V   5[      P� 5\       � {� .  . �5]      ��  � ��
 �����6;   �� 5^      $ buttonBorder��6%    � ��
 �����6U   5_      5a      5d      �� 5f   
   -   5        $ 	addButton��5f      $��1��6$   $��0��61   $��Do Hyeon)�5g      $��20(�6'   $��30��5h      $��28��6   $��Right=�5i      $��Center=�5j      $��+��5k       . 
�������$��0,36,34.8,26.4q�5m   (   �� 5o   
   -   5        $ 	delButton��5o      $��1��6$   $��0��61   $��Do Hyeon)�5p      $��20(�6'   $��30��5q      $��28��6   $��Center=�5r      $��Center=�5s      $��-��5t       . 
�������$��287,36,316.6,26.4q�5v   (   $��2��6C   �� 5x   
   -   5        $ userListButton��5x      $��1��6)   $��0��66   $��Do Hyeon)�5y      $��20(�6'   $��95��5z      $��28��6   $��Center=�5{      $��Center=�5|      $��	User list��5}       . 
�������$��152,36,69.8,26.4q�5   (   �� 5�   
   -   5        $ 
backButton��5�      $��1��6%   $��1��65   $��Do Hyeon)�5�      $��20(�6'   $��62��5�      $��39��6   $��Center=�5�      $��Center=�5�      $
��Exit��5�       . 
�������$��235.2,31,19.6,20.4q�5�   (   ��5�      �� 5�      " ��6"   .R�5�      �� $ buttonBorder��6   $ 25��63   #��z��5�      #��z��5�      #��z��5�      #��z��5�      #��z��5�      ._�5�      �� #��z��6)   #��z��5�      #��z��5�      #��z��5�      5�       5�      P� 5�       �@J�IsMouseOver . . �5�      ��  � ��$
 Bold"�6;   5�      P� 5�       � �� . . �5�      �� $ buttonBorder��6%    � ��
 �����6U   �� 5�      $ buttonBorder��6%    � ��
 ��  �6V   5�      P� 5�       � {� .  . �5�      ��  � ��
 �����6;   �� 5�      $ buttonBorder��6%    � ��
 �����6U   5�      5�      5�      5�      5�      