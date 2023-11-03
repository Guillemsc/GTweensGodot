using Godot;
using GTweens.Enums;

namespace GTweensGodot.Extensions;

public static class AngleExtensions
{
    public static Vector3 GetDestinationAngleDegrees(Vector3 origin, Vector3 destination, RotationMode mode)
    {
        switch (mode)
        {
            case RotationMode.ShortestDistance:
            {
                Vector3 clampedOrigin = GTweens.Extensions.AngleExtensions.Clamp360(origin);
                Vector3 clampedDestination = GTweens.Extensions.AngleExtensions.Clamp360(destination);
        
                Vector3 deltaAngle = GTweens.Extensions.AngleExtensions.DeltaAngle(clampedOrigin, clampedDestination);
        
                return origin + deltaAngle;
            }
        
            default:
            case RotationMode.TotalDistance:
            {
                return destination;
            }
        }
    }
    
    public static Vector3 GetDestinationAngleRadiants(Vector3 origin, Vector3 destination, RotationMode mode)
    {
        return GetDestinationAngleDegrees(
            origin * MathExtensions.Rad2Deg,
            destination * MathExtensions.Rad2Deg,
            mode
        ) * MathExtensions.Deg2Rad;
    }
}