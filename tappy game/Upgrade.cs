﻿namespace tappygame
{
    public class Upgrade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string GetFormattedBacePrice() => Price.ToString("0.00");
    }
}
