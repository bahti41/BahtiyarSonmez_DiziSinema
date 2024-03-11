using DiziSinema.Entity.Concrete.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziSinema.Data.Concrete.Configs
{
    public class SerialTvConfig : IEntityTypeConfiguration<SerialTv>
    {
        public void Configure(EntityTypeBuilder<SerialTv> builder)
        {
            throw new NotImplementedException();
        }
    }
}
