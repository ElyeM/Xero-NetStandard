/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// Balance supplied for each account that has a value as at the conversion date.
    /// </summary>
    [DataContract]
    public partial class ConversionBalances :  IEquatable<ConversionBalances>, IValidatableObject
    {
        
        /// <summary>
        /// The account code for a account
        /// </summary>
        /// <value>The account code for a account</value>
        [DataMember(Name="AccountCode", EmitDefaultValue=false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// The opening balances of the account. Debits are positive, credits are negative values
        /// </summary>
        /// <value>The opening balances of the account. Debits are positive, credits are negative values</value>
        [DataMember(Name="Balance", EmitDefaultValue=false)]
        public double? Balance { get; set; }

        /// <summary>
        /// Gets or Sets BalanceDetails
        /// </summary>
        [DataMember(Name="BalanceDetails", EmitDefaultValue=false)]
        public List<BalanceDetails> BalanceDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversionBalances {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  BalanceDetails: ").Append(BalanceDetails).Append("\n");
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
            return this.Equals(input as ConversionBalances);
        }

        /// <summary>
        /// Returns true if ConversionBalances instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversionBalances to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversionBalances input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    this.Balance == input.Balance ||
                    this.Balance.Equals(input.Balance)
                ) && 
                (
                    this.BalanceDetails == input.BalanceDetails ||
                    this.BalanceDetails != null &&
                    input.BalanceDetails != null &&
                    this.BalanceDetails.SequenceEqual(input.BalanceDetails)
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
                if (this.AccountCode != null)
                    hashCode = hashCode * 59 + this.AccountCode.GetHashCode();
                hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.BalanceDetails != null)
                    hashCode = hashCode * 59 + this.BalanceDetails.GetHashCode();
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
