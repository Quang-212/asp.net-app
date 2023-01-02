using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace asp.net_app.Entities
{
    /// <summary>
    /// Nhân viên
    /// </summary>
    public class Employee : BaseEntity
    {
        #region Property
        /// <summary>
        /// ID nhân viên
        /// </summary>
        [Key]
        public Guid EmployeeId { get; set; }
        /// <summary>
        /// Mã nhân viên
        /// </summary>
        [Required(ErrorMessage = "Mã nhân viên không được để trống.")]
        public string EmployeeCode { get; set; }
        /// <summary>
        /// Tên nhân viên
        /// </summary>
        [Required(ErrorMessage = "Tên nhân viên không được để trống.")]
        public string EmployeeName { get; set; }
        /// <summary>
        /// ID đơn vị
        /// </summary>
        [Required(ErrorMessage = "Đơn vị không được để trống.")]
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// Mã đơn vị
        /// </summary>
        public string? DepartmentCode { get; set; }
        /// <summary>
        /// Tên đơn vị
        /// </summary>?
        public string? DepartmentName { get; set; }
        /// <summary>
        /// Vị trí công việc 
        /// </summary>
        public string? EmployeePosition { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// Số chứng minh nhân dân
        /// </summary>
        public string? IdentityNumber { get; set; }
        /// <summary>
        /// Ngày cấp chứng minh nhân dân
        /// </summary>
        public DateTime? IdentityIssuedDate { get; set; }
        /// <summary>
        /// Nơi cấp chứng minh nhân dân
        /// </summary>
        public string? IdentityIssuedPlace { get; set; }
        /// <summary>
        /// Địa chỉ nhân viên
        /// </summary>
        public string? Address { get; set; }
        /// <summary>
        /// Số điện thoại di động
        /// </summary>
        public string? PhoneNumber { get; set; }
        /// <summary>
        /// Số điện thoại cố định
        /// </summary>
        public string? TelePhoneNumber { get; set; }
        /// <summary>
        /// Email nhân viên
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Số tài khoản ngân hàng
        /// </summary>
        public string? BankAccountNumber { get; set; }
        /// <summary>
        /// Tên ngân hàng
        /// </summary>
        public string? BankName { get; set; }
        /// <summary>
        /// Tên chi nhánh ngân hàng
        /// </summary>
        public string? BankBranchName { get; set; }
        /// <summary>
        /// True: Là nhà cung cấp
        /// </summary>
        public bool IsVendor { get; set; }
        /// <summary>
        /// True: Là khách hàng
        /// </summary>
        public bool IsCustomer { get; set; }
        #endregion
    }
}
