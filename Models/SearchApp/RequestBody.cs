using System.Runtime.Serialization;
using System.Text;

namespace FaceProductAPI.Models.SearchApp
{
    [DataContract]
    public partial class RequestBody : IEquatable<RequestBody>
    {
        /// <summary>
        /// Gets or Sets FilterName
        /// </summary>

        [DataMember(Name = "filterName")]
        public string FilterName { get; set; }

        /// <summary>
        /// Gets or Sets LastXDays
        /// </summary>

        [DataMember(Name = "lastXDays")]
        public int? LastXDays { get; set; }

        /// <summary>
        /// Gets or Sets Field0
        /// </summary>

        [DataMember(Name = "field[0]")]
        public string Field0 { get; set; }

        /// <summary>
        /// Gets or Sets Field1
        /// </summary>

        [DataMember(Name = "field[1]")]
        public string Field1 { get; set; }

        /// <summary>
        /// Gets or Sets FacilityCategoryCode
        /// </summary>

        [DataMember(Name = "facilityCategoryCode")]
        public string FacilityCategoryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestBody {\n");
            sb.Append("  FilterName: ").Append(FilterName).Append("\n");
            sb.Append("  LastXDays: ").Append(LastXDays).Append("\n");
            sb.Append("  Field0: ").Append(Field0).Append("\n");
            sb.Append("  Field1: ").Append(Field1).Append("\n");
            sb.Append("  FacilityCategoryCode: ").Append(FacilityCategoryCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        //public string ToJson()
        //{
        //    return JsonConvert.SerializeObject(this, Formatting.Indented);
        //}

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((RequestBody)obj);
        }

        /// <summary>
        /// Returns true if RequestBody instances are equal
        /// </summary>
        /// <param name="other">Instance of RequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestBody other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    FilterName == other.FilterName ||
                    FilterName != null &&
                    FilterName.Equals(other.FilterName)
                ) &&
                (
                    LastXDays == other.LastXDays ||
                    LastXDays != null &&
                    LastXDays.Equals(other.LastXDays)
                ) &&
                (
                    Field0 == other.Field0 ||
                    Field0 != null &&
                    Field0.Equals(other.Field0)
                ) &&
                (
                    Field1 == other.Field1 ||
                    Field1 != null &&
                    Field1.Equals(other.Field1)
                ) &&
                (
                    FacilityCategoryCode == other.FacilityCategoryCode ||
                    FacilityCategoryCode != null &&
                    FacilityCategoryCode.Equals(other.FacilityCategoryCode)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (FilterName != null)
                    hashCode = hashCode * 59 + FilterName.GetHashCode();
                if (LastXDays != null)
                    hashCode = hashCode * 59 + LastXDays.GetHashCode();
                if (Field0 != null)
                    hashCode = hashCode * 59 + Field0.GetHashCode();
                if (Field1 != null)
                    hashCode = hashCode * 59 + Field1.GetHashCode();
                if (FacilityCategoryCode != null)
                    hashCode = hashCode * 59 + FacilityCategoryCode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(RequestBody left, RequestBody right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RequestBody left, RequestBody right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}