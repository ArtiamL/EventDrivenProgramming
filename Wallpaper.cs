namespace EventDrivenProgramming
{
    /// <summary>
    /// Provides basic data for wallpapers.
    /// </summary>
    internal class Wallpaper
    {
        public string? Name { get; set; } //Wallpaper name
        public decimal? Price { get; set; } //Wallpaper price
        public Button? AssignedBtn { get; set; } //Button assigned to wallpaper
        
        public const decimal LENGTH = 5; //Wallpaper roll length. Always 5.
        public const decimal WIDTH = 0.5M; //Wallpaper roll width. Always 0.5

        public const decimal AREA = LENGTH * WIDTH; //Wallpaper roll area. Always Length * Width.
    }
}
