   M S B A M L   `   `   `  ����F  BJeuBatonnet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:JeuBatonnet.VuesJeuBatonnet.Vues  5   	   *    $JeuBatonnet.Vues.fenetre_inscription   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:JeuBatonnet.Vues     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5        � Title$  fenetre_inscription��5	   	   $	��450��6%   $	��800��62   .��5
      �  � RowDefinitions 5   
   �� 5      $	��65* �6   �� 5      $
��152* �6   .+�5   
   �� "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ ..\images\full.gif��6   $��462,46,79,5q�6F   $��1��6[   �� 5   
   -   5         ��Name$ 
TBX_Prenom��5      $
��Left=�6&   $��
150,41,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��145��6�   $��22��6�   �� 5   
   $��Prénom��6   $
��Left=�6!   $��	64,34,0,0q�6<   $	��Top=�6O   �� 5   
   $	��Nom��6   $
��Left=�6   $��	67,91,0,0q�69   $	��Top=�6L    J� RenderTransformOrigin$ 0.347,0.448&�6d   �� 5   
   $��Pseudo��6   $
��Left=�6!   $��66,3,0,0q�6<   $	��Top=�6N   $ 0.468,-0.118&�6f   $��1��6�   �� 5   
   $��Numéro de
 téléphone��6   $
��Left=�63   $��
50,164,0,0q�6N   $	��Top=�6b   $ 1.036,0.402&�6z   $��1��6�   �� 5   
   $��Mot de passe��6   $
��Left=�6'   $��
32,220,0,0q�6B   $	��Top=�6V   $��1��6n   �� 5   
   -   5        $ TBX_Nom��5      $
��Left=�6#   $��
150,91,0,0q�6>   $
 Wrap=�6R   $	��Top=�6f   $	��145��6~   $��22��6�   �� 5   
   -   5        $ TBX_Naissance��5      $
��Left=�6)   $��150,119,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��145��6�   $��22��6�   $��1��6�   �� 5   
   -   5        $ TBX_Telephone��5      $
��Left=�6)   $��150,174,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��145��6�   $��22��6�   $��1��6�   �� 5   
   -   5         ��Name$ BTN_Inscription��5      $��INSCRIPTION
��6*   $
��Left=�6E   $��	507,5,0,0q�6`   $	��Top=�6s   $��28��6�   $	��169��6�   $��1��6�   �� 5   
   -   5        $ 
TBX_Pseudo��5      $
��Left=�6&   $��	150,5,0,0q�6A   $
 Wrap=�6T   $	��Top=�6h   $	��145��6�   $��22��6�   $��1��6�   �� 5   
   -   5        $ TBX_Mail��5      $
��Left=�6$   $��
150,65,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $	��145��6   $��22��6�   $��1��6�   �� 5   
   $��Date de naissance��6   $
��Left=�6,   $��
32,117,0,0q�6G   $	��Top=�6[   $ 0.468,-0.118&�6s   $��1��6�   �� 5   
   $��Adresse Mail��6   $
��Left=�6'   $��	52,63,0,0q�6B   $	��Top=�6U   $ 0.468,-0.118&�6m   $��1��6�   G� 5   
   -   5         G�Name$ TBX_Mdp��5      $��150,221,479,49q�6'   $��1��6?   5       5"      