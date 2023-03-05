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
            if (form.A.Contains(','))
                form.A = this.form.A.Replace(",", ".");
            if (form.B.Contains(','))
                form.B = this.form.B.Replace(",", ".");
            if (form.C.Contains(','))
                form.C = this.form.C.Replace(",", ".");

            double a, b, c;

            if (!double.TryParse(form.A, NumberStyles.Any, CultureInfo.InvariantCulture, out a) ||
                !double.TryParse(form.B, NumberStyles.Any, CultureInfo.InvariantCulture, out b) ||
                !double.TryParse(form.C, NumberStyles.Any, CultureInfo.InvariantCulture, out c))
            {
                throw new ArgumentException("Argument is not valid");
            }

            double D = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0 && b == 0)
            {
                form.X1 = form.X2 = c.ToString();
                return;
            }
            else if ((a == 0 && c == 0) || (b == 0 && c == 0))
            {
                form.X1 = form.X2 = "0";
                return;
            }
            else if (a == 0)
            {
                form.X1 = form.X2 = (-c / b).ToString();
                return;
            }
            else if (b == 0)
            {
                if (c > 0)
                    form.X1 = form.X2 = "Ошибка! Корень < 0";
                else
                    form.X1 = form.X2 = Math.Sqrt(-c / a).ToString();
                return;
            }

            if (D < 0)
                form.X1 = form.X2 = "Дискриминант < 0";
            else if (D == 0)
                form.X1 = form.X2 = (-b / (2 * a)).ToString();
            else
            {
                form.X1 = ((-b + Math.Sqrt(D)) / (2 * a)).ToString();
                form.X2 = ((-b - Math.Sqrt(D)) / (2 * a)).ToString();
            }
        }

        private void Form_ClearAttempted(object? sender, EventArgs e)
        {
            form.A = string.Empty;
            form.B = string.Empty;
            form.C = string.Empty;
            form.X1 = string.Empty;
            form.X2 = string.Empty;
        }
    }
}