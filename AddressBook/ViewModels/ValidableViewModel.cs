using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.ViewModels
{
    public abstract class ValidableViewModel : BaseViewModel, IViewModel, IDataErrorInfo
    {
        protected List<string> ignoredProperties = new List<string>();
        protected List<string> validatedProperties = new List<string>();

        public ValidableViewModel(MainViewModel mainViewModel) : base(mainViewModel)
        {

        }

        public string this[string columnName] { get => GetValidationError(columnName); }

        public string Error { get => null; }

        public List<string> ValidatedProperties { get => validatedProperties; }

        public bool IsValid
        {
            get
            {
                foreach (string property in validatedProperties)
                {
                    if (GetValidationError(property) != null) return false;
                }
                return true;
            }
        }

        protected string GetValidationError(string propertyName)
        {
            if (ignoredProperties.FirstOrDefault(item => item == propertyName) != null)
            {
                ignoredProperties.Remove(propertyName);
                return null;
            }

            var validationResults = new List<ValidationResult>();

            if (Validator.TryValidateProperty(
                    GetType().GetProperty(propertyName).GetValue(this),
                    new ValidationContext(this)
                    {
                        MemberName = propertyName
                    },
                    validationResults)
                ) return null;

            return validationResults.First().ErrorMessage;
        }

        protected void ValidateProperty(string propertyName, bool ignoreFirstValidation = false)
        {
            validatedProperties.Add(propertyName);
            if (ignoreFirstValidation)
                ignoredProperties.Add(propertyName);
        }
    }
}
