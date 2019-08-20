namespace Grabble.Data.Domain.GrabPack
{
    public class Container : BaseEntity
    {
        /*Enum grabble pack sizes
         Small
         Medium 
         Large
             */
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal Volume { get; set; }
    }
}
