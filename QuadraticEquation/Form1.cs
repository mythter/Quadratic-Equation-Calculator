/*
Файл: Form1.cs
Лабораторная робота № 2
Автор: Положий А. С.
Тема: Розробка та дослідження програми вирішення квадратного рівняння.
Дата створення: 23.02.2023
*/

using BuisnessLogic;
using Microsoft.Win32;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace QuadraticEquation
{
    public partial class QuadraticEquation : Form, IView
    {
        #region Caret disabled
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        public void HideCaret()
        {
            HideCaret(X1TextBox.Handle);
            HideCaret(X2TextBox.Handle);
        }
        #endregion

        Presenter presenter;
        public QuadraticEquation()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        public string A { get => ATextBox.Text; set => ATextBox.Text = value; }
        public string B { get => BTextBox.Text; set => BTextBox.Text = value; }
        public string C { get => CTextBox.Text; set => CTextBox.Text = value; }
        public string X1 { get => X1TextBox.Text; set => X1TextBox.Text = value; }
        public string X2 { get => X2TextBox.Text; set => X2TextBox.Text = value; }
        public bool Radio1 { get => radioButton1.Checked; set => radioButton1.Checked = value; }
        public bool Radio2 { get => radioButton2.Checked; set => radioButton2.Checked = value; }
        public bool Radio3 { get => radioButton3.Checked; set => radioButton3.Checked = value; }

        public event EventHandler CalcAttempted;
        public event EventHandler ClearAttempted;

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(A) || string.IsNullOrEmpty(B) || string.IsNullOrEmpty(C))
            {
                MessageBox.Show("Не все поля заполнены!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Radio1)
            {
                if (A.Contains(','))
                    A = A.Replace(",", ".");
                if (B.Contains(','))
                    B = B.Replace(",", ".");
                if (C.Contains(','))
                    C = C.Replace(",", ".");

                double a, b, c;

                if (!double.TryParse(A, NumberStyles.Any, CultureInfo.InvariantCulture, out a) ||
                    !double.TryParse(B, NumberStyles.Any, CultureInfo.InvariantCulture, out b) ||
                    !double.TryParse(C, NumberStyles.Any, CultureInfo.InvariantCulture, out c))
                {
                    MessageBox.Show("Поля заполнены некорректно!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double D = Math.Pow(b, 2) - 4 * a * c;

                if (a == 0 && b == 0)
                {
                    X1 = X2 = c.ToString();
                    return;
                }
                else if ((a == 0 && c == 0) || (b == 0 && c == 0))
                {
                    X1 = X2 = "0";
                    return;
                }
                else if (a == 0)
                {
                    X1 = X2 = (-c / b).ToString();
                    return;
                }
                else if (b == 0)
                {
                    if (c > 0)
                        X1 = X2 = "Ошибка! Корень < 0";
                    else
                        X1 = X2 = Math.Sqrt(-c / a).ToString();
                    return;
                }

                if (D < 0)
                    X1 = X2 = "Дискриминант < 0";
                else if (D == 0)
                    X1 = X2 = (-b / (2 * a)).ToString();
                else
                {
                    X1 = ((-b + Math.Sqrt(D)) / (2 * a)).ToString();
                    X2 = ((-b - Math.Sqrt(D)) / (2 * a)).ToString();
                }
            }
            else if (Radio2)
            {
                Calculate();
            }
            else
            {
                try
                {
                    CalcAttempted?.Invoke(this, EventArgs.Empty);
                }
                catch
                {
                    MessageBox.Show("Поля заполнены некорректно!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Calculate()
        {
            if (A.Contains(','))
                A = A.Replace(",", ".");
            if (B.Contains(','))
                B = B.Replace(",", ".");
            if (C.Contains(','))
                C = C.Replace(",", ".");

            double a, b, c;

            if (!double.TryParse(A, NumberStyles.Any, CultureInfo.InvariantCulture, out a) ||
                !double.TryParse(B, NumberStyles.Any, CultureInfo.InvariantCulture, out b) ||
                !double.TryParse(C, NumberStyles.Any, CultureInfo.InvariantCulture, out c))
            {
                MessageBox.Show("Поля заполнены некорректно!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double D = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0 && b == 0)
            {
                X1 = X2 = c.ToString();
                return;
            }
            else if ((a == 0 && c == 0) || (b == 0 && c == 0))
            {
                X1 = X2 = "0";
                return;
            }
            else if (a == 0)
            {
                X1 = X2 = (-c / b).ToString();
                return;
            }
            else if (b == 0)
            {
                if (c > 0)
                    X1 = X2 = "Ошибка! Корень < 0";
                else
                    X1 = X2 = Math.Sqrt(-c / a).ToString();
                return;
            }

            if (D < 0)
                X1 = X2 = "Дискриминант < 0";
            else if (D == 0)
                X1 = X2 = (-b / (2 * a)).ToString();
            else
            {
                X1 = ((-b + Math.Sqrt(D)) / (2 * a)).ToString();
                X2 = ((-b - Math.Sqrt(D)) / (2 * a)).ToString();
            }
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            ClearAttempted?.Invoke(this, EventArgs.Empty);
        }

        private void ABC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == ',')
            {
                TextBox textBox = (TextBox)sender;
                string s = textBox.Text;

                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (s.Contains(".") || s.Contains(",") || s.Length == 0 || (s.Length == 1 && s[0] == '-'))
                        e.KeyChar = (char)Keys.None;
                }
                if (e.KeyChar == '-')
                {
                    if (s.Length > 0)
                        e.KeyChar = (char)Keys.None;
                }
            }
            else
                e.KeyChar = (char)Keys.None;
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            HideCaret();
        }
    }
}