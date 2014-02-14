namespace MyGame.Data.Models
{
    public interface ISetting
    {
        string Id { get; set; }

        string Title { get; set; }

        int GameSpeed { get; set; }

        string GoogleTrackingCode { get; set; }
    }
}