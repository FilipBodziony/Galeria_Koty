   M S B A M L   `   `   `  ����D  @kotki_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:kotki_wpf	kotki_wpf  5   	       kotki_wpf.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:kotki_wpf     5   	     � Title$  
MainWindow��5   	   $	��450��5	   	   $	��300��5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	   .��5      � .+�5   
   � -   5         �Name$ 	girdTitle��5      $��	0,0,0,420q�5      ���#004C40.+�5      �� -   5         ��Name$ lblTitle��5      $��Galeria��5      $
��Left=�5      $	��Top=�5      
�������$��16(�5      5      � 5   
   -   5        $ gridContent��5      $��	0,30,0,26q�5      ���#00796B.+�5       � -   5        $ 	gridImage��5       $��	0,0,0,202q�5!      .+�5"      �� -   5         ��Name$ imgKotek��5"      $��assets/kot1.jpg��5#      $
��Fill=�5$      5%      � 5(      $��
0,197,0,10q�6   .+�5*      �� -   5         ��Name$ btnPREV��5*      ���#004c40
�������$��0,0,190,132q�5-      $��14(�5.      .��5/   /   PREV65   �� 52      -   5        $ btnNEXT��52      ���#004c40
�������$��190,0,0,132q�55      $��14(�56      .��57   /   NEXT65   �� 5:      $ ��Który obraz wyświetlić?��6   $
��Left=�5;      $��Center=�5<      
���   �$��12(�5>      $	��150��5?      $��25��5@      �� 5A      -   5         ��Name$ 	txtNumber��5A      $��Right=�5B      $��Center=�5C      $��50��5D      $��25��5E      $��	250,0,0,0q�5F      ���#00796B
���   �
���   �$��1��5L      �� 5O      $��Tło niebieskie?��6   $
��Left=�5P      $��Center=�5Q      
���   �$��12(�5S      $	��150��5T      $��25��5U      $��	0,162,0,0q�5V      �� 5X      -	   5         ��Name$ cbColor��5X      $��Right=�5Y      $��Center=�5Z      $��0,167,190,0q�5[      5]      5`      5a      � 5c   
   -
   5        $ 
gridFooter��5c      ���#004C40$��	0,424,0,0q�5e      .+�5f      �� $��Autor: Filip��6   $
��Left=�5g      $��Center=�5h      
���   �$��12(�5j      5k      5o      5p      