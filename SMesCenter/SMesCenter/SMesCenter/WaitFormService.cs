using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;


namespace SMesCenter
{
    public class WaitFormService
      {
           private Thread waitThread;
           private frmWaiting frmWaiting;
          private delegate void CloseSplashForm();
          private static readonly Object syncLock = new object();
  
          private static WaitFormService _instance = null;
         /// <summary>
         /// 保证仅有一个实例
        /// </summary>
          public static WaitFormService Instance
          {
            get
            {
                 if (WaitFormService._instance == null)
                 {
                      lock (syncLock)
                      {
                        if (WaitFormService._instance == null)
                        {
                           WaitFormService._instance = new WaitFormService();
                        }
                     }
                 }
                return WaitFormService._instance;
             }
        }

         /// <summary>
         /// 创建一个等待窗实例
         /// </summary>
         public static void CreateWaitForm()
        {
            WaitFormService.Instance.CreateForm();
        }
 
         /// <summary>
         /// 关闭这个等待窗体
         /// </summary>
          public static void CloseWaitForm()
        {
              WaitFormService.Instance.CloseForm();
         }
 
        /// <summary>
        /// 设置窗体中的文字内容
         /// </summary>
         /// <param name="text"></param>
         public static void SetWaitFormCaption(string text)
        {
            WaitFormService.Instance.SetFormCaption(text);
        }
 
          public void CreateForm()
         {
             if (waitThread != null)
            {
                try
                {
                     DisposeForm();  //此处实现了委托调用，在创建窗体前检查并释放窗体
                     waitThread.Abort();
                     waitThread.Join();
                     //waitThread.DisableComObjectEagerCleanup();
                  
                }
                catch { }
            }

             frmWaiting = new frmWaiting();
           waitThread = new Thread(new ThreadStart(delegate() {
               Application.Run(frmWaiting);
            }));
             waitThread.Start();
         }
 
         private void DisposeForm()
        {
            if (frmWaiting != null && frmWaiting.InvokeRequired)
             {
                 CloseSplashForm csf = new CloseSplashForm(DisposeForm);
                 this.frmWaiting.Invoke(csf, null);
            }
             else
             {
                 frmWaiting.Dispose();
            }
        }
 
         public void CloseForm()
          {
            if (waitThread != null)
             {
                 try
                {
                    DisposeForm();
                   waitThread.Abort();
                    waitThread.Join();
                    //waitThread.DisableComObjectEagerCleanup();
                }
                catch { }
           }
         }

        /// <summary>
        /// 设置等待屏中的显示文字
       /// </summary>
         /// <param name="text"></param>
         public void SetFormCaption(string text)
         {
             if (frmWaiting != null)
             {
                 try
                {
                   // frmWaiting.SetText(text);
                }
                catch { }
             }
         }
    }
}
