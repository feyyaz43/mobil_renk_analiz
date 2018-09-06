using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;
using Microsoft.Phone;
using System.IO;


namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }


        PhotoChooserTask selectphoto = null;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            selectphoto = new PhotoChooserTask();
            selectphoto.Completed += new EventHandler<PhotoResult>(selectphoto_Completed);
            selectphoto.Show();

          
        }

        void selectphoto_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                BinaryReader reader = new BinaryReader(e.ChosenPhoto);
                image1.Source = new BitmapImage(new Uri(e.OriginalFileName));
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e) //kutu ciz
        {
            kutulari_cizdir(1,4);

        }

        private void kutulari_cizdir(int seviye, int alt_seviye)
        {
            switch (seviye)
            {
                case 1: //kolay

                    if (alt_seviye == 1)
                    {
                        Line line1 = new Line(); line1.Stroke = new SolidColorBrush(Colors.Blue); line1.StrokeThickness = 50; line1.X1 = 10; line1.Y1 = 300; line1.X2 = 75; line1.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line1);
                        Line line2 = new Line(); line2.Stroke = new SolidColorBrush(Colors.Blue); line2.StrokeThickness = 50; line2.X1 = 85; line2.Y1 = 300; line2.X2 = 150; line2.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line2);
                        Line line3 = new Line(); line3.Stroke = new SolidColorBrush(Colors.Blue); line3.StrokeThickness = 50; line3.X1 = 160; line3.Y1 = 300; line3.X2 = 225; line3.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line3);
                        Line line4 = new Line(); line4.Stroke = new SolidColorBrush(Colors.Blue); line4.StrokeThickness = 50; line4.X1 = 235; line4.Y1 = 300; line4.X2 = 300; line4.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line4);
                        Line line5 = new Line(); line5.Stroke = new SolidColorBrush(Colors.Blue); line5.StrokeThickness = 50; line5.X1 = 310; line5.Y1 = 300; line5.X2 = 375; line5.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line5);

                    }
                    else if (alt_seviye == 2)
                    {
                        Line line1 = new Line(); line1.Stroke = new SolidColorBrush(Colors.Blue); line1.StrokeThickness = 50; line1.X1 = 10; line1.Y1 = 300; line1.X2 = 75; line1.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line1);
                        Line line2 = new Line(); line2.Stroke = new SolidColorBrush(Colors.Blue); line2.StrokeThickness = 50; line2.X1 = 85; line2.Y1 = 300; line2.X2 = 150; line2.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line2);
                        Line line3 = new Line(); line3.Stroke = new SolidColorBrush(Colors.Blue); line3.StrokeThickness = 50; line3.X1 = 160; line3.Y1 = 300; line3.X2 = 225; line3.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line3);
                        Line line4 = new Line(); line4.Stroke = new SolidColorBrush(Colors.Blue); line4.StrokeThickness = 50; line4.X1 = 235; line4.Y1 = 300; line4.X2 = 300; line4.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line4);
                        Line line5 = new Line(); line5.Stroke = new SolidColorBrush(Colors.Blue); line5.StrokeThickness = 50; line5.X1 = 235; line5.Y1 = 360; line5.X2 = 300; line5.Y2 = 360; this.ContentPanelCanvas1.Children.Add(line5);

                    }
                    else if (alt_seviye == 3)
                    {
                        Line line1 = new Line(); line1.Stroke = new SolidColorBrush(Colors.Blue); line1.StrokeThickness = 50; line1.X1 = 10; line1.Y1 = 300; line1.X2 = 75; line1.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line1);
                        Line line2 = new Line(); line2.Stroke = new SolidColorBrush(Colors.Blue); line2.StrokeThickness = 50; line2.X1 = 85; line2.Y1 = 300; line2.X2 = 150; line2.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line2);
                        Line line3 = new Line(); line3.Stroke = new SolidColorBrush(Colors.Blue); line3.StrokeThickness = 50; line3.X1 = 85; line3.Y1 = 360; line3.X2 = 150; line3.Y2 = 360; this.ContentPanelCanvas1.Children.Add(line3);
                        Line line4 = new Line(); line4.Stroke = new SolidColorBrush(Colors.Blue); line4.StrokeThickness = 50; line4.X1 = 160; line4.Y1 = 360; line4.X2 = 225; line4.Y2 = 360; this.ContentPanelCanvas1.Children.Add(line4);
                        Line line5 = new Line(); line5.Stroke = new SolidColorBrush(Colors.Blue); line5.StrokeThickness = 50; line5.X1 = 235; line5.Y1 = 360; line5.X2 = 300; line5.Y2 = 360; this.ContentPanelCanvas1.Children.Add(line5);

                    }
                    else if (alt_seviye == 4)
                    {
                        Line line1 = new Line(); line1.Stroke = new SolidColorBrush(Colors.Blue); line1.StrokeThickness = 50; line1.X1 = 10; line1.Y1 = 300; line1.X2 = 75; line1.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line1);
                        Line line2 = new Line(); line2.Stroke = new SolidColorBrush(Colors.Blue); line2.StrokeThickness = 50; line2.X1 = 85; line2.Y1 = 300; line2.X2 = 150; line2.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line2);
                        Line line3 = new Line(); line3.Stroke = new SolidColorBrush(Colors.Blue); line3.StrokeThickness = 50; line3.X1 = 85; line3.Y1 = 360; line3.X2 = 150; line3.Y2 = 360; this.ContentPanelCanvas1.Children.Add(line3);
                        Line line4 = new Line(); line4.Stroke = new SolidColorBrush(Colors.Blue); line4.StrokeThickness = 50; line4.X1 = 85; line4.Y1 = 420; line4.X2 = 150; line4.Y2 = 420; this.ContentPanelCanvas1.Children.Add(line4);
                        Line line5 = new Line(); line5.Stroke = new SolidColorBrush(Colors.Blue); line5.StrokeThickness = 50; line5.X1 = 85; line5.Y1 = 480; line5.X2 = 150; line5.Y2 = 480; this.ContentPanelCanvas1.Children.Add(line5);

                    }
                    break;

                case 2: //orta

                    if (alt_seviye == 1)
                    {
                        Line line1 = new Line(); line1.Stroke = new SolidColorBrush(Colors.Blue); line1.StrokeThickness = 50; line1.X1 = 10; line1.Y1 = 300; line1.X2 = 75; line1.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line1);
                        Line line2 = new Line(); line2.Stroke = new SolidColorBrush(Colors.Blue); line2.StrokeThickness = 50; line2.X1 = 85; line2.Y1 = 300; line2.X2 = 150; line2.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line2);
                        Line line3 = new Line(); line3.Stroke = new SolidColorBrush(Colors.Blue); line3.StrokeThickness = 50; line3.X1 = 160; line3.Y1 = 300; line3.X2 = 225; line3.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line3);
                        Line line4 = new Line(); line4.Stroke = new SolidColorBrush(Colors.Blue); line4.StrokeThickness = 50; line4.X1 = 235; line4.Y1 = 300; line4.X2 = 300; line4.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line4);
                        Line line5 = new Line(); line5.Stroke = new SolidColorBrush(Colors.Blue); line5.StrokeThickness = 50; line5.X1 = 310; line5.Y1 = 300; line5.X2 = 375; line5.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line5);

                    }
                    else if (alt_seviye == 2)
                    {
                        Line line1 = new Line(); line1.Stroke = new SolidColorBrush(Colors.Blue); line1.StrokeThickness = 50; line1.X1 = 10; line1.Y1 = 300; line1.X2 = 75; line1.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line1);
                        Line line2 = new Line(); line2.Stroke = new SolidColorBrush(Colors.Blue); line2.StrokeThickness = 50; line2.X1 = 85; line2.Y1 = 300; line2.X2 = 150; line2.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line2);
                        Line line3 = new Line(); line3.Stroke = new SolidColorBrush(Colors.Blue); line3.StrokeThickness = 50; line3.X1 = 160; line3.Y1 = 300; line3.X2 = 225; line3.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line3);
                        Line line4 = new Line(); line4.Stroke = new SolidColorBrush(Colors.Blue); line4.StrokeThickness = 50; line4.X1 = 235; line4.Y1 = 300; line4.X2 = 300; line4.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line4);
                        Line line5 = new Line(); line5.Stroke = new SolidColorBrush(Colors.Blue); line5.StrokeThickness = 50; line5.X1 = 235; line5.Y1 = 360; line5.X2 = 300; line5.Y2 = 360; this.ContentPanelCanvas1.Children.Add(line5);

                    }
                    else if (alt_seviye == 3)
                    {
                        Line line1 = new Line(); line1.Stroke = new SolidColorBrush(Colors.Blue); line1.StrokeThickness = 50; line1.X1 = 10; line1.Y1 = 300; line1.X2 = 75; line1.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line1);
                        Line line2 = new Line(); line2.Stroke = new SolidColorBrush(Colors.Blue); line2.StrokeThickness = 50; line2.X1 = 85; line2.Y1 = 300; line2.X2 = 150; line2.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line2);
                        Line line3 = new Line(); line3.Stroke = new SolidColorBrush(Colors.Blue); line3.StrokeThickness = 50; line3.X1 = 85; line3.Y1 = 360; line3.X2 = 150; line3.Y2 = 360; this.ContentPanelCanvas1.Children.Add(line3);
                        Line line4 = new Line(); line4.Stroke = new SolidColorBrush(Colors.Blue); line4.StrokeThickness = 50; line4.X1 = 160; line4.Y1 = 360; line4.X2 = 225; line4.Y2 = 360; this.ContentPanelCanvas1.Children.Add(line4);
                        Line line5 = new Line(); line5.Stroke = new SolidColorBrush(Colors.Blue); line5.StrokeThickness = 50; line5.X1 = 235; line5.Y1 = 360; line5.X2 = 300; line5.Y2 = 360; this.ContentPanelCanvas1.Children.Add(line5);

                    }
                    else if (alt_seviye == 4)
                    {
                        Line line1 = new Line(); line1.Stroke = new SolidColorBrush(Colors.Blue); line1.StrokeThickness = 50; line1.X1 = 10; line1.Y1 = 300; line1.X2 = 75; line1.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line1);
                        Line line2 = new Line(); line2.Stroke = new SolidColorBrush(Colors.Blue); line2.StrokeThickness = 50; line2.X1 = 85; line2.Y1 = 300; line2.X2 = 150; line2.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line2);
                        Line line3 = new Line(); line3.Stroke = new SolidColorBrush(Colors.Blue); line3.StrokeThickness = 50; line3.X1 = 85; line3.Y1 = 360; line3.X2 = 150; line3.Y2 = 360; this.ContentPanelCanvas1.Children.Add(line3);
                        Line line4 = new Line(); line4.Stroke = new SolidColorBrush(Colors.Blue); line4.StrokeThickness = 50; line4.X1 = 85; line4.Y1 = 420; line4.X2 = 150; line4.Y2 = 420; this.ContentPanelCanvas1.Children.Add(line4);
                        Line line5 = new Line(); line5.Stroke = new SolidColorBrush(Colors.Blue); line5.StrokeThickness = 50; line5.X1 = 85; line5.Y1 = 480; line5.X2 = 150; line5.Y2 = 480; this.ContentPanelCanvas1.Children.Add(line5);

                    }
                    break;

                case 3: //zor

                    if (alt_seviye == 1)
                    {
                        Line line1 = new Line(); line1.Stroke = new SolidColorBrush(Colors.Blue); line1.StrokeThickness = 50; line1.X1 = 10; line1.Y1 = 300; line1.X2 = 75; line1.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line1);
                        Line line2 = new Line(); line2.Stroke = new SolidColorBrush(Colors.Blue); line2.StrokeThickness = 50; line2.X1 = 85; line2.Y1 = 300; line2.X2 = 150; line2.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line2);
                        Line line3 = new Line(); line3.Stroke = new SolidColorBrush(Colors.Blue); line3.StrokeThickness = 50; line3.X1 = 160; line3.Y1 = 300; line3.X2 = 225; line3.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line3);
                        Line line4 = new Line(); line4.Stroke = new SolidColorBrush(Colors.Blue); line4.StrokeThickness = 50; line4.X1 = 235; line4.Y1 = 300; line4.X2 = 300; line4.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line4);
                        Line line5 = new Line(); line5.Stroke = new SolidColorBrush(Colors.Blue); line5.StrokeThickness = 50; line5.X1 = 310; line5.Y1 = 300; line5.X2 = 375; line5.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line5);

                    }
                    else if (alt_seviye == 2)
                    {
                        Line line1 = new Line(); line1.Stroke = new SolidColorBrush(Colors.Blue); line1.StrokeThickness = 50; line1.X1 = 10; line1.Y1 = 300; line1.X2 = 75; line1.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line1);
                        Line line2 = new Line(); line2.Stroke = new SolidColorBrush(Colors.Blue); line2.StrokeThickness = 50; line2.X1 = 85; line2.Y1 = 300; line2.X2 = 150; line2.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line2);
                        Line line3 = new Line(); line3.Stroke = new SolidColorBrush(Colors.Blue); line3.StrokeThickness = 50; line3.X1 = 160; line3.Y1 = 300; line3.X2 = 225; line3.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line3);
                        Line line4 = new Line(); line4.Stroke = new SolidColorBrush(Colors.Blue); line4.StrokeThickness = 50; line4.X1 = 235; line4.Y1 = 300; line4.X2 = 300; line4.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line4);
                        Line line5 = new Line(); line5.Stroke = new SolidColorBrush(Colors.Blue); line5.StrokeThickness = 50; line5.X1 = 235; line5.Y1 = 360; line5.X2 = 300; line5.Y2 = 360; this.ContentPanelCanvas1.Children.Add(line5);

                    }
                    else if (alt_seviye == 3)
                    {
                        Line line1 = new Line(); line1.Stroke = new SolidColorBrush(Colors.Blue); line1.StrokeThickness = 50; line1.X1 = 10; line1.Y1 = 300; line1.X2 = 75; line1.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line1);
                        Line line2 = new Line(); line2.Stroke = new SolidColorBrush(Colors.Blue); line2.StrokeThickness = 50; line2.X1 = 85; line2.Y1 = 300; line2.X2 = 150; line2.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line2);
                        Line line3 = new Line(); line3.Stroke = new SolidColorBrush(Colors.Blue); line3.StrokeThickness = 50; line3.X1 = 85; line3.Y1 = 360; line3.X2 = 150; line3.Y2 = 360; this.ContentPanelCanvas1.Children.Add(line3);
                        Line line4 = new Line(); line4.Stroke = new SolidColorBrush(Colors.Blue); line4.StrokeThickness = 50; line4.X1 = 160; line4.Y1 = 360; line4.X2 = 225; line4.Y2 = 360; this.ContentPanelCanvas1.Children.Add(line4);
                        Line line5 = new Line(); line5.Stroke = new SolidColorBrush(Colors.Blue); line5.StrokeThickness = 50; line5.X1 = 235; line5.Y1 = 360; line5.X2 = 300; line5.Y2 = 360; this.ContentPanelCanvas1.Children.Add(line5);

                    }
                    else if (alt_seviye == 4)
                    {
                        Line line1 = new Line(); line1.Stroke = new SolidColorBrush(Colors.Blue); line1.StrokeThickness = 50; line1.X1 = 10; line1.Y1 = 300; line1.X2 = 75; line1.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line1);
                        Line line2 = new Line(); line2.Stroke = new SolidColorBrush(Colors.Blue); line2.StrokeThickness = 50; line2.X1 = 85; line2.Y1 = 300; line2.X2 = 150; line2.Y2 = 300; this.ContentPanelCanvas1.Children.Add(line2);
                        Line line3 = new Line(); line3.Stroke = new SolidColorBrush(Colors.Blue); line3.StrokeThickness = 50; line3.X1 = 85; line3.Y1 = 360; line3.X2 = 150; line3.Y2 = 360; this.ContentPanelCanvas1.Children.Add(line3);
                        Line line4 = new Line(); line4.Stroke = new SolidColorBrush(Colors.Blue); line4.StrokeThickness = 50; line4.X1 = 85; line4.Y1 = 420; line4.X2 = 150; line4.Y2 = 420; this.ContentPanelCanvas1.Children.Add(line4);
                        Line line5 = new Line(); line5.Stroke = new SolidColorBrush(Colors.Blue); line5.StrokeThickness = 50; line5.X1 = 85; line5.Y1 = 480; line5.X2 = 150; line5.Y2 = 480; this.ContentPanelCanvas1.Children.Add(line5);

                    }
                    break;
                default: break;

            }
        }

    }

}