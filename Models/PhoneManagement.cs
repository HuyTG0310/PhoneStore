namespace MyBlazorProject.Models;

public class PhoneManagement
{
    public List<Phone> SearchList(List<Phone> PhoneList, string SearchInput, string PriceInput, bool InStockInput)
    {
        return PhoneList.Where(p => p.IsFiltered(SearchInput, PriceInput, InStockInput)).ToList();
    }

    public void Sort(List<Phone> list, string SortType)
    {
        if (SortType.Equals("1"))
        {
            AscendingAlphabetically(list);
        }
        else if (SortType.Equals("2"))
        {
            PriceAscendingList(list);
        }
        else if (SortType.Equals("3"))
        {
            PriceDescendingList(list);
        }
    }

    void AscendingAlphabetically(List<Phone> list)
    {
        list.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
    }

    void PriceAscendingList(List<Phone> list)
    {
        list.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
    }

    void PriceDescendingList(List<Phone> list)
    {
        list.Sort((p1, p2) => p2.Price.CompareTo(p1.Price));
    }
}