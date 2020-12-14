/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// SuperannuationLine
    /// </summary>
    [DataContract]
    public partial class SuperannuationLine :  IEquatable<SuperannuationLine>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ContributionType
        /// </summary>
        [DataMember(Name="ContributionType", EmitDefaultValue=false)]
        public SuperannuationContributionType ContributionType { get; set; }
        /// <summary>
        /// Gets or Sets CalculationType
        /// </summary>
        [DataMember(Name="CalculationType", EmitDefaultValue=false)]
        public SuperannuationCalculationType CalculationType { get; set; }
        
        /// <summary>
        /// Xero identifier for payroll super fund membership ID.
        /// </summary>
        /// <value>Xero identifier for payroll super fund membership ID.</value>
        [DataMember(Name="SuperMembershipID", EmitDefaultValue=false)]
        public Guid? SuperMembershipID { get; set; }

        /// <summary>
        /// Superannuation minimum monthly earnings.
        /// </summary>
        /// <value>Superannuation minimum monthly earnings.</value>
        [DataMember(Name="MinimumMonthlyEarnings", EmitDefaultValue=false)]
        public decimal? MinimumMonthlyEarnings { get; set; }

        /// <summary>
        /// Superannuation expense account code.
        /// </summary>
        /// <value>Superannuation expense account code.</value>
        [DataMember(Name="ExpenseAccountCode", EmitDefaultValue=false)]
        public string ExpenseAccountCode { get; set; }

        /// <summary>
        /// Superannuation liability account code
        /// </summary>
        /// <value>Superannuation liability account code</value>
        [DataMember(Name="LiabilityAccountCode", EmitDefaultValue=false)]
        public string LiabilityAccountCode { get; set; }

        /// <summary>
        /// Superannuation payment date for the current period (YYYY-MM-DD)
        /// </summary>
        /// <value>Superannuation payment date for the current period (YYYY-MM-DD)</value>
        [DataMember(Name="PaymentDateForThisPeriod", EmitDefaultValue=false)]
        public DateTime? PaymentDateForThisPeriod { get; set; }

        /// <summary>
        /// Superannuation percentage
        /// </summary>
        /// <value>Superannuation percentage</value>
        [DataMember(Name="Percentage", EmitDefaultValue=false)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Superannuation amount
        /// </summary>
        /// <value>Superannuation amount</value>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuperannuationLine {\n");
            sb.Append("  SuperMembershipID: ").Append(SuperMembershipID).Append("\n");
            sb.Append("  ContributionType: ").Append(ContributionType).Append("\n");
            sb.Append("  CalculationType: ").Append(CalculationType).Append("\n");
            sb.Append("  MinimumMonthlyEarnings: ").Append(MinimumMonthlyEarnings).Append("\n");
            sb.Append("  ExpenseAccountCode: ").Append(ExpenseAccountCode).Append("\n");
            sb.Append("  LiabilityAccountCode: ").Append(LiabilityAccountCode).Append("\n");
            sb.Append("  PaymentDateForThisPeriod: ").Append(PaymentDateForThisPeriod).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as SuperannuationLine);
        }

        /// <summary>
        /// Returns true if SuperannuationLine instances are equal
        /// </summary>
        /// <param name="input">Instance of SuperannuationLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuperannuationLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SuperMembershipID == input.SuperMembershipID ||
                    (this.SuperMembershipID != null &&
                    this.SuperMembershipID.Equals(input.SuperMembershipID))
                ) && 
                (
                    this.ContributionType == input.ContributionType ||
                    this.ContributionType.Equals(input.ContributionType)
                ) && 
                (
                    this.CalculationType == input.CalculationType ||
                    this.CalculationType.Equals(input.CalculationType)
                ) && 
                (
                    this.MinimumMonthlyEarnings == input.MinimumMonthlyEarnings ||
                    this.MinimumMonthlyEarnings.Equals(input.MinimumMonthlyEarnings)
                ) && 
                (
                    this.ExpenseAccountCode == input.ExpenseAccountCode ||
                    (this.ExpenseAccountCode != null &&
                    this.ExpenseAccountCode.Equals(input.ExpenseAccountCode))
                ) && 
                (
                    this.LiabilityAccountCode == input.LiabilityAccountCode ||
                    (this.LiabilityAccountCode != null &&
                    this.LiabilityAccountCode.Equals(input.LiabilityAccountCode))
                ) && 
                (
                    this.PaymentDateForThisPeriod == input.PaymentDateForThisPeriod ||
                    (this.PaymentDateForThisPeriod != null &&
                    this.PaymentDateForThisPeriod.Equals(input.PaymentDateForThisPeriod))
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    this.Percentage.Equals(input.Percentage)
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
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
                if (this.SuperMembershipID != null)
                    hashCode = hashCode * 59 + this.SuperMembershipID.GetHashCode();
                hashCode = hashCode * 59 + this.ContributionType.GetHashCode();
                hashCode = hashCode * 59 + this.CalculationType.GetHashCode();
                hashCode = hashCode * 59 + this.MinimumMonthlyEarnings.GetHashCode();
                if (this.ExpenseAccountCode != null)
                    hashCode = hashCode * 59 + this.ExpenseAccountCode.GetHashCode();
                if (this.LiabilityAccountCode != null)
                    hashCode = hashCode * 59 + this.LiabilityAccountCode.GetHashCode();
                if (this.PaymentDateForThisPeriod != null)
                    hashCode = hashCode * 59 + this.PaymentDateForThisPeriod.GetHashCode();
                hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
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
