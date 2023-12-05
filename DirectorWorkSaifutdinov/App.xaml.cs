using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DirectorWorkSaifutdinov.Models;

namespace DirectorWorkSaifutdinov
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static [Models]Entities DB = new [Models]Entities();
         
        App.DB.[DirectorWorkSaifutdinov].ToList() // Получение списка из таблицы на сервере
    }
}
