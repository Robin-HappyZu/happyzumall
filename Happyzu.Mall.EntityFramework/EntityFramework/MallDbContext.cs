﻿using System.Data.Entity;
using Abp.EntityFramework;
using Happyzu.Mall.Auditing;
using Happyzu.Mall.Configuration;
using Happyzu.Mall.Users;

namespace Happyzu.Mall.EntityFramework
{
    public class MallDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        #region 系统
        /// <summary>
        /// Audit logs.
        /// </summary>
        public virtual DbSet<AuditLog> AuditLogs { get; set; }

        /// <summary>
        /// 配置
        /// </summary>    
        public virtual IDbSet<Setting> Setting { get; set; }

        #endregion



        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MallDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MallDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MallDbContext since ABP automatically handles it.
         */
        public MallDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
