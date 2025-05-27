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
        Console.SetCursorPosition(0, 2);
        Console.WriteLine("Ändern Sie den Kundennamen:");
        Console.SetCursorPosition(27, 2);
        _ctrl.EditCustomer(Console.ReadLine());
    }

    public void DisplayOutputElement()
    {
        Console.SetCursorPosition(0, 1);
        Console.WriteLine($"Name des Kunden: {_ctrl.model.Name}");
    }
}
