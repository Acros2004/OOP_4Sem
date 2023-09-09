using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace lab7
{
    
    public class Name : DependencyObject
    {
        public static readonly DependencyProperty TextProperty;

        static Name()
        {

          

            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);
            metadata.DefaultValue = "Никита";
            TextProperty = DependencyProperty.Register("TextName", typeof(string), typeof(Name), metadata,
                new ValidateValueCallback(ValidateValue));
        }
        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            var currentValue = (string)baseValue;
            return currentValue == "Nikita" ? "Никита" : currentValue; // иначе возвращаем текущее значение
        }

        private static bool ValidateValue(object value)
        {
            string currentValue = (string)value;
            return (currentValue == "Nikita" || currentValue == "Никита" || currentValue == "Secret"); // если текущее значение от нуля и выше
        }
        public string TextName
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
    }
}
