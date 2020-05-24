using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EscAdv.Data;
using EscAdv.Models;
using System;
using System.Linq;

namespace EscAdv.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EscAdvContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EscAdvContext>>()))
            {
                // Look for any movies.
                if (context.Process.Any())
                {
                    return;   // DB has been seeded
                }

                context.Process.AddRange(
                  new Process{
                    title = "Processo Criminal",
                    type = "Criminal",
                    petition = "1547854"
                  },
                  new Process{
                    title = "Processo Administrativo",
                    type = "Administrativo",
                    petition = "5472014"
                  },
                  new Process{
                    title = "Processo Previdênciário",
                    type = "Previdênciário",
                    petition = "7540325"
                  }
                );
                context.SaveChanges();
            }
        }
    }
}