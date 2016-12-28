using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace Happyzu.Mall.Orders
{
    public class OrderInfo: FullAuditedAggregateRoot<long>
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public string OrderStatus { get; set; }

        /// <summary>
        /// 小计金额
        /// </summary>
        public decimal SubTotalAmount { get; set; }

        /// <summary>
        /// 订单合计
        /// </summary>
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// 剩余金钱
        /// </summary>
        public decimal SurplusMoney { get; set; }

        /// <summary>
        /// 是否评价
        /// </summary>
        public bool IsReview { get; set; }

        /// <summary>
        /// 重量（单位：g）
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// 物流费
        /// </summary>
        public decimal ShipFee { get; set; }

        /// <summary>
        /// 满减
        /// </summary>
        public decimal FullCut { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// 使用积分支付数量
        /// </summary>
        public int PaidUsePoints { get; set; }

        /// <summary>
        /// 使用积分支付抵扣金额
        /// </summary>
        public decimal PaidUsePointsAmount { get; set; }

        /// <summary>
        /// 优惠券抵扣金额
        /// </summary>
        public decimal CouponAmount { get; set; }

        /// <summary>
        /// 已支付金额
        /// </summary>
        public decimal PaidAmount { get; set; }

        /// <summary>
        /// 买家备注
        /// </summary>
        public string BuyerRemark { get; set; }

        /// <summary>
        /// 买家IP
        /// </summary>
        public string Ip { get; set; }
    }
}
