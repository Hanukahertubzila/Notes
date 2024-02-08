using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Domain
{
    public interface IServices
    {
        Settings Settings { get; }
        ISaver Saver { get; }
        ILoader Loader { get; }
        string ConfigPath { get; }
    }
}
