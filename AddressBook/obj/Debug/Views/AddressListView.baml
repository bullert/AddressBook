   M S B A M L   `   `   `  ����F  BAddressBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AddressBook.ViewsAddressBook.Views  5      ?$clr-namespace:AddressBook.ConvertersAddressBook.Converters  5      '    !AddressBook.Views.AddressListView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:AddressBook.Views     5      ;
converters$clr-namespace:AddressBook.Converters     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5
      -   5          >�Name$
  Root��5       � 	Resources 5      ,   &AddressBook.Converters.GenderConverter   GenderConverter9   3AddressBook.Converters.BooleanToVisibilityConverter   BooleanToVisibilityConverter  DataGridCellStyle �� 
TargetType*  $System.Windows.Controls.DataGridCell  MaterialDesignDataGridCell �� BasedOn �� Property �� Value �� Triggers P� Property P� Value  DataGridTextColumnStyle ) %MaterialDesignDataGridTextColumnStyle��%�  &	        &	      &	 &     7  &	 G    7    5   
   6%     5   
   62   �� 5   
   "  6*   8   .�5      ��  � ��$ 24 16q�6(   �� 5       � �� 6+   Z� �� 5       � �� 6,   Z�  5      P� 5       �@ 
IsSelected . . �5      ��  � �� 63   Z� �� 5       � �� 64   Z� 5      5      �� 5   
   " ��60   8   5      5      .��5       � 	 � RowDefinitions	 5"   
   �� 5#      �� 5$      �� 5%      .+�5(   
   � $��0��6   $
��8 16q�6   
 � ColumnDefinitions
 5)      �� 5*      �� 5+      .+�5-      �� $��0��6    �� Orientation$ 
Horizontal=�6)   .+�5.      �� $	��ADD��5/      $
��16 5q�50      $	��2 0q�51        MaterialDesignFlatButton#��[ 52        PrimaryHueLightBrush#��[ 53      $!��AddressListAddItemViewModel��55      ��54      �� *!MainViewModel.UpdateViewCommand+55      �� 56      $��	EDIT MODE��57      $
��16 5q�58      $	��2 0q�59      #��[ 5:      #��[ 5;      ��5<      �� *ToggleEditModeCommand+5=      �� 5>      $��1��6   $ 
Horizontal=�6)   $��Right=�6B   .+�5?      �� $
��12 5q�5@      $	��2 0q�5A       � ToolTip$ Zapisz��5B      +  %MaterialDesignThemes.Wpf.RippleAssist   RippleSizeMultiplier$ .7Q�5C        MaterialDesignToolButton#��[ 5D       #	 MaterialDesignToolTipBackground#��[	 5E      ��5F      �� *SaveAddressListCommand+.��5G      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ContentSave=�6.   $��20��6A   $��20��6L   5H      �� 5I      $
��12 5q�5J      $	��2 0q�5K      $ Usuń��5L      $ .7Q�5M      #��[ 5O      #��[	 5P      y�5N      �� *DataContext.IsEditModeEnabled+ �� ElementName$
 Root�� �� 	Converter# [  �� UpdateSourceTrigger$ PropertyChanged=���5Q      �� *" DeleteSelectedSubscribersCommand+.��5R        $ Delete=�6.   $��20��6<   $��20��6G   5S      5T      5U      �� 5W   
    
 MaterialDesignDarkSeparator#��[
 5X      $��32q�5Y      $��
0 28 0 -28q�5Z       K� ZIndex$ 1��5[      �� 5]   
   #��[
 5^      $��32q�5_      $��
0 78 0 -78q�5`      $ 1��5a      �� 5c   
   $��1��6   .+�5e      &   System.Windows.Controls.DataGrid     	CellStyle# [ 5f       & "MaterialDesignDataGridColumnHeader   ColumnHeaderStyle# [ 5g        MaterialDesignBackground#��[ 5h         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5i         CanUserAddRows .     AutoGenerateColumns .     CanUserResizeColumns .     CanUserResizeRows .     
IsReadOnly . ��5e      �� *FilteredSubscribersList+   Columns 5p      4  .System.Windows.Controls.DataGridTemplateColumn  5r      ,	  &System.Windows.Controls.DataGridColumn 	  Width$ 96 5s       	  HeaderTemplate 5t      �� 5u      .R�5v   "   �� .+�5w   &   �� $��48 -36 -48 36q�5x   )   $ Zaznacz wszystko��5y   )    d� 	IsChecked 5z   )   �� *DataContext.ToggleSelectAll+$
 Root��$ PropertyChanged=�y�5{   )   �� *DataContext.IsEditModeEnabled+$
 Root��# [ $ PropertyChanged=� � LayoutTransform 5|   *   �� 5}   .     �� ScaleX$	  1.2Q�6=   ! �� ScaleY$	! 1.2Q�6J   5   '   5�   #   5�      "   CellTemplate" 5�      �� 5�      .R�5�   "   �� .+�5�   &   �� $��48 -4 -48 4q�5�   )   $ Zaznacz��5�   )    5�   )   �� *	CanDelete+$ PropertyChanged=�y�5�   )   �� *DataContext.IsEditModeEnabled+$
 Root��# [ $ PropertyChanged=� 5�   *   �� 5�   .   $	  1.2Q�6=   $	! 1.2Q�6J   5�   '   �� 5�   &    & "MaterialDesignToolForegroundButton#��[ 5�   )   #��[	 5�   )   $
��0 -8q�5�   )   $��0q�5�   )   $ Edytuj��5�   )   #   
IsDisabled# . ��5�   )   �� *#!DataContext.EditSubscriberCommand+$
 Root����5�   )   �� y�5�   )   �� *DataContext.IsEditModeEnabled+$
 Root��# [ $ PropertyChanged=�.��5�   *     $
 Edit=�5�   -   $��20��5�   -   $��20��5�   -   5�   '   5�   #   5�      5�      0
  *System.Windows.Controls.DataGridTextColumn
  5�      $ 	  Header$$ Imię��5�      1  +System.Windows.Controls.DataGridBoundColumn%   ElementStyle#% [ 5�      &   Binding& 5�      �� *	FirstName+ 5�      �� 5�      .R�5�   "   � 	 5�   &   �� 5�   *   �� 5�   *   .+�5�   &   �� $��0��60   ��6=   �� *	Content+' �� RelativeSource' �� ( �� Mode$( TemplatedParent=��� 5�   &   $��1��6-   .+�5�   *   �� )  #MaterialDesignThemes.Wpf.HintAssist)   Hint$) 	Filter...��5�   -   .  (MaterialDesignThemes.Wpf.TextFieldAssist*   HasClearButton* . ��5�   -   �� *DataContext.FirstNameFilter+$
 Root��$ PropertyChanged=�5�   -   5�   '   5�   #   5�      5�      
  5�      $$ Nazwisko��6)   #% [ 5�   )   & 5�   )   �� *
LastName+ 5�      �� 5�      .R�5�   "   � 	 5�   &   �� 5�   *   �� 5�   *   .+�5�   &   �� $��0��60   ��6=   �� *	Content+' �� $( TemplatedParent=��� 5�   &   $��1��6-   .+�5�   *   �� $) 	Filter...��5�   -   * . ��5�   -   �� *DataContext.LastNameFilter+$
 Root��$ PropertyChanged=�5�   -   5�   '   5�   #   5�      5�      
  5�      $$ Płeć��6)   #% [ 5�   )   & 5�   )   �� *Gender+# [   5�      �� 5�      .R�5�   "   � 	 5�   &   �� 5�   *   �� 5�   *   .+�5�   &   �� $��0��60   ��6=   �� *	Content+' �� $( TemplatedParent=��� 5�   &   $��1��6-   .+�5�   *   �� $��	0 11 0 11q�5�   -   $	��0 5q�5�   -   + �� SelectedValuePath$	+ Key��5�   -   , �� DisplayMemberPath$, Value��5�   -   $) 	Filter...��5�   -   - �� SelectedValue- 5�   -   �� *DataContext.GenderFilter+$
 Root��$ PropertyChanged=���5�   -   �� *-+DataContext.GenderAdapter.ExtendedPairsList+$
 Root��5�   +   5�   '   5�   #   5�      5�      
  5�      $$ Rok urodzenia��6)   #% [ 5�   )   & 5�   )   �� *YearOfBirth+ 5�      �� 5�      .R�5�   "   � 	 5�   &   �� 5�   *   �� 5�   *   .+�5�   &   �� $��0��60   ��6=   �� *	Content+' �� $( TemplatedParent=��� 5�   &   $��1��6-   .+�5�   *   �� .+�5�   .   � $
��auto��63   
 5�   2   �� 5�   6   �� 5�   6   .+�5�   2   �� $��0��5�   5   $
��auto��5�   5   $��
0 11 12 11q�5   5   $	��0 5q�5  5   $	+ Key��5  5   $, Value��5  5   $	) ...��5  5   .   
PrefixText$	. od ��5  5   - 5  5   �� *'%DataContext.YearOfBirthMinRangeFilter+$
 Root��$ PropertyChanged=���5  5   �� *20DataContext.YearOfBirthAdapter.ExtendedPairsList+$
 Root����5  6   �� 5	  :   .R�5
  >   �� .+�5  B   �� ��6L   �� *Value+5  ?   5  ;   5  3   �� 5  2   $��1��5  5   $
��auto��5  5   $��
12 11 0 11q�5  5   $	��0 5q�5  5   $	+ Key��5  5   $, Value��5  5   $	) ...��5  5   $	. do ��5  5   - 5  5   �� *'%DataContext.YearOfBirthMaxRangeFilter+$
 Root��$ PropertyChanged=���5  5   �� *20DataContext.YearOfBirthAdapter.ExtendedPairsList+$
 Root����5  6   �� 5  :   .R�5  >   �� .+�5  B   �� ��6L   �� *Value+5  ?   5   ;   5"  3   5#  /   5$  +   5%  '   5&  #   5'     5)     
  5+     $$ Miasto��6)   #% [ 5-  )   & 5,  )   �� *Address.City+ 5.     �� 5/     .R�50  "   � 	 51  &   �� 52  *   �� 53  *   .+�55  &   �� $��0��60   ��6=   �� *	Content+' �� $( TemplatedParent=��� 56  &   $��1��6-   .+�57  *   �� $) 	Filter...��59  -   * . ��58  -   �� *DataContext.CityFilter+$
 Root��$ PropertyChanged=�5:  -   5;  '   5<  #   5=     5?     
  5A     $$ Ulica��6)   #% [ 5C  )   & 5B  )   �� *Address.Street+ 5D     �� 5E     .R�5F  "   � 	 5G  &   �� 5H  *   �� 5I  *   .+�5K  &   �� $��0��60   ��6=   �� *	Content+' �� $( TemplatedParent=��� 5L  &   $��1��6-   .+�5M  *   �� $) 	Filter...��5O  -   * . ��5N  -   �� *DataContext.StreetFilter+$
 Root��$ PropertyChanged=�5P  -   5Q  '   5R  #   5S     5U     
  5W     $$ Numer mieszkania��6)   #% [ 5Y  )   & 5X  )   �� *Address.PropertyNumber+ 5Z     �� 5[     .R�5\  "   � 	 5]  &   �� 5^  *   �� 5_  *   .+�5a  &   �� $��0��60   ��6=   �� *	Content+' �� $( TemplatedParent=��� 5b  &   $��1��6-   .+�5c  *   �� $) 	Filter...��5e  -   * . ��5d  -   �� *" DataContext.PropertyNumberFilter+$
 Root��$ PropertyChanged=�5f  -   5g  '   5h  #   5i     5k     
  5m     $$ Kod pocztowy��6)   #% [ 5o  )   & 5n  )   �� *Address.Postcode+ 5p     �� 5q     .R�5r  "   � 	 5s  &   �� 5t  *   �� 5u  *   .+�5w  &   �� $��0��60   ��6=   �� *	Content+' �� $( TemplatedParent=��� 5x  &   $��1��6-   .+�5y  *   �� $) 	Filter...��5{  -   * . ��5z  -   �� *DataContext.PostcodeFilter+$
 Root��$ PropertyChanged=�5|  -   5}  '   5~  #   5     5�     5�     5�     �� 5�  
   $��2��6   $��48��6"   5�     5�     5�     