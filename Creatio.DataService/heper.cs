﻿using Creatio.DataService.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Creatio.DataService
{
    public static class Helper
    {
        public static async Task ExpandValuesAsync<Entity>(this Entity entity) where Entity : BaseEntity, new()
        {
            var r = await Utils.Instance.Select<Entity>(entity.Id.ToString());
            if (r.Count != 1) return;
            List<PropertyInfo> props = entity.GetType().GetProperties().ToList<PropertyInfo>();

            foreach (var prop in props)
            {
                prop.SetValue(entity, prop.GetValue(r[0]));
            }
        }
        public static async Task ExpandNavAsync<Entity>(this Entity entity, params string[] properties) where Entity : BaseEntity, new()
        {
            List<PropertyInfo> props = new List<PropertyInfo>();
            if (properties?.Length > 0)
            {
                foreach (string item in properties)
                {
                    PropertyInfo pInfo = entity.GetType().GetProperty(item);
                    props.Add(pInfo);
                }
            }
            else
            {
                foreach (PropertyInfo property in entity.GetType().GetProperties())
                {
                    if (property.GetCustomAttribute<CPropertyAttribute>().Navigation != null)
                    {
                        props.Add(property);
                    }
                }
            }

            MethodInfo select = typeof(Utils).GetMethod("Select");
            Parallel.ForEach(props, (prop) =>
            {
                string[] navigationAttribute = prop.GetCustomAttribute<CPropertyAttribute>().Navigation?.Split(':');

                string key = (navigationAttribute?.Length == 2) ? navigationAttribute[1] : string.Empty;
                if (string.IsNullOrEmpty(key))
                    return;

                string id = entity.GetType().GetProperty(key).GetValue(entity, null)?.ToString();
                if (id == Guid.Empty.ToString())
                    return;

                Type entityType = entity.GetType().GetProperty(prop.Name).PropertyType;
                //I want to invoke Select method: await Select<Entity>(string id = "")
                MethodInfo generic = select.MakeGenericMethod(entityType);
                object[] args = { id };
                object selectReturn = generic.Invoke(Utils.Instance, args);

                //Select method returns TASK.Resut,  thus "a" is a Task.Result or List<Entity>
                var taskResult = selectReturn.GetType().GetProperty("Result").GetValue(selectReturn); //a is a Task.Result or List<Entity>

                IList elements = (IList)taskResult;
                if (elements.Count > 0)
                {
                    prop.SetValue(entity, elements[0]); 
                }
            });
        }
        public static async Task ExpandAssociationsAsync<Entity>(this Entity entity, params string[] properties) where Entity : BaseEntity, new()
        {
            List<PropertyInfo> props = new List<PropertyInfo>();
            if (properties?.Length > 0)
            {
                foreach (string item in properties)
                {
                    PropertyInfo pInfo = entity.GetType().GetProperty(item);
                    props.Add(pInfo);
                }
            }
            else
            {
                PropertyInfo[] p = entity.GetType().GetProperties();
                foreach (PropertyInfo property in entity.GetType().GetProperties())
                {
                    if (property.GetCustomAttribute<CPropertyAttribute>().Association != null)
                    {
                        props.Add(property);
                    }
                }
            }

            MethodInfo select = typeof(Utils).GetMethod("SelectAssociation");
            Type tThis = entity.GetType();
            Parallel.ForEach(props, (prop) =>
            {
                Type entityType;
                if (entity.GetType().GetProperty(prop.Name).PropertyType.IsGenericType)
                {
                    entityType = entity.GetType().GetProperty(prop.Name).PropertyType.GetGenericArguments().FirstOrDefault().UnderlyingSystemType;
                }
                else return;

                string id = tThis.GetProperty("Id").GetValue(entity, null).ToString();
                if (id == Guid.Empty.ToString())
                    return;

                string attr = tThis.GetProperty(prop.Name).GetCustomAttribute<CPropertyAttribute>()?.Association;
                if (attr.Contains("ERROR")) return;
                string parentColumnName = attr.Split(':')[1];
                parentColumnName = parentColumnName.Substring(0, parentColumnName.Length - 2);

                //I want to invoke Select method
                //Select<Entity>(string id = "")
                MethodInfo generic = select.MakeGenericMethod(entityType);

                object[] args = { id, parentColumnName };
                object selectReturn = generic.Invoke(Utils.Instance, args);
                var taskResult = selectReturn?.GetType().GetProperty("Result")?.GetValue(selectReturn); //a is a Task.Result or List<Entity>
                IList elements = (IList)taskResult;

                if (elements.Count > 0) 
                {
                    prop.SetValue(entity, elements);
                }
            });
        }
    }
}
