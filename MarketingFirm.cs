﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    //dependency injection
   public class MarketingFirm
   {
       public ISweepstakesManager manager;


        public MarketingFirm(ISweepstakesManager manager)
        {

            this.manager = manager;



        }



   }







}
