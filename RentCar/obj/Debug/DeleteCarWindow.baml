   M S B A M L   `   `   `  ����B  >RentCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RentCarRentCar  5   	       RentCar.DeleteCarWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:RentCar     5   	     � Title$  RentCar��5   
   $	��300��6   $	��700��5	   	    � AllowsTransparency .   � Icon$ Resources/appIcon.png��60    � WindowStartupLocation$ CenterScreen=�6M    � 
ResizeMode$ CanMinimize=�5
   	    � ShowInTaskbar . ��5      �� 5   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 2,2&�6/   .��5      �  � Color$ #70116B��6   	 � Offset$	 0Q�6+   � 5      $ White��6   $
	 0.52Q�6)   � 5      $ White��6   $	 1Q�6)   5      .��5      � 
 � RowDefinitions
 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Do Hyeon)�6   $��Car id��6+   $��21(�69   $��208,71.8,420.6,40.4q�6G   $��1��6d   �� 5   
   -   5         ��Name$ carList��5      $��0��6#   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��0 15 0 0q�6;   $��Center=�6M   .+�5      �� -   5         ��Name$ 	idTextBox��5      $��Center=�6)   $��Center=�6M   $	��113��6o   $��	0,44,0,28q�6{   �� 5      -   5        $��Delete��5      $��Do Hyeon)�6&   $��70��6<   $��0,44,0,0q�6c   $��48��6u   $	��Top=�6�   5       5!      5"      