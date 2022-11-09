namespace ComputerService.DataAcces.Entities
{
    using System.Collections.Generic;

    public class Owner
    {
        public int OwnerId { get; set; }

        public string OwnerName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
