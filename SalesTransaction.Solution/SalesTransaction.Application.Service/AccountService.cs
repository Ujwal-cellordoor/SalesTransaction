using Microsoft.Extensions.Configuration;
using Newtonsoft,Json;
using SalesTransaction.Application.DataAccess;
using SalesTransaction.Application.Model.Account;
using SalesTransaction.Application.Service.Account;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SalesTransaction.Application.Service
{
    public class AccountService : IAccountService
    {
        private DataAccessfile da;
        private readonly int commandTimeout;
        private readonly string connectionString;
        private IConfiguration config;

        public AccountService (IConfiguration configuration)
        {
            config = configuration;

            dynamic connectionString = config;
            connectionString =  
        }
    }
}
namespace SalesTransaction.Application.Service
{
    public class AccountService
    {
    }
}
