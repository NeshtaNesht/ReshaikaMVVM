using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ReshaikaMVVM 
{
    class RootVM : Settings
    {
        private IDialogCoordinator dialog;
        RootVM root;
        public RootVM()
        {
            //Проброс изменений из модели в вм
            Model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };
            //Инициализация диалога для открытия диалоговых окон махаппса
            dialog = DialogCoordinator.Instance;
            //Установка текущей вьюшки     
            _currentContentVM = View1;
        }
        //Обновление компонента, в котором показываются вьюшки
        private object _currentContentVM;
        public object CurrentContentVM
        {
            get
            {
                return _currentContentVM;
            }

            set
            {
                _currentContentVM = value;
                RaisePropertyChanged("CurrentContentVM");
            }
        }

        //Команда для установки имени
        private ICommand _setNameCommand;
        public ICommand SetNameCommand
        {
            get
            {
                return _setNameCommand ?? (_setNameCommand = new RelayCommand<string>(str =>
                {
                    try
                    {
                        if (!(Regex.Match(str, @"[а-яА-ЯA-Za-z\.\,]$").Success))
                        {
                            root = new RootVM();

                            root.dialog.ShowMessageAsync(this, "Ошибка", "Проблема с вводом имени. Попробуйте еще раз");
                        }
                        else
                        {
                            Popup = null;
                            GotoViewSetOther();
                        }
                    }
                    catch
                    {
                        Popup = "Проблема с вводом имени. Попробуйте еще раз";
                    }
                }));
            }
        }
        //Команда для установки остальных значение (кол-во вопросов, сложность и т.д.)
        private ICommand _setOtherCommand;
        public ICommand SetOtherCommand
        {
            get
            {
                return _setOtherCommand ?? (_setOtherCommand = new RelayCommand<string>(str => {
                    root = new RootVM();
                    if (Model.QAmount > MaxAmount)
                    {
                        root.dialog.ShowMessageAsync(this, "Ошибка", "Максимальное количество вопросов: " + MaxAmount);
                        Model.QAmount = null;
                        return;
                    }
                    if (!(Regex.Match(str, @"[0-9\.]$").Success))
                    {
                        Model.UserPopup = "Неверный формат введенного числа";
                        return;
                    }
                    if (Model.IsCurrent())
                    {
                        Model.UserPopup = null;
                        CurrentResult = Model.GameLogic();
                        GotoViewStartGame();
                    }
                    else
                    {
                        root.dialog.ShowMessageAsync(this, "Ошибка", "Где-то вы ошиблись. Попробуйте еще раз");
                        root = null;
                    }
                }));
            }

        }
        private ICommand _setNextSampleCommand;
        public ICommand SetNextSampleCommand
        {
            get
            {
                return _setNextSampleCommand ?? (_setNextSampleCommand = new RelayCommand<string>(str =>
                {
                    try
                    {
                        if (!(Regex.Match(str, @"[0-9\.]$").Success))
                        {
                            Model.UserPopup = "Неверный формат ответа";
                            return;
                        }
                        Model.UserPopup = null;
                        Model.UserAnswer = null;
                        if (Double.Parse(str) == CurrentResult)
                        {
                            CurrentGood++;
                        }
                        else CurrentBad++;
                        CurrentResult = Model.GameLogic();
                        if (IsGameOver == true)
                        {
                            CurrentContentVM = View4;
                            //Model = null;
                            //root = null;                            
                            return;
                        }
                        CurrentContentVM = new Views.GameView();
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("Неопределенная ошибка во время работы: " + e.Message);
                    }

                }));
            }
        }
        private ICommand _newGame;
        public ICommand NewGame
        {
            get
            {
                return _newGame ?? (_newGame = new RelayCommand(() =>
                {
                    Popup = null;
                    IsGameOver = false;
                    CurrentGood = 0;
                    CurrentBad = 0;
                    CurrentAmount = null;
                    CurrentName = null;
                    CurrentHard = null;
                    CurrentMode = null;
                    CurrentContentVM = new InputNameView();
                    Model = new Model();                    
                }));
            }
        }
        //***---Методы для переходов между вьюшками---***    
        private void GotoViewInputName() => CurrentContentVM = View1;
        private void GotoViewSetOther() => CurrentContentVM = View2;
        private void GotoViewStartGame() => CurrentContentVM = View3;
        //----------********************----------   
        public string CurrentName
        {
            get
            {
                if(Model == null)
                {
                    Model = new Model();
                    return Model.UserName;
                }
                return Model.UserName;
            }
            set
            {
                //if (Regex.Match(value, @"[а-яА-ЯA-Za-z\.\,]$").Success)
                //{
                    Model.UserName = value;
                    RaisePropertyChanged("CurrentName");
                //}
                /*else if (value.Length == 0)
                    dialog.ShowMessageAsync(this, "Ошибка ввода имени", "Необходимо ввести фамилию и инициалы");
                else dialog.ShowMessageAsync(this, "Ошибка ввода имени", "Ввод цифр запрещен");*/
            }
        }
        public int? CurrentAmount
        {
            get
            {
                return Model.QAmount;
            }
            set
            {
                Model.QAmount = value;
                RaisePropertyChanged("CurrentAmount");
            }
        }
        public string CurrentHard
        {
            get
            {
                return Model.UserHard;
            }
            set
            {
                Model.UserHard = value;
                RaisePropertyChanged("CurrentHard");
            }
        }
        public string CurrentMode
        {
            get
            {
                return Model.UserMode;
            }
            set
            {
                Model.UserMode = value;
                RaisePropertyChanged("CurrentMode");
            }
        }        
        public int? CurrentNumberQ
        {
            get { return Model.NumberQ; }
            set
            {
                Model.NumberQ = value;
                RaisePropertyChanged("CurrentNumberQ");
            }
        }
        public string CurrentAnswer
        {
            get { return Model.UserAnswer; }
            set
            {
                if (value == null)
                    return;
                Model.UserAnswer = value;
                RaisePropertyChanged("CurrentAnswer");
            }
        }
        public string CurrentSample
        {
            get { return Model.Sample; }
        }
        public int? CurrentGood
        {
            get { return Model.QGood; }
            set
            {
                Model.QGood = value;
                RaisePropertyChanged("CurrentGood");
            }
        }
        public int? CurrentBad
        {
            get { return Model.QBad; }
            set
            {
                Model.QBad = value;
                RaisePropertyChanged("CurrentBad");
            }
        }
        public double CurrentResult
        {
            get; set;
        }

        public double CurrentGoodPercent
        {
            get
            {
                //return Convert.ToDouble(Model.QGood * 100 / Model.NumberQ);
                return Model.UserGoodPercent;
            }
            set
            {
                Model.UserGoodPercent = value;
                RaisePropertyChanged("CurrentGoodPercent");
            }
        }
        public double CurrentBadPercent
        {
            get
            {
                //return Convert.ToDouble(Model.QBad * 100 / Model.NumberQ);
                return Model.UserBadPercent;
            }
            set
            {
                Model.UserBadPercent = value;
                RaisePropertyChanged("CurrentBadPercent");
            }
        }
        public string Popup
        {
            get
            {
                return Model.UserPopup;
            }
            set
            {
                Model.UserPopup = value;
                RaisePropertyChanged("Popup");
            }
        }
        public string EndLabel
        {
            get
            {
                /*if (CurrentGoodPercent >= 0 && CurrentGoodPercent <= 49)
                    return Model.UserEndLabel = "Тебе еще есть к чему стремиться!";
                else if (CurrentGoodPercent >= 50 && CurrentGoodPercent <= 74)
                    return Model.UserEndLabel = "Неплохо!";
                else if (CurrentGoodPercent >= 75 && CurrentGoodPercent <= 90)
                    return Model.UserEndLabel = "Хорошо";
                else
                    return Model.UserEndLabel = "Отлично. Ты молодец!";*/
                return Model.UserEndLabel;
                
            }
            set
            {                
                Model.UserEndLabel = value;
                RaisePropertyChanged("EndLabel");
            }
        }
        public ObservableCollection<string> CurrentHardCollection
        {
            get { return Model.HardCollection; }
        }
        public ObservableCollection<string> CurrentModeCollection
        {
            get { return Model.ModeCollection; }
        }        
        internal Model Model { get; set; } = new Model();
        public object View1 { get; } = new InputNameView();
        public object View2 { get; } = new InputOtherSetView();
        public object View3 { get; } = new Views.GameView();
        public object View4 { get; } = new Views.GameEndView();
        public bool IsFocused { get; set; } = true;
        public bool IsFocused1 { get; set; } = true;
        public bool IsGameOver
        {
            get { return Model.IsGameOver; }
            set
            {
                Model.IsGameOver = value;
            }
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }    
}

