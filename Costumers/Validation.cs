using System;
using System.Text.RegularExpressions;


public static class CustomerValidator
{
    public static void ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty or whitespace.");
        }


        const int MAX_LENGTH = 250;
        if (name.Length > MAX_LENGTH)
        {
            throw new ArgumentException($"Name length ({name.Length}) exceeds the maximum allowed length of {MAX_LENGTH} characters.");
        }

        if (!Regex.IsMatch(name, @"^[\p{L}\s]+$"))
        {
            throw new ArgumentException("Name contains invalid characters. Only letters and spaces are allowed.");
        }
    }
    public static void ValidateIdentityNumber(string identityNumber)
    {
        if (string.IsNullOrWhiteSpace(identityNumber))
        {
            throw new ArgumentException("Identity Number cannot be empty.");
        }

        const int REQUIRED_LENGTH_INDIVIDUAL = 11;
        const int REQUIRED_LENGTH_LEGAL = 8;
        if (identityNumber.Length != REQUIRED_LENGTH_INDIVIDUAL && identityNumber.Length != REQUIRED_LENGTH_LEGAL)
        {
            throw new ArgumentException($"Identity Number must be exactly {REQUIRED_LENGTH_INDIVIDUAL} or {REQUIRED_LENGTH_LEGAL} digits, but found {identityNumber.Length}.");
        }

        if (!long.TryParse(identityNumber, out _))
        {
            throw new FormatException($"Invalid format for Identity Number: '{identityNumber}'. Must contain only digits.");
        }
    }

    public static void ValidatePhoneNumber(string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            throw new ArgumentException("Phone Number cannot be empty.");
        }

        const int REQUIRED_LENGTH = 9;
        if (phoneNumber.Length != REQUIRED_LENGTH)
        {
            throw new ArgumentException($"Phone Number must be exactly {REQUIRED_LENGTH} digits.");
        }

        if (!int.TryParse(phoneNumber, out _))
        {
            throw new FormatException($"Invalid format for Phone Number: '{phoneNumber}'. Must contain only digits.");
        }
    }

    public static void ValidateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("Email cannot be empty.");
        }

        const int MAX_LENGTH = 320;
        if (email.Length > MAX_LENGTH)
        {
            throw new ArgumentException($"Email length ({email.Length}) exceeds the maximum allowed length of {MAX_LENGTH} characters.");
        }

        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        if (!Regex.IsMatch(email, emailPattern))
        {
            throw new ArgumentException($"Invalid Email format: '{email}'.");
        }
    }

    public static void ValidateType(string Type)
    {
        if (Type != "0" && Type != "1")
        {
            throw new ArgumentException($"Invalid Type value: {Type}. Only 0 or 1 is allowed.");
        }
    }
}