using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPF
{
    public partial class MainWindow : Window
    {
        record Item(int Numero, string Titulo, Func<Page> Factory);
        private readonly List<Item> _items;

        public MainWindow()
        {
            InitializeComponent();
            _items = new()
            {
            new Item(1, "Salario (horas extra)", () => new Pages.E01()),
new Item(2, "Descuento sueldo", () => new Pages.E02()),
new Item(3, "Descuento por monto", () => new Pages.E03()),
new Item(4, "Segundos → minuto", () => new Pages.E04()),
new Item(5, "Minutos → d/h/m", () => new Pages.E05()),
new Item(6, "Suma 1..N", () => new Pages.E06()),
new Item(7, "Suma salarios (varios)", () => new Pages.E07()),
new Item(8, "Salario simple", () => new Pages.E08()),
new Item(9, "Notas: promedios", () => new Pages.E09()),
new Item(10, "Suma de dígitos", () => new Pages.E10()),
new Item(12, "Contador 50 números", () => new Pages.E12()),
new Item(13, "Factorial", () => new Pages.E13()),
new Item(14, "Media de números", () => new Pages.E14()),
new Item(15, "Suma y producto pares", () => new Pages.E15()),
new Item(18, "Primera vocal", () => new Pages.E18()),
new Item(19, "Parte fraccionaria", () => new Pages.E19()),
new Item(20, "Ecuación cuadrática", () => new Pages.E20()),
new Item(21, "Operaciones x10", () => new Pages.E21()),
new Item(22, "Cubo y raíz (loop)", () => new Pages.E22()),
new Item(23, "Operaciones hasta 0", () => new Pages.E23()),
new Item(24, "Área triángulo", () => new Pages.E24()),
new Item(25, "Hipotenusa", () => new Pages.E25()),
new Item(26, "Geometría con radio", () => new Pages.E26()),
new Item(27, "Consumos restaurant", () => new Pages.E27()),
new Item(28, "Suma 8..N", () => new Pages.E28()),
new Item(29, "Caja y egresos", () => new Pages.E29()),
new Item(30, "Promedio 2 notas", () => new Pages.E30()),
new Item(31, "Clasificar deportes", () => new Pages.E31()),
new Item(32, "Claves de la fiesta", () => new Pages.E32()),
            };
            foreach (var it in _items)
                MenuList.Items.Add($"Ejercicio {it.Numero:00} — {it.Titulo}");
            if (_items.Count > 0)
            {
                MenuList.SelectedIndex = 0;
            }
        }

        private void MenuList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MenuList.SelectedIndex < 0) return;
            var it = _items[MenuList.SelectedIndex];
            MainFrame.Content = it.Factory();
        }
    }
}
