   M S B A M L   `   `   `  ����J  FWindowsRestorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WindowsRestorerWindowsRestorer  5   	        WindowsRestorer.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WindowsRestorer     5   	     � Title$  Windows Restorer��5   	    � Icon$ Resources/reload.ico��6"   ���#3a3a3a$��760.55��6S   $��288.353��6c    � WindowStartupLocation$ CenterScreen=�6s    � 
ResizeMode$ NoResize=�6�   .��5	      � .+�5
   
   �� -   5         ��Name$ GraphicsGroupBox��5
      $��Graphic Drivers��6-   
�������$
��Left=�6Y   $��	10,52,0,0q�6t   $	��Top=�6�   $��90��6�   $	��254��6�   �� 5   
   -   5        $ webBrowsingGroupBox��5      $��Web Browsing��60   
�������$
��Left=�6Y   $��
10,252,0,0q�6t   $	��Top=�6�   $��98��6�   $	��254��6�   �� 5   
   -   5        $ securityGroupBox��5      $��Security��6-   
�������$
��Left=�6R   $	��Top=�6m   $��
10,147,0,0q�6�   $	��100��6�   $	��254��6�   �� 5   
   -   5         ��Name$ 	GeForceCb��5      $��GeForce Experience��6&   
�������$
��Left=�6V   $��	25,84,0,0q�6q   $	��Top=�6�   �� 5   
   -   5         ��Name$ 	nameLabel��5      $��Windows Restorer��6#   
�������$��17(�6Q   $��segoe UI)�6_   $
��Left=�6u   $��	10,14,0,0q�6�   $	��Top=�6�   $��33��6�   $	��153��6�   �� 5   
   -   5        $ amdCataclystCb��5      $��AMD Cataclyst��6+   
�������$
��Left=�6V   $��
25,104,0,0q�6q   $	��Top=�6�   �� 5   
   -   5        $ comodoCb��5      $��Comodo Firewall��6%   
�������$
��Left=�6R   $��
25,178,0,0q�6m   $	��Top=�6�   �� 5   
   -   5        $ KeyscramblerCb��5      $��Key Scrambler��6+   
�������$
��Left=�6V   $��
25,198,0,0q�6q   $	��Top=�6�   �� 5   
   -	   5        $ malwareBytesCb��5      $��Malware Bytes��6+   
�������$
��Left=�6V   $��
25,218,0,0q�6q   $	��Top=�6�   �� 5   
   -
   5        $ 	firefoxCb��5      $��Firefox��6&   
�������$
��Left=�6K   $��
25,280,0,0q�6f   $	��Top=�6z   �� 5   
   -   5        $ ChromeCb��5      $��Google Chrome��6%   
�������$
��Left=�6P   $��
25,300,0,0q�6k   $	��Top=�6   �� 5   
   -   5        $ OperaCb��5      $��Opera��6$   
�������$
��Left=�6G   $��
25,320,0,0q�6b   $	��Top=�6v   �� 5   
   -   5        $ multimediaGroupBox��5      $��
MultiMedia��6/   $
��Left=�6C   $��
10,355,0,0q�6^   $	��Top=�6r   $��77��6�   $	��254��6�   �� 5   
   -   5        $ 
vlcMediaCB��5      $��VLC Media Player��6'   
�������$
��Left=�6U   $��
25,382,0,0q�6p   $	��Top=�6�   �� 5   
   -   5        $ 	SpotifyCb��5      $��Spotify��6&   
�������$
��Left=�6K   $��
25,402,0,0q�6f   $	��Top=�6z   �� 5   
   -   5        $ EssentialsGroupBox��5      $��
Essentials��6/   $
��Left=�6C   $��
10,437,0,0q�6^   $	��Top=�6r   $��78��6�   $	��254��6�   �� 5   
   -   5        $ javaandJdkCb��5      $��Java and JDK��6)   
�������$
��Left=�6S   $��
25,465,0,0q�6n   $	��Top=�6�   �� 5   
   -   5        $ dotnetFrameworkDb��5      $��.NET Framework 4.5��6.   
�������$
��Left=�6^   $��
25,485,0,0q�6y   $	��Top=�6�   � 5!   
   -   5         �Name$ progressBar1��5!   1   $
��Left=�6   $��10��6G   $��
10,671,0,0q�6S   $	��Top=�6g   $	��254��6   �� 5"   
   -   5         ��Name$ 
restoreBtn��5"      $��Restore��6>   $
��Left=�6P   $��
10,686,0,0q�6k   $	��Top=�6   $	��254��6�   �� 5#   
   -   5        $ statusLabel��5#      $��Overall Progress 0%��6%   $
��Left=�6C   $��
74,643,0,0q�6^   $	��Top=�6r   �� 5$   
   -   5        $ developmentGroupBox��5$      $��Development��60   $
��Left=�6E   $��
10,520,0,0q�6`   $	��Top=�6t   $	��114��6�   $	��254��6�   �� 5%   
   -   5        $ visualStudioCb��5%      $��Visual Studio��6+   
�������$
��Left=�6V   $��
25,544,0,0q�6q   $	��Top=�6�   �� 5&   
   -   5        $ 	EclipseCb��5&      $��Eclipse��6&   
�������$
��Left=�6K   $��
25,564,0,0q�6f   $	��Top=�6z   �� 5'   
   -   5        $ 
BracketsCb��5'      $��Brackets��6'   
�������$
��Left=�6M   $��
25,584,0,0q�6h   $	��Top=�6|   �� 5(   
   -   5        $ Notepadplusplus��5(      $��	Notepad++��6,   
�������$
��Left=�6S   $��
25,604,0,0q�6n   $	��Top=�6�   �� 5)   
   -   5        $��	comboBox1��5)      $��163,17,18,677q�6$   .@�5*      �� -   5        $��itemOne��5*      	 �� 
IsSelected	 . .��6<   32-bit6D   �� 5+      -   5        $��itemTwo��5+      .��6*   64-bit62   5,      50      51      