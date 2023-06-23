using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Data;
using org.mariuszgromada.math.mxparser;
namespace Scientific_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool opFlag = false; // true or false for actions
        private double saved = 0; // txtresult
        private string op =string.Empty ;
        private double memory = 0; //our memory
             
        public MainWindow()
        {
            InitializeComponent();

           
        }

        //clicks for digits 

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //Button btn = sender as Button;

            //if (txtResult.Text == "0" || opFlag == true)
            //{
            //    txtResult.Text = btn.Content.ToString();
            //    opFlag= false;
            //}
            //else
            //    txtExp.Text += btn.Content.ToString();
            //Button button = (Button)sender;

            Button button = (Button)sender;

            
            // получаем содержимое кнопки
            string content = button.Content.ToString();

            // добавляем содержимое кнопки в поле выражения
            txtResult.Text += content;

        }

        // for dot click0
        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
           
                txtResult.Text += ".";
        }


        //PlusMinus
        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            double v = double.Parse(txtResult.Text);
            v = -v;
            txtResult.Text = v.ToString();
        }

        

        // equal
        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                // вычисляем значение выражения
                string expression = new DataTable().Compute(txtExp.Text + txtResult.Text, null).ToString();

                // выводим результат на экран
                //txtExp.Text = expression;
                txtResult.Text = expression;

                // добавляем выражение в историю
                ListHistory.Items.Add(txtExp.Text +  txtResult.Text + " = " + expression);

                // очищаем поле выражения
                //txtExp.Text = "";
            }
            catch (Exception ex)
            {
                // выводим ошибку на экран
                txtResult.Text = "Error: " + ex.Message;

                // очищаем поле выражения
                txtExp.Text = "";
            }
        }

        private void btnRecip_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {

                var split1 = txtResult.Text.Split('(').Last();
                //  var split2 = txtExp.Text.Remove(txtExp.Text.LastIndexOf(' '));
                txtExp.Text += (1 / double.Parse(txtResult.Text)).ToString();
                // txtExp.Text = split2;
            }
            catch { txtResult.Text = "Enter trigonometric function on the first place: "; }
        }
   
        private void btnSqr_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var split1 = txtResult.Text.Split('(').Last();
                //  var split2 = txtExp.Text.Remove(txtExp.Text.LastIndexOf(' '));
                txtExp.Text += (double.Parse(txtResult.Text) * double.Parse(txtResult.Text)).ToString();
                // txtExp.Text = split2;
            }
            catch { txtResult.Text = "Enter trigonometric function on the first place: "; }
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var split1 = txtResult.Text.Split('(').Last();
                //  var split2 = txtExp.Text.Remove(txtExp.Text.LastIndexOf(' '));
                txtExp.Text += (Math.Sqrt(double.Parse(split1))).ToString();
                // txtExp.Text = split2;
            }
            catch { txtResult.Text = "Enter trigonometric function on the first place: "; }
            txtResult.Text = "";
        }
       
        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txtExp.Text = "";
            txtResult.Text = "";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "";
            txtExp.Text = "";
            saved = 0;
            op = "";
            opFlag  = false;   

        }



        private void btnDelete_CLick(object sender, RoutedEventArgs e)
        {
            txtExp.Text = txtExp.Text.Remove(txtExp.Text.Length - 1);
            if (txtExp.Text.Length == 0)
            {
                txtExp.Text = "";
            }
        }
        // memory clear
        private void btnMC_Click(object sender, RoutedEventArgs e)
        {
            memory = 0;
            
        }
        // recall
        private void btnMR_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = memory.ToString();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            
            txtExp.Text += txtResult.Text + " + ";
            txtResult.Text = "";
        }

        private void btnMMinus_Click(object sender, RoutedEventArgs e)
        {
            memory -= double.Parse(txtResult.Text);
        }
        // saving into memory
        private void btnMS_Click(object sender, RoutedEventArgs e)
        {
            memory = double.Parse(txtResult.Text);
           
        }

        

        private void Menu3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            txtExp.Text += txtResult.Text + " - " ;
            txtResult.Text = "";

        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            txtExp.Text += txtResult.Text + " * ";
            txtResult.Text = "";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            txtExp.Text += txtResult.Text + " / ";
            txtResult.Text = "";
        }

        private void btnTg_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var split1 = txtResult.Text.Split('(').Last();
                //  var split2 = txtExp.Text.Remove(txtExp.Text.LastIndexOf(' '));
                txtExp.Text += (Math.Tan(Math.PI * double.Parse(split1) / 180)).ToString();
                // txtExp.Text = split2;
            }
            catch { txtResult.Text = "Enter trigonometric function on the first place: "; }
            txtResult.Text = "";
        }

        private void btnCos_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var split1 = txtResult.Text.Split('(').Last();
                //  var split2 = txtExp.Text.Remove(txtExp.Text.LastIndexOf(' '));
                txtExp.Text += (Math.Cos(Math.PI * double.Parse(split1) / 180)).ToString();
                // txtExp.Text = split2;
            }
            catch { txtResult.Text = "Enter trigonometric function on the first place: "; }
            txtResult.Text = "";
        }

        private void btnSin_Click(object sender, RoutedEventArgs e)
        {
            
           
            try
            {
                
                var split1 = txtResult.Text.Split('(').Last();
              //  var split2 = txtExp.Text.Remove(txtExp.Text.LastIndexOf(' '));
                txtExp.Text += (Math.Sin(Math.PI *  double.Parse(split1)/180)).ToString();
               // txtExp.Text = split2;
            }
            catch { txtResult.Text = "Enter trigonometric function on the first place: "; }
            txtResult.Text = "";

        }

        private void btnBracket_Right_Click(object sender, RoutedEventArgs e)
        {
            txtExp.Text += txtResult.Text + ")";
            txtResult.Text = "";
        }

        private void btnBracket_Left_Click(object sender, RoutedEventArgs e)
        {
            txtExp.Text += txtResult.Text + "(";
            txtResult.Text = "";

        }

        private void btnMPlus_Click(object sender, RoutedEventArgs e)
        {
            memory += double.Parse(txtResult.Text);
        }

        private void btnPi_Click(object sender, RoutedEventArgs e)
        {
            txtExp.Text += "3.1415926535";
            txtResult.Text = "";
        }
    }
}
 

       
    




