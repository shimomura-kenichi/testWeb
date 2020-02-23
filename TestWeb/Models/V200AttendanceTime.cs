//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    
    public partial class V200AttendanceTime
    {
        ///<summary>ユーザーID</summary>
        [DisplayName("ユーザーID")]
        public string UserId { get; set; }
        ///<summary>年</summary>
        [DisplayName("年")]
        public int WorkYear { get; set; }
        ///<summary>月</summary>
        [DisplayName("月")]
        public int WorkMonth { get; set; }
        ///<summary>日</summary>
        [DisplayName("日")]
        public int WorkDay { get; set; }
        ///<summary>行</summary>
        [DisplayName("行")]
        public int WorkNo { get; set; }
        ///<summary>勤務区分</summary>
        [DisplayName("勤務区分")]
        public string WorkKind { get; set; }
        ///<summary>部署コード</summary>
        [DisplayName("部署コード")]
        public string DepartmentCd { get; set; }
        ///<summary>週開始日</summary>
        [DisplayName("週開始日")]
        public System.DateTime WeekStartDate { get; set; }
        ///<summary>休日区分</summary>
        [DisplayName("休日区分")]
        public string HolidayKind { get; set; }
        ///<summary>開始</summary>
        [DisplayName("開始")]
        public Nullable<System.TimeSpan> StartTime { get; set; }
        ///<summary>終了</summary>
        [DisplayName("終了")]
        public Nullable<System.TimeSpan> EndTime { get; set; }
        ///<summary>休憩</summary>
        [DisplayName("休憩")]
        public Nullable<System.TimeSpan> RestTime { get; set; }
        ///<summary>備考</summary>
        [DisplayName("備考")]
        public string Remarks { get; set; }
        ///<summary>削除フラグ</summary>
        [DisplayName("削除フラグ")]
        public string DeleteFlg { get; set; }
        ///<summary>作成日時</summary>
        [DisplayName("作成日時")]
        public System.DateTime CreateDttm { get; set; }
        ///<summary>更新日時</summary>
        [DisplayName("更新日時")]
        public System.DateTime UpdateDttm { get; set; }
        ///<summary>更新ユーザーID</summary>
        [DisplayName("更新ユーザーID")]
        public string UpdateUserId { get; set; }
        ///<summary>勤務区分</summary>
        [DisplayName("勤務区分")]
        public string WorkKindName { get; set; }
        ///<summary>休日区分</summary>
        [DisplayName("休日区分")]
        public string HolidayKindName { get; set; }
    }
}
