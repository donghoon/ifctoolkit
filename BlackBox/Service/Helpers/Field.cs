using System;
using System.Reflection;
using System.Collections.Generic;

namespace BlackBox.Service
{
    /// <summary>
    /// Generic reflected field.
    /// </summary>
    /// <typeparam name="T">Field type.</typeparam>
    public sealed class Field<T>
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        public Field(string fieldName)
        {
            if (fieldName == null)
            {
                throw new ArgumentNullException("fieldName");
            }

            this.fieldName = fieldName;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the field value of an object.
        /// </summary>
        /// <param name="obj">Object instance.</param>
        /// <returns>Field value.</returns>
        public T this[object obj]
        {
            get
            {
                return GetValue(obj);
            }
            set
            {
                SetValue(obj, value);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Determines whether the field exists in the specified object.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>A boolean value indicating whether the field exists in the
        /// specified object.</returns>
        public bool Exists(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }

            FieldInfo field = obj.GetType().GetField(fieldName);

            if (field != null)
            {
                return (field.FieldType == typeof(T));
            }
            else
            {
                PropertyInfo property = obj.GetType().GetProperty(fieldName);

                return (property != null && property.PropertyType == typeof(T));
            }
        }

        /// <summary>
        /// Gets the field value in the specified object.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>Field value.</returns>
        private T GetValue(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }

            try
            {
                FieldInfo field = obj.GetType().GetField(fieldName);

                if (field != null)
                {
                    if (field.FieldType == typeof(T))
                    {
                        return (T)field.GetValue(obj);
                    }
                }
                else
                {
                    PropertyInfo property = obj.GetType().GetProperty(fieldName);

                    if (property != null &&
                        property.CanRead &&
                        property.PropertyType == typeof(T))
                    {
                        return (T)property.GetValue(obj, null);
                    }
                }
            }
            catch (AmbiguousMatchException)
            {
                // No action.
            }

            return default(T);
        }

        /// <summary>
        /// Sets the field value in the specified object.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <param name="value">Field value.</param>
        private void SetValue(object obj, T value)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }

            try
            {
                FieldInfo field = obj.GetType().GetField(fieldName);

                if (field != null)
                {
                    if (field.FieldType == typeof(T))
                    {
                        field.SetValue(obj, value);
                    }
                }
                else
                {
                    PropertyInfo property = obj.GetType().GetProperty(fieldName);

                    if (property != null &&
                        property.CanWrite &&
                        property.PropertyType == typeof(T))
                    {
                        property.SetValue(obj, value, null);
                    }
                }
            }
            catch (AmbiguousMatchException)
            {
                // No action.
            }
        }
        #endregion

        #region Fields
        /// <summary>
        /// Field name.
        /// </summary>
        private readonly string fieldName;
        #endregion
    }
}
