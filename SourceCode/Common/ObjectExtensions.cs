using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Returns an empty string if the object is null otherwise the object ToString
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static string ToEmptyStringIfNull(this object o)
        {
            if (o == null)
            {
                return string.Empty;
            }

            return o.ToString();
        }

        public static string ToEmptyStringIfNull(this object o, string format)
        {
            if (o == null)
            {
                return string.Empty;
            }

            try
            {
                format = string.Concat("{0:", format, "}");
                return string.Format(format, o);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Returns the DateTime.MinValue if null or if the object cannot be parsed as a DateTime
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this object o)
        {
            if (o == null)
            {
                return DateTime.MinValue;
            }

            try
            {
                return DateTime.ParseExact(o.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                //;
            }
            catch
            {
                try
                {
                    return DateTime.Parse(o.ToString());
                }
                catch (Exception)
                {

                    return DateTime.MinValue;
                }
                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// Returns true if the object value is 1, true, yes, or y otherwise returns false
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static Boolean ToBool(this object o)
        {
            if (o == null)
            {
                return false;
            }
            try
            {
                string s = o.ToString().ToLower();
                switch (s)
                {
                    case "":
                        return false;
                    case "1":
                        return true;
                    case "true":
                        return true;
                    case "yes":
                        return true;
                    case "y":
                        return true;
                    default:
                        return bool.Parse(o.ToString());
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Returns a new Guid if the object is null, otherwise returns the Guid
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static Guid ToGuid(this object o)
        {
            if (o == null)
            {
                return new Guid();
            }
            try
            {
                return new Guid(o.ToString());
            }
            catch
            {
                return new Guid();
            }
        }

        public static decimal ToDecimal(this object o)
        {
            if (o == null)
            {
                return 0;
            }
            try
            {
                return decimal.Parse(o.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public static int ToInt(this object o)
        {
            if (o == null)
            {
                return 0;
            }
            try
            {
                return Convert.ToInt32(o);
                //return int.Parse(o.ToString());
            }
            catch
            {

                return 0;
            }
        }

        public static int ToSortedInt(this object o)
        {
            if (o == null)
            {
                return -1; //return int.MaxValue;
            }
            try
            {
                return int.Parse(o.ToString());
            }
            catch
            {

                return -1; //return int.MaxValue;
            }
        }

        public static float ToFloat(this object o)
        {
            if (o == null)
            {
                return 0;
            }
            try
            {
                if (o.ToString().Contains("("))
                {
                    return float.Parse(o.ToString().Replace("(", "").Replace(")", "")); 
                }
                else
                {
                    return float.Parse(o.ToString());
                }
            }
            catch
            {

                return 0;
            }
        }

        public static string ToDecimal3(this object o)
        {
            if (o == null)
            {
                return "0";
            }
            try
            {
                return float.Parse(o.ToString()).ToString("#,#00.000");
            }
            catch
            {

                return "0";
            }
        }

        public static string ToDecimal2(this object o)
        {
            if (o == null)
            {
                return "0";
            }
            try
            {
                return float.Parse(o.ToString()).ToString("#,#00.00");
            }
            catch
            {

                return "0";
            }
        }
    }
}
