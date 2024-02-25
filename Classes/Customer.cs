namespace Classes;

public class Customer
{
    public string DateYear; // field-alan ,değişken tanımlamak
    public int Id { get; set; } //property- özellik tanımlamak.
    
    private string _firstName;
    
    public string FirstName
    {
        get
        {
            return "MR." + _firstName;
        }
        set
        {
            _firstName = value;
        }
    }

    public string LastName { get; set; }
    public string City { get; set; }
}
// değer vermek set , değer almak get .