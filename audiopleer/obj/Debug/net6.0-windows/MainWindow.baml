   M S B A M L   `   `   `  ????E  Aaudiopleer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:audiopleer
audiopleer  5   	       audiopleer.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   $localclr-namespace:audiopleer  5   	     ? WindowStyle$
  None=?5
   	    ? WindowStartupLocation$ CenterScreen=?5   	    ? Title$ 
MainWindow??5   	   $	??480??6   $	??800??6)   ???	#FF1C7CDF??5   	   ??  ?? Source# Zo? ?? Path$ Width???5   	   ?? # Zo?$ Height?.??5      ? ???	#FF512878 ? RowDefinitions 5   
   ?? 5      $
??227* ?6   ?? 5      $	??40* ?6   ?? 5      $
??213* ?6   .+?5   
   ]? -   5         ]?Name$ 
RootWindow??5      $??3??6(   .+?5      ]? -   5        $ TitleBar??5      $	??Top=?6*   .+?5      ?? -   5         ??Name$ CloseButton??5      $??X??6.   $??Right=?5      ?? 5      -   5        $ 	MaxButton??5      $	??▢??6,   $??Right=?5      ?? 5      -   5        $ 	MinButton??5      $??-??6,   $??Right=?5!      ?? 5#      $??Center=?6   
???????$??Cascadia Code)?6L   $??19(?6g   
Audiopleer6?   5$      ?? 5&      ??6   ?? *CurrentPage+5(      ?? 5)   
   -   5         ??Name$	 img??5)      $
??Left=?6   $	??209??68   $??	38,57,0,0q?6E   $	??Top=?6X   $	??314??6p   	 J? OpacityMask
	 ?????"  WpfAnimatedGif.ImageBehavior
   AnimatedSource$
 guitar-cat.gif??6?   $
??Fill=?6?   $y?Hidden=?6?   $??2??6?   ?? 5*   
   -   5        $ chs_btn??5*      $??Выбрать папку??6"   $??Center=?6:   $??Center=?6W   $	??192??6r   ???	#FF688FF3 ? Cursor$
 Hand??6?   $??1??6?   $??32??6?   ?? 5+   
   -   5         ??Name$ lb??5+      $??557,110,10,0q?6   $??3??6[   r? 5,   
   -	   5         r?Name$ media??5,       r? LoadedBehavior$ Manual=?6&   $??3??6|   6?   ?? 5-   
   -
   5         ??Name$ 	song_name??5-      $
??Left=?6'   $??	38,15,0,0q?6B   $
??Wrap=?6U   $	??Top=?6i   $	??314??6?   $??30??6?    ?? TextAlignment$ Center=?6?   $??Cascadia Mono)?6?   $??14(?6?   
???????$y?Hidden=?6?   $??2??6   ?? 6   ? Language$ ru-ru?6  $?
Текст??6#  63  ?? 5.   
   -   5         ??Name$ slider??5.      $
??Left=?6!   $??	28,50,0,0q?6<   $	??Top=?6O   $	??334??6g   $??22??6s   $y?Hidden=?6   $??2??6?   ?? 5/   
   -   5        $ play_btn??5/      $	??▶??6#   $
??Left=?6/   $??	55,88,0,0q?6J   $	??Top=?6]   $
 Hand??6u   $??50??6?   $y?Hidden=?6?   $??2??6?   $??32??6?   ?? 50   
   -   5        $ stop_btn??50      $	??⏸??6#   $
??Left=?6/   $??
110,88,0,0q?6J   $	??Top=?6^   $??56??6v   $y?Hidden=?6?   $??2??6?   $??32??6?   ?? 51   
   -   5        $ next_btn??51      $	??⏩??6#   $
??Left=?6/   $??
171,88,0,0q?6J   $	??Top=?6^   $y?Hidden=?6v   $??2??6?   $??32??6?   $??51??6?   ?? 52   
   -   5        $ prev_btn??52      $	??⏪??6#   $
??Left=?6/   $??
227,88,0,0q?6J   $	??Top=?6^   $??Right=?6v   $y?Hidden=?6?   $??2??6?   $??32??6?   $??51??6?   ?? 53   
   -   5        $ rand_btn??53      $
??🔀??6#   $
??Left=?60   $??
283,88,0,0q?6K   $	??Top=?6_   $y?Hidden=?6w   $??2??6?   $??32??6?   $??51??6?   54      55      