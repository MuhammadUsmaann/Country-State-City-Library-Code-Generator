   M S B A M L   `   `   `  ����  Location    MU.Location.TestLocation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Location Tester��5   	   $��279.044��6!   $	��300��62   .��5      � $��0,0,0,29q�6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5	      $��60 �6   �� 5
      $��60 �6    � ColumnDefinitions 5   
   �� 5      $	��30* �6   �� 5      $	��70* �6   .+�5   
   �� $��0��6   $��0��6    $
��Left=�6-   $��Center=�6H   $��Country��6c   �� 5   
   -   5        $��1��5      $��0��6#   $
��Left=�60   $��Center=�6K   $	��200��5      $��31��6   $��	0,20,0,10q�6+    �� DisplayMemberPath$ DisplayName��5       �� SelectedValuePath$ 	DisplayID��5      ��5      �� *CountryList+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedValue 5      �� *SelectedCountry+$ TwoWay=�$ PropertyChanged=�5      �� 5   
   $��0��6   $��1��6    $
��Left=�6-   $��Center=�6H   $��State��6c   �� 5   
   -   5        $��1��5      $��1��6#   $
��Left=�60   $��Center=�6K   $	��200��6f   $��32��6r   $��	0,19,0,10q�6~   $ DisplayName��5      $ 	DisplayID��5      ��5      �� *	StateList+$ TwoWay=�$ PropertyChanged=� 5      �� *SelectedState+$ TwoWay=�$ PropertyChanged=�5       �� 5"   
   $��0��6   $��2��6    $
��Left=�6-   $��Center=�6H   $
��City��6c   �� 5#   
   $��1��6   $��2��6#   $
��Left=�60   $��Center=�6K   $	��200��6f   $��31��6r   $��	0,20,0,10q�6~   $ DisplayName��5%      $ 	DisplayID��5&      ��5$      �� *
CityList+$ TwoWay=�$ PropertyChanged=�5&      �� 5)   
   $��Close��6   $��1��6!   $
��Left=�61   $��42��6L   $��119,71,0,-52q�6X   $��2��6n   $	��Top=�6{   $��75��6�   5+      5,      