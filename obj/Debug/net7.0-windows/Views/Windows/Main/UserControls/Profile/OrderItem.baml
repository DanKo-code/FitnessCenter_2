   M S B A M L   `   `   `  ����H  DFitnessCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.Profile5FitnessCenter.Views.Windows.Main.UserControls.Profile  5      C&clr-namespace:FitnessCenter.ConvertersFitnessCenter.Converters  5      I)clr-namespace:FitnessCenter.BD.EntitiesBDFitnessCenter.BD.EntitiesBD  5
      E    ?FitnessCenter.Views.Windows.Main.UserControls.Profile.OrderItem   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.Profile     5      7conv&clr-namespace:FitnessCenter.Converters     5      7m)clr-namespace:FitnessCenter.BD.EntitiesBD     5
        � 	Resources  5      3   -FitnessCenter.Converters.OrderStatusConverter   OrderStatusConverter��%   &	          5   
   6$   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.4* �6   �� 5      .+�5   
   �� $��40(�6   $��Center=�6"   $��Center=�6?   $��0��6Z   
���   �
���������6�   �� *Abonement.Name+� 5    
   $��1��6    � ColumnDefinitions 5!      �� 5"      �� 5#      .+�5&      � $��0��6    5'      �� 5(      �� 5)      $
��0.4* �6$   .+�5,      �� $��0��6   .+�5.      �� $��20q�6!   $��Center=�6-    �� Orientation$ 
Horizontal=�6H   .+�5/      �� 
���   �$��30��67   $��30��6B   �� 50      $	��100��6    $��Возраст:��6,   �� 51      
���/���$��Center=�6=   $��Center=�6X   $	��100��6u   ��6�   �� *Abonement.Age+52      �� 54      $��20q�6!   $��Center=�6-   $ 
Horizontal=�6H   .+�55      �� 
���   �$��30��67   $��30��6B   �� 56      $	��100��6    $ ��Срок действия:��6,   �� 57      
���/���$��Center=�6=   $��Center=�6X   $	��100��6u   ��6�   �� *Abonement.Validity+58      �� 5:      $��20q�6!   $��Center=�6-   $ 
Horizontal=�6H   .+�5;      �� 
���   �$��30��67   $��30��6B   �� 5<      $	��100��6    $$��Время посещения:��6,   �� 5=      
���/���$��Center=�6=   $��Center=�6X   $	��100��6u   ��6�   �� *Abonement.VisitingTime+5>      5@      � 5B      $��1��6    5C      �� 5D      $
��0.3* �6(   �� 5E      .+�5H      �� $��0��6    $��Включено:��6-   �� 5J      $��1��6   
������ ��6D   �� *Abonement.Services+ �� UpdateSourceTrigger$ PropertyChanged=���5L      �� 5M      .R�5N   "   �� $ 
Horizontal=�6-   5O      ��5R      �� 5S      .R�5T   "   �� $��10q�6-   .+�5U   &   �� $��50��6E   $��50��6P   ��6,   �� *Phote+6P   �� 5V   &   ��60   �� *Title+5W   #   5X      5Z      5[      5\      �� 5^      $��1��6   .+�5g      �� $��20q�6   $ 
Horizontal=�6)   .+�5h      �� $��10q�6   $��Стоимость:��6(   �� 5i      $��Center=�6    ��6;   �� *Abonement.Price+�� 5j      $��10q�6    $��Center=�6,   $��рублей��6G   5k      �� 5m      $��20q�6   $	��400��6$   $	��200��60   ��6=   �� *Abonement.Photo+5o      5p      �� 5r   
   $��0��6   $��2��6!   $	��400��62   $	��100��6>   
�������._�5s      �� 
��� ���$��40(�6*    �� Padding$ 10q�6�   ��68   �� *Status+ �� 	Converter# [  $ PropertyChanged=�6�   5t      5v      5w      