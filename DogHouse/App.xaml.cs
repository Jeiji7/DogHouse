﻿using DogHouse.DB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DogHouse
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static bool editOrAdd = false;
        public static DogHomeEntities db = new DogHomeEntities();
        public static Dog ContextDog { get; set; }
       
    }
}
