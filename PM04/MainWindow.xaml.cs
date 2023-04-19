using PM04.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PM04
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IDictionary<TextBox, IValidator<string>> m_validatorMap;

        public MainWindow()
        {
            InitializeComponent();
            InitializeValidators();
        }

        private void InitializeValidators()
        {
            m_validatorMap = new Dictionary<TextBox, IValidator<string>>
            {
                { NameField, new NameValidator() },
                { SurnameField, new SurnameValidator() },
                { AgeField, new AgeValidator() },
                { BirthDateField, new DateValidator() }
            };
        }

        private void OnTextFieldTextChanged(object sender, TextChangedEventArgs e)
        {
            if (m_validatorMap == null) return;

            var textField = sender as TextBox;

            if(!m_validatorMap.TryGetValue(textField, out var validator)) return;

            var isValid = validator.Validate(textField.Text);

            textField.Background = isValid ? Brushes.Transparent : Brushes.Red;
        }
    }
}
