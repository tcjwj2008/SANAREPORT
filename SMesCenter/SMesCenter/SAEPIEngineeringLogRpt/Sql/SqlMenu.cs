using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAEPIEngineeringLogRpt.Sql
{
    class SqlMenu
    {
        public static string TestData(string transactiontimeS, string transactiontimeE, string componentid, string structure)
        {
            string sql = "";
            sql = @"SELECT A1_外延片号,
                    SUBSTR (A0_建档时间, 1, 10) AS 建档日期,
                    A0_建档时间,
                    A3_快测片尺寸,
                    SUBSTR (A1_外延片号, 1, 12) AS 炉次号,
                    SUBSTR (A1_外延片号, 1, 5) AS 机台号,
                    SUBSTR (A1_外延片号, 12, 1) AS RUN类型,
                    AD_衬底类型,
                    AE_衬底盒号,
                    TO_NUMBER (SUBSTR (FL_石墨盘规格, 1, 2)) AS 石墨盘规格,
                    AF_石墨盘号,
                    FC_圈位,
                    FA_结构码,
                    SUBSTR (FA_结构码, 4, 3) AS 结构码简码,
                    FT_快测类别,
                    GR_陪片,
                    A1_外延片号 AS 片号,
                    AK_WLP_AVG,
                    AL_WLP_STD,
                    AM_WLD_AVG,
                    AN_WLD_STD,
                    AO_HW_AVG,
                    AP_HW_STD,
                    AQ_PHOTO_AVG,
                    AR_PHOTO_STD,
                    AS_THICK_AVG,
                    AT_THICK_STD,
                    AU_ROUGH_AVG,
                    AV_ROUGH_STD,
                    TO_NUMBER (HE_加K值后WLD),
                    B3_THICKNESS_I,
                    B4_THICKNESS_O,
                    B5_THICKNESS_C,
                    AX_FWHM002_I,
                    AY_FWHM002_C,
                    AZ_FWHM002_O,
                    B0_FWHM102_I,
                    B1_FWHM102_C,
                    B2_FWHM102_O,
                    TO_NUMBER (EE_STRAINED_C),
                    TO_NUMBER (FY_INSTRAINED_C),
                    EK_WLD_WLP,
                    CASE WHEN EI_BOWING_X = 0 THEN NULL ELSE TO_NUMBER (EI_BOWING_X) END
                    AS EI_BOWING_X,
                    CASE WHEN EJ_BOWING_Y = 0 THEN NULL ELSE TO_NUMBER (EJ_BOWING_Y) END
                    AS EJ_BOWING_Y,
                    TO_NUMBER (EH_WLD_YIELD),
                    B8_EL_LOP1,
                    B9_EL_VF1,
                    BA_EL_WLD,
                    TO_NUMBER (FQ_EL_HW2),
                    GL_方阻平均值,
                    TO_NUMBER (HL_EPI_EL_VF30MA),
                    TO_NUMBER (HM_EPI_EL_WLD30MA),
                    TO_NUMBER (HN_EPI_EL_WLP30MA),
                    TO_NUMBER (HO_EPI_EL_FWHM30MA),
                    TO_NUMBER (HP_EPI_EL_RMPT30MA),
                    TO_NUMBER (HQ_EPI_EL_VF5MA),
                    TO_NUMBER (HR_EPI_EL_WLP5MA),
                    TO_NUMBER (HS_EPI_EL_FWHM5MA),
                    TO_NUMBER (HT_EPI_EL_RMPT5MA),
                    TO_NUMBER (HU_EPI_EL_WLD5MA),
                    A8_表面等级,
                    A9_表面备注,
                    HE_REMARK,
                    HW_工艺名称,
                    TO_NUMBER (IC_中心波长),
                    TO_NUMBER (IE_EPI_EL_VF1UA),
                    TO_NUMBER (IB_PW2_YIELD),
                    GC_反射率,
                    AW_PL机台,
                    AH_烤炉批号,
                    TO_NUMBER (IT_WLD_A),
                    TO_NUMBER (IU_WLD_B),
                    TO_NUMBER (IV_WLD_C),
                    TO_NUMBER (IW_WLD_D),
                    TO_NUMBER (IX_WLD_E),
                    TO_NUMBER (IY_WLD_F),
                    TO_NUMBER (IZ_WLD_G),
                    TO_NUMBER (JA_WLD_H),
                    TO_NUMBER (JB_WLD_I)
                    FROM EPIDM.EPI_ALLDATA_NEW3
                    WHERE A0_建档时间 >'" + transactiontimeS + @"' and A0_建档时间 <'" + transactiontimeE + @"'";

            if (!string.IsNullOrEmpty(componentid))
            {
                sql += @" and A1_外延片号 like '%" + componentid + @"%'";
            }
            if (!string.IsNullOrEmpty(structure))
            {
                sql += @" and FA_结构码 like '%" + structure + @"%'";
            }

            sql += @" order by A0_建档时间,A1_外延片号";
            return sql;
        }
        public static string QuickData(string transactiontimeS,string transactiontimeE,string componentid, string structure, string verifysize, string lotsequence)
        {
            string sql = "";
            sql = @"SELECT A1_外延片号,
                    SUBSTR (A0_建档时间, 1, 10) AS 建档日期,
                    SUBSTR (CK_快测时间, 1, 10) AS 出快测日期,
                    A0_建档时间,
                    CK_快测时间 AS 回传快测时间,
                    A3_快测片尺寸,
                    E3_芯片产品等级,
                    SUBSTR (A1_外延片号, 1, 12) AS 炉次号,
                    SUBSTR (A1_外延片号, 1, 5) AS 机台号,
                    SUBSTR (A1_外延片号, 12, 1) AS RUN类型,
                    CL_芯片片号,
                    SUBSTR (CL_芯片片号, 1, 12) AS 芯片工单,
                    AD_衬底类型,
                    AE_衬底盒号,
                    TO_NUMBER (SUBSTR (FL_石墨盘规格, 1, 2)),
                    AF_石墨盘号,
                    FC_圈位,
                    D9_抽测机台,
                    FA_结构码,
                    SUBSTR (FA_结构码, 4, 3) AS 结构码简码,
                    AA_快测等级,
                    FT_快测类别,
                    HG_陪片,
                    AQ_PHOTO_AVG,
                    AR_PHOTO_STD,
                    TO_NUMBER (HE_加K值后WLD),
                    AM_WLD_AVG,
                    AN_WLD_STD,
                    AS_THICK_AVG,
                    AU_ROUGH_AVG,
                    AO_HW_AVG,
                    B5_THICKNESS_C,
                    AY_FWHM002_C,
                    B1_FWHM102_C,
                    TO_NUMBER (EE_STRAINED_C),
                    TO_NUMBER (FY_INSTRAINED_C),
                    EK_WLD_WLP,
                    CASE WHEN EI_BOWING_X = 0 THEN NULL ELSE TO_NUMBER (EI_BOWING_X) END
                        AS EI_BOWING_X,
                    CASE WHEN EJ_BOWING_Y = 0 THEN NULL ELSE TO_NUMBER (EJ_BOWING_Y) END
                        AS EJ_BOWING_Y,
                    TO_NUMBER (EH_WLD_YIELD),
                    B8_EL_LOP1,
                    B9_EL_VF1,
                    BA_EL_WLD,
                    TO_NUMBER (FQ_EL_HW2),
                    GL_方阻平均值,
                    TO_NUMBER (HL_EPI_EL_VF30MA),
                    TO_NUMBER (HM_EPI_EL_WLD30MA),
                    TO_NUMBER (HN_EPI_EL_WLP30MA),
                    TO_NUMBER (HO_EPI_EL_FWHM30MA),
                    TO_NUMBER (HP_EPI_EL_RMPT30MA),
                    TO_NUMBER (HQ_EPI_EL_VF5MA),
                    TO_NUMBER (HR_EPI_EL_WLP5MA),
                    TO_NUMBER (HS_EPI_EL_FWHM5MA),
                    TO_NUMBER (HT_EPI_EL_RMPT5MA),
                    TO_NUMBER (HU_EPI_EL_WLD5MA),
                    A8_表面等级,
                    A9_表面备注,
                    HE_REMARK,
                    BR_SMP_LOP1_AVG,
                    BJ_SMP_WLD1_AVG,
                    BJ_SMP_WLD1_AVG - AM_WLD_AVG,
                    BK_SMP_WLD1_STD,
                    BX_SMP_VF1_AVG,
                    GB_N_N,
                    C0_SMP_VF3_AVG,
                    C1_SMP_VF4_AVG,
                    TO_NUMBER (EN_SMP_VFD_AVG01) AS EN_SMP_VFD_AVG01,
                    BT_SMP_IR_AVG,
                    BV_SMP_VZ1_AVG,
                    C6_HBM2000,
                    C7_HBM4000,
                    C8_HBM6000,
                    C9_HBM8000,
                    CA_MMF300,
                    CB_MMZ300,
                    TO_NUMBER (FJ_MMF350) AS FJ_MMF350,
                    TO_NUMBER (FK_MMF400) AS FK_MMF400,
                    C4_BS,
                    C2_SMP_HW1_AVG,
                    C5_D减P,
                    TO_NUMBER (FE_SMP_YIELD) AS FE_SMP_YIELD,
                    TO_NUMBER (FB_EPIIRYIELD),
                    FD_SMP_VF1_VF3,
                    CG_SMP_LOP1_YIELD,
                    CC_SMP_VF1_YIELD,
                    CD_SMP_VF3_YIELD,
                    FI_SMP_VZ1_YIELD,
                    CF_SMP_WLD1_YIELD,
                    TO_NUMBER (EP_SMP_VFD_YIELD) AS EP_SMP_VFD_YIELD,
                    TO_NUMBER (EO_SMP_PURITY1_AVG) AS EO_SMP_PURITY1_AVG,
                    CH_SMP_BS_YIELD,
                    CJ_SMP_HW1_YIELD,
                    CI_SMP_WLD1_WLP1_YIELD,
                    TO_NUMBER (BR_SMP_LOP3_AVG) / BR_SMP_LOP1_AVG,
                    TO_NUMBER (BR_SMP_LOP3_AVG),
                    TO_NUMBER (EA_SMP_VF5_AVG),
                    TO_NUMBER (EE_SMP_WLD5_AVG),
                    TO_NUMBER (EG_SMP_WLP5_AVG),
                    TO_NUMBER (EI_SMP_WLC5_AVG),
                    TO_NUMBER (EK_SMP_HW5_AVG),
                    EM_SE蚀刻宽度,
                    EL_RIE判级,
                    E2_全测时间,
                    DA_FT_LOP1_AVG,
                    DC_FT_WLD1_AVG,
                    DD_FT_WLD1_STD,
                    DE_FT_WLP1_AVG,
                    DF_FT_WLP1_STD,
                    DG_FT_VF1_AVG,
                    DH_FT_VF1_STD,
                    DI_FT_VF3_AVG,
                    DK_FT_VF4_AVG,
                    DM_FT_IR_AVG,
                    DO_FT_HW1_AVG,
                    E0_RESORTYIELD,
                    DZ_FT_YIELD,
                    DV_FT_LOP1_YIELD,
                    DQ_FT_VF1_YIELD,
                    DR_FT_VF3_YIELD,
                    DX_FT_VF4_YIELD,
                    DT_FT_IR_YIELD,
                    DW_FT_WLD1_YIELD,
                    DY_FT_HW1_YIELD,
                    FS_出老化时间,
                    FH_老化等级,
                    E4_LIFE_VF_AVG,
                    E5_LIFE_IR_AVG,
                    E6_LIFE_IV_AVG,
                    E7_LIFE_WLD_AVG,
                    GC_反射率,
                    HW_工艺名称,
                    SUBSTR (CK_快测时间, 1, 10) AS 快测日期,
                    BY_SMP_VF1_STD,
                    A2_快测片,
                    E1_全测机台,
                    GW_下线品名,
                    GA_投片规格,
                    A5_包灯,
                    A6_非常规老化,
                    A7_常规老化,
                    AB_外延等级,
                    CASE WHEN IR_MMF600 = 0 THEN NULL ELSE TO_NUMBER (IR_MMF600) END
                        AS IR_MMF600,
                    CASE WHEN IS_MMF800 = 0 THEN NULL ELSE TO_NUMBER (IS_MMF800) END
                        AS IS_MMF800,
                    E1_RESORTYIELD,
                    TO_NUMBER (JC_MMZ500) AS JC_MMZ500,
                    TO_NUMBER (JD_MMZ600) AS JD_MMZ600FROM
                FROM EPIDM.EPI_ALLDATA_NEW3
                WHERE A2_快测片 = 'Y' and A0_建档时间 >'" + transactiontimeS + @"' and A0_建档时间 <'" + transactiontimeE + @"'"; 
            if (!string.IsNullOrEmpty(componentid))
            {
                sql += @" and A1_外延片号 like '%" + componentid + @"%'";
            }
            if (!string.IsNullOrEmpty(structure))
            {
                sql += @" and FA_结构码 like '%" + structure + @"%'";
            }
            if (!string.IsNullOrEmpty(verifysize))
            {
                sql += @" and A3_快测片尺寸 like '%" + verifysize + @"%'";
            }
            if (!string.IsNullOrEmpty(lotsequence))
            {
                sql += @" and CL_芯片片号 like '%" + verifysize + @"%'";
            }

            sql += @" order by A0_建档时间,A1_外延片号";
            return sql;
        }
    }
}
