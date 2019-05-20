using System;
using System.ComponentModel.DataAnnotations;

namespace Kafe.Controls
{
    public class NumberOnlyAttribute:ValidationAttribute
    {
        private readonly Type typeOfNumber;

        private readonly int maxNumber;

        public NumberOnlyAttribute(Type type,int maxNumber = int.MaxValue)
        {
            typeOfNumber = type;
            this.maxNumber = maxNumber;
        }

        public override bool IsValid(object value)
        {
            if (Convert.ToDouble(value) > maxNumber)
            {
                ErrorMessage = "Maximum only " + maxNumber;
                return false;
            }
            if (typeOfNumber == typeof(int))
                return int.TryParse(value.ToString(), result: out int numberInt);
            if (typeOfNumber == typeof(float))
                return float.TryParse(value.ToString(), out float numberFloat);
            if (typeOfNumber == typeof(double))
                return double.TryParse(value.ToString(), out double numberDouble);
            
            return false;
        }
    }
}
