   M S B A M L   `   `   `  ���� H  DFitnessCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:FitnessCenter.ViewModelFitnessCenter.ViewModel  C&clr-namespace:FitnessCenter.ConvertersFitnessCenter.Converters  A%clr-namespace:FitnessCenter.ViewModelFitnessCenter.ViewModel  =#clr-namespace:FitnessCenter.HelpersFitnessCenter.Helpers  �Fclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.AdminPanel8FitnessCenter.Views.Windows.Main.UserControls.AdminPanel  I    CFitnessCenter.Views.Windows.Main.UserControls.AdminPanel.AdminPanel   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7local%clr-namespace:FitnessCenter.ViewModel     6con&clr-namespace:FitnessCenter.Converters     _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  .vm%clr-namespace:FitnessCenter.ViewModel  .help#clr-namespace:FitnessCenter.Helpers  OucFclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.AdminPanel    � 	Resources  1   +FitnessCenter.ViewModel.AdminPanelViewModel   
ViewModell<   6FitnessCenter.Converters.ServicesListToStringConverter ! ServicesListToStringConverter  	ForOrders m� Command  ForAbonements � DataContext  MyListBoxContextMenu �� RelativeSource��%�  &	        &	      &	 
     &	      7   &	 �         �� .@�m� $��Одобрить�� �� *ApproveOrder+m� $��Отклонить�� �� *RejectOrder+�� 8   .@�m� $��Сохранить�� �� *SaveAllChanges+m� $��Удалить�� �� *RemoveAbonement+��  �� *PlacementTarget.DataContext+ �� *Self+.@�m� $0��*Добавить/Изменить фото�� �� *SetServicePhoto+m� $��Удалить��y���  �� .��� -    �Name$ AdminContext�� ��  �� Source# [   � ColumnDefinitions �� �� $
��auto ��� .+�� 
���  ��$��0�� � RowDefinitions �� $
��0.2* ��� �� $
��0.3* �.+��� $��10q� �� Orientation$ 
Horizontal=�$��0��.+��� $��Абонементы��$��10q�$	��100��$��30������ *ShowAbonementsPanel+�� $��Заказы��$��10q�$	��100��$��30������ *ShowOrdersPanel+�� $��Тренера��$��10q�$	��100��$��30������ *ShowCouchesPanel+N   HFitnessCenter.Views.Windows.Main.UserControls.AdminPanel.AbonementsPanel  N   HFitnessCenter.Views.Windows.Main.UserControls.AdminPanel.AbonementsPanel	   Loaded$	 AbonementsPanel_Loaded��$��1�� �� # [  y��� *AbonementsPanelVisibility+J   DFitnessCenter.Views.Windows.Main.UserControls.AdminPanel.OrdersPanel  $��1�� �� # [  y��� *OrdersPanelVisibility+K   EFitnessCenter.Views.Windows.Main.UserControls.AdminPanel.CouchesPanel  $��1�� �� # [  y��� *CouchesPanelVisibility+� $��2��y��� *!BottomAbonementsPanelVisibility+ �� �� .+��� $��Center=�$��0��.+��� $��Снять выбор��$��10q����� *
Deselect+�� $��Добавить��$��10q����� *AddAbonement+�� $��10q����� *SearchString+
 �� UpdateSourceTrigger$
 PropertyChanged=�.��*  $Microsoft.Xaml.Behaviors.Interaction   Triggers +  %Microsoft.Xaml.Behaviors.EventTrigger     	EventName$ TextChanged��*	  $Microsoft.Xaml.Behaviors.TriggerBase 	  Actions. 2
  ,Microsoft.Xaml.Behaviors.InvokeCommandAction
   
  Command �� *SearchAbonementByName+.���� $��Center=�$��2��.+��� $��Удалить��$��10q����� *RemoveAbonement+��  �� Text$ Фильтр��$��10q�.@��� $��Название��   $ PreviewMouseDown��. 
   �� *SortAbonementByName+�� $��Возраст���� $��Срок действий���� $#��Время посещений���� $$��Доступное кол-во���� $2��,Сохранить все изменения��$��10q����� *SaveAllChanges+�� $��2��$��1��$��Stretch=�$��Center=��� 
��� � �$��2�� � ContextMenu# [  �� SelectedItem �� *SelectedProducts+���� *SearchedList+y��� *AbonementsListVisibility+ �� View �� .P��� $��Название�� �� CellTemplate �� .R���  �� TextWrapping$
 Wrap=�$��16(����#99aab5$��10,0,0,0q����� *Title+$
 PropertyChanged=��� $��Срок действия�� �� .R��� $
��Wrap=�$��16(����#99aab5$��10,0,0,0q����� *
Validity+�� $$��Время посещения:�� �� .R��� $
��Wrap=�$��16(����#99aab5$��10,0,0,0q����� *VisitingTime+�� $%��Доступное кол-во:�� �� .R��� $
��Wrap=�$��16(����#99aab5$��10,0,0,0q����� *Amount+�� $��Услуги:�� �� .R��  �� �� .+��� $��0������ *
Services+$
 PropertyChanged=����� .R��� $ 
Horizontal=����� .R��� .+��� $��50��$��50������ *Phote+�� ���� *Title+�� $��Стоимость:�� �� .R��� $
��Wrap=�$��16(����#99aab5$��10,0,0,0q����� *Price+�� $��	Фото:�� �� .R��� $��50��$��50��$��10,0,0,0q����� *Photo+�� # [ 
��� � �$��2�� �� *SelectedOrders+���� *
OrdersList+y��� *OrdersListVisibility+ �� .P��� $��Имя клиента�� �� .R��� $
��Wrap=�$��16(����#99aab5$��10,0,0,0q����� *Client.Name+�� $#��Фамилия клиента�� �� .R��� $
��Wrap=�$��16(����#99aab5$��10,0,0,0q����� *Client.SurName+�� $��Название�� �� .R��� $
��Wrap=�$��16(����#99aab5$��10,0,0,0q����� *Abonement.Title+�� $��Срок действия�� �� .R��� $
��Wrap=�$��16(����#99aab5$��10,0,0,0q����� *Abonement.Validity+�� $$��Время посещения:�� �� .R��� $
��Wrap=�$��16(����#99aab5$��10,0,0,0q����� *Abonement.VisitingTime+�� $%��Доступное кол-во:�� �� .R��� $
��Wrap=�$��16(����#99aab5$��10,0,0,0q����� *Abonement.Amount+�� $��Услуги:�� �� .R��� ���� *Abonement.Services+$
 PropertyChanged=����� .R��� $ 
Horizontal=����� .R��� .+��� $��50��$��50������ *Phote+�� ���� *Title+�� $��Стоимость:�� �� .R��� $
��Wrap=�$��16(����#99aab5$��10,0,0,0q����� *Abonement.Price+�� $��	Фото:�� �� .R��� $��50��$��50��$��10,0,0,0q����� *Abonement.Photo+�� 
��� � �$��2�� �� *SelectedCouches+���� *CouchesList+y��� *CouchesListVisibility+ �� .P��� $��	Фото:�� �� .R��� $��50��$��50��$��10,0,0,0q����� *Photo+�� $��Имя�� �� .R��� $
��Wrap=�$��16(����#99aab5$��10,0,0,0q����� *Name+�� $��Описание:�� �� .R��� $
��Wrap=�$��16(����#99aab5$��10,0,0,0q����� *Description+�� $��Услуги:�� �� .R��� ���� *
Services+$
 PropertyChanged=����� .R��� $ 
Horizontal=����� .R��� .+��� $��50��$��50������ *Phote+�� ���� *Title+