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


public void DisplayOutputElement()
{
    Console.SetCursorPosition(0, 1); 
    Console.Write(new string(' ', Console.WindowWidth)); 
    Console.SetCursorPosition(0, 1);
    Console.WriteLine($"Name des Kunden: {_ctrl.model.Name}");
}

public void DisplayInputElement()
{
    Console.SetCursorPosition(0, 2); 
    Console.Write(new string(' ', Console.WindowWidth)); 
    Console.SetCursorPosition(0, 2);
    Console.Write("Ändern Sie den Kundennamen: ");
    string? input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input))
    {
        _ctrl.EditCustomer(input);
    }
}

}
