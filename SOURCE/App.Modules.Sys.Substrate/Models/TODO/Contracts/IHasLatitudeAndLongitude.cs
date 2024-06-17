namespace App.Modules.Core.Shared.Models.TODO.Contracts
{
    /// <summary>
    /// Contract for models that define their 
    /// Global Position.
    /// </summary>
    public interface IHasLatitudeAndLongitude
    {
        /// <summary>
        /// The latitude
        /// </summary>
        decimal Latitude { get; set; }
        /// <summary>
        /// The longitude
        /// </summary>
        decimal Longitude { get; set; }
    }
}