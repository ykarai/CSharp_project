   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	       PLWPF.UpdateNannyWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	   ���	#FF62C4FB  � Title$  UpdateNannyWindow��5   	   $	��330��6#   $	��730��60    � 	Resources 5	        PLWPF.ImageConverter   ImageConverter��%   &	          5
   
   6   5      .��5      � -   5        $��grid1��5       � RowDefinitions 5   
   �� 5      $	��36* �6   �� 5      $
��201* �6   �� 5      $	��64* �6   .+�5   
   �� -   5         ��Name$ comboBox��5      $��0��6%   $��0,8,0.333,8q�6_   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ NannyDataGrid��5      $��1��6+   $��Center=�69      
IsReadOnly . $��0,28,0.333,107.333q�5      $��66��63    �� SelectedItem 5      �� *child+ �� Mode$ TwoWay=� �� NotifyOnValidationError . 	 �� ValidatesOnExceptions	 . �� 5   
   -   5        
 ��Name$
 changedetailsbutton��5      $��change details��6.   $��2��6G   $��241,11.667,271.333,0q�6T   $��44��6r   $	��Top=�6~     MyButtomStyleNanny#��[ 6�   $	��211��6�   �� 5   
   -   5         ��Name$ image��5      $
��Left=�6   $	��100��6:   $��
274,91,0,0q�6G   $��1��6[   $	��Top=�6h   $	��100��6�   $��images/start/nannys.jpg��6�   $
��Fill=�6�   5$      5%      