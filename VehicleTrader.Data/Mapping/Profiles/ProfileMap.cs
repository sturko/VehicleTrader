using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleTrader.Core.Domain;

namespace VehicleTrader.Data.Mapping.Profiles
{
    public class ProfileMap : EntityTypeConfiguration<Profile>
    {
        /// <summary>
		/// Configures the entity
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity</param>
		public override void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.ToTable(nameof(Profile));
            builder.HasKey(user => user.Id);

            builder.HasOne(profile => profile.ApplicationUser)
                .WithOne(profile => profile.Profile)
                .IsRequired();

            PostConfigure(builder);
        }
    }
}