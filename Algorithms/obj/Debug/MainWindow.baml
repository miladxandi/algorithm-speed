   M S B A M L   `   `   `  ����E  AAlgorithms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Algorithms
Algorithms  5   	   S.clr-namespace:Wpf.CartesianChart.MaterialCards Wpf.CartesianChart.MaterialCards  5   	       Algorithms.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Algorithms     5   	   HMaterialCards.clr-namespace:Wpf.CartesianChart.MaterialCards     5   	     � WindowState$  Normal=�5	   	    � Title$ 
MainWindow��5
   	   $	��650��6   $	��986��6)   $	��986��65   $	��650��6D    � Icon$ Assets/Logo.ico��6T    � 
ResizeMode$ CanMinimize=�6k    � WindowStartupLocation$ CenterScreen=�6�   .��5      � ���	#FFE17B9A � RowDefinitions 5   
   �� 5      .+�5   
   �� ���	#FFCE2156$��	0,0,0,511q�6%   ���	#FFCE215668   �� 5   
   -   5         ��Name$ firstBtn��5      $��Generate��6#   $��97��66   $��0,0,213,153q�6A   
����������	#FFCE2156���	#FFCE2156$��Right=�6�   $��43��6  $��Bottom=�6   � Cursor$
 Hand��62  6B  �� 5   
   -   5         ��Name$ liView��5      $
��Left=�6#   $	��446��6>   
���   �
�������$	��511��6q   $��Bottom=�6~   $��Center=�6�   $	 �� IsSynchronizedWithCurrentItem$
	 TrueY�6�   
 �� SelectedIndex$
 0��6�   ���	#FFE17B9A �� View 5      �� 5       �� ColumnHeaderStringFormat$ Information��6    �� ColumnHeaderContextMenu 5      �� 5      $��Stretch=�6&   .P�5      �� $��Informations��6%   5      5      	� 5   
   -   5         	�Name$ binary��5      $��Binary Search��6&   $��	0,0,9,219q�6>   
�������
�������$��Right=�6x   $��97��6�   $��25��6�   $��Bottom=�6�   ���	#FFCE21566�   	� 5   
   -   5        $ linear��5      $��Linear Search��6&   $��0,0,111,219q�6>   $��Bottom=�6S   
�������
�������$��Right=�6�   $��97��6�   $��25��6�   ���	#FFCE21566�   	� 5   
   -   5        $ qsort��5      $��
Quick Sort��6%   $��0,0,213,219q�6:   
�������
�������$��Right=�6v   $��97��6�   $��25��6�   $��Bottom=�6�   ���	#FFCE21566�   �� 5   
   -   5         ��Name$ lblText��5      $��	0,0,9,326q�6%   $
��Wrap=�68   ���	#FF20EE00$��32��6c   $��Bottom=�6o   $��Right=�6�   $	��505��6�   $��20(�6�    �� TextAlignment$ Center=�6�   	� 5   
   -   5        $ bsort��5      $��Bubble Sort��6%   $��0,0,315,219q�6;   
�������
�������$��Right=�6w   $��97��6�   $��25��6�   $��Bottom=�6�   ���	#FFCE21566�   	� 5    
   -   5        $ hanoi��5       $��
Hanoi Sort��6%   $��0,0,417,219q�6:   
�������
�������$��Right=�6v   $��97��6�   $��25��6�   $��Bottom=�6�   ���	#FFCE21566�   �� 5!   
   -	   5        $
 Home��5!      $
��Left=�6"   $��	60,29,0,0q�6=   $
��Wrap=�6P   $
��Home��6d   $	��Top=�6p   $��20(�6�   
�������$ Center=�6�   $
 Hand��6�   �� 5"   
   -
   5        $ Charts��5"      $
��Left=�6$   $��
220,29,0,0q�6?   $
��Wrap=�6S   $��Charts��6g   $	��Top=�6u   $��20(�6�   
�������$ Center=�6�   $
 Hand��6�   6�   �� 5#   
   -   5        $ 	Resources��5#      $
��Left=�6'   $��
380,29,0,0q�6B   $
��Wrap=�6V   $��	Resources��6j   $	��Top=�6{   $��20(�6�   
�������$ Center=�6�   $
 Hand��6�   6�   �� 5$   
   -   5        $ Technologies��5$      $��560,29,271,0q�6*   $
��Wrap=�6@   $��Technologies��6T   $	��Top=�6h   $��20(�6�   
�������$ Center=�6�   $
 Hand��6�   6�   �� 5%   
   -   5        $ 	Developer��5%      $��761,29,70,0q�6'   $
��Wrap=�6<   $��	Developer��6P   $	��Top=�6a   $��20(�6y   
�������$ Center=�6�   $
 Hand��6�   $��27��6�   6�   �� 5&   
   -   5         ��Name$ 	valGetter��5&      $��
0,0,10,275q�6%    �� TextWrapping$
 Wrap=�69   $��35��6M   $��Bottom=�6Y   $��Right=�6t   $	��300��6�   $��20(�6�   $��1,2,3,4,...��6�    �� SelectionBrush �	#FFE17B9A
�������
������� �� 
CaretBrush �	#FFCE2156��6z  Z� 5'      5(      