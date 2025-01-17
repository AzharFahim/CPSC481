public class MenuItem {
        public int ID { get; set; }
        public string? category { get; set; }
        public string? name { get; set; }
        public decimal price { get; set; }
        public string? size { get; set; }
        public string? image { get; set; }
        public string? imageSm { get; set; }
        public string? imageLg { get; set; }
        public string? tags { get; set; }
        public List<Ingredient> ingredients { get; set; }
}