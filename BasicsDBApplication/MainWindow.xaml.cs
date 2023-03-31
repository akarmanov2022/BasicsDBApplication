using System.Windows;
using BasicsDBApplication.Services;
using Microsoft.EntityFrameworkCore;

namespace BasicsDBApplication
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MyDbContext _dbContext;
        public MainWindow()
        {
            InitializeComponent();
            _dbContext = new MyDbContext();
            _dbContext.Teams.Load();
        }
    }
}