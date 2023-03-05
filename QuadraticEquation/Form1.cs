/*
����: Form1.cs
������������ ������ � 2
�����: ������� �. �.
����: �������� �� ���������� �������� �������� ����������� �������.
���� ���������: 23.02.2023
*/

using BuisnessLogic;
using Microsoft.Win32;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                MessageBox.Show("�� ��� ���� ���������!", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (A == "-" || B == "-" || C == "-" || A == "." || B == "." || C == "." || A == "," || B == "," || C == ",")
            {
                MessageBox.Show("���� ��������� �����������!", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                double a = double.Parse(A, NumberStyles.Any, CultureInfo.InvariantCulture);
                double b = double.Parse(B, NumberStyles.Any, CultureInfo.InvariantCulture);
                double c = double.Parse(C, NumberStyles.Any, CultureInfo.InvariantCulture);
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
                        X1 = X2 = "������! ������ < 0";
                    else
                        X1 = X2 = Math.Sqrt(-c / a).ToString();
                    return;
                }

                if (D < 0)
                    X1 = X2 = "������������ < 0";
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
                CalcAttempted?.Invoke(this, EventArgs.Empty);
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
            double a = double.Parse(A, NumberStyles.Any, CultureInfo.InvariantCulture);
            double b = double.Parse(B, NumberStyles.Any, CultureInfo.InvariantCulture);
            double c = double.Parse(C, NumberStyles.Any, CultureInfo.InvariantCulture);
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
                    X1 = X2 = "������! ������ < 0";
                else
                    X1 = X2 = Math.Sqrt(-c / a).ToString();
                return;
            }

            if (D < 0)
                X1 = X2 = "������������ < 0";
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
                string a = ATextBox.Text;
                string b = BTextBox.Text;
                string c = CTextBox.Text;

                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if ((a.Contains(".") || a.Contains(",") || a.Length == 0) && ATextBox.Focused)
                        e.KeyChar = (char)Keys.None;
                    if ((b.Contains(".") || b.Contains(",") || b.Length == 0) && BTextBox.Focused)
                        e.KeyChar = (char)Keys.None;
                    if ((c.Contains(".") || c.Contains(",") || c.Length == 0) && CTextBox.Focused)
                        e.KeyChar = (char)Keys.None;
                }
                if (e.KeyChar == '-')
                {
                    a = ATextBox.Text;
                    b = BTextBox.Text;
                    c = CTextBox.Text;

                    if (a.Length > 0 && ATextBox.Focused)
                        e.KeyChar = (char)Keys.None;
                    if (b.Length > 0 && BTextBox.Focused)
                        e.KeyChar = (char)Keys.None;
                    if (c.Length > 0 && CTextBox.Focused)
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