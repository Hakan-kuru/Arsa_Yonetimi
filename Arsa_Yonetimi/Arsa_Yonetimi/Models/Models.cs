using System;

namespace Models
{
    public class Expense
    {
        public int Id { get; set; } // Giderin benzersiz kimliği
        public int FieldId { get; set; } // Hangi arsa ile ilişkili olduğu
        public string Category { get; set; } // Gider türü (örneğin işçi, gübre)
        public double Amount { get; set; } // Gider miktarı
        public DateTime ExpenseDate { get; set; } // Gider tarihi
    }

    public class Sale
    {
        public int SaleId { get; set; } // Satışın benzersiz kimliği
        public int FieldId { get; set; } // Hangi arsa ile ilişkili olduğu
        public double Amount { get; set; } // Satılan ürün miktarı (kilo)
        public double PricePerKg { get; set; } // Kilo başı fiyat
        public DateTime SaleDate { get; set; } // Satış tarihi
    }

    public class Field
    {
        public int FieldId { get; set; } // Her arsa için benzersiz bir kimlik
        public string FieldName { get; set; } // Arsa adı
        public double FieldArea { get; set; } // Dönüm bilgisi
        public string FieldCrop { get; set; } // Ekilen ürün
        public DateTime PlantDate { get; set; } // Ekiliş tarihi
    }

    public static class DataStore
    {
        public static List<Field> Fields { get; set; } = new List<Field>();
        public static List<Sale> Sales { get; set; } = new List<Sale>();
        public static List<Expense> Expenses { get; set; } = new List<Expense>();
    }

}
