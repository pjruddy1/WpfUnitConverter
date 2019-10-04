using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfUnitConverter.ViewModels
{
    public class UnitConverterViewModel : ObservableObject
    {
        public ICommand ButtonConvertCommand { get; set; }


        private double _result;

        public double Operand { get; set; }

        public string OperandUnit { get; set; }

        public string ResultUnit { get; set; }

        public double Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

        public List<string> Units { get; set; }

        private List<string> BuildOutUnitComboBoxSource()
        {
            return new List<string>() { "Inches", "Feet", "Miles", "Millimeters", "Centimeters", "Meters", "Kilmoeters" };
        }

        private void PerformCalculation(object obj)
        {
            Result = 55; // value to confirm binding
        }

        public UnitConverterViewModel()
        {
            Operand = 44; // value to confirm binding
            Units = BuildOutUnitComboBoxSource();
            ButtonConvertCommand = new RelayCommand(new Action<object>(PerformCalculation));
        }
    }
}
