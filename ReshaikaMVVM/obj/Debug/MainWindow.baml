   M S B A M L   `   `   `  ����G  CReshaikaMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ReshaikaMVVMReshaikaMVVM  5   	   ?$clr-namespace:ReshaikaMVVM.ViewModelReshaikaMVVM.ViewModel  5   	   7 clr-namespace:ReshaikaMVVM.ViewsReshaikaMVVM.Views  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullfCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.MetroMahApps.Metro.Controls.Dialogs 5	   	       ReshaikaMVVM.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ReshaikaMVVM     5   	   3vm$clr-namespace:ReshaikaMVVM.ViewModel     5   	   1view clr-namespace:ReshaikaMVVM.Views     5   	   VDialogCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.Metro     5	   	   ;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$E  ?Арифметический тренажёр "Решай-ка"��5   	   $��401.333��6>   $	��602��6O    � WindowStartupLocation$ CenterScreen=�6[    � 
ResizeMode$ CanMinimize=�6�    � Icon$ Resources/ico.png��6�   8  2MahApps.Metro.Controls.Dialogs.DialogParticipation   Register 5
   	   ��  � 	Resources 5       �� DataType  ReshaikaMVVM.InputNameVM    ReshaikaMVVM.InputNameView"  ReshaikaMVVM.InputOtherSetVM$   ReshaikaMVVM.InputOtherSetView#  ReshaikaMVVM.ViewModel.GameVM!   ReshaikaMVVM.Views.GameView&   ReshaikaMVVM.ViewModel.GameEndVM$	   ReshaikaMVVM.Views.GameEndView��%,  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5      	  5      5       � DataContext 5      
  ReshaikaMVVM.RootVM
  5   
   .��5      � .+�5    
   �� -   5         ��Name$ stack1��5       	 �� Orientation$	 Vertical=�6%   $��	0,0,172,0q�6<   
�������.+�5!      8  2MahApps.Metro.Controls.TransitioningContentControl  
   
Transition$

 Left=�63   $	��371��6j   $��0q�6w   ��6E   �� *CurrentContentVM+6w   5"      �� 5#   
   $	 Vertical=�6   $��	429,0,0,0q�6,   ���	#FFFB8633.+�5$      � $	��208��6   .+�5%      �� ��5&      �� 5'      .R�5(      �  � RowDefinitions 5)   "   �� 5*   &   $��* �64   �� 5+   &   $��* �64   �� 5,   &   $��* �64   �� 5-   &   $��* �64   �� 5.   &   $��* �64   �� 5/   &   $��* �64    � ColumnDefinitions 51   "   �� 52   &   $
��Auto �67   �� 53   &   $
��Auto �67   55      56      .@�58      �� $��ФИО: ��6"   $��0��63   $��0��6@   $
��Bold"�6P   �� 59      $��Вопросов: ��6"   $��1��68   $��0��6E   $
��Bold"�6U   �� 5:      $��Сложность: ��6"   $��2��68   $��0��6E   $
��Bold"�6U   �� 5;      $��Режим: ��6"   $��3��64   $��0��6A   $
��Bold"�6Q   �� 5<      $��Верно: ��6"   $��4��64   $��0��6A   ���	#FF2DD135$
��Bold"�6h   �� 5=      $��Неверно: ��6"   $��5��66   $��0��6C   ���	#FFD33535$
��Bold"�6j   �� 5?      $��10(�6B   $��0��6P   $��1��6]   ��6"   �� *CurrentName+6]   �� 5@      $��1��6D   $��1��6Q   ��6"   �� *CurrentAmount+6Q   �� 5A      $��2��6B   $��1��6O   ��6"   �� *CurrentHard+6O   �� 5B      $��3��6B   $��1��6O   ��6"   �� *CurrentMode+6O   �� 5C      $��4��6B   $��1��6O   ��6"   �� *CurrentGood+6O   �� 5D      $��5��6A   $��1��6N   ��6"   �� *
CurrentBad+6N   5E      5F      � 5G      $	��131��6   .+�5H      �� $��14(�62   
���  ��$
��Bold"�6Q   $��-419,-203,180,0q�6c   $��31��6|   $	��Top=�6�   ��6   �� *Popup+6�   5I      5K      �� 5L   
   -   5         ��Name$ 	about_img��5L      $y�	Collapsed=�6#   $	��380��6n   $	��290��6z   $��Resources/logo_new.png��6�   5M      (  "MahApps.Metro.Controls.MetroWindow   RightWindowCommands 5N      +  %MahApps.Metro.Controls.WindowCommands  5O   
   .@�5P      �� $��Новая игра��6   $
��bold"�6*   ��6<   �� *	NewGame+�� 5Q      -   5        $��Справка��5Q      $
��bold"�6'   69   5R      5U      