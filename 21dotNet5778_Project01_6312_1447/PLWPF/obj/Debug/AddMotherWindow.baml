   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	   1clr-namespace:GoogleMapWpfAppGoogleMapWpfApp  5   	       PLWPF.AddMotherWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	   9googlemapwpfappclr-namespace:GoogleMapWpfApp     5   	     � Title$  AddMotherWindow��5	   	   $	��800��6!   $	��670��6.   ���	#FF62C4FB � 	Resources 5
        PLWPF.ImageConverter   ImageConverter��%   &	          5   
   6   5      .��5      � -   5         �Name$ grid0��5       � ColumnDefinitions 5   
   �� 5      $
��290* �6   �� 5      $
��118* �6   �� 5      $
��255* �6    � RowDefinitions 5   
   �� 5      $
��697* �6   �� 5      $	��74* �6   .+�5    
   � -   5        $ grid1��5       $��0,0,0,67.333q�6    5!      �� 5"      $
��Auto �6#   �� 5#      $
��Auto �6#   �� 5$      $
��115* �6#   �� 5%      $
��271* �6#    5'      �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    �� 5+      $
��Auto �6    �� 5,      $
��Auto �6    �� 5-      $
��Auto �6    �� 5.      $
��Auto �6    �� 5/      $
��Auto �6    �� 50      $
��Auto �6    �� 51      $
��Auto �6    �� 52      $
��Auto �6    �� 53      $
��Auto �6    �� 54      $
��Auto �6    �� 55      $
��Auto �6    �� 56      $
��Auto �6    �� 57      $
��Auto �6    �� 58      $
��Auto �6    �� 59      $
��Auto �6    .+�5<      �� $��kilometer Around:��6   $��0��60   $
��Left=�6@   $��	0,10,0,33q�6[   $��0��6n   $��Center=�6{   $��2��6�   �� 5=      -   5         ��Name$ kilometerAroundTextBox��5=      $��1��66    �� IsReadOnlyCaretVisible .  $
��Left=�6�   $��24��6�   $��4.667,4,0,4q�6�   $��0��6�   $��Center=�6|  $	��120��6�  ��6�   �� *kilometerAround+ �� Mode$ TwoWay=� �� ValidatesOnDataErrors . 	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 .  �� UpdateSourceTrigger$ PropertyChanged=�6�  �� 5>      $��Mother Address:��6   $��0��6.   $
��Left=�6>   $��3,4,0,4q�6Y   $��1��6j   $��Center=�6w   )   #GoogleMapWpfApp.PlaceAutoCompleteUC  5?      -   5          Name$ motherAddressTextBox��5?   2   $��1��6P   $
��Left=�6`   $��24��6{   $��4.667,4,0,4q�6�   $��1��6�   $��Center=�6R  $	��120��6m     Text 6�   �� *MotherAddress+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�6m  �� 5@      $��Mother Around Address:��6   $��0��65   $
��Left=�6E   $��3,4,0,4q�6`   $��2��6q   $��Center=�6~     5A      -   5        $  motherAroundAddressTextBox��5A   2   $��1��6V   $
��Left=�6h   $��24��6�   $��5,6.6,0,4.6q�6�   $��2��6�   $��Center=�6`  $	��120��6{  $��2��6�   6�   �� *MotherAroundAddress+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�6�  �� 5B      $��Mother Date:��6   $��0��6+   $
��Left=�6;   $��3,4,0,4q�6V   $��3��6g   $��Center=�6t   (  "System.Windows.Controls.DatePicker  5C      -   5          Name$ motherDateDatePicker��5C      $��1��67   $
��Left=�6G   $��4.667,4,0,4q�6b   $��3��6w   $��Center=�62     SelectedDate 6�   �� *
MotherDate+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�62  �� 5D      $��Mother First Name:��6   $��0��61   $
��Left=�6A   $��3,4,0,4q�6\   $��4��6m   $��Center=�6z   �� 5E      -   5        $ motherFirstNameTextBox��5E      $��1��66    .  $
��Left=�6�   $��24��6�   $��4.667,4,0,4q�6�   $��4��6�   $��Center=�6}  $	��120��6�  ��6�   �� *MotherFirstName+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�6�  �� 5F      $��Mother Have Elevator:��6   $��0��64   $
��Left=�6D   $��3,4,0,4q�6_   $��5��6p   $��Center=�6}   �� 5G      -   5         ��Name$  motherHaveElevatorCheckBox��5G      $�� ��6;   $��1��6F   $
��Left=�6V   $��4.667,9,0,9q�6$  $��5��69  $��Center=�6F   d� 	IsChecked 6q   �� *MotherHaveElevator+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�6F  �� 5H      $��Mother Holidays Tamat:��6   $��0��65   $
��Left=�6E   $��3,4,0,4q�6`   $��6��6q   $��Center=�6~   �� 5I      -	   5        $! motherHolidaysTamatCheckBox��5I      $�� ��6<   $��1��6G   $
��Left=�6W   $��4.667,9,0,9q�6&  $��6��6;  $��Center=�6H   6r   �� *MotherHolidaysTamat+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�6H  �� 5J      $��
Mother Id:��6   $��0��6)   $
��Left=�69   $��3,4,0,4q�6T   $��7��6e   $��Center=�6r   �� 5K      -
   5        $ motherIdTextBox��5K      $��1��6/    .  $
��Left=�6�   $��24��6�   $��4.667,4,0,4q�6�   $��7��6�   $��Center=�6o  $	��120��6�  ��6�   �� *
MotherId+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�6�  �� 5L      $��Mother Is Hourlysalary:��6   $��0��66   $
��Left=�6F   $��3,4,0,4q�6a   $��8��6r   $��Center=�6   �� 5M      -   5        $" motherIsHourlysalaryCheckBox��5M      $�� ��6=   $��1��6H   $
��Left=�6X   $��4.667,9,0,9q�6(  $��8��6=  $��Center=�6J   6s   �� *MotherIsHourlysalary+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�6J  �� 5N      $��Mother Kids Average:��6   $��0��63   $
��Left=�6C   $��3,4,0,4q�6^   $��9��6o   $��Center=�6|   �� 5O      -   5        $ motherKidsAverageTextBox��5O      $��1��68    .  $
��Left=�6�   $��24��6�   $��4.667,4,0,4q�6�   $��9��6�   $��Center=�6�  $	��120��6�  ��6�   �� *MotherKidsAverage+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�6�  �� 5P      $��Mother Last Name:��6   $��0��60   $
��Left=�6@   $��3,4,0,4q�6[   $��10��6l   $��Center=�6z   �� 5Q      -   5        $ motherLastNameTextBox��5Q      $��1��65    .  $
��Left=�6�   $��24��6�   $��4.667,4,0,4q�6�   $��10��6�   $��Center=�6|  $	��120��6�  ��6�   �� *MotherLastName+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�6�  �� 5R      $��Mother Max Kids Age:��6   $��0��63   $
��Left=�6C   $��3,4,0,4q�6^   $��11��6o   $��Center=�6}   �� 5S      -   5        $ motherMaxKidsAgeTextBox��5S      $��1��67   $
��Left=�6G   $��24��6b   $��4.667,4,0,4q�6n   $��11��6�   $��Center=�6<  $	��120��6W  ��6�   �� *MotherMaxKidsAge+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�6W  �� 5T      $��Mother Min Kids Age:��6   $��0��63   $
��Left=�6C   $��3,4,0,4q�6^   $��13��6o   $��Center=�6}   �� 5U      -   5        $ motherMinKidsAgeTextBox��5U      $��1��67   $
��Left=�6G   $��24��6b   $��4.667,4,0,4q�6n   $��13��6�   $��Center=�6<  $	��120��6W  ��6�   �� *MotherMinKidsAge+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�6W  �� 5V      $��Mother Phone Number:��6   $��0��63   $
��Left=�6C   $��3,4,0,4q�6^   $��14��6o   $��Center=�6}   �� 5W      -   5        $ motherPhoneNumberTextBox��5W      $��1��68    .  $
��Left=�6�   $��24��6�   $��4.667,4,0,4q�6�   $��14��6�   $��Center=�6�  $	��120��6�  ��6�   �� *MotherPhoneNumber+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�6�  �� 5X      $��Mother Remarks:��6   $��0��6.   $
��Left=�6>   $��3,4,0,4q�6Y   $��15��6j   $��Center=�6x   �� 5Y      -   5        $ motherRemarksTextBox��5Y      $��1��64   $
��Left=�6D   $��24��6_   $��4.667,4,0,4q�6k   $��15��6�   $��Center=�67  $	��120��6R  ��6�   �� *MotherRemarks+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�6R  �� 5Z      $��Mother Tariff For Hour:��6   $��0��66   $
��Left=�6F   $��3,4,0,4q�6a   $��16��6r   $��Center=�6�   �� 5[      -   5        $  motherTariffForHourTextBox��5[      $��1��6:    .  $
��Left=�6�   $��24��6�   $��4.667,4,0,4q�6�   $��16��6�   $��Center=�6�  $	��120��6�  ��6�   �� *MotherTariffForHour+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�6�  �� 5\      $��Mother Tariff For Month:��6   $��0��67   $
��Left=�6G   $��3,4,0,4q�6b   $��17��6s   $��Center=�6�   �� 5]      -   5        $! motherTariffForMonthTextBox��5]      $��1��6;   $
��Left=�6K   $��24��6f   $��4.667,4,0,4q�6r   $��17��6�   $��Center=�6E  $	��120��6`  ��6�   �� *MotherTariffForMonth+$ TwoWay=� . 	 . 
 . $ PropertyChanged=�6`  5^      �� 5b   
   -   5         ��Name$ 	textBlock��5b      $��2��6'   $
��Left=�67   $��	27,18,0,0q�6R   $
��Wrap=�6e   $%��Click on the image to change it��6y   $	��Top=�6�   $��52��6�   $��88��6�   �� 5g   
   -   5         ��Name$ IndicationImage12��5g      $��24��6,   $��
10,16,55,0q�68   $	��Top=�6L   $��1��6d   $��images/start/vvvv.jpg��6t    J� RenderTransformOrigin$ -0.659,-1.148&�6A  y�6�   ��  �� ElementName$ kilometerAroundTextBox��$ PropertyChanged=� �� Path$ IsReadOnlyCaretVisible�  ToVisibilityConverter2 �� 	Converter# [ 6A  �� 5l   
   -   5        $ MotherImage��5l      $
��Fill=�6}   $
��Left=�6�   $	��100��6�   $��	122,9,0,0q�6�   $	��Top=�6�   $	��103��6�   $��2��6�   ��6%   �� *ImageSource+$ TwoWay=�# [  6�   �� 5m   
   -   5         ��Name$ AddMotherbutton��5m        MyButtomStylMother#��[ 6*   $��
Add Mother��6V   $
��Left=�6k   $��24,4.667,0,0q�6�   $	��Top=�6�   $	��495��6�   $��1��6�   $��3��6�   $��43��6�   6�   �� 5n   
   -   5        $ IndicationImage12_Copy1��5n      $��24��62   $��
9,142,56,0q�6>   $	��Top=�6R   $��1��6j   $��images/start/vvvv.jpg��6z   $ -0.659,-1.148&�6C  y�6�   �� *IsReadOnlyCaretVisible+# [ $ motherFirstNameTextBox��$ PropertyChanged=�6C  �� 5o   
   -   5        $ IndicationImage12_Copy2��5o      $��24��62   $��
8,252,57,0q�6>   $	��Top=�6R   $��1��6j   $��images/start/vvvv.jpg��6z   $ -0.659,-1.148&�6<  y�6�   �� *IsReadOnlyCaretVisible+# [ $ motherIdTextBox��$ PropertyChanged=�6<  �� 5p   
   -   5        $ IndicationImage12_Copy3��5p      $��24��62   $��
5,352,60,0q�6>   $	��Top=�6R   $��1��6j   $��images/start/vvvv.jpg��6z   $ -0.659,-1.148&�6B  y�6�   �� *IsReadOnlyCaretVisible+# [ $ motherLastNameTextBox��$ PropertyChanged=�6B  �� 5q   
   -   5        $ IndicationImage12_Copy4��5q      $��24��62   $��
3,459,62,0q�6>   $	��Top=�6R   $��1��6j   $��images/start/vvvv.jpg��6z   $ -0.659,-1.148&�6E  y�6�   �� *IsReadOnlyCaretVisible+# [ $ motherPhoneNumberTextBox��$ PropertyChanged=�6E  �� 5r   
   -   5        $ IndicationImage12_Copy8��5r      $��24��62   $��
2,522,63,0q�6>   $	��Top=�6R   $��1��6j   $��images/start/vvvv.jpg��6z   $ -0.659,-1.148&�6G  y�6�   �� *IsReadOnlyCaretVisible+# [ $  motherTariffForHourTextBox��$ PropertyChanged=�6G  �� 5s   
   -   5        $ IndicationImage11_Copy1��5s      $��12��62   $��31,524,48,0q�6>   $	��Top=�6S   $��1��6k   $��images/start/x.png��6{   y�6�   �� *IsReadOnlyCaretVisible+  ToVisibilityConverter# [ $  motherTariffForHourTextBox��$ PropertyChanged=��� 5t   
   -   5        $ IndicationImage11_Copy2��5t      $��12��62   $��
52,21,27,0q�6>   $	��Top=�6R   $��1��6j   $��images/start/x.png��6z   y�6�   �� *IsReadOnlyCaretVisible+# [ $ kilometerAroundTextBox��$ PropertyChanged=��� 5u   
   -   5        $ IndicationImage11_Copy4��5u      $��12��62   $��26,452,53,0q�6>   $	��Top=�6S   $��1��6k   $��images/start/x.png��6{   y�6�   �� *IsReadOnlyCaretVisible+# [ $ motherPhoneNumberTextBox��$ PropertyChanged=��� 5v   
   -    5        $ IndicationImage11_Copy6��5v      $��12��62   $��31,355,48,0q�6>   $	��Top=�6S   $��1��6k   $��images/start/x.png��6{   y�6�   �� *IsReadOnlyCaretVisible+# [ $ motherLastNameTextBox��$ PropertyChanged=��� 5w   
   -!   5        $ IndicationImage11_Copy7��5w      $��12��62   $��27,249,52,0q�6>   $	��Top=�6S   $��1��6k   $��images/start/x.png��6{   y�6�   �� *IsReadOnlyCaretVisible+# [ $ motherIdTextBox��$ PropertyChanged=��� 5y   
   -"   5        $ IndicationImage11_Copy10��5y      $��12��63   $��47,155,32,0q�6?   $	��Top=�6T   $��1��6l   $��images/start/x.png��6|   y�6�   �� *IsReadOnlyCaretVisible+# [ $ motherFirstNameTextBox��$ PropertyChanged=�   PLWPF.UserControOfTheWeek  5z   
   -#   5          Name$ UserControOfTheWeek��5z   $   $��1��6A   $
��Left=�6Q   $��
91,115,0,0q�6l   $	��Top=�6�   $��2��6�   $	��450��6�   $	��276��6�   5�      5�      