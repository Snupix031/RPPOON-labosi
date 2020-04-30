using System;
using System.Collections.Generic;
using System.Text;

namespace lv4
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();

    }
}
