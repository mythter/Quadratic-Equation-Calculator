/*
Файл: IView.cs
Лабораторная робота № 2
Автор: Положий А. С.
Тема: Розробка та дослідження програми вирішення квадратного рівняння.
Дата створення: 23.02.2023
*/

namespace UI
{
    public interface IView
    {
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string X1 { get; set; }
        public string X2 { get; set; }
        public bool Radio1 { get; set; }
        public bool Radio2 { get; set; }
        public bool Radio3 { get; set; }

        public event EventHandler CalcAttempted;
        public event EventHandler ClearAttempted;
    }
}