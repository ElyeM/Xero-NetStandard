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
    /// TaxLine
    /// </summary>
    [DataContract]
    public partial class TaxLine :  IEquatable<TaxLine>, IValidatableObject
    {
        
        /// <summary>
        /// Xero identifier for payroll tax line
        /// </summary>
        /// <value>Xero identifier for payroll tax line</value>
        [DataMember(Name="taxLineID", EmitDefaultValue=false)]
        public Guid? TaxLineID { get; set; }

        /// <summary>
        /// Tax line description
        /// </summary>
        /// <value>Tax line description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Identifies if the amount is paid for by the employee or employer. True if employer pays the tax
        /// </summary>
        /// <value>Identifies if the amount is paid for by the employee or employer. True if employer pays the tax</value>
        [DataMember(Name="isEmployerTax", EmitDefaultValue=false)]
        public bool? IsEmployerTax { get; set; }

        /// <summary>
        /// The amount of the tax line
        /// </summary>
        /// <value>The amount of the tax line</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// Tax type ID
        /// </summary>
        /// <value>Tax type ID</value>
        [DataMember(Name="globalTaxTypeID", EmitDefaultValue=false)]
        public string GlobalTaxTypeID { get; set; }

        /// <summary>
        /// Identifies if the tax line is a manual adjustment
        /// </summary>
        /// <value>Identifies if the tax line is a manual adjustment</value>
        [DataMember(Name="manualAdjustment", EmitDefaultValue=false)]
        public bool? ManualAdjustment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxLine {\n");
            sb.Append("  TaxLineID: ").Append(TaxLineID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsEmployerTax: ").Append(IsEmployerTax).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  GlobalTaxTypeID: ").Append(GlobalTaxTypeID).Append("\n");
            sb.Append("  ManualAdjustment: ").Append(ManualAdjustment).Append("\n");
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
            return this.Equals(input as TaxLine);
        }

        /// <summary>
        /// Returns true if TaxLine instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaxLineID == input.TaxLineID ||
                    (this.TaxLineID != null &&
                    this.TaxLineID.Equals(input.TaxLineID))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsEmployerTax == input.IsEmployerTax ||
                    this.IsEmployerTax.Equals(input.IsEmployerTax)
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.GlobalTaxTypeID == input.GlobalTaxTypeID ||
                    (this.GlobalTaxTypeID != null &&
                    this.GlobalTaxTypeID.Equals(input.GlobalTaxTypeID))
                ) && 
                (
                    this.ManualAdjustment == input.ManualAdjustment ||
                    this.ManualAdjustment.Equals(input.ManualAdjustment)
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
                if (this.TaxLineID != null)
                    hashCode = hashCode * 59 + this.TaxLineID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.IsEmployerTax.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.GlobalTaxTypeID != null)
                    hashCode = hashCode * 59 + this.GlobalTaxTypeID.GetHashCode();
                hashCode = hashCode * 59 + this.ManualAdjustment.GetHashCode();
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
