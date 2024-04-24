using System;
using System.Collections.Generic;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public bool Equals(FacialFeatures otherFace)
    {
        if ((EyeColor == otherFace.EyeColor) && (PhiltrumWidth == otherFace.PhiltrumWidth)) return true;
        else return false;
    }

    public int GetHashCode()
    {
        var hash = new HashCode();

        hash.Add(EyeColor);
        hash.Add(PhiltrumWidth);

        return hash.ToHashCode();
    }
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public bool Equals(Identity otherIdentity)
    {

        if (FacialFeatures.Equals(otherIdentity.FacialFeatures) && Email == otherIdentity.Email) return true;
        else return false;
    }

    public int GetHashCode()
    {
        var hash = new HashCode();

        hash.Add(Email);
        hash.Add(FacialFeatures.GetHashCode());

        return hash.ToHashCode();
    }
}

public class Authenticator
{
    private HashSet<int> registeredList;

    public Authenticator()
    {
        registeredList = new HashSet<int>();
    }

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        return identity.Equals(new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m)));
    }

    public bool Register(Identity identity)
    {
        if (registeredList.Contains(identity.GetHashCode())) return false;
        else
        {
            registeredList.Add(identity.GetHashCode());
            return true;
        }


    }

    public bool IsRegistered(Identity identity)
    {
        return registeredList.Contains(identity.GetHashCode());
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return System.Object.ReferenceEquals(identityA, identityB);
    }
}

















