using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApi.Models
{
    public class RechargeModel
    {
        public int Id { get; set; }
        public int MobileNumber { get; set; }

        public int RechargeAmount { get; set; }

        public static List<RechargeModel>GetAllRecharge()
        {
            List<RechargeModel> rm = new List<RechargeModel>()
            {
                new RechargeModel(){Id=1, MobileNumber= 123456798, RechargeAmount=499},
                new RechargeModel(){Id=2, MobileNumber= 987645, RechargeAmount=599},

            };
            return rm;
           
            }
        }
    }
