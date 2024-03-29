﻿using System;
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

        public ICommand SelectedConvertCommand { get; set; }

        public ICommand Selected2ConvertCommand { get; set; }

        private double _result;

        public double Operand { get; set; }

        private string _operandUnit;

        public string OperandUnit
        {
            get { return _operandUnit; }
            set
            {
                _operandUnit = value;
                OnPropertyChanged("OperandUnit");

            }
        }

        private string _resultUnit;

        public string ResultUnit
        {
            get { return _resultUnit; }
            set
            {
                _resultUnit = value;
                OnPropertyChanged("ResultUnit");
            }
        }


        

        private string _feedback;

        private string _operandString;

        public string OperandString
        {
            get { return _operandString; }
            set
            {
                _operandString = value;
                OnPropertyChanged("OperandString");
                GetFeedback();
            }
        }


        public string Feedback
        {
            get { return _feedback; }
            set
            {
                _feedback = value;
                OnPropertyChanged("Feedback");
            }
        }


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
            if (Operand != 0 && OperandUnit !=null && ResultUnit != null)
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
                                Result = Operand * 0.03937007;
                                break;
                            case "Centimeters":
                                Result = Operand * 0.393700787;
                                break;
                            case "Meters":
                                Result = Operand * 39.3700787;
                                break;
                            case "Kilmoeters":
                                Result = Operand * 39370.07874;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Feet":
                        switch (OperandUnit)
                        {
                            case "Inches":
                                Result = Operand * 0.08333333;
                                break;
                            case "Feet":
                                Result = Operand;
                                break;
                            case "Miles":
                                Result = Operand * 5280;
                                break;
                            case "Millimeters":
                                Result = Operand * 0.0032808;
                                break;
                            case "Centimeters":
                                Result = Operand * 0.03280839;
                                break;
                            case "Meters":
                                Result = Operand * 3.2808398;
                                break;
                            case "Kilmoeters":
                                Result = Operand * 3280.83989;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Miles":
                        switch (OperandUnit)
                        {
                            case "Inches":
                                Result = Operand * 0.0000157828;
                                break;
                            case "Feet":
                                Result = Operand * 0.0001893939;
                                break;
                            case "Miles":
                                Result = Operand;
                                break;
                            case "Millimeters":
                                Result = Operand * 0.00000062137;
                                break;
                            case "Centimeters":
                                Result = Operand * 0.00000621;
                                break;
                            case "Meters":
                                Result = Operand * 0.00062137;
                                break;
                            case "Kilmoeters":
                                Result = Operand * 0.62137119;
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
                                Result = Operand * 1609344;
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
                                Result = Operand * .1;
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
                                Result = Operand * .000001;
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
       
        }

        private void GetFeedback()
        {
            bool isOperandValid;
            isOperandValid = double.TryParse(OperandString, out double operand);

            if (!isOperandValid)
            {
                Feedback = "Please Enter A Valid Number";
            }
            else
            {

                Operand = operand;
                Feedback = "";
            }
        }

        public UnitConverterViewModel()
        {
            Units = BuildOutUnitComboBoxSource();
            ButtonConvertCommand = new RelayCommand(new Action<object>(PerformCalculation));
            // commands for units selected
            SelectedConvertCommand = new RelayCommand(new Action<object>(PerformCalculation));
            Selected2ConvertCommand = new RelayCommand(new Action<object>(PerformCalculation));
        }

        private void ValidateOperand1(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
