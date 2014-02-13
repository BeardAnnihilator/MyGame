namespace MyGame.Data.Models
{
    public class GameSetting : ISetting
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public int GameSpeed { get; set; }

        public string GoogleTrackingCode { get; set; }
    }
}