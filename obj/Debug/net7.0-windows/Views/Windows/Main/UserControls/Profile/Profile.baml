   M S B A M L   `   `   `  ����H  DFitnessCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.Profile5FitnessCenter.Views.Windows.Main.UserControls.Profile  5      �Fclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.Abonements8FitnessCenter.Views.Windows.Main.UserControls.Abonements  5      }Cclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.Profile5FitnessCenter.Views.Windows.Main.UserControls.Profile  5	      }Cclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.Profile5FitnessCenter.Views.Windows.Main.UserControls.Profile  5      A%clr-namespace:FitnessCenter.ViewModelFitnessCenter.ViewModel  5      =#clr-namespace:FitnessCenter.HelpersFitnessCenter.Helpers  5      C&clr-namespace:FitnessCenter.ConvertersFitnessCenter.Converters  5      C    =FitnessCenter.Views.Windows.Main.UserControls.Profile.Profile   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.Profile     5      ]
abonementsFclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.Abonements     5      VordersCclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.Profile     5	      QvCclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.Profile     5      4vm%clr-namespace:FitnessCenter.ViewModel     5      1h#clr-namespace:FitnessCenter.Helpers     5      7conv&clr-namespace:FitnessCenter.Converters     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5      -   5          >�Name$  profileCore��5       � 	Resources 5      4   .FitnessCenter.Converters.MissingPhotoConverter   MissingPhotoConverter0   *FitnessCenter.Converters.FontSizeConverter  FontSizeConverter3   -FitnessCenter.Converters.OrderStatusConverter  OrderStatusConverter��%W   &	        &	      &	 &       5   
   6%     5   
   6!     5    
   6$   5!      .��5#      � -   5         �Name$ Profilee��5#   $   
������  � ColumnDefinitions 5&   
   �� 5'      $
��0.4* �6   �� 5(      $
��0.6* �6   .+�5+   
   � $��0��6    � RowDefinitions 5,      �� 5-      $
��0.5* �6    �� 5.      �� 5/      $
��0.2* �6    .+�52      � $��0��6    53      �� 54      $
��0.7* �6'   �� 55      .+�58      �� $��0��6   $��10q�6(   ��64   �� *CurrentClient.Photo+ �� 	Converter# [   �� UpdateSourceTrigger$ PropertyChanged=�*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 59      +  %Microsoft.Xaml.Behaviors.EventTrigger  5:         	EventName$! PreviewMouseRightButtonDown��6)   *  $Microsoft.Xaml.Behaviors.TriggerBase	   Actions.	 5;      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction  
   Command
 64   �� *
SetPhoto+5<      5>      � 5@      $	��200��6   $��Center=�6'   $��1��6B    5B      �� 5C      �� 5D      .+�5G      � -   5        $ firstDiv��5G      $��0��6-   $��10q�6:    5I      �� 5J      �� 5K      .+�5N      �� $��30��6    $��0��6,   $��Имя��5P   !   �� 5S      $��1��6!   
�������$
��Auto��6A   $
��Auto��6O    �� CornerRadius$ 10��6\   ._�5T      �� $��0q�6&   
������ ��6S   �� *CurrentClient.Name+$ PropertyChanged=�5U      5V      � 5X      $��1��6   $��10q�6(    5Z      �� 5[      �� 5\      .+�5_      �� $��0��6    $��Фамилия��6-   �� 5a      $��1��6!   
�������$
��Auto��6A   $
��Auto��6O   $ 10��6\   ._�5b      �� $��0q�6&   
������ ��6S   �� *CurrentClient.SurName+$ PropertyChanged=�5c      5e      5f      5h      � 5j      $��Center=�6   $��1��6.    5l      �� 5m      �� 5n      �� 5o      �� 5p      .+�5s      � $��0��6   $	��900��6$   $��10q�63    5u      �� 5v      �� 5w      .+�5z      �� $��0��6   $��
Логин��6)   �� 5}      $��1��6   
�������$
��Auto��6=   $
��Auto��6K   $ 10��6X   ._�5~      �� $��0q�6"   
������ ��6O   �� *CurrentClient.Login+$ PropertyChanged=�5      5�      � 5�      $��2��6   $��10q�6$    5�      �� 5�      �� 5�      .+�5�      �� $��0��6   $��
Почта��6)   �� 5�      $��1��6   
�������$
��Auto��6=   $
��Auto��6K   $ 10��6X   ._�5�      �� $��0q�6"   
������ ��6O   �� *CurrentClient.Email+$ PropertyChanged=�5�      5�      � 5�      $��3��6   $��10q�6$    5�      �� 5�      �� 5�      .+�5�      �� $��0��6   $��Телефон��6)   �� 5�      $��1��6   
�������$
��Auto��6=   $
��Auto��6K   $ 10��6X   ._�5�      �� $��0q�6"   
������ ��6O   �� *CurrentClient.Phone+$ PropertyChanged=�5�      5�      5�      �� 5�      
����������#A093C5$��2��5�   O   $+��%Сохранить изменения��6\   ��5�      �� *SaveAllChanges+��68   ��  �� ElementName$ profileCore�� �� Path$ ActualWidth�# [  �� ConverterParameter$
 0.02����5�   '   �� $ profileCore��$ ActualWidth�# [ $	 0.4����5�   &   �� $ profileCore��$ ActualWidth�# [ $
 0.04�� 5�       �� 
TargetType �� Property �� Value��%_   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 20��69   5�      5�      5�      5�      � 5�   
   $��1��6    5�      �� 5�      $
��0.1* �6    �� 5�      .+�5�      �� $��0q�6<   ��6   �� *ReloadOrdersHisory+��6P   �� $ profileCore��$ ActualWidth�# [ $
 0.04����5�   '   �� $ profileCore��$ ActualWidth�# [ $
 0.04����5�      �� 5�       �� ImageSource$� �D:\2k2s\OOP_MY\Курсач\моя залупа\Работал MyListBox и delete\Test\FintessCenter-08b29904dd9b128bdfdea8ffc3c463cad2e1991c\Resources\MainCoreImages\Reboot.png��6!   5�      �� 5�      $��Disabled=�6   $��0q�6M   $��1��5�      
������ $��Center=�5�      $��Center=�5�      ��5�      �� *ClientOrders+��5�      �� 5�      .R�5�      � $��Center=�6$    � 	ItemWidth$
 Auto��6A    � 
ItemHeight$
 Auto��6R   5�      ��5�      �� 5�      .R�5�      � .+�5�      G   AFitnessCenter.Views.Windows.Main.UserControls.Profile.OrdersItemD  $	��500��61   $	��500��6@   �� 5�      $��0��6%   $��3��65   $	��400��6F   $	��100��6R   
������ ._�5�   "   �� $��Center=�6,   
��� ���$��40(�6[    �� Padding$ 10q�5�      $��Center=�6)   ��5�      �� *Status+# [ $ PropertyChanged=�5�   )   5�      5�      5�      5�      5�      5�      5�      