using GalaSoft.MvvmLight;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReshaikaMVVM
{
    class Settings : ViewModelBase
    {
        public MetroDialogSettings setBtnText = new MetroDialogSettings();
        
        public Settings()
        {
            setBtnText.AffirmativeButtonText = "Принять";
            setBtnText.NegativeButtonText = "Отмена";
        }

        public string ProgramColor { get; set; } = "#FFFB8633";//Цвет
        public int MaxTextLength { get; set; } = 18;//Максимальное число символов для имени
        //Размеры юзерконтролов. //*/*//*//*Как-то странно работает
        public int Height { get; set; } = 374;
        public int Width { get; set; } = 434;

        public int OneMax { get; set; } = 10;
        public int OneMin { get; set; } = 1;
        public int TwoMax { get; set; } = 100;
        public int TwoMin { get; set; } = 10;
        public int ThreeMax { get; set; } = 1000;
        public int ThreeMin { get; set; } = 100;
        //*********************
        public int MaxAmount { get; set; } = 25;//Максимальное количество вопросов
    }
}
