/* 
 * Xero Payroll UK
 *
 * This is the Xero Payroll API for orgs in the UK region.
 *
 * The version of the OpenAPI document: 2.7.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.PayrollUk
{
    /// <summary>
    /// SalaryAndWage
    /// </summary>
    [DataContract]
    public partial class SalaryAndWage :  IEquatable<SalaryAndWage>, IValidatableObject
    {
        /// <summary>
        /// The current status of the corresponding salary and wages
        /// </summary>
        /// <value>The current status of the corresponding salary and wages</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 1,

            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 2,

            /// <summary>
            /// Enum History for value: History
            /// </summary>
            [EnumMember(Value = "History")]
            History = 3

        }

        /// <summary>
        /// The current status of the corresponding salary and wages
        /// </summary>
        /// <value>The current status of the corresponding salary and wages</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// The type of the payment of the corresponding salary and wages
        /// </summary>
        /// <value>The type of the payment of the corresponding salary and wages</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentTypeEnum
        {
            /// <summary>
            /// Enum Salary for value: Salary
            /// </summary>
            [EnumMember(Value = "Salary")]
            Salary = 1

        }

        /// <summary>
        /// The type of the payment of the corresponding salary and wages
        /// </summary>
        /// <value>The type of the payment of the corresponding salary and wages</value>
        [DataMember(Name="paymentType", EmitDefaultValue=false)]
        public PaymentTypeEnum PaymentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SalaryAndWage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SalaryAndWage() 
        { 
        }
        
        /// <summary>
        /// Xero unique identifier for a salary and wages record
        /// </summary>
        /// <value>Xero unique identifier for a salary and wages record</value>
        [DataMember(Name="salaryAndWagesID", EmitDefaultValue=false)]
        public Guid? SalaryAndWagesID { get; set; }

        /// <summary>
        /// Xero unique identifier for an earnings rate
        /// </summary>
        /// <value>Xero unique identifier for an earnings rate</value>
        [DataMember(Name="earningsRateID", EmitDefaultValue=false)]
        public Guid? EarningsRateID { get; set; }

        /// <summary>
        /// The Number of Units per week for the corresponding salary and wages
        /// </summary>
        /// <value>The Number of Units per week for the corresponding salary and wages</value>
        [DataMember(Name="numberOfUnitsPerWeek", EmitDefaultValue=false)]
        public double? NumberOfUnitsPerWeek { get; set; }

        /// <summary>
        /// The rate of each unit for the corresponding salary and wages
        /// </summary>
        /// <value>The rate of each unit for the corresponding salary and wages</value>
        [DataMember(Name="ratePerUnit", EmitDefaultValue=false)]
        public double? RatePerUnit { get; set; }

        /// <summary>
        /// The Number of Units per day for the corresponding salary and wages
        /// </summary>
        /// <value>The Number of Units per day for the corresponding salary and wages</value>
        [DataMember(Name="numberOfUnitsPerDay", EmitDefaultValue=false)]
        public double? NumberOfUnitsPerDay { get; set; }

        /// <summary>
        /// The effective date of the corresponding salary and wages
        /// </summary>
        /// <value>The effective date of the corresponding salary and wages</value>
        [DataMember(Name="effectiveFrom", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EffectiveFrom { get; set; }

        /// <summary>
        /// The annual salary
        /// </summary>
        /// <value>The annual salary</value>
        [DataMember(Name="annualSalary", EmitDefaultValue=false)]
        public double? AnnualSalary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalaryAndWage {\n");
            sb.Append("  SalaryAndWagesID: ").Append(SalaryAndWagesID).Append("\n");
            sb.Append("  EarningsRateID: ").Append(EarningsRateID).Append("\n");
            sb.Append("  NumberOfUnitsPerWeek: ").Append(NumberOfUnitsPerWeek).Append("\n");
            sb.Append("  RatePerUnit: ").Append(RatePerUnit).Append("\n");
            sb.Append("  NumberOfUnitsPerDay: ").Append(NumberOfUnitsPerDay).Append("\n");
            sb.Append("  EffectiveFrom: ").Append(EffectiveFrom).Append("\n");
            sb.Append("  AnnualSalary: ").Append(AnnualSalary).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SalaryAndWage);
        }

        /// <summary>
        /// Returns true if SalaryAndWage instances are equal
        /// </summary>
        /// <param name="input">Instance of SalaryAndWage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalaryAndWage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SalaryAndWagesID == input.SalaryAndWagesID ||
                    (this.SalaryAndWagesID != null &&
                    this.SalaryAndWagesID.Equals(input.SalaryAndWagesID))
                ) && 
                (
                    this.EarningsRateID == input.EarningsRateID ||
                    (this.EarningsRateID != null &&
                    this.EarningsRateID.Equals(input.EarningsRateID))
                ) && 
                (
                    this.NumberOfUnitsPerWeek == input.NumberOfUnitsPerWeek ||
                    this.NumberOfUnitsPerWeek.Equals(input.NumberOfUnitsPerWeek)
                ) && 
                (
                    this.RatePerUnit == input.RatePerUnit ||
                    this.RatePerUnit.Equals(input.RatePerUnit)
                ) && 
                (
                    this.NumberOfUnitsPerDay == input.NumberOfUnitsPerDay ||
                    this.NumberOfUnitsPerDay.Equals(input.NumberOfUnitsPerDay)
                ) && 
                (
                    this.EffectiveFrom == input.EffectiveFrom ||
                    (this.EffectiveFrom != null &&
                    this.EffectiveFrom.Equals(input.EffectiveFrom))
                ) && 
                (
                    this.AnnualSalary == input.AnnualSalary ||
                    this.AnnualSalary.Equals(input.AnnualSalary)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.PaymentType == input.PaymentType ||
                    this.PaymentType.Equals(input.PaymentType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SalaryAndWagesID != null)
                    hashCode = hashCode * 59 + this.SalaryAndWagesID.GetHashCode();
                if (this.EarningsRateID != null)
                    hashCode = hashCode * 59 + this.EarningsRateID.GetHashCode();
                hashCode = hashCode * 59 + this.NumberOfUnitsPerWeek.GetHashCode();
                hashCode = hashCode * 59 + this.RatePerUnit.GetHashCode();
                hashCode = hashCode * 59 + this.NumberOfUnitsPerDay.GetHashCode();
                if (this.EffectiveFrom != null)
                    hashCode = hashCode * 59 + this.EffectiveFrom.GetHashCode();
                hashCode = hashCode * 59 + this.AnnualSalary.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.PaymentType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
