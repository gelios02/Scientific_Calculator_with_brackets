//using System;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Shapes;
//using System.Data;

//namespace Scientific_Calculator
//{
//    public partial class MainWindow : Window
//    {
//        public MainWindow()
//        {
//            InitializeComponent();
//        }

//        private void btn_Click(object sender, RoutedEventArgs e)
//        {
//            // получаем кнопку, на которую нажали
//            Button button = (Button)sender;

//            // получаем содержимое кнопки
//            string content = button.Content.ToString();

//            // добавляем содержимое кнопки в поле выражения
//            txtExp.Text += content;
//        }



//        private void btnPlus_Click(object sender, RoutedEventArgs e)
//        {
//            txtExp.Text += "+";
//        }

//        private void btnMinus_Click(object sender, RoutedEventArgs e)
//        {
//            txtExp.Text += "-";
//        }

//        private void btnMultiply_Click(object sender, RoutedEventArgs e)
//        {
//            txtExp.Text += "*";
//        }

//        private void btnDivide_Click(object sender, RoutedEventArgs e)
//        {
//            txtExp.Text += "/";
//        }

//        private void btnBracket_Left_Click(object sender, RoutedEventArgs e)
//        {
//            txtExp.Text += "(";
//        }

//        private void btnBracket_Right_Click(object sender, RoutedEventArgs e)
//        {
//            txtExp.Text += ")";
//        }

//        private void btnSin_Click(object sender, RoutedEventArgs e)
//        {
//            txtExp.Text += "sin";
//        }

//        private void btnCos_Click(object sender, RoutedEventArgs e)
//        {
//            txtExp.Text += "cos(";
//        }




//        //private void CalculateTrigonometricFunction(string functionName)
//        //{
//        //    double result = 0;
//        //    double value = 0;

//        //    if (txtExp.Text != null)
//        //    {
//        //        //txtResult.Text = Math.Sin(0).ToString();

//        //        switch (functionName)
//        //        {
//        //            case "sin":
//        //                txtExp.Text = (Math.Cos(value)).ToString();
//        //                break;
//        //            case "cos":
//        //                result = Math.Cos(value);
//        //                break;
//        //            case "tan":
//        //                result = Math.Tan(value);
//        //                break;
//        //        }

//        //    }
//        //    //return result;

//        //}



//        private void btnCalculate_Click(object sender, RoutedEventArgs e)
//        {
//            /*if (txtExp.Text.Contains("sin("))
//            {
//                CalculateTrigonometricFunction("sin");
//            }
//            else if (txtExp.Text.Contains("cos("))
//            {
//                CalculateTrigonometricFunction("cos");
//            }
//            else if (txtExp.Text.Contains("tan("))
//            {
//                CalculateTrigonometricFunction("tan");
//            }*/
//        }

//        private void btnEqual_Click(object sender, RoutedEventArgs e)
//        {
//            try
//            {
//                // вычисляем значение выражения
//                string expression = new DataTable().Compute(txtExp.Text, null).ToString();

//                // выводим результат на экран
//                txtResult.Text = expression;

//                // добавляем выражение в историю
//                ListHistory.Items.Add(txtExp.Text + " = " + expression);

//                // очищаем поле выражения
//                txtExp.Text = "";
//            }
//            catch (Exception ex)
//            {
//                // выводим ошибку на экран
//                txtResult.Text = "Error: " + ex.Message;

//                // очищаем поле выражения
//                txtExp.Text = "";
//            }
//        }

//        private void btnTg_Click(object sender, RoutedEventArgs e)
//        {
//            txtExp.Text += "tan(";
//        }

//        private void btnDot_Click(object sender, RoutedEventArgs e)
//        {

//        }

//        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
//        {

//        }

//        private void btnDelete_CLick(object sender, RoutedEventArgs e)
//        {

//        }

//        private void btnC_Click(object sender, RoutedEventArgs e)
//        {

//        }

//        private void btnCE_Click(object sender, RoutedEventArgs e)
//        {
//            txtResult.Clear();
//            txtExp.Clear();
//        }

//        private void btnRecip_Click(object sender, RoutedEventArgs e)
//        {

//        }

//        private void btnSqr_Click(object sender, RoutedEventArgs e)
//        {

//        }

//        private void btnSqrt_Click(object sender, RoutedEventArgs e)
//        {

//        }

//        private void btnPercent_Click(object sender, RoutedEventArgs e)
//        {

//        }

//        private void btnMC_Click(object sender, RoutedEventArgs e)
//        {

//        }

//        private void btnMR_Click(object sender, RoutedEventArgs e)
//        {

//        }

//        private void btnMPlus_Click(object sender, RoutedEventArgs e)
//        {

//        }

//        private void btnMMinus_Click(object sender, RoutedEventArgs e)
//        {

//        }

//        private void btnMS_Click(object sender, RoutedEventArgs e)
//        {

//        }

//        private void Menu3_Click(object sender, RoutedEventArgs e)
//        {

//        }
//    }
//}




