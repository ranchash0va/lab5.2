namespace lab5
{
    internal class CommerceManager
    {
        private List<BaseInform> commerceObjects;

        public CommerceManager()
        {
            commerceObjects = new List<BaseInform>();
        }

        public void AddElement(BaseInform element)
        {
            commerceObjects.Add(element);
        }

        public void RemoveElement(int index)
        {
            if (index >= 0 && index < commerceObjects.Count)
            {
                commerceObjects[index].IsDeleted = true;
                commerceObjects.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Неверный индекс. Элемент не найден.");
            }
        }

        public void UpdateElement(int index, BaseInform updatedElement)
        {
            if (index >= 0 && index < commerceObjects.Count)
            {
                commerceObjects[index].IsEdited = true;
                commerceObjects[index] = updatedElement;
            }
            else
            {
                Console.WriteLine("Неверный индекс. Элемент не найден.");
            }
        }

        public void DisplayElements()
        {
            Console.WriteLine("Список объектов:");
            for (int i = 0; i < commerceObjects.Count; i++)
            {
                Console.WriteLine($"{i}: {commerceObjects[i]}");
            }
        }

        public List<BaseInform> GetDeletedElements()
        {
            return commerceObjects.Where(obj => obj.IsDeleted).ToList();
        }

        public List<BaseInform> GetEditedElements()
        {
            return commerceObjects.Where(obj => obj.IsEdited).ToList();
        }
    }
}