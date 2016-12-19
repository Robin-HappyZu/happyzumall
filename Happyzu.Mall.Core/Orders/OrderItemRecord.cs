using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Happyzu.Mall.Orders
{
    public class OrderItemRecord:Entity<long>, ICreationAudited
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderNo { get; set; }
        /// <summary>
        /// 商品Id
        /// </summary>
        public int ProductId { get; set; }

        public string SKU { get; set; }



        #region ICreationAudited
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        #endregion
    }
}
