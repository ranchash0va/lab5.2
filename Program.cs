namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            CommerceManager commerceManager = new CommerceManager();

            try
            {
                commerceManager.AddElement(new Goods("Smartphone", 1, "High-end smartphone", 699.99, "Electronics", "Electronics", 50, "Samsung"));
                commerceManager.AddElement(new Service("Plumbing Service", 2, "Plumbing repair service", 89.99, "Home Services", "ABC Plumbing", 2, true));
                commerceManager.AddElement(new Logistics("Express Delivery", 3, "Fast delivery service", 19.99, "Logistics", "Truck", "Customer's Address", DateTime.Now.AddDays(2)));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка при добавлении элемента: {ex.Message}");
                return;
            }

            commerceManager.DisplayElements();

            try
            {
                commerceManager.UpdateElement(0, new Goods("Updated Smartphone", 1, "High-end smartphone", 799.99, "Electronics", "Electronics", 50, "Samsung"));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка при обновлении элемента: {ex.Message}");
            }

            commerceManager.DisplayElements();

            commerceManager.RemoveElement(1);

            commerceManager.DisplayElements();

            foreach (var element in commerceManager.GetDeletedElements())
            {
                Console.WriteLine($"Объект {element.Name} был удален.");
            }

            foreach (var element in commerceManager.GetEditedElements())
            {
                Console.WriteLine($"Объект {element.Name} был отредактирован.");
            }
        }
    }
}
