   M S B A M L   `   `   `  ���� G  CReshaikaMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ReshaikaMVVMReshaikaMVVM  H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullfCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.MetroMahApps.Metro.Controls.Dialogs !    ReshaikaMVVM.Views.GameView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,localclr-namespace:ReshaikaMVVM     VDialogCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.Metro     ;Controls,http://metro.mahapps.com/winfx/xaml/controls  6mah,http://metro.mahapps.com/winfx/xaml/controls  8  2MahApps.Metro.Controls.Dialogs.DialogParticipation    Register  ��  � 	Resources    SelectedTextBoxStyle �� 
TargetType �� Triggers �� Binding �� Value �� Property �� Value �� RelativeSource��%x   &	        �� " �� ��  �� *
IsFocused1+ True.a���  �@+�FocusedElement ��  �� *Self+.��� .+��� $
��Left=�$��	10,30,0,0q�$
��Wrap=�$ ��Решаем пример:��$	��Top=�$��36(�$
��Bold"�$	��297���� $
��Left=�$��
321,30,0,0q�$	��Top=�$��36(����� *CurrentNumberQ+�� $��75,92,75,205q�$
��Wrap=�	 �� TextAlignment$	 Center=�$��36(����� *CurrentSample+�� -   
 ��Name$
 tAnswer��$��112,171,112,0q�$	��Top=�$��36(� �� TextAlignment$ Center=����� *ProgramColor+���� *CurrentAnswer+.��*  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Ваш ответ��.���� -    ��Name$ button��$��
Далее��$��128,278,127,10q�$��Center=�$��83��$��29(�$��
ExtraLight"�$��4�� �� 	IsDefault . ���� *SetNextSampleCommand+����  �� ElementName$ tAnswer�� �� Path$
 Text�