using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment02
{
    class Globals
    {
                
        //Customer details Variables
        public static String 
            Forename, 
            Surname, 
            HouseNo,
            Address,
            Town_City,
            County,
            Postcode,
            Mobile,
            Email;
                
        //Device details Variables
        public static String
            selected_device,
            selected_harddisc,
            selected_graphicsadapter;

        //Device Warranty Variables
        public static String
            selected_warranty;
        
        //Device Delivery Variables
        public static String
            selected_delivery;


        //Device Price Variables
        public static Double
            device_price = 0.0,
            harddisc_price = 0.0,
            graphicsadapter_price = 0.0,
            warranty_price = 0.0,
            delivery_price = 0.0;


    }
}
