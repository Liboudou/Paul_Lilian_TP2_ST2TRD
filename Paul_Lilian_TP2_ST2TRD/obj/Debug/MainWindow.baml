   M S B A M L   `   `   `  ����Q  MPaul_Lilian_TP2_ST2TRD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Paul_Lilian_TP2_ST2TRDPaul_Lilian_TP2_ST2TRD  5   	   '    !Paul_Lilian_TP2_ST2TRD.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Paul_Lilian_TP2_ST2TRD     5   	     � Title$  EFREI ST2TRD PAUL Lilian��5   	   $	��600��6*   $	��920��67    � 
ResizeMode$ NoResize=�5	   	   
������  � AllowsTransparency .  .��5      � 4  .System.Windows.Automation.AutomationProperties   Name$	 oui��6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��100 �6   �� 5      $	��360 �6   �� 5       � RowDefinitions 5   
   �� 5      $��75 �6   �� 5      $��75 �6   �� 5      .+�5   
   �� $	��TP2��6   $��Showcard Gothic)�5      $��Center=�5      $��Center=�5       
�������$	�� 32(�5"      �� 5$   
   $��1��6   $��0��6"   $��5,0,0,0q�62   .+�5%      �� -   5         ��Name$
 Help��5%      $
��Help��6#   $��Showcard Gothic)�63   $��34��6P   $��0,0,-0.333,0q�6\    � ToolTip 5&      _� 5'      .��5(      �� �� 6%   $;�5Help tool in maintenance, I can't help you, try later��6)   $��Showcard Gothic)�6f   6�   5)      5+      5.      �� 51   
   $
��Mode��6   $��Showcard Gothic)�52      
�������$��Center=�54      $��1��55      $	�� 20(�56      $��11,0,11.667,0q�6#   $��Center=�6:   �� 5>   
   $��0��6   $��2��6"   $��Center=�63   .+�5?      �� -   5        $��	ComboBox1��5?       �� TextAlignment$ Center=�6-   	 �� SelectedValuePath$	 Content��5@      $��Showcard Gothic)�6:   
 J� Effect
 5A      3  -System.Windows.Media.Effects.DropShadowEffect  5B      .@�5E      �� $��Cesar��6   61   �� 5F      $��Vigenere��6   64   �� 5G      $��	Froduleux��6   65   �� 5H      $
��Hexa��6   60   5J      5K      �� 5M   
   $��3��6   $��0��6"   .+�5N      �� 
�������$��Center=�5O      $��Showcard Gothic)�5P      $	�� 18(�5Q      $��	24,0,25,0q�6#   $��Center=�66   $��32��6S   �� 6`   $	�Enc��6d   �� 6q   $�i��6u   �� 6�   $
�pher��6�   �� 6�   $
� Key��6�   6�   �� 5R      -   5        $��TextBox1��5R   $   $��3��6   $��25��64   $��16(�6@   5S      �� 5U   
   -   5        $��	AddButton��5U      $��Encipher��6"   $��-4,319,102,54q�6H   $��2��6_   $��Showcard Gothic)�6l   �� 5X   
   -   5         ��Name$ lstNames��5Z      $��1��5X      $��1��6   " �� VerticalScrollBarVisibility$ Visible=�6/   $��16(�5Y   	    �� TextWrapping$
 Wrap=�5Z   
   $��2��60   $��2��6A   ���	#FFF6F6F66U   �� 5\   
   -   5        $ 	lstNames2��5^      $��1��5\      $��3��6   $ Visible=�6/   $��18(�5]   
   $
 Wrap=�5^   
   $��2��61   $��1��6B   
�������5_   
   �� 5`   
   -   5        $ AddButton_Copy��5`      $��Decipher��6)   $��98,319,0,54q�6O   $��2��6d   $��Showcard Gothic)�6q   �� 5a   
   -   5        $ Clear2��5a      $��Clear��6!   $��
-4,368,0,0q�6>   $��2��6R   $��25(�6_   $��Showcard Gothic)�6m   �� 5b   
   -	   5        $ butt_export��5b      $��Export��6&   $��0,358,-0.333,0q�6F   $��2��6^   $��25(�6k   $��Showcard Gothic)�6y   $��3��6�   �� 5c   
   $��Result��6   $��Showcard Gothic)�5d      
�������$��Center=�5f      $��3��5g      $��25(�5h      $��86,25,64.667,12.333q�6   $��Center=�68    J� RenderTransformOrigin$ 10.15,0.615&�6U   $��38��6y   $	��104��6�   5k      5l      