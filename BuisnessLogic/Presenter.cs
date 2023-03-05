/*
Файл: Presenter.cs
Лабораторная робота № 2
Автор: Положий А. С.
Тема: Розробка та дослідження програми вирішення квадратного рівняння.
Дата створення: 23.02.2023
*/

using System.Globalization;
using System.Runtime.CompilerServices;
using UI;

namespace BuisnessLogic
{
    public class Presenter
    {
        private readonly IView form;

        public Presenter(IView form)
        {
            this.form = form;
            this.form.ClearAttempted += Form_ClearAttempted;
            this.form.CalcAttempted += Form_CalcAttempted;
        }

        private void Form_CalcAttempted(object? sender, EventArgs e)
        {
            if (this.form.A.Contains(','))
                this.form.A = this.form.A.Replace(",", ".");
            if (this.form.B.Contains(','))
                this.form.B = this.form.B.Replace(",", ".");
            if (this.form.C.Contains(','))
                this.form.C = this.form.C.Replace(",", ".");
            double a = double.Parse(this.form.A, NumberStyles.Any, CultureInfo.InvariantCulture);
            double b = double.Parse(this.form.B, NumberStyles.Any, CultureInfo.InvariantCulture);
            double c = double.Parse(this.form.C, NumberStyles.Any, CultureInfo.InvariantCulture);
            double D = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0 && b == 0)
            {
                this.form.X1 = this.form.X2 = c.ToString();
                return;
            }
            else if ((a == 0 && c == 0) || (b == 0 && c == 0))
            {
                this.form.X1 = this.form.X2 = "0";
                return;
            }
            else if (a == 0)
            {
                this.form.X1 = this.form.X2 = (-c / b).ToString();
                return;
            }
            else if (b == 0)
            {
                if (c > 0)
                    this.form.X1 = this.form.X2 = "Ошибка! Корень < 0";
                else
                    this.form.X1 = this.form.X2 = Math.Sqrt(-c / a).ToString();
                return;
            }

            if (D < 0)
                this.form.X1 = this.form.X2 = "Дискриминант < 0";
            else if (D == 0)
                this.form.X1 = this.form.X2 = (-b / (2 * a)).ToString();
            else
            {
                this.form.X1 = ((-b + Math.Sqrt(D)) / (2 * a)).ToString();
                this.form.X2 = ((-b - Math.Sqrt(D)) / (2 * a)).ToString();
            }
        }

        private void Form_ClearAttempted(object? sender, EventArgs e)
        {
            this.form.A = string.Empty;
            this.form.B = string.Empty;
            this.form.C = string.Empty;
            this.form.X1 = string.Empty;
            this.form.X2 = string.Empty;
        }
    }
}