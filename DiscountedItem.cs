using System;
using System.Collections.Generic;
using System.Text;

namespace lv4
{
    class DiscountedItem : RentableDecorator
    {
        private readonly double DiscountedItemBonus = 0.20;

        public DiscountedItem(IRentable rentable) : base(rentable) { }
        public override double CalculatePrice()
        {
            return base.CalculatePrice() - base.CalculatePrice() * this.DiscountedItemBonus;
        }
        public override String Description
        {
            get
            {
                return "Now at  " + DiscountedItemBonus * 100 + " % off " + base.Description;
            }
        }
    }
}
