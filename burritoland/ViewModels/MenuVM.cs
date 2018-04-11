using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burritoland.Models;

namespace burritoland.ViewModels
{
    public class MenuVM : ObservableBaseObject
    {
        private List<Product> productList = new List<Product>();

        private List<Product> _burritosList = new List<Product>();
        public List<Product> burritosList
        {
            get
            {
                return _burritosList;
            }
            set
            {
                _burritosList = value;
                OnPropertyChanged();
            }
        }

        private List<Product> _tacosList = new List<Product>();
        public List<Product> tacosList
        {
            get
            {
                return _tacosList;
            }
            set
            {
                _tacosList = value;
                OnPropertyChanged();
            }
        }


        public MenuVM()
        {
            localPopulateProductList();
            burritosList = getBurritosListFromProductList();
            tacosList = getTacosListFromProductList();
        }

        private void localPopulateProductList()
        {
            productList.Add(new Product() { id = 0, name = "Ham and Cheese", description = "Delicious burritos easy to prepare ham and cheese", price = 65.00, category = "Burritos" });
            productList.Add(new Product() { id = 1, name = "Beans and Cheese", description = "For a quick snack and that you can take to the office and heat it there or eat it cold", price = 48.00, category = "Burritos" });
            productList.Add(new Product() { id = 2, name = "Chicken with Salad", description = "With these Chicken Burritos and accompanied with a Cucumber and Tomato Salad", price = 64.00, category = "Burritos" });
            productList.Add(new Product() { id = 3, name = "Chicken n' Avocado", description = "A base of beans, grilled chicken accompanied by slices of avocado", price = 85.00, category = "Burritos" });
            productList.Add(new Product() { id = 4, name = "De Guisado", description = "Chicken tinga, picositas rajas with cream, soft pork rind in green sauce, and rich potatoes with chorizo", price = 45.00, category = "Tacos" });
            productList.Add(new Product() { id = 5, name = "De Lengua", description = "Delicious tacos of tongue drowned in chile tree and guajillo sauce are a very popular dish in Monterrey", price = 45.00, category = "Tacos" });
            productList.Add(new Product() { id = 6, name = "De Canasta", description = "Tacos of bean, chicharrón and chicken basket or fill them with the stew that you like", price = 45.00, category = "Tacos" });
            productList.Add(new Product() { id = 7, name = "Machaca and Eggs", description = "The egg with the machaca, tomato and chile serrano; then form a burrito with flour tortillas.", price = 55.00, category = "Burritos" });
            productList.Add(new Product() { id = 8, name = "Teotihuacán", description = "Accompanied with beans, the tortilla is corn but you can use flour or cactus tortilla", price = 90.00, category = "Burritos" });
            productList.Add(new Product() { id = 9, name = "Chorizo", description = "Chorizo burrito with black beans and tomato. Tree chili sauce to accompany them", price = 60.00, category = "Burritos" });
            productList.Add(new Product() { id = 10, name = "Steak", description = "much flavor these taquitos are ideal, since they are super simple, and delicious", price = 45.00, category = "Tacos" });
            productList.Add(new Product() { id = 11, name = "De Tripa", description = "The classic tripa taquitos, enjoy these delicious tacos, you'll love them", price = 45.00, category = "Tacos" });
            productList.Add(new Product() { id = 12, name = "Spaghetti", description = "A little different from traditional tacos but they are even richer", price = 45.00, category = "Tacos" });
            productList.Add(new Product() { id = 13, name = "Tuna", description = "Accompanied with a little light cream and escarole lettuce that will give you all the freshness needed for these hot days", price = 53.00, category = "Burritos" });
            productList.Add(new Product() { id = 14, name = "Mushrooms", description = "They have all the flavor, except that instead of meat, they are stuffed with tasty mushrooms", price = 48.00, category = "Burritos" });
            productList.Add(new Product() { id = 15, name = "Steak", description = "The best for an afternoon with friends at home and enjoy a good conversation with these steak burritos", price = 99.00, category = "Burritos" });
            productList.Add(new Product() { id = 16, name = "De Machaca", description = "Crunchy tacos from Machaca de Sonora with cheese and cream", price = 45.00, category = "Tacos" });
            productList.Add(new Product() { id = 17, name = "Fish", description = "Delicious battered fish strips accompanied with pico de gallo, cabbage and a touch of sour cream that you will love", price = 45.00, category = "Tacos" });
            productList.Add(new Product() { id = 18, name = "Healthy Lettuce", description = "Healthy choice of chicken shepherd's tacos without carbohydrates served in a French Lettuce", price = 45.00, category = "Tacos" });
        }

        private List<Product> getBurritosListFromProductList()
        {
            burritosList = productList.Where(i => i.category == "Burritos").ToList<Product>();
            return burritosList;
        }

        private List<Product> getTacosListFromProductList()
        {
            tacosList = productList.Where(i => i.category == "Tacos").ToList<Product>();
            return tacosList;
        }
    }
}