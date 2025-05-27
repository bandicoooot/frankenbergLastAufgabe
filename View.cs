using System;

public class View 
{
    private Controller _ctrl;
    public Controller Ctrl
    {
        get { return _ctrl; }
        set { _ctrl = value; }
    }

public View(Controller ctrl)
{
    _ctrl = ctrl;
    _ctrl.model.OnCustomerChanged += DisplayOutputElement;
}


public void DisplayInputElement()
{
    Console.WriteLine("Ändern Sie den Kundennamen:");
    string? input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input))
    {
        _ctrl.EditCustomer(input);
    }
}




    public void DisplayOutputElement()
    {
        Console.WriteLine($"Name des Kunden:{_ctrl.model.Name}");
    }
}
