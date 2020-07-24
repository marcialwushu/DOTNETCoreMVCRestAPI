using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Commander> GetAppCommands();
        Command GetComandById(int id)
    }
}