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

namespace Battleship
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

/*
    1. Главное меню (создать игру/подключиться)
        a) ввод имени пользователья
        б) ip, если подключается
    2. Настройка своей карты кораблей (после завершения нажимается кнопка "готов". Игра начинается после готовности 2 игроков)
    3. Основная игра (право первого хода выбирается случайно)
    
==================================================================================================================================

WPF:
    StartWindow (главное меню)
    SetupWindow (настройка поля)
    MainWindow (основная игра)

Классы:
    Карта
    Игрок
        Имя
        Карта
        Ip?
        
    GameController
    GameConnector?
 */
