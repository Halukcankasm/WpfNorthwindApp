using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using static WpfNorthwindApp.Model.Enums;

namespace WpfNorthwindApp.Converter
{
    public class IntToImageConcerter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((int)value)
            {
                case (int)ProductCategory.Beverages:
                    return "/Source/ProductCategoryImages/Beverages.png";
                case (int)ProductCategory.Condiments:
                    return "/Source/ProductCategoryImages/Condiments.png";
                case (int)ProductCategory.Confections:
                    return "/Source/ProductCategoryImages/Confections.png";
                case (int)ProductCategory.DairyProducts:
                    return "/Source/ProductCategoryImages/DairyProducts.png";
                case (int)ProductCategory.GrainsOrCereals:
                    return "/Source/ProductCategoryImages/GrainsOrCereals.png";
                case (int)ProductCategory.MeatOrPoultry:
                    return "/Source/ProductCategoryImages/MeatOrPoultry.png";
                case (int)ProductCategory.Produce:
                    return "/Source/ProductCategoryImages/Produce.png";
                case (int)ProductCategory.Seafood:
                    return "/Source/ProductCategoryImages/Seafood.png";
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
