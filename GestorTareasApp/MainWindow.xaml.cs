using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestorTareasApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Tarea> Tareas { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            // Datos iniciales de ejemplo
            Tareas = new ObservableCollection<Tarea>
            {
                new Tarea { Titulo = "Aprender sintaxis de XAML", Completada = true },
                new Tarea { Titulo = "Comprender la separación Vista / Código", Completada = true },
                new Tarea { Titulo = "Practicar Data Binding en WPF", Completada = false }
            };
            // Asignación del contexto de datos (DataContext) a la propia ventana
            this.DataContext = this;
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNuevaTarea.Text))
            {
                // Se añade la nueva tarea a la colección observada
                Tareas.Add(new Tarea
                {
                    Titulo = TxtNuevaTarea.Text,
                    Completada = false
                });

                TxtNuevaTarea.Clear(); // Limpia el cuadro de texto
            }
            else
            {
                MessageBox.Show("Por favor, introduce una descripción para la tarea.",
                                "Campo vacío",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
        }
    }
}