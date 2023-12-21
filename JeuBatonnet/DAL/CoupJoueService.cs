using JeuBatonnet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuBatonnet.DAL
{
    public static class CoupJoueService
    {
        public static int AddCoupJoue(CoupJoue cj)
        {
            using (JfmContext jfmContext = new JfmContext())
            {
                if (cj == null)
                {
                    throw new ArgumentNullException(nameof(cj));
                }

                jfmContext.CoupJoues.Add(cj);

                jfmContext.SaveChanges();

                return cj.CoupId;
            }
        }
    }
}
