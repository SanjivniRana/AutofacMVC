﻿using System;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Transactions;

using AutofacDatatable.Core.Interfaces;

namespace AutofacDatatable.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private TransactionScope transaction;

        public void StartTransaction()
        {
            this.transaction = new TransactionScope();
        }

        public void CommitTransaction()
        {
            this.transaction.Complete();
        }

        public void Dispose()
        {
            this.transaction.Dispose();
        }

        private class TransactionScope
        {
            internal void Complete()
            {
                throw new NotImplementedException();
            }

            internal void Dispose()
            {
                throw new NotImplementedException();
            }
        }
    }
}