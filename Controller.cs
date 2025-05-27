using System;

public class Controller {
    private CustomerModel _model;
    public CustomerModel model {
        get { return _model; }
        set { _model = value; }
    }

    private View _view;
    public View view {
        get { return _view; }
        set { _view = value; }
    }

 public Controller() {
    _model = new CustomerModel();
    _view = new View(this);

    _model.Name = "Karin Weber"; 
}


    public void EditCustomer(string name) {
        model.Name = name;
    }
}
