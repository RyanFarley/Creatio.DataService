﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Creatio.DataService;
using Newtonsoft.Json;

namespace TestDataService
{
    class Program
    {
        static async Task Main()
        {
            Utils utils = Utils.Instance;
            utils.SetCredentials("Kirill", "111", "https://023879-studio.creatio.com");
            if (await utils.LoginAsync()) {

                Console.WriteLine($"You Logged In as: {utils.CurrentUser.Contact.DisplayValue}");

                var ContactId = utils.CurrentUser.Contact.Value;
                Console.WriteLine($"Your ContactId is: {ContactId}");

                SelectQuery select = BuildContactQuery();
                string jsonRequest = JsonConvert.SerializeObject(select);
                RequestResponse result = await utils.GetResponseAsync(jsonRequest, ActionEnum.SELECT).ConfigureAwait(false);
                DataTable dt = utils.ConvertResponseToDataTable(result.Result);

                Guid.TryParse(ContactId, out Guid contactIdGuid);

                string expression = $"Id = '{contactIdGuid}'";
                DataRow[] row = dt.Select(expression);
                if (row.Length > 0)
                    Console.WriteLine($"\tYour Name is: \t{row[0]["Name"]}");
                    Console.WriteLine($"\tYour Email is: \t{row[0]["Email"]}");
                    Console.WriteLine($"\tYour Phone is: \t{row[0]["Phone"]}");
                    Console.WriteLine($"\tYour Account is: {row[0]["Account"]}");

                Console.ReadLine();
            }

        }

        private static SelectQuery BuildContactQuery() {
            SelectQuery contactQuery = new SelectQuery()
            {
                RootSchemaName = "Contact",
                RowCount = 10,
                RowsOffset = -1,
                QueryKind = Enums.QueryKind.General,
                QuerySource = Enums.QuerySource.Filter,
                UseLocalization = true,
                QueryOptimize = true,
                Columns = new SelectQueryColumns()
                {
                    Items = new Dictionary<string, SelectQueryColumn>()
                    {
                        {
                            "Id", new SelectQueryColumn()
                            {
                                Caption = "Id",
                                OrderDirection = Enums.OrderDirection.Ascending,
                                OrderPosition = 0,
                                Expression = new ColumnExpression()
                                {
                                    ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                                    ColumnPath = "Id"
                                }
                            }
                        },
                        {
                            "Name", new SelectQueryColumn()
                            {
                                Caption = "Name",
                                OrderDirection = Enums.OrderDirection.Ascending,
                                OrderPosition = 0,
                                Expression = new ColumnExpression()
                                {
                                    ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                                    ColumnPath = "Name"
                                }
                            }
                        },
                        {
                            "Email", new SelectQueryColumn()
                            {
                                Caption = "Email",
                                OrderDirection = Enums.OrderDirection.Ascending,
                                OrderPosition = 0,
                                Expression = new ColumnExpression()
                                {
                                    ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                                    ColumnPath = "Email"
                                }
                            }
                        },
                        {
                            "Phone", new SelectQueryColumn()
                            {
                                Caption = "Phone",
                                OrderDirection = Enums.OrderDirection.Ascending,
                                OrderPosition = 0,
                                Expression = new ColumnExpression()
                                {
                                    ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                                    ColumnPath = "Phone"
                                }
                            }
                        },
                        {
                            "Image", new SelectQueryColumn()
                            {
                                Caption = "Image",
                                OrderDirection = Enums.OrderDirection.Ascending,
                                OrderPosition = 0,
                                Expression = new ColumnExpression()
                                {
                                    ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                                    ColumnPath = "Photo.Id"
                                }
                            }
                        },
                        {
                            "Account", new SelectQueryColumn()
                            {
                                Caption = "Account",
                                OrderDirection = Enums.OrderDirection.Ascending,
                                OrderPosition = 0,
                                Expression = new ColumnExpression()
                                {
                                    ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                                    ColumnPath = "Account"
                                }
                            }
                        }
                    }
                }
            };
            return contactQuery;
        }
    }
}