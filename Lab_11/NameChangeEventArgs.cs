using System;

class NameChangeEventArgs : EventArgs
{
    public string _name { get; set; }
    public NameChangeEventArgs(string Name)
    {
        _name = Name;
    }
}