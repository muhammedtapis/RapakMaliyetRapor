﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapakMaliyetRapor.Core.UnitOfWork;

public interface IUnitOfWork
{
    Task CommitAsync(); //implemente ettiğimizde  DBContextin saveChangesAsync(); metoduna karşılık gelecek.

    void Commit(); //implemente ettiğimizde  DBContextin saveChanges(); metoduna karşılık gelecek
}