   M S B A M L   `   `   `  ����G  CReshaikaMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ReshaikaMVVMReshaikaMVVM  5      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullfCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.MetroMahApps.Metro.Controls.Dialogs 5      !    ReshaikaMVVM.Views.GameView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ReshaikaMVVM     5      VDialogCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.Metro     5      ;Controls,http://metro.mahapps.com/winfx/xaml/controls  5      6mah,http://metro.mahapps.com/winfx/xaml/controls  5	      8  2MahApps.Metro.Controls.Dialogs.DialogParticipation    Register  5
      ��  � 	Resources 5         SelectedTextBoxStyle �� 
TargetType �� Triggers �� Binding �� Value �� Property �� Value �� RelativeSource��%�   &	        �� 5   
   " ��6-    5      �� 5       6   �� *
IsFocused1+ True6=   .a�5      ��  �@+�FocusedElement 5      ��  �� *Self+5      5      5      .��5      � .+�5   
   �� $
��Left=�6   $��	10,30,0,0q�6/   $
��Wrap=�6B   $ ��Решаем пример:��6V   $	��Top=�6l   $��36(�6�   $
��Bold"�6�   $	��297��6�   �� 5   
   $
��Left=�63   $��
321,30,0,0q�6N   $	��Top=�6b   $��36(�6z   ��6   �� *CurrentNumberQ+6z   �� 5   
   $��75,92,75,205q�6   $
��Wrap=�6*   	 �� TextAlignment$	 Center=�6]   $��36(�6t   ��6>   �� *CurrentSample+6t   �� 5   
   -   5        
 ��Name$
 tAnswer��5   >   $��112,171,112,0q�6t   $	��Top=�6�   $��36(�6�    �� TextAlignment$ Center=�6�   ��6O   �� *ProgramColor+��6�   �� *CurrentAnswer+.��6�   *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Ваш ответ��5   [   .��5      �� 5   
   -   5         ��Name$ button��5   v   $��
Далее��6�   $��128,278,127,10q�6�   $��Center=�6�   $��83��6�   $��29(�6�   $��
ExtraLight"�6�   $��4��6�    �� 	IsDefault . ��6   �� *SetNextSampleCommand+��6:   ��  �� ElementName$ tAnswer�� �� Path$
 Text�6  5      5       