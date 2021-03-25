using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinCI.Shared
{
    public class CalculatorModel
    {
        private readonly Model _model;
        public CalculatorModel(Model model)
        {
            _model = model;
        }
         
        public int Calculate()
        {
            return _model.X + _model.Y;
        }
    }
}
