   M S B A M L   `   `   `  ���� E  AAlgorithms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Algorithms
Algorithms  S.clr-namespace:Wpf.CartesianChart.MaterialCards Wpf.CartesianChart.MaterialCards      Algorithms.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Algorithms     HMaterialCards.clr-namespace:Wpf.CartesianChart.MaterialCards       � WindowState$  Normal=� � Title$ 
MainWindow��$	��650��$	��986��$	��986��$	��650�� � Icon$ Assets/Logo.ico�� � 
ResizeMode$ CanMinimize=� � WindowStartupLocation$ CenterScreen=�.��� ���	#FFE17B9A � RowDefinitions �� .+��� ���	#FFCE2156$��	0,0,0,511q����	#FFCE2156�� -    ��Name$ firstBtn��$��Generate��$��97��$��0,0,213,153q�
����������	#FFCE2156���	#FFCE2156$��Right=�$��43��$��Bottom=� � Cursor$
 Hand���� -    ��Name$ liView��$
��Left=�$	��446�����	#FFCE2156
�������$	��511��$��Bottom=�$��Center=�$	 �� IsSynchronizedWithCurrentItem$
	 TrueY�
 �� SelectedIndex$
 0�����	#FFE17B9A �� View ��  �� ColumnHeaderStringFormat$ Information�� �� ColumnHeaderContextMenu �� $��Stretch=�.P��� $��Informations��	� -    	�Name$ binary��$��Binary Search��$��	0,0,9,219q�
�������
�������$��Right=�$��97��$��25��$��Bottom=����	#FFCE2156	� -   $ linear��$��Linear Search��$��0,0,111,219q�$��Bottom=�
�������
�������$��Right=�$��97��$��25�����	#FFCE2156	� -   $ qsort��$��
Quick Sort��$��0,0,213,219q�
�������
�������$��Right=�$��97��$��25��$��Bottom=����	#FFCE2156�� -    ��Name$ lblText��$��	0,0,9,326q�$
��Wrap=����	#FF20EE00$��32��$��Bottom=�$��Right=�$	��505��$��20(� �� TextAlignment$ Center=�	� -   $ bsort��$��Bubble Sort��$��0,0,315,219q�
�������
�������$��Right=�$��97��$��25��$��Bottom=����	#FFCE2156	� -   $ hanoi��$��
Hanoi Sort��$��0,0,417,219q�
�������
�������$��Right=�$��97��$��25��$��Bottom=����	#FFCE2156�� -	   $
 Home��$
��Left=�$��	60,29,0,0q�$
��Wrap=�$
��Home��$	��Top=�$��20(�
�������$ Center=�$
 Hand���� -
   $ Charts��$
��Left=�$��
220,29,0,0q�$
��Wrap=�$��Charts��$	��Top=�$��20(�
�������$ Center=�$
 Hand���� -   $ 	Resources��$
��Left=�$��
380,29,0,0q�$
��Wrap=�$��	Resources��$	��Top=�$��20(�
�������$ Center=�$
 Hand���� -   $ Technologies��$��560,29,271,0q�$
��Wrap=�$��Technologies��$	��Top=�$��20(�
�������$ Center=�$
 Hand���� -   $ 	Developer��$��761,29,70,0q�$
��Wrap=�$��	Developer��$	��Top=�$��20(�
�������$ Center=�$
 Hand��$��27���� -    ��Name$ 	valGetter��$��
0,0,10,275q� �� TextWrapping$
 Wrap=�$��35��$��Bottom=�$��Right=�$	��300��$��20(�$��1,2,3,4,...�� �� SelectionBrush �	#FFE17B9A
�������
������� �� 
CaretBrush �	#FFCE2156��Z� �� -   $ lblText_Copy��$��0,0,325,275q�$
��Wrap=�
�������$��35��$��Bottom=�$��Right=�$	��189��$G��ADefine a number or array (separate values with comma for array ):��