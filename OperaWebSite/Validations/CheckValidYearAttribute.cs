using System.ComponentModel.DataAnnotations;
namespace OperaWebSite.Validations
{
    public class CheckValidYearAttribute : ValidationAttribute
    {
        public CheckValidYearAttribute()
        {
            ErrorMessage = "El año debe ser mayor o igual a 1598";
        }
        public override bool IsValid(object value)
        {
            //   return base.IsValid(value);
            int year = (int)value;
            if (year < 1598)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

