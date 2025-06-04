namespace IsoscelesTriangle.Services;

public class IsoscelesTriangle
{
    public static string ValidIsoscelesTriangle(int firstAngle, int secondAngle, int
            thirdAngle)
    {
        string result;

        if ((firstAngle == secondAngle) || (firstAngle == thirdAngle) || (secondAngle == thirdAngle))
        {
            result = "This is a valid Isosceles Triangle";
        }
        else
        {
            result = "This is NOT a valid Isosceles Triangle";
        }

        return result;
    }
}
