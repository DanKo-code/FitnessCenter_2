   M S B A M L   `   `   `  ���� H  DFitnessCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.Profile5FitnessCenter.Views.Windows.Main.UserControls.Profile  C&clr-namespace:FitnessCenter.ConvertersFitnessCenter.Converters  I)clr-namespace:FitnessCenter.BD.EntitiesBDFitnessCenter.BD.EntitiesBD  E    ?FitnessCenter.Views.Windows.Main.UserControls.Profile.OrderItem   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     UlocalCclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.Profile     7conv&clr-namespace:FitnessCenter.Converters     7m)clr-namespace:FitnessCenter.BD.EntitiesBD       � 	Resources  3   -FitnessCenter.Converters.OrderStatusConverter   OrderStatusConverter��%   &	          .���  � RowDefinitions �� $
��0.4* ��� .+��� $��40(�$��Center=�$��Center=�$��0��
���   �
����������� *Abonement.Name+� $��1�� � ColumnDefinitions �� �� .+�� $��0�� �� �� $
��0.4* �.+��� $��0��.+��� $��20q�$��Center=� �� Orientation$ 
Horizontal=�.+��� 
���   �$��30��$��30���� $	��100��$��Возраст:���� 
���/���$��Center=�$��Center=�$	��100������ *Abonement.Age+�� $��20q�$��Center=�$ 
Horizontal=�.+��� 
���   �$��30��$��30���� $	��100��$ ��Срок действия:���� 
���/���$��Center=�$��Center=�$	��100������ *Abonement.Validity+�� $��20q�$��Center=�$ 
Horizontal=�.+��� 
���   �$��30��$��30���� $	��100��$$��Время посещения:���� 
���/���$��Center=�$��Center=�$	��100������ *Abonement.VisitingTime+� $��1�� �� $
��0.3* ��� .+��� $��0��$��Включено:���� $��1��
������ ���� *Abonement.Services+ �� UpdateSourceTrigger$ PropertyChanged=����� .R��� $ 
Horizontal=����� .R��� $��10q�.+��� $��50��$��50������ *Phote+�� ���� *Title+�� $��1��.+��� $��20q�$ 
Horizontal=�.+��� $��10q�$��Стоимость:���� $��Center=����� *Abonement.Price+�� $��10q�$��Center=�$��рублей���� $��20q�$	��400��$	��200������ *Abonement.Photo+�� $��0��$��2��$	��400��$	��100��
�������._��� 
��� ���$��40(� �� Padding$ 10q����� *Status+ �� 	Converter# [  $ PropertyChanged=�