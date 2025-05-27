using System;

public class Client
{
    private CustomerModel _model;
    private View _view;

    public static void Main(string[] args)
    {
        Client client = new Client();
        Console.ReadKey();
    }

public Client()
{
    Controller ctrl = new Controller();
    _model = ctrl.model;
    _view = new View(ctrl); // View subscribes to model changes
    Start(); // Now loop only handles input
}


    public void Start()
    {
        while (true)
        {
            _view.DisplayInputElement(); 
        }
    }
}
