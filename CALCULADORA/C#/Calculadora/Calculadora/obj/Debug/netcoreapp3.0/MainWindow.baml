   M S B A M L   `   `   `  ����F  BCalculadora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CalculadoraCalculadora  5   	       Calculadora.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Calculadora     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ lblFirst��5
      $��First Number��6"   $
��Left=�69   $��
224,76,0,0q�6T   $	��Top=�6h   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5        $ 	lblSecond��5      $��Second Number��6#   $
��Left=�6;   $��224,149,0,0q�6V   $	��Top=�6k   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ txtFirst��5      $
��Left=�6$   $��
423,80,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��120��6   �� 5   
   -   5        $ 	txtSecond��5      $
��Left=�6%   $��423,151,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $	��120��6�   �� 5   
   -   5        $ lblName��5      $��
Calculator��6!   $
��Left=�66   $��
340,21,0,0q�6Q   $	��Top=�6e   $��Arial Black)�6}   $��20(�6�   �� 5   
   $��Button��6   $
��Left=�6"   $��1��6=   $��108,240,0,0q�6H   $	��Top=�6]   $��7��6u   �� 5   
   -   5         ��Name$ btnSum��5      $	��Add��6!   $
��Left=�6/   $��230,240,0,0q�6J   $	��Top=�6_   $��60��6w   $
��Bold"�6�   $��18(�6�   6�   �� 5   
   -   5        $ btnSubstract��5      $��	Substract��6'   $
��Left=�6;   $��304,240,0,0q�6V   $	��Top=�6k    J� RenderTransformOrigin$ 0.485,-2.259&�6�   $
��Bold"�6�   $��18(�6�   6�   �� 5   
   -   5        $ btnMultiply��5      $��Multiply��6&   $
��Left=�69   $��400,240,0,0q�6T   $	��Top=�6i   $
��Bold"�6�   $��18(�6�   6�   �� 5   
   -	   5        $ 	btnDivide��5      $��Divide��6$   $
��Left=�65   $��501,240,0,0q�6P   $	��Top=�6e   $
��Bold"�6}   $��18(�6�   6�   5      5      