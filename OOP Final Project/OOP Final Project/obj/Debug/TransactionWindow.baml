   M S B A M L   `   `   `  ����L  HOOP Final Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:OOP_Final_ProjectOOP_Final_Project  5   	   )    #OOP_Final_Project.TransactionWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:OOP_Final_Project     5   	   -   5          � Title$  TransactionWindow��5	   	   $	��540��6#   $
��1080��60   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��419* �6   �� 5      $
��231* �6   �� 5      $
��622* �6   .+�5   
   �� -   5        $��btnLoan��5      $��25(�6    $��Add Loan��6.   $
��Left=�6A   $��	10,10,0,0q�6\   $	��Top=�6o   $	��143��6�   $��70��6�   �� 5   
   -   5        $��btnPay��5      $��25(�6   $	��Pay��6-   $
��Left=�6;   $��	10,85,0,0q�6V   $	��Top=�6i   $	��143��6�   $��70��6�   6�   �� 5   
   -   5         ��Name$ btnBack��5      $��25(�6"   $
��Menu��60   $
��Left=�6?   $��
10,160,0,0q�6Z   $	��Top=�6n   $	��143��6�   $��70��6�   �� 5   
   -   5        $��listViewMasterList��5      $��20(�6-   $��Right=�6;   $
��Auto��6W   $��
0,10,354,0q�6e   $	��Top=�6y   $	��560��6�   4  .System.Windows.Automation.AutomationProperties   Name$ listViewMasterList��6�   $��3��60   �� View 5      �� 5      .P�5      �� $
��No #��6%    �� Width$ 75��63    �� DisplayMemberBinding 6>   �� *ID+6e   �� 5      $
��Name��6%   $	 150��63    6?   �� *Name+6g   �� 5      $��Transaction Date��6%   $	 200��6?    6K   �� *TransactionDate+6~   �� 5      $��Amount Loaned��6%   $	 200��6<    6H   �� *AmountLoaned+6x   �� 5      $��Interest Rate��6%   $	 150��6<    6H   �� *InterestRate+6x   �� 5      $��Remaining Balance��6%   $	 250��6@    6L   �� *	Balance+6w   5      5      5       5!      