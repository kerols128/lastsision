   M S B A M L   `   `   `  ����D  @Assiment2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Assiment2	Assiment2  5          Assiment2.Admin   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Assiment2     5        N� Title$  Admin��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��43* �6   �� 5      $	��66* �6   �� 5      $	��54* �6   �� 5      $	��56* �6   �� 5      $
��131* �6   .+�5   
   �� $��
Admin page��6   $��Center=�6%   $��18(�6B   $	��Top=�6P   $��0��6h   
�������$��33��6�   $	��128��6�   �� 5   
   -   5         ��Name$ 	txtsearch��5      $��194,10,154,28q�6%   $��1��6<   �� 5   
   -   5         ��Name$ search��5      $��search��6!   $��351,10,10,28q�62   $��1��6H   6U   �� 5   
   $��Student ID :��6   $
��Left=�6'   $��2��6B   $��	0,10,0,10q�6O   $��18(�6b   $	��103��6p   �� 5   
   -   5        $ txtId��5      $��2��6!   $��Center=�6.   $��	0,10,0,10q�6K   $	��192��6^   �� 5   
   $��Department :��6   $
��Left=�6'   $��3��6B   $��	0,10,0,10q�6O   $��18(�6b   $	��114��6p   �� 5   
   -   5        $ txtdep��5      $��3��6"   $��Center=�6/   $��0,7,0,8q�6L   $	��192��6]   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dg��5   .      AutoGenerateColumns . $��4��68   $��	10,0,10,0q�6E   5      �� 5   
   -   5        $ Delete��5      $��Delete��6!   $��361,16,0,10q�62   $��2��6G   6T   �� 5   
   -   5        $
 Edit��5      $
��Edit��6   $��361,18,0,10q�6.   $��3��6C   6P   5      5       