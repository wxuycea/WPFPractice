   M S B A M L   `   `   `  ����B  >MPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MPlayerMPlayer  5   	       MPlayer.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MPlayer     5   	     � Title$  Music Player��5   	   $	��150��6   $	��400��6+    � 
ResizeMode$ NoResize=�67   .��5	      �  � RowDefinitions 5
   
   �� 5      $��40 �6   �� 5      �� 5      $��20 �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��Center=�6V   .+�5      �� -   5        $
��Open��5      $��60��6$   $��30��6/   6;   �� 5      -   5        $��BtnPlay��5      $
��Play��6$   $��60��63   $��30��6>   $��10, 0, 0, 0q�6J   6_   �� 5      -   5        $��BtnPause��5      $��Pause��6%   $��60��65   $��30��6@   $��10, 0, 0, 0q�6L   6a   �� 5      -   5        $��BtnStop��5      $
��Stop��6$   $��60��63   $��30��6>   $��10, 0, 0, 0q�6J   6_   5      �� 5   
   -   5        $��
TbFileName��5      $��2��6&   $��FileName : ��63   $��
5, 0, 0, 0q�6F   5      5      