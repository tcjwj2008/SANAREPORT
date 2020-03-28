using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMes.Core.Service;

namespace SMes.Core.AppObj
{
    public class Transaction
    {
        private string transactionId;
        //private Connection conn;


        /// <summary>
        /// 使用系统连接类来初始化Transaction类的新的空实例。
        /// </summary>
        /// <param name="conn"></param>
        public Transaction(Connection conn)
        {
            //this.conn = conn;
            //Monitor.Enter(idGenerator);
            this.transactionId = Convert.ToString(SMes.Core.Service.DataBaseAccess.TrxIdGenerator++);
            //Monitor.Exit(idGenerator);
            //this.transactionId = ""+DateTime.Now.ToFileTime();
        }

        /// <summary>
        /// 设置或获取一个值,该值指示事务的ID号
        /// </summary>
        public string TransactionId
        {
            get
            {
                return transactionId;
            }

            set
            {
                transactionId = value;
            }
        }
    }
}
