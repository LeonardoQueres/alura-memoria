using System.Globalization;

namespace UsuarioLib;

public struct Coordenada(double latitude, double longitude)
{
    public double Latitude = latitude;
    public double Longitude = longitude;


    public override string ToString()
    {
        return $"{Latitude.ToString(CultureInfo.InvariantCulture)}, {Longitude.ToString(CultureInfo.InvariantCulture)}";
    }
}