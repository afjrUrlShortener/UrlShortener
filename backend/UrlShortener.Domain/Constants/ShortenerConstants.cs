namespace UrlShortener.Domain.Constants;

public readonly struct ShortenerConstants
{
    public static readonly char[] CharacterSet =
    [
        'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e', 'F', 'f', 'G', 'g', 'H', 'h', 'I', 'i', 'J', 'j', 'K', 'k',
        'L', 'l',
        'M', 'm', 'N', 'n', 'O', 'o', 'P', 'p', 'Q', 'q', 'R', 'r', 'S', 's', 'T', 't', 'U', 'u', 'V', 'v', 'W', 'w',
        'X', 'x',
        'Y', 'y', 'Z', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'
    ];

    public const int ShortUrlMaxSize = 6;
    public const int RenewalDays = 15;
}