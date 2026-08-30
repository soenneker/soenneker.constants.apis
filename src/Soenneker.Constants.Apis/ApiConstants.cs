namespace Soenneker.Constants.Apis;

/// <summary>
/// Provides keys shared by API middleware and filters.
/// </summary>
public static class ApiConstants
{
    /// <summary>
    /// The <c>HttpContext.Items</c> key indicating that request execution reached a controller.
    /// </summary>
    public const string ControllerHitFlag = nameof(ControllerHitFlag);
}
