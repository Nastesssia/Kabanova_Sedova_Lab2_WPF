using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Kabanova_Sedova_Lab2_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBlock res;
        private int countMen;
        private int countProp;
        private int[] mas;
        public MainWindow()
        {
            InitializeComponent();
            
                StackPanel stackPanel = new StackPanel();
                stackPanel.Orientation = Orientation.Horizontal;
                Label textBoxHeader = new Label { Width = 100 };
                textBoxHeader.Content = "Свойства/Имена";
                stackPanel.Children.Add(textBoxHeader);
                countMen = 0;
                foreach (Properties cand in Enum.GetValues(typeof(Properties)))
                {
                    Label textBoxInner = new Label { Width=100};
                    textBoxInner.Content = cand.ToString();
                    stackPanel.Children.Add(textBoxInner);
                    countProp++;
                }           
                Root.Children.Add(stackPanel);
                foreach (Candidate prop in Enum.GetValues(typeof(Candidate)))
                {
                    StackPanel stackPanelInner = new StackPanel();
                    stackPanelInner.Orientation = Orientation.Horizontal;
                stackPanelInner.HorizontalAlignment = HorizontalAlignment.Center;
                    Label textBox = new Label { Width = 100 };
                    textBox.Content = prop.ToString();
                    stackPanelInner.Children.Add(textBox);
                    foreach (Properties cand in Enum.GetValues(typeof(Properties)))
                    {
                        CheckBox checkBox = new CheckBox { Width=100};
                        stackPanelInner.Children.Add(checkBox);
                    }
                    Root.Children.Add(stackPanelInner);
                    countMen++;
                }
                StackPanel btn = new StackPanel();
                Button button = new Button();
                button.Content = "OK";
                btn.Children.Add(button);
                button.Click += Button_Click;
                Root.Children.Add(btn);

                StackPanel result = new StackPanel();
                res = new TextBlock();
                result.Children.Add(res);
                Root.Children.Add(result);
                mas = new int[countMen];
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            for (int i = 0; i < Root.Children.Count; i++)
            {
                if (Root.Children[i] is StackPanel)
                {
                    int k = 0;
                    StackPanel st = Root.Children[i] as StackPanel;
                    int m = 0;
                    for (int j = 0; j < st.Children.Count; j++)
                    {
                        if (st.Children[j] is CheckBox)
                        {
                            CheckBox ch = st.Children[j] as CheckBox;
                            if (ch.IsChecked==true) k++;
                            m++;
                        }
                    }
                    if (m == countProp)
                    {
                        mas[n] = k;
                        n++;
                    } 
                }
            }
            res.Text = "";
            
            for (int i = 0; i < mas.Length; i++)
            {
                res.Text += mas[i].ToString() + "\n";
            }

      





        }
    }
}
