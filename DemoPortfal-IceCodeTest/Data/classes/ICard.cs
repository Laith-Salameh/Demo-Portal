namespace  DemoPortfal_IceCodeTest.Data {
    public enum CardType{
        Primary,
        Secondary
    }
    public class ICard{
        public String Icon { get; set; } = "";
        public CardType Color {get; set;} = CardType.Primary;
        public String Period { get; set; } = "";
        public int Number { get; set; }
        public DateTime LastUpdated {get; set;}
    }
}