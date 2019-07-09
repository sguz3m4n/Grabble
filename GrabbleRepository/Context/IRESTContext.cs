using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grabble.Repository.Context
{
    public partial interface IRestContext
    {

        void Patch();
        void Put();
        void Get();
        void Delete();
    }
}
