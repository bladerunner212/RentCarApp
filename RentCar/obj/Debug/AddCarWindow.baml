   M S B A M L   `   `   `  ����B  >RentCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RentCarRentCar  5   	       RentCar.AddCarWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:RentCar     5   	     � Title$  RentCar��5   	   $	��300��6   $	��700��5	   	    � AllowsTransparency .   � Icon$ Resources/appIcon.png��60    � WindowStartupLocation$ CenterScreen=�6M    � 
ResizeMode$ CanMinimize=�5
   	    � ShowInTaskbar . ��5      �� 5   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 2,2&�6/   .��5      �  � Color$ #70116B��6   	 � Offset$	 0Q�6+   � 5      $ White��6   $
	 0.52Q�6)   � 5      $ White��6   $	 1Q�6)   5      .��5      � 
 � RowDefinitions
 5   
   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ carBrand��5       �� 	MaxLength$ 12��6$   $��0��63   $	��100��5      $	��150��6!   $��35��60   $��Do Hyeon)�5      $��15(�6(   $��Center=�5      $��Center=�5      $��0,32,-0.4,203.4q�64   �� 5    
   $��Brand��6   $��Do Hyeon)�6!   $��25(�67   $��0��6E   $��205,36,424.6,199.4q�6R   �� 5!   
   $��Color��6   $��Do Hyeon)�6!   $��25(�67   $��0��6E   $��208,158,421.6,77.4q�6R   �� 5"   
   $��Model��6   $��Do Hyeon)�6!   $��25(�67   $��0��6E   $��205,98,424.6,137.4q�6R   �� 5$   
   -   5        $ carModel��5%      $ 12��6$   $	��100��5&      $	��150��6!   $��35��60   $��Do Hyeon)�5'      $��15(�6(   $��Center=�5(      $��Center=�5)      $��0,158,-0.4,77.4q�64   �� 5+   
   -   5        $ carColor��5,      $ 12��6$   $	��100��5-      $	��150��6!   $��35��60   $��Do Hyeon)�5.      $��15(�6(   $��Center=�5/      $��Center=�50      $��0,95,-0.4,140.4q�64   �� 52   
   -   5        $��0��52      $��239,219,227.6,10.4q�6   $��Add car��6:   $��Do Hyeon)�6L   $��21(�6b   53      55      56      