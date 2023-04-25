using System;
using System.Collections.Generic;
using System.Linq;
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

namespace PR_3_Lamaev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Player> players;
        List<Questions> questions;
        string b;
        int g;
        public MainWindow()
        {
            InitializeComponent();
            players = new List<Player>()
            {
                new Player("Первый игрок", 0)
            };
            Update();
            questions = new List<Questions>()
            {
                new Questions ("Какой город является самым северным городом России?","Певек",100),
                new Questions ("Какой город является самым старым в России?","Керчь",200),
                new Questions ("Какой город является колыбелью космонавтики?","Калуга",300),
                new Questions ("В каком городе находится самый древний сохранившийся кремль?","Великий Новгород",400),
                new Questions ("Какой город является самой западной точкой России?","Калининград",500),

                new Questions ("Где живёт Баба-Яга?","Избушка на курьих ножках",100),
                new Questions ("Как в сказках называют скатерть, которая сама накрывает на стол?","Самобранка",200),
                new Questions ("Кто сделал Буратино?","Папа Карло",300),
                new Questions ("Откуда получилось старику выловить золотую рыбку?","Из моря",400),
                new Questions ("Сколько голов было у Змея-Горыныча?","Три",500),

                new Questions ("Сколько основных отраслей насчитывает машиностроение?","12",100),
                new Questions ("Какой главный отраслевой фактор машиностроения?","Транспортные связи",200),
                new Questions ("Где в России сосредоточено производство оборудования для чёрной металлургии?","В Екатеринбурге",300),
                new Questions ("Где в России сосредоточено судостроение?","В Санкт-Петербурге",400),
                new Questions ("В каком городе выпускают атомные подводные лодки?","В Северодвинске",500),

                new Questions ("Как можно закаливаться на природе?","Водные процедуры",100),
                new Questions ("Как называется спортивный бег на большие дистанции?","Марафон",200),
                new Questions ("Как называют человека, который зимой купается в проруби?","Морж",300),
                new Questions ("Полезно ли жевать жвачку вместо чистки зубов?","нет",400),
                new Questions ("Как долго нужно чистить зубы?","Две минуты",500)
            };
        }
        public void Update()
        {
            players = players.ToList();
            list_1.ItemsSource = players;
        }

        private void list_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
