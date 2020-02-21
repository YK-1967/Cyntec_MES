Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports CyntecMESEquipment
Imports System.IO
Imports System.Data.SQLite

Public Class frm_Main
    '    /* Set Value */
    Dim strMESServerURL As String = ""
    Dim strMachineID As String = ""
    Dim strRecipeIDCodeName As String = ""
    Dim strLogPath As String = "D:/cyntec"
    Dim intDefaultTimeout As Integer = 30000
    Dim intRefreshInterval As Integer = 60000
    Dim IsOnlineMode As Boolean = True
    'SqliteClass _sqliteClass = New SqliteClass();

    '/* Eqp Transaction Object */
    'CyntecMESEquipment.cls_Eqp serviceEqp = null;
    Dim serviceEqp As CyntecMESEquipment.cls_Eqp ' = Null

    Private Sub GetSetValue()
        '        /* Get Setting Value */
        Dim tmpDt As DataTable = New DataTable
        'tmpDt = _sqliteClass.GetDataTable("SELECT * FROM " + clsEqp.EqpMasterTableName)
        '        If (_sqliteClass.SqlCode)
        '        {
        If (tmpDt.Rows.Count > 0) Then
            strMESServerURL = tmpDt.Rows(0)("MES_ServerURL").ToString().Trim()
            strMachineID = tmpDt.Rows(0)("MachineID").ToString().Trim()
            strRecipeIDCodeName = tmpDt.Rows(0)("RecipeIDCodeName").ToString().Trim()
            strLogPath = tmpDt.Rows(0)("Log_Path").ToString().Trim()
            intRefreshInterval = Convert.ToInt32(tmpDt.Rows(0)("EqpStatus_refresh_interval"))

            If tmpDt.Rows(0)("MESMode").ToString().Trim() == "ONLINE" Then
                IsOnlineMode = True
            Else
                IsOnlineMode = False
            End If



            '                gvMould.Rows.Clear();
            '                DataTable dtEqpMould = _sqliteClass.GetDataTable("SELECT * FROM " + clsEqp.EqpMouldTableName);
            '                If (_sqliteClass.SqlCode)
            '                {
            '                    If (dtEqpMould.Rows.Count > 0)
            '                    {
            '                        foreach(DataRow Dr in dtEqpMould.Rows)
            '                        {
            '                            gvMould.Rows.Add("●",
            '                                             Dr["MouldType"].ToString().Trim(),
            '                                             Dr["UsageQty"].ToString().Trim(),
            '                                             Dr["TotalUsageQty"].ToString().Trim(),
            '                                             Dr["OnlineDate"].ToString().Trim(),
            '                                             Dr["MouldNo"].ToString().Trim());
            '                        }

            '                        foreach(DataGridViewRow DGVR in gvMould.Rows)
            '                        {
            '                            If (DGVR.Cells["colMouldNo"].Value.ToString().Trim() != string.Empty)
            '                            {
            '                                DGVR.Cells["colMouldStatus"].Style.ForeColor = Color.LightGreen;
            '                            }
            '                            Else
            '                            {
            '                                DGVR.Cells["colMouldStatus"].Style.ForeColor = Color.Gray;
            '                            }
            '                        }
            '                    }
            '                }
            '                Else
            '                {
            '                    ScreenControl(false);
            '                    MessageBox.Show(_sqliteClass.SqlErrMsg, "異常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            '                }
            '                gvMat.Rows.Clear();
            '                DataTable dtEqpMat = _sqliteClass.GetDataTable("SELECT * FROM " + clsEqp.EqpMatTableName);
            '                If (_sqliteClass.SqlCode)
            '                {
            '                    If (dtEqpMat.Rows.Count > 0)
            '                    {
            '                        foreach (DataRow Dr in dtEqpMat.Rows)
            '                        {
            '                            gvMat.Rows.Add(Dr["MatType"].ToString().Trim(),
            '                                             Dr["MatCode"].ToString().Trim(),
            '                                             Dr["MatValue"].ToString().Trim());
            '                        }
            '                    }
            '                }
            '                Else
            '                {
            '                    ScreenControl(false);
            '                    MessageBox.Show(_sqliteClass.SqlErrMsg, "異常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            '                }


            '                gvACWorkOrder.Rows.Clear();
            '                DataTable dtACWorkOrder = _sqliteClass.GetDataTable("SELECT * FROM " + clsEqp.EqpACWorkOrderTableName);
            '                If (_sqliteClass.SqlCode)
            '                {
            '                    If (dtACWorkOrder.Rows.Count > 0)
            '                    {
            '                        foreach (DataRow Dr in dtACWorkOrder.Rows)
            '                        {
            '                            gvACWorkOrder.Rows.Add(Dr["WorkOrder"].ToString().Trim());
            '                        }
            '                    }
            '                }
            '                Else
            '                {
            '                    ScreenControl(false);
            '                    MessageBox.Show(_sqliteClass.SqlErrMsg, "異常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            '                }

            '                txtUserID.Text = "";
            '                DataTable dtUserID = _sqliteClass.GetDataTable("SELECT * FROM " + clsEqp.EqpUserIDTableName);
            '                If (_sqliteClass.SqlCode)
            '                {
            '                    If (dtUserID.Rows.Count > 0)
            '                    {
            '                        txtUserID.Text = dtUserID.Rows[0]["UserID"].ToString().Trim();
            '                    }
            '                }
            '                Else
            '                {
            '                    ScreenControl(false);
            '                    MessageBox.Show(_sqliteClass.SqlErrMsg, "異常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            '                }
            '                ScreenControl(IsOnlineMode);
            '            }
            '            Else
            '            {
            '                ScreenControl(false);
            '                MessageBox.Show("找不到MES設定資料，請確認！", "異常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            '            }
        Else
                '            ScreenControl(false);
                ' MessageBox.Show(_sqliteClass.SqlErrMsg, "異常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            End If
        '    }
    End Sub
    Private Sub Init()
        '    {
        '        /* check http string foramt */
        '        Uri uriResult = null;
        '        If (Uri.TryCreate(strMESServerURL, UriKind.Absolute, out uriResult) == False || (uriResult.Scheme != "http" && uriResult.Scheme != "https"))
        '        {
        '            MessageBox.Show("MES Server URL validate fail");
        '            ScreenControl(false);
        '            Return;
        '        }


        '        /* New Eqp Transaction Object With MachineID */
        '        serviceEqp = New cls_Eqp(strMachineID);

        '        /* Set MES Server URL & timeout */
        '        serviceEqp.SetServiceUrl(strMESServerURL, intDefaultTimeout);

        '        /* Set log path */
        '        serviceEqp.SetLogDefaultPath(strLogPath);

        '        /* Set timer run in set interval */
        '        timer1.Interval = intRefreshInterval;
        '        timer1.Start();

        '    }
    End Sub
    '/* This object integrate Web Service transaction And Log event 
    ' * just pass json string to this object function 『 serviceEqp.EqpTransaction 』it will be done And return json string result
    ' *  */
    '#Region 設備狀態更新
    Private Sub Update_Info_to_MES()
        txtResult.Text = ""
        txtResultCode.Text = ""
        txtResultMessage.Text = ""
        '            /* 1. Update infotmation to MES */
        '            JObject JSONParameter = New JObject();
        '            JSONParameter.Add("TransactionName", "EQPSTATUS");
        '            JSONParameter.Add("EqpNo", strMachineID);
        '            JSONParameter.Add("UserID", txtUserID.Text);
        '            JSONParameter.Add("StatusCode", "1");                       //Dependenting on equipment status   1 = Run , 2 = fail , 3 = idel
        '            JSONParameter.Add("CycleTime", "");                         //Equipment CycleTime ,it's option
        '            JSONParameter.Add("OutPutQty", "1000");                     //Equipment Count Qty,Dependenting on equipment counter
        '            JSONParameter.Add("Target_OutPutQty", "");                  //Default Empty
        '            JSONParameter.Add("WONO", txtWONO.Text);
        '            JSONParameter.Add("ErrorCode", "");                         //if equipment status Is fail,this item need have Error Code
        '            JSONParameter.Add("Availability", "");                      //Equipment Availability, it's option

        '            //Parameter
        Dim dtParameterList As DataTable = New DataTable()
        dtParameterList.Columns.Add("P_Name")
        dtParameterList.Columns.Add("P_Value")
        dtParameterList.Columns.Add("P_LSL")
        dtParameterList.Columns.Add("P_USL")

        '            //真空值
        dtParameterList.Rows.Add("Vacuum",
                                 "actual value",
                                 "LSL value",
                                 "USL value")

        '            //主軸轉速
        dtParameterList.Rows.Add("Spindle_RPM_value",
                                             "actual value",
                                             "LSL value",
                                             "USL value")

        ' JSONParameter.Add("ParameterList", JsonConvert.SerializeObject(dtParameterList))

        '            //EqpPart
        '            DataTable dtEqpPartList = New DataTable();
        '            dtEqpPartList.Columns.Add("PartTypeCode", TypeOf(string));
        '            dtEqpPartList.Columns.Add("PartStartDate", TypeOf(string));
        '            dtEqpPartList.Columns.Add("StatusCode", TypeOf(string));
        '            dtEqpPartList.Columns.Add("UsageQty", TypeOf(string));
        '            dtEqpPartList.Columns.Add("LimitQty", TypeOf(string));

        '            dtEqpPartList.Rows.Add(strMachineID + "_Blade_exposure",
        '                                   "1911-01-01", 
        '                                   "0",
        '                                   "actual usage",
        '                                   "limit usage");
        '            JSONParameter.Add("EqpPartList", JsonConvert.SerializeObject(dtEqpPartList));


        '            String strJSONResult = jud_TransMode(JSONParameter);
        '            JObject JSONResult = JsonConvert.DeserializeObject < JObject > (strJSONResult);
        '            If (JSONResult["Result"].ToString().Trim() == "success")
        '            {
        '                //Update Info to MES  success
        '            }
        '            Else
        '            {
        '                //Update Info to MES  fail
        '            }
        '        }
        '        #endregion
    End Sub
    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick

    End Sub
End Class
