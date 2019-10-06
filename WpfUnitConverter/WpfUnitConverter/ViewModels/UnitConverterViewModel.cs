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
            switch (ResultUnit)
            {
                case "Inches":
                    switch (OperandUnit)
                    {
                        case "Inches":
                            Result = Operand;
                            break;
                        case "Feet":
                            Result = Operand * 12;
                            break;
                        case "Miles":
                            Result = Operand * 63360;
                            break;
                        case "Millimeters":
                            Result = Operand * 25.4;
                            break;
                        case "Centimeters":
                            Result = Operand * 2.54;
                            break;
                        case "Meters":
                            Result = Operand * .0254;
                            break;
                        case "Kilmoeters":
                            Result = Operand * .0000254;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Feet":
                    switch (OperandUnit)
                    {
                        case "Inches":
                            Result = Operand / 12;
                            break;
                        case "Feet":
                            Result = Operand;
                            break;
                        case "Miles":
                            Result = Operand * 5280;
                            break;
                        case "Millimeters":
                            Result = Operand * 304.8;
                            break;
                        case "Centimeters":
                            Result = Operand * 30.48;
                            break;
                        case "Meters":
                            Result = Operand * .3048;
                            break;
                        case "Kilmoeters":
                            Result = Operand * .0003048;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Miles":
                    switch (OperandUnit)
                    {
                        case "Inches":
                            Result = Operand / 63360;
                            break;
                        case "Feet":
                            Result = Operand / 5280;
                            break;
                        case "Miles":
                            Result = Operand;
                            break;
                        case "Millimeters":
                            Result = Operand / 1609000;
                            break;
                        case "Centimeters":
                            Result = Operand / 160900;
                            break;
                        case "Meters":
                            Result = Operand / 1609;
                            break;
                        case "Kilmoeters":
                            Result = Operand / 1.609;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Millimeters":
                    switch (OperandUnit)
                    {
                        case "Inches":
                            Result = Operand * 25.4;
                            break;
                        case "Feet":
                            Result = Operand * 304.8;
                            break;
                        case "Miles":
                            Result = Operand * 1609000;
                            break;
                        case "Millimeters":
                            Result = Operand;
                            break;
                        case "Centimeters":
                            Result = Operand * 10;
                            break;
                        case "Meters":
                            Result = Operand * 1000;
                            break;
                        case "Kilmoeters":
                            Result = Operand * 1000000;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Centimeters":
                    switch (OperandUnit)
                    {
                        case "Inches":
                            Result = Operand * 2.54;
                            break;
                        case "Feet":
                            Result = Operand * 30.48;
                            break;
                        case "Miles":
                            Result = Operand * 160934;
                            break;
                        case "Millimeters":
                            Result = Operand * 10;
                            break;
                        case "Centimeters":
                            Result = Operand;
                            break;
                        case "Meters":
                            Result = Operand * 100;
                            break;
                        case "Kilmoeters":
                            Result = Operand * 100000;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Meters":
                    switch (OperandUnit)
                    {
                        case "Inches":
                            Result = Operand * 0.0254;
                            break;
                        case "Feet":
                            Result = Operand * 0.3048;
                            break;
                        case "Miles":
                            Result = Operand * 1609;
                            break;
                        case "Millimeters":
                            Result = Operand * .001;
                            break;
                        case "Centimeters":
                            Result = Operand * .01;
                            break;
                        case "Meters":
                            Result = Operand;
                            break;
                        case "Kilmoeters":
                            Result = Operand * 1000;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Kilmoeters":
                    switch (OperandUnit)
                    {
                        case "Inches":
                            Result = Operand * .0000254;
                            break;
                        case "Feet":
                            Result = Operand * .0003048;
                            break;
                        case "Miles":
                            Result = Operand * 1.609;
                            break;
                        case "Millimeters":
                            Result = Operand *.000001;
                            break;
                        case "Centimeters":
                            Result = Operand * .00001;
                            break;
                        case "Meters":
                            Result = Operand * .001;
                            break;
                        case "Kilmoeters":
                            Result = Operand;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        public UnitConverterViewModel()
        {
            Operand = 44; // value to confirm binding
            Units = BuildOutUnitComboBoxSource();
            ButtonConvertCommand = new RelayCommand(new Action<object>(PerformCalculation));
        }
    }
}
