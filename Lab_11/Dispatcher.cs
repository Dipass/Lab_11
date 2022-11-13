using System;


class Dispatcher
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs names);
    private string _name;
    public event NameChangeEventHandler NameChange;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
            OnNameChange(new NameChangeEventArgs(Name));
        }
    }

    public void OnNameChange(NameChangeEventArgs args)
    {
        NameChange?.Invoke(this,args);
    }


}