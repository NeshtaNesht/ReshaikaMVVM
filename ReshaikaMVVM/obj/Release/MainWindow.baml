   M S B A M L   `   `   `  ���� G  CReshaikaMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ReshaikaMVVMReshaikaMVVM  ?$clr-namespace:ReshaikaMVVM.ViewModelReshaikaMVVM.ViewModel  7 clr-namespace:ReshaikaMVVM.ViewsReshaikaMVVM.Views  H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullfCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.MetroMahApps.Metro.Controls.Dialogs     ReshaikaMVVM.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:ReshaikaMVVM     3vm$clr-namespace:ReshaikaMVVM.ViewModel     1view clr-namespace:ReshaikaMVVM.Views     VDialogCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.Metro     ;Controls,http://metro.mahapps.com/winfx/xaml/controls    � Title$E  ?Арифметический тренажёр "Решай-ка"��$��401.333��$	��602�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ CanMinimize=� � Icon$ Resources/ico.png��8  2MahApps.Metro.Controls.Dialogs.DialogParticipation   Register ��  � 	Resources  �� DataType  ReshaikaMVVM.InputNameVM    ReshaikaMVVM.InputNameView"  ReshaikaMVVM.InputOtherSetVM$   ReshaikaMVVM.InputOtherSetView#  ReshaikaMVVM.ViewModel.GameVM!   ReshaikaMVVM.Views.GameView&   ReshaikaMVVM.ViewModel.GameEndVM$	   ReshaikaMVVM.Views.GameEndView��%�   (��       *, +)(��      *, +)(�� $     *, +)(�� 6     *, +)�� "  .R�  �� "  .R�  �� "  .R�  �� "  .R�	   � DataContext 
  ReshaikaMVVM.RootVM
  .��� .+��� -    ��Name$ stack1��	 �� Orientation$	 Vertical=�$��	0,0,172,0q�
�������.+�8  2MahApps.Metro.Controls.TransitioningContentControl  
   
Transition$

 Left=�$	��371��$��0q����� *CurrentContentVM+�� $	 Vertical=�$��	429,0,0,0q����	#FFFB8633.+�� $	��208��.+��� ���� .R��  � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � � ColumnDefinitions �� $
��Auto ��� $
��Auto �.@��� $��ФИО: ��$��0��$��0��$
��Bold"��� $��Вопросов: ��$��1��$��0��$
��Bold"��� $��Сложность: ��$��2��$��0��$
��Bold"��� $��Режим: ��$��3��$��0��$
��Bold"��� $��Верно: ��$��4��$��0�����	#FF2DD135$
��Bold"��� $��Неверно: ��$��5��$��0�����	#FFD33535$
��Bold"��� $��10(�$��0��$��1������ *CurrentName+�� $��1��$��1������ *CurrentAmount+�� $��2��$��1������ *CurrentHard+�� $��3��$��1������ *CurrentMode+�� $��4��$��1������ *CurrentGood+�� $��5��$��1������ *
CurrentBad+� $	��131��.+��� $��14(�
���  ��$
��Bold"�$��-419,-203,180,0q�$��31��$	��Top=����� *Popup+�� -    ��Name$ 	about_img��$y�	Collapsed=�$	��380��$	��290��$��Resources/logo_new.png��(  "MahApps.Metro.Controls.MetroWindow   RightWindowCommands +  %MahApps.Metro.Controls.WindowCommands  .@��� $��Новая игра��$
��bold"����� *	NewGame+�� -   $��Справка��$
��bold"�