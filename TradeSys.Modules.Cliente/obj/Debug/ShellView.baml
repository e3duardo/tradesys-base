   M S B A M L   `   `   `  ����R  NTradeSys.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullbFclr-namespace:TradeSys.Infrastructure;assembly=TradeSys.InfrastructureTradeSys.Infrastructure  5      tOclr-namespace:TradeSys.Infrastructure.Controls;assembly=TradeSys.Infrastructure TradeSys.Infrastructure.Controls  5      vPclr-namespace:TradeSys.Infrastructure.Behaviors;assembly=TradeSys.Infrastructure!TradeSys.Infrastructure.Behaviors  5       TradeSys.Modules.Cliente(   "TradeSys.Modules.Cliente.ShellView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ` \Microsoft.Practices.Prism, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35.cal$http://www.codeplex.com/CompositeWPF  5      PinfFclr-namespace:TradeSys.Infrastructure;assembly=TradeSys.Infrastructure  5      ^ControlsOclr-namespace:TradeSys.Infrastructure.Controls;assembly=TradeSys.Infrastructure  5      cinfBehaviorsPclr-namespace:TradeSys.Infrastructure.Behaviors;assembly=TradeSys.Infrastructure  5      $	��768��5      $
��1024��6   $
��Auto=�5	      $
��Auto=�67     � 	Resources  5       �� Source�� 5   
   $< 6/TradeSys.Infrastructure;component/Themes/generic.xaml?�6   %    .��5      �  J� RenderTransformOrigin$ 0.5,0.5&�6   $��3q�6,    � RowDefinitions 5   
   �� 5      $	��105 �6   �� 5      $��50 �6   �� 5      $	��150 �6   �� 5      $
��408* �6    � ColumnDefinitions 5   
   �� 5      $
��677* �6   $	��650��6,   �� 5      $	��307 �6   .+�5   
   �� -   5         ��Name$
 Logo��5      $��2��6   $ 0.5,0.5&�63   $��0,5,0,2q�6S   z�5       V� 5!      .~�5"      �� �� 5#      �� 5$      T� 5%      5&      .+�5(      �� $��C��6   $��NoWrap=�6!   ���	#FFC4CFD6$��72(�6N    J� Opacity$
 0.85Q�6\    �� Left$ 0��6k   
 �� Top$ 5��6{   $��Stretch=�6�   $��Stretch=�6�   $��80��6�   $��50��6�   	 �� TextAlignment$
	 Left=�6�   $
��Bold"�6�   �� 5)      $��lientes��6   $��NoWrap=�6'   ���	#FFC4CFD6$��72(�6T   $
 0.85Q�6b   $��80��6q   $
	 Left=�6}   $��Normal"�6�   $	��606��6�   $ 46��6�   $ 5��6�   5*      �� 5/   
   -   5        
 ��Name$
 MainToolbar��5/      )   #TradeSys.Infrastructure.RegionNames   MainToolBarRegion5  /Microsoft.Practices.Prism.Regions.RegionManager   
RegionName# Z 6,   $��Right=�6x   $	��Top=�6�   $��	0,21,10,0q�6�   $��1��6�   $ 0.5,0.5&�6�   z�50      V� 51      .~�52      �� �� 53      �� 54      T� 55      56      ��58      �� 59      .R�5:      ��  �� Orientation$ 
Horizontal=�6!   5;      5=      � 5B   
   -   5         �Name$ DetailsGrid��5B      $��2��6$   $��10,10,10,10q�61   $ 0.5,0.5&�6F   $��2��6f   z�5C      V� 5D      .~�5E      �� �� 5F      �� 5G      T� 5H      5I      .+�5K      �� -   5         ��Name$ ActionContent��5K         InsertRegion# Z 64   ��5L      �� 5M       �� 
TargetType" ��6&   .R�5N      � .+�5O      1   +TradeSys.Infrastructure.Controls.RoundedBox  �� 5P      $��	10,0,10,0q�6/   #��z��6B   5Q      5S      5U      5V      � 5[   
   -   5        $ ListGrid��5[      $��3��6!   $��10,10,10,10q�6.   $ 0.5,0.5&�6C   $��1��6c   z�5\      V� 5]      .~�5^      �� �� 5_      �� 5`      T� 5a      5b      .+�5d      �� -   5        $ ListContent��5d         
ListRegion# Z 62   ��5e      �� 5f      " ��6&   .R�5g      � .+�5h        �� 5i      $��	10,0,10,0q�6/   #��z��6B   5j      5k      5m      5n      � 5s   
   -   5        $ 
FilterGrid��5s      $��2��6#   $��10,10,10,10q�60   $ 0.5,0.5&�6E   $��1��6e   z�5t      V� 5u      .~�5v      �� �� 5w      �� 5x      T� 5y      5z      .+�5|      �� -   5        $ FilterContent��5|         FilterRegion# Z 64   ��5}      �� 5~      " ��6&   .R�5      � .+�5�        �� 5�      $��	10,0,10,0q�6/   #��z��6B   5�      5�      5�      5�      c� 5�   
   -	   5        $��toolBar1��5�      $��1��6"    J� 	AllowDrop .  $��3q�6A   .@�5�      �� -
   5        $
��Novo��5�      $
��NOVO��6!   �� 5�      -   5        $��Editar��5�      $��EDITAR��6#   �� 5�      -   5        $��Salvar��5�      $��SALVAR��6#   �� 5�      -   5        $��Cancelar��5�      $��CANCELAR��6%   �� 5�      -   5        $��Excluir��5�      $��EXCLUIR��6$   5�      5�      5�      