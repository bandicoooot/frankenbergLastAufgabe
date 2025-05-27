public class CustomerModel
{
    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            OnCustomerChanged?.Invoke(); // Notify view
        }
    }

    public event Action? OnCustomerChanged;
}
