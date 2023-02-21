using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace audiopleer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary> 


    ///17 17 17 17 17 17 17 17 17 17 17 17 17 17 17 17 17 17 17 17 17 17 17 19 сенеи волны опять завут меня в мор'е

    ///рофлокотики в проекте? wtf? - с котиками легче    --- приколыш но иногда депресыш


    public partial class MainWindow : Window
    {
        private TimeSpan TotalTime;
        int index = 1;
        private int counter = 0;
        List<string> MP3PATHCOLLECTOR = new List<string>();
        private bool isRand = false;//для функции перемешки

        public MainWindow()
        {
            InitializeComponent();
        }
        private void showAll()//вывод всего при выборе папки
        {
            chs_btn.Margin = new Thickness(570, 57, 10, 0);
            img.Visibility = Visibility.Visible;
            song_name.Visibility = Visibility.Visible;
            slider.Visibility = Visibility.Visible;
            play_btn.Visibility = Visibility.Visible;
            stop_btn.Visibility = Visibility.Visible;
            next_btn.Visibility = Visibility.Visible;
            prev_btn.Visibility = Visibility.Visible;
            rand_btn.Visibility = Visibility.Visible;
        }
        private void startMusic()
        {
            if (index > MP3PATHCOLLECTOR.Count - 1)
            {
                index = 0;
            }
            song_name.Text = MP3PATHCOLLECTOR[index].Split("\\").Last().Split(".mp3")[0];
            media.Source = new Uri(MP3PATHCOLLECTOR[index]);
            media.Play();
            media.Volume = 0.7;
            index++;

        }
        private void chs_btn_Click(object sender, RoutedEventArgs e)
        {
            MP3PATHCOLLECTOR.Clear();
            var dialog = new CommonOpenFileDialog()
            {
                IsFolderPicker = true
            };
            var res = dialog.ShowDialog();
            if (res == CommonFileDialogResult.Ok)
            {
                string[] files = Directory.GetFiles(dialog.FileName);
                List<string> sorted = new List<string>();
                foreach (string file in files)
                {
                    if (file.Contains("mp3"))
                    {
                        MP3PATHCOLLECTOR.Add(file);
                        var a = file.Split("\\");
                        sorted.Add(a[a.Length - 1]);
                    }
                }
                lb.ItemsSource = sorted;
                showAll();
                startMusic();

            }
            else
            {
                MessageBox.Show("Вы выбрали неверную папку!");
            }
        }

        private void lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lb.SelectedItem == null)
            {

            }
            else
            {
                int findIndex = 0;
                foreach (var item in MP3PATHCOLLECTOR)
                {
                    if (item.Contains(lb.SelectedItem.ToString()))
                    {
                        findIndex = MP3PATHCOLLECTOR.IndexOf(item);
                    }
                }
                song_name.Text = MP3PATHCOLLECTOR[findIndex].Split("\\").Last().Split(".mp3")[0];
                media.Stop();
                media.Source = new Uri(MP3PATHCOLLECTOR[findIndex]);
                media.Play();
                media.Volume = 0.7;
                lb.SelectedItem = null;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((e.OriginalSource as Button).Name == "play_btn")
            {
                media.Play();
            }
            else if ((e.OriginalSource as Button).Name == "stop_btn")
            {
                media.Pause();
            }
            else if ((e.OriginalSource as Button).Name == "next_btn")
            {
                index += 1;
                if (index > MP3PATHCOLLECTOR.Count - 1)
                {
                    index = 0;
                    media.Stop();
                    media.Source = new Uri(MP3PATHCOLLECTOR[index]);
                    song_name.Text = MP3PATHCOLLECTOR[index].Split("\\").Last().Split(".mp3")[0];
                    media.Play();
                    media.Volume = 0.7;
                }
                else
                {
                    media.Stop();
                    media.Source = new Uri(MP3PATHCOLLECTOR[index]);
                    song_name.Text = MP3PATHCOLLECTOR[index].Split("\\").Last().Split(".mp3")[0];
                    media.Play();
                    media.Volume = 0.7;
                }
            }
            else if ((e.OriginalSource as Button).Name == "prev_btn")
            {
                counter++;
                if (counter == 2)
                {
                    counter = 0;
                    index -= 1;
                    if (index < 0)
                    {
                        index = MP3PATHCOLLECTOR.Count - 1;
                        media.Stop();
                        media.Source = new Uri(MP3PATHCOLLECTOR[index]);
                        song_name.Text = MP3PATHCOLLECTOR[index].Split("\\").Last().Split(".mp3")[0];
                        media.Play();
                        media.Volume = 0.7;
                    }
                    else
                    {
                        media.Stop();
                        media.Source = new Uri(MP3PATHCOLLECTOR[index]);
                        song_name.Text = MP3PATHCOLLECTOR[index].Split("\\").Last().Split(".mp3")[0];
                        media.Play();
                        media.Volume = 0.7;
                    }
                }
                else
                {
                    media.Stop();
                    media.Play();
                }
            }
            else if ((e.OriginalSource as Button).Name == "rand_btn")
            {
                Random random = new Random();
                index = random.Next(0, MP3PATHCOLLECTOR.Count - 1);
                media.Stop();
                media.Source = new Uri(MP3PATHCOLLECTOR[index]);
                song_name.Text = MP3PATHCOLLECTOR[index].Split("\\").Last().Split(".mp3")[0];
                media.Play();
                media.Volume = 0.7;
            }

        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            AdjustWindowSize();
        }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void AdjustWindowSize()
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                MaxButton.Content = "▢";
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                MaxButton.Content = "▢";
            }

        }

        private void media_MediaEnded(object sender, RoutedEventArgs e)
        {
            index++;
            startMusic();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //slider.Value = e.NewValue;  wtf help me bruh
            media.Position = new TimeSpan(Convert.ToInt64(slider.Value));
            
        }

        private void media_MediaOpened(object sender, RoutedEventArgs e)
        {
            slider.Value = 0;
            slider.Maximum = media.NaturalDuration.TimeSpan.Ticks;
            slider.Delay = 1;
            slider.TickFrequency = 1;
            /*Thread t = new Thread(_ =>
            {
                Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                    while (slider.Value < slider.Maximum)
                    {
                        Thread.Sleep(1000);
                        slider.Value++;
                    }
                }));
            });
            t.Start();*/

            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += ticktimer;
            dt.Start();
        }

        private void ticktimer(object sender, EventArgs e)
        {
            slider.Value = media.Position.Ticks;
        }

    }

}
