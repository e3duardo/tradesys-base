   M S B A M L   `   `   `  ����R  NTradeSys.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullbFclr-namespace:TradeSys.Infrastructure;assembly=TradeSys.InfrastructureTradeSys.Infrastructure  5      xQclr-namespace:TradeSys.Infrastructure.Converters;assembly=TradeSys.Infrastructure"TradeSys.Infrastructure.Converters  5       TradeSys.Modules.Cliente:   4TradeSys.Modules.Cliente.ViewModel.ClienteInsertView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      VinfFclr-namespace:TradeSys.Infrastructure;assembly=TradeSys.Infrastructure     5      kinfConvertersQclr-namespace:TradeSys.Infrastructure.Converters;assembly=TradeSys.Infrastructure     5      $��6q�5	   7     � 	Resources  5         ErrorTemplate7   1TradeSys.Infrastructure.Converters.ErrorConverter  errorConverter  textBoxInError �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� RelativeSource �� Path	 �� 	Converter?   9TradeSys.Infrastructure.Converters.EnumToBooleanConverter  enumToBooleanConverterH   BTradeSys.Infrastructure.Converters.StringToNullableNumberConverter # stringToNullableNumberConverter��%�  &	        &	 Z     &	 m     7  &	 *    &	 =    �� 5   
   .R�5      �� 
���  ��$��2q�6'   ._�5      �� 5      5        5   
   6'   �� 5   
   " ��6'    5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip 60   ��  �� *Self+$ (Validation.Errors)�8	   5      5        5   
   6/     5   
   68   5      .��5      � $��6q�6   
 � RowDefinitions
 5   
   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6   �� 5$      $
��Auto �6   �� 5%      $
��Auto �6   �� 5&      $
��Auto �6   �� 5'      $
��Auto �6   �� 5(      $
��Auto �6   �� 5)      $	��51* �6    � ColumnDefinitions 5+   
   �� 5,      $	��123 �6   �� 5-      $
��260* �6   �� 5.      $	��123 �6   �� 5/      $
��260* �6   .+�53   
   �� -   5        $��label1��53       $��Nome:��6   $��6q�6.   �� 54   
   -   5        $��NomeTextBox��54      4  .System.Windows.Automation.AutomationProperties   AutomationId$ NomeTextBox��6%    =� ErrorTemplate# [  6'  $��1��6a  $��6q�6q  ��6U   �� $
 Nome� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnExceptions .  �� NotifyOnValidationError .  �� ValidatesOnDataErrors . #	 [ 6q  �� 56   
   -   5        $��label2��56   %   $��
Sobrenome:��6   $��1��63   $��6q�6@   �� 57   
   -   5        $��SobrenomeTextBox��57      $ SobrenomeTextBox��6*   # [  66  $��1��6p  $��1��6�  $��6q�6�  ��6_   �� $ 	Sobrenome�$ PropertyChanged=� .  .  . #	 [ 6�  �� 59   
   -   5        $��label3��59   "   $��Bairro:��6   $��2��60   $��6q�6=   �� 5:   
   -   5        $��BairroTextBox��5:      $ BairroTextBox��6'   # [  6-  $��1��6g  $��2��6w  $��6q�6�  ��6Y   �� $ Bairro�$ PropertyChanged=� .  .  . #	 [ 6�  �� 5<   
   -   5        $��label4��5<   ,   $
��CEP:��6   $��3��6   $��6q�6:   �� 5=   
   -   5        $��
CepTextBox��5=      $ 
CepTextBox��6$   # [  6$  $��1��6^  $��3��6n  $��6q�6{  ��6S   �� $	 Cep�$ PropertyChanged=� .  .  . #	 [ 6{  �� 5?   
   -	   5        $��label5��5?   /   $��Cidade:��6   $��4��6"   $��6q�6=   �� 5@   
   -
   5        $��CidadeTextBox��5@      $ CidadeTextBox��6'   # [  6-  $��1��6g  $��4��6w  $��6q�6�  ��6Y   �� $ Cidade�$ PropertyChanged=� .  .  . #	 [ 6�  �� 5B   
   -   5        $��label6��5B   4   $��Complemento:��6   $��5��6'   $��6q�6B   �� 5C   
   -   5        $��ComplementoTextBox��5C      $ ComplementoTextBox��6,   # [  6<  $��1��6v  $��5��6�  $��6q�6�  ��6c   �� $ Complemento�$ PropertyChanged=� .  .  . #	 [ 6�  �� 5E   
   -   5        $��label7��5E   /   $��Estado:��6   $��6��6"   $��6q�6=   �� 5F   
   -   5        $��EstadoTextBox��5F      $ EstadoTextBox��6'   # [  6-  $��1��6g  $��6��6w  $��6q�6�  ��6Y   �� $ Estado�$ PropertyChanged=� .  .  . #	 [ 6�  �� 5H   
   -   5        $��label8��5H   2   $��
Logadouro:��6   $��7��6%   $��6q�6@   �� 5I   
   -   5        $��LogadouroTextBox��5I      $ LogadouroTextBox��6*   # [  66  $��1��6p  $��7��6�  $��6q�6�  ��6_   �� $ 	Logadouro�$ PropertyChanged=� .  .  . #	 [ 6�  �� 5K   
   -   5        $��label9��5K   .   $��Email:��6   $��8��6!   $��6q�6<   �� 5L   
   -   5        $��EmailTextBox��5L      $ EmailTextBox��6&   # [  6*  $��1��6d  $��8��6t  $��6q�6�  ��6W   �� $ Email�$ PropertyChanged=� .  .  . #	 [ 6�  5M      5N      