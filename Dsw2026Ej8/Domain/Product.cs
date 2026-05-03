using System;

namespace Dsw2026Ej8.Domain
{
    internal class Product
    {
        private long _code;
        private string _description;
        private bool _active;
        private double _price;
        private float _tax;
        private int _stock;
        private char _presentation;
        private DateTime _date;
        private bool __internal;

        public Product(long code, string description, double price, char presentation)
        {
            _code = code;
            _description = description;
            _price = price;
            _tax = 0.21f;
            _active = true;
            __internal = false;
            _stock = 0;
            _date = DateTime.Now;

            char[] validPresentations = { 'I', 'S', 'K', 'E', 'P' };
            if (validPresentations.Contains(presentation))
                _presentation = presentation;
            else
                _presentation = 'I';
        }

        public long GetCode()
        {
            return _code;
        }

        public string GetDescription()
        {
            return _description;
        }

        public bool GetActive()
        {
            return _active;
        }

        public double GetPrice()
        {
            return _price;
        }

        public float GetTax()
        {
            return _tax;
        }

        public int GetStock()
        {
            return _stock;
        }

        public char GetPresentation()
        {
            return _presentation;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public bool GetInternal()
        {
            return __internal;
        }

        public void SetInternal(bool value)
        {
            __internal = value;
        }

        public void SetTax(float value)
        {
            _tax = value;
        }

        public void Deactivate()
        {
            _active = false;
        }

        public double GetFinalPrice
        {
            get
            {
                return _price + (_price * _tax);
            }
        }

        public string GetDetailedInfo()
        {
            string stockMsg;

            if (_stock > 0 && _active)
            {
                stockMsg = "Disponible";
            }
            else if (!_active)
            {
                stockMsg = "No disponible";
            }
            else
            {
                stockMsg = "Sin stock";
            }

            return "[" + _code + "] " + _description + " [" + _presentation + "]: " + _price.ToString("C") + " - " + stockMsg;
        }

        public void IncreaseStock() => _stock++;

        public void DecreaseStock()
        {
            if (_stock > 0)
            {
                _stock--;
            }
        }

        public void IncreaseStock(int amount)
        {
            _stock = _stock + amount;
        }

        public double GetPricePerFraction(int fractions)
        {
            if (_presentation != 'K')
            {
                return 0;
            }
            if (fractions <= 0)
            {
                return 0;
            }
            return _price / fractions;
        }

        public string GetPackaging()
        {
            if (_presentation == 'I')
            {
                return "Envase Individual";
            }
            else if (_presentation == 'S')
            {
                return "Empaque Secundario";
            }
            else if (_presentation == 'K')
            {
                return "Pack";
            }
            else if (_presentation == 'E')
            {
                return "Eco-friendly";
            }
            else
            {
                return "Premium";
            }
        }

        public void Update(string description, double price = 0, float tax = 0.21f)
        {
            _description = description;

            if (price != 0)
            {
                _price = price;
            }

            if (tax != _tax)
            {
                _tax = tax;
            }
        }
    }
}