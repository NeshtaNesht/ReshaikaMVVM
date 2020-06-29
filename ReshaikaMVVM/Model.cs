using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReshaikaMVVM
{
    class Model : ViewModelBase
    {
        /**
         * Арифметический тренажёр Решай-ка
         * ***************************
         * Разработчик Мурашов А.А.
         * murashovaa@tmk-group.com
         * ***************************
         **/
        private string _userName = null;//Имя игрока        
        private string _userHard = null;
        private string _userMode = null;
        private string _userAnswer = null;//Ответ
        private string sample = null;//Пример
        private string _userEndLabel;
        private string _popup;

        private int? _qAmount = null;
        private int? _numberQ = 0;
        private int? _qGood = 0;
        private int? _qBad = 0;

        private double _userGoodPercent;
        private double _userBadPercent;

        private char _arithOper;//Знак арифметической операции  
        private char[] _arith = new char[] { '+', '-', '*', '/' };

        private bool _isGameOver = false;  

        private Settings settings;
        private Random rnd;        

        public Model()
        {
            if (IsGameOver == false)
            {
                UserName = _userName;
                QAmount = _qAmount;
                UserHard = _userHard;
                UserMode = _userMode;
                QGood = _qGood;
                QBad = _qBad;
                UserPopup = _popup;
                UserEndLabel = _userEndLabel;
                UserGoodPercent = _userGoodPercent;
                UserBadPercent = _userBadPercent;
                NumberQ = _numberQ;
                IsGameOver = _isGameOver;
                settings = new Settings();
                rnd = new Random();
            }
        }
        public string UserName
        {
            get
            {
                return _userName;
            }

            set
            {
                _userName = value;
            }
        }
        public int? QAmount
        {
            get
            {
                return _qAmount;
            }

            set
            {
                _qAmount = value;

            }
        }
        public int? NumberQ
        {
            get
            {
                return _numberQ;
            }
            set
            {
                _numberQ = value;
            }
        }
        public string UserHard
        {
            get
            {
                return _userHard;
            }

            set
            {
                _userHard = value;

            }
        }
        public string UserMode
        {
            get
            {
                return _userMode;
            }

            set
            {
                _userMode = value;

            }
        }
        public string UserAnswer { get => _userAnswer; set => _userAnswer = value; }
        public int? QGood
        {
            get
            {
                return _qGood;
            }

            set
            {
                RaisePropertyChanged("CurrentGood");
                _qGood = value;
                
            }
        }
        public int? QBad
        {
            get
            {
                return _qBad;
            }

            set
            {
                RaisePropertyChanged("CurrentBad");
                _qBad = value;
                
            }
        }
        public string UserPopup
        {
            get
            {
                return _popup;
            }
            set
            {
                _popup = value;
                RaisePropertyChanged("Popup");
            }
        }
        public string UserEndLabel
        {
            get { return _userEndLabel; }
            set
            {
                _userEndLabel = value;
            }
        }
        public double UserGoodPercent
        {
            get
            {
                return _userGoodPercent;
            }
            set
            {
                _userGoodPercent = value;
            }
        }
        public double UserBadPercent
        {
            get
            {
                return _userBadPercent;
            }
            set
            {
                _userBadPercent = value;
            }
        }

        private static ObservableCollection<string> _hardCollection;
        public static ObservableCollection<string> HardCollection
        {
            get
            {
                _hardCollection = new ObservableCollection<string>();
                foreach (string str in Enum.GetNames(typeof(Hards)))
                    _hardCollection.Add(str);
                return _hardCollection;
            }
        }
        private static ObservableCollection<string> _modeCollection;
        public static ObservableCollection<string> ModeCollection
        {
            get
            {
                _modeCollection = new ObservableCollection<string>();
                foreach (string str in Enum.GetNames(typeof(Modes)))
                    _modeCollection.Add(str);
                return _modeCollection;
            }
        }

        public string Sample { get => sample; set => sample = value; }
        public bool IsGameOver
        {
            get
            {
                return _isGameOver;
            }
            set
            {
                _isGameOver = value;
            }
        }
        public char ArithOper { get => _arithOper; set => _arithOper = value; }

        private enum Modes
        {
            Сложение,
            Вычитание,
            Умножение,
            Деление,
            Комбинированный
        }
        private enum Hards 
        {
            Однозначные,
            Двузначные,
            Трёхзначные,
            Случайные
        }
        public bool IsCurrent()
        {
            if (QAmount == null || QAmount <= 0 || UserHard == null || UserMode == null)
                return false;
            return true;
        }
        /// <summary>
        /// Игровая логика
        /// </summary>
        /// <returns>Результат примера</returns>
        public double GameLogic()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            double Result = 0;

            H:
            switch (UserHard)
            {
                case "Однозначные":
                    firstNumber = rnd.Next(settings.OneMin, settings.OneMax);
                    secondNumber = rnd.Next(settings.OneMin, settings.OneMax);
                    break;
                case "Двузначные":
                    firstNumber = rnd.Next(settings.TwoMin, settings.TwoMax);
                    secondNumber = rnd.Next(settings.TwoMin, settings.TwoMax);
                    break;
                case "Трёхзначные":
                    firstNumber = rnd.Next(settings.ThreeMin, settings.ThreeMax);
                    secondNumber = rnd.Next(settings.ThreeMin, settings.ThreeMax);
                    break;
                default:
                    firstNumber = rnd.Next(settings.OneMin, settings.ThreeMax);
                    secondNumber = rnd.Next(settings.OneMin, settings.ThreeMax);
                    break;
            }
            switch (UserMode)
            {
                case "Сложение":
                    _arithOper = '+';
                    break;
                case "Вычитание":
                    _arithOper = '-';
                    break;
                case "Умножение":
                    _arithOper = '*';
                    break;
                case "Деление":
                    _arithOper = '/';
                    break;
                default:
                    _arithOper = _arith[rnd.Next(1, _arith.Length)];
                    break;
            }
            switch (ArithOper)
            {
                case '+':
                    Result = firstNumber + secondNumber;
                    break;
                case '-':
                    Result = firstNumber - secondNumber;
                    break;
                case '*':
                    Result = firstNumber * secondNumber;
                    break;
                case '/':
                    Result = firstNumber / secondNumber;
                    double res = firstNumber % secondNumber;
                    if(res > 0)
                    {
                        goto H;//Мне не хотелось так делать, но пришлось
                    }
                    break;
            }

            //sample = string.Format("{0} {1} {2}", firstNumber, ArithOper, secondNumber);
                        
            if (QAmount == 0)
            {
                IsGameOver = true;
                GetResult();
                return Result;
            }
            sample = string.Format("{0} {1} {2}", firstNumber, ArithOper, secondNumber);
            _numberQ++;
            _qAmount--;
            return Result;
        }
        /// <summary>
        /// Возвращает результат игрока
        /// </summary>
        public void GetResult()
        {
            _userGoodPercent = Convert.ToDouble(_qGood * 100 / _numberQ);
            _userBadPercent = Convert.ToDouble(_qBad * 100 / _numberQ);
            if (_userGoodPercent >= 0 && _userGoodPercent <= 49)
                _userEndLabel = "Тебе еще есть к чему стремиться!";
            else if (_userGoodPercent >= 50 && _userGoodPercent <= 74)
                _userEndLabel = "Неплохо!";
            else if (_userGoodPercent >= 75 && _userGoodPercent <= 90)
                _userEndLabel = "Хорошо";
            else
                _userEndLabel = "Отлично. Ты молодец!"; 
        }
    }

}
