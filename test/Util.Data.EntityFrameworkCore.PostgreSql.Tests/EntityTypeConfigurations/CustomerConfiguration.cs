using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Util.Data.EntityFrameworkCore.Models;

namespace Util.Data.EntityFrameworkCore.EntityTypeConfigurations {
    /// <summary>
    /// 客户类型配置
    /// </summary>
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {
        /// <summary>
        /// 配置
        /// </summary>
        /// <param name="builder">实体类型生成器</param>
        public void Configure( EntityTypeBuilder<Customer> builder ) {
            ConfigTable( builder );
            ConfigId( builder );
            ConfigProperties( builder );
        }

        /// <summary>
        /// 配置表
        /// </summary>
        private void ConfigTable( EntityTypeBuilder<Customer> builder ) {
            builder.ToTable( "Customer", "Customers" ).HasComment( "客户" );
        }

        /// <summary>
        /// 配置标识
        /// </summary>
        private void ConfigId( EntityTypeBuilder<Customer> builder ) {
            builder.Property( t => t.Id )
                .HasColumnName( "CustomerId" )
                .HasComment( "客户标识" )
                .ValueGeneratedOnAdd();
        }

        /// <summary>
        /// 配置属性
        /// </summary>
        private void ConfigProperties( EntityTypeBuilder<Customer> builder ) {
            builder.Property( t => t.Code )
                .HasColumnName( "Code" )
                .HasComment( "编码" );
            builder.Property( t => t.Name )
                .HasColumnName( "Name" )
                .HasComment( "姓名" );
            builder.Property( t => t.Nickname )
                .HasColumnName( "Nickname" )
                .HasComment( "昵称" );
            builder.Property( t => t.Gender )
                .HasColumnName( "Gender" )
                .HasComment( "性别" );
            builder.Property( t => t.Birthday )
                .HasColumnName( "Birthday" )
                .HasColumnType( "timestamp" )
                .HasComment( "出生日期" );
            builder.Property( t => t.Nation )
                .HasColumnName( "Nation" )
                .HasComment( "民族" );
            builder.Property( t => t.Phone )
                .HasColumnName( "Phone" )
                .HasComment( "手机号" );
            builder.Property( t => t.Email )
                .HasColumnName( "Email" )
                .HasComment( "电子邮件" );
            builder.Property( t => t.CreationTime )
                .HasColumnName( "CreationTime" )
                .HasColumnType( "timestamp" )
                .HasComment( "创建时间" );
            builder.Property( t => t.CreatorId )
                .HasColumnName( "CreatorId" )
                .HasComment( "创建人" );
            builder.Property( t => t.LastModificationTime )
                .HasColumnName( "LastModificationTime" )
                .HasColumnType( "timestamp" )
                .HasComment( "最后修改时间" );
            builder.Property( t => t.LastModifierId )
                .HasColumnName( "LastModifierId" )
                .HasComment( "最后修改人" );
        }
    }
}