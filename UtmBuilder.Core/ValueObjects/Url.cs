using UtmBuilder.Core.ValueObjects.Exceptions;
namespace UtmBuilder.Core.ValueObjects;
public class Url : ValueObjehct
{
    public Url(string address)
    {
        Address = address;
        InvalidUrlException.ThrowIfInvalid(address);
    }

    ///<summary>
    ///Create a new URL
    ///<param name="Address">Address of URL (Website link)</param>
    ///</summary>
    public string Address { get; }
}