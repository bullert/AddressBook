   M S B A M L   `   `   `  ����F  BAddressBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AddressBook.ViewsAddressBook.Views  5      .    (AddressBook.Views.AddressListAddItemView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      +localclr-namespace:AddressBook.Views  5      .��5
      � $��32q�6   $��16(�6     � ColumnDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��0��5      $��16q�5      .+�5      ��  (  $MaterialDesignFilledTextFieldTextBox#��[  6   $	��240��5      $��0q�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Imię��5          
IsFloating .  /  )MaterialDesignThemes.Wpf.ValidationAssist   
Background
 ����    HorizontalAlignment$ Right=�5#      ��5      �� *	FirstName+ �� UpdateSourceTrigger$ 	LostFocus=� �� ValidatesOnDataErrors . 5#      5$      �� 5&   
   $��0��6   $��1��5'      $��16q�5(      .+�5)      �� #��[  6   $	��240��5+      $��0q�5,      $ Nazwisko��5-       .  
 ���� $ Right=�50      ��5*      �� *
LastName+$ 	LostFocus=� . 50      51      �� 53   
   $��1��6   $��0��54      $��16q�55      .+�56      ��    MaterialDesignFilledComboBox#��[ 6   $	��240��57      $��10 -1q�58      $��16 12q�59       �� SelectedValuePath$	 Key��5<      	 �� DisplayMemberPath$	 Value��5=      $
 Wiek��5>       .  
 ���� $ Right=�5A      
 �� SelectedValue
 5:      �� *YearOfBirth+$ 	LostFocus=� . ��5;      �� *YearOfBirthAdapter.PairsList+5A      5B      �� 5D   
   $��1��6   $��1��5E      $��16q�5F      .+�5G      �� #��[ 6   $	��240��5H      $��10 -1q�5I      $��16 12q�5J      $	 Key��5M      $	 Value��5N      $ Płeć��5O       .  
 ���� $ Right=�5R      
 5K      �� *Gender+$ 	LostFocus=� . ��5L      �� *GenderAdapter.PairsList+5R      5S      �� 5U   
   $��2��6   $��0��5V      $��16q�5W      .+�5X      �� #��[  6   $	��240��5Z      $��0q�5[      $ Kod Pocztowy��5\       .  
 ���� $ Right=�5_      ��5Y      �� *
Postcode+$ 	LostFocus=� . 5_      5`      �� 5b   
   $��2��6   $��1��5c      $��16q�5d      .+�5e      �� #��[  6   $	��240��5g      $��0q�5h      $ Miasto��5i       .  
 ���� $ Right=�5l      ��5f      �� *City+$ 	LostFocus=� . 5l      5m      �� 5o   
   $��3��6   $��0��5p      $��16q�5q      .+�5r      �� #��[  6   $	��240��5t      $��0q�5u      $ Ulica��5v       .  
 ���� $ Right=�5y      ��5s      �� *Street+$ 	LostFocus=� . 5y      5z      �� 5|   
   $��3��6   $��1��5}      $��16q�5~      .+�5      �� #��[  6   $	��240��5�      $��0q�5�      $ Numer domu/mieszkania��5�       .  
 ���� $ Right=�5�      ��5�      �� *PropertyNumber+$ 	LostFocus=� . 5�      5�      �� 5�   
   $��4��6   $��1��5�      $��Right=�5�      $��16q�5�      .+�5�      �� $	��ADD��6     PrimaryHueLightBrush#��[ 5�       ! PrimaryHueDarkForegroundBrush#��[ 5�      
������ +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5�      $	��128��5�      $
��16 5q�5�      $	��2 0q�5�      ��5�      �� *AddSubscriberCommand+5�      5�      5�      5�      