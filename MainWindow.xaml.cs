using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
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

namespace Lecture_Example___Rich_Text_Box__Advanced_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Page Document
        FlowDocument fdDisplay = new FlowDocument();
        public MainWindow()
        {
            InitializeComponent();
            rtbDisplay.Document = fdDisplay;
        }

        private void btnDisplayInfo_Click(object sender, RoutedEventArgs e)
        {
            //Paragraph para1 = new Paragraph();
            //Run run1 = new Run("Lecrure Example - Rich Text Box Advanced");

            ////Add a sigle line to the paragraph, then add the paragraph to the page document.

            //   para1.Inlines.Add(run1);
            //   fdDisplay.Blocks.Add(para1);

            fdDisplay.Blocks.Add(BlogPostFormatted());


        }
        public Run HeaderFormatted(string header)
        {
            Run newHeader = new Run(header);
            newHeader.Foreground = new SolidColorBrush(Colors.Red);
            newHeader.FontSize = 24;
            newHeader.FontStyle = FontStyles.Italic;
            newHeader.FontWeight = FontWeights.Bold;

            return newHeader;
        }
        public Run BodyFormatted(string body)
        {
            Run newBody = new Run(body);
            newBody.FontSize = 16;

            return newBody;
        }
        public Paragraph BlogPostFormatted()
        {
            Paragraph newPara = new Paragraph();

            string header = $"{tbHeader.Text}\n";
            string body = $"{rtbRunBody.Text}\n";

            Run newHeader = HeaderFormatted(header);
            Run newBody = BodyFormatted(body);

            newPara.Inlines.Add(newHeader);
            newPara.Inlines.Add(newBody);

           return newPara;

        }
    }//class
}//namespace
