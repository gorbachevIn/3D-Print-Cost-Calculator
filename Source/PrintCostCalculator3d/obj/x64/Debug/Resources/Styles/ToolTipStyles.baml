   M S B A M L   `   `   `  ����W  SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   DefaultToolTip  �� 
TargetType  MahApps.Styles.ToolTip �� BasedOn �� Property �� Value  MahApps.Brushes.Gray8 # MahApps.Brushes.ThemeForeground # MahApps.Brushes.ThemeBackground  HelpToolTip �� 
TargetType ��Name J� Opacity J� SnapsToDevicePixels �� Padding	 � 	Resources  Key  WrapTextBlock'   !System.Windows.VisualStateManager
    VisualStateGroups%  System.Windows.VisualStateGroup   Transitions%  System.Windows.VisualTransition   GeneratedDuration   From	   To   States   System.Windows.VisualState   
Storyboard �� 
TargetName �� TargetProperty9   3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  WarnToolTip�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %�  &	        7  '_� �     7   &	 �     7   7  &	 x    7  �� 5      "  _�6#   8   .�5   
   ��  � ��$ 14(�6%   �� 5   
    � ��$	 300��6%   �� 5   
    � ��# �  6(   �� 5   
    � ��# �  6'   �� 5   
    � ��# �  6'   5	      �� 5      "  _�6   8   6*   �� 5      "  _�6    8   .�5   
   ��  � �� 5      �� 5      " _�6"   .R�5      �� $
 Root��6   #��z��6+   #��z��6U   #��z��6�   $ 0Q�6�   # z 6�   $ 5q�6�   	 5      ���� 5      Visible State 6)   �� 5      Normal State 6)   5      ._�5      �� #��z��6$   #��z��6E   8�� $��Center=�6�   
 5        5      
OpenStates�� 5   "     5   &   $ 0:0:0.3D�67   $
 Open��6S   $ Closed��6_   . 5   "     
Closed��. 5   &   �� .��5   *   U� $
 Root��6H   $ (UIElement.Opacity)�6e   .\�5   .     $ 0:0:0.4��6C   $ 0Q�6U   5    +   5!   '   5"   #     5#   "   Open��. 5$   &   �� .��5%   *   U� $
 Root��6H   $ (UIElement.Opacity)�6e   .\�5&   .     $ 0:0:0.3��6C   $ 1Q�6U   5'   +   5(   '   5)   #   5*      5,      5-      5/      50      �� 52      "  _�6    8   6>   53      