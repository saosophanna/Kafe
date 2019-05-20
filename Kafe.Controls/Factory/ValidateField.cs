using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kafe.Controls
{
    public class ValidateField : BaseViewModul, INotifyDataErrorInfo
    {
        private Dictionary<string, List<string>> errors =
             new Dictionary<string, List<string>>();

        public bool HasErrors => errors.Count > 0;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged=(sender,e)=> { };

        public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName))
                return null;
            if (!errors.ContainsKey(propertyName))
                return null;
            if (errors[propertyName].Count == 0)
                return null;
            return errors[propertyName];
        }

        public void OnErrorChanage([CallerMemberName] string propertyName = "") => ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));

        public void ValidateModul<Modul>(Modul modul, object value, [CallerMemberName] string propertyName = "")
        {
            if (errors.ContainsKey(propertyName))
                errors.Remove(propertyName);

            var validationContext = new ValidationContext(modul,null,null){MemberName=propertyName};

            var validationResutls = new List<ValidationResult>();

            if (!Validator.TryValidateProperty(value, validationContext, validationResutls))
            {
                errors.Add(propertyName, new List<string>());
                foreach (var vr in validationResutls)
                {
                    errors[propertyName].Add(vr.ErrorMessage);
                }
            }

            OnErrorChanage(propertyName);
            OnPropertyChanged(propertyName);
        }

    }
}
