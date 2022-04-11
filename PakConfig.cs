using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PakTestWin.Config;

namespace PakTestWin.Config;

public class PakConfig
{
    private string pathToWoW = String.Empty;
    private List<PakConfigActor>? actors = null;

    public string PathToWoW { get => pathToWoW; set => pathToWoW = value; }

    public List<PakConfigActor>? Actors { get => actors; set => actors = value; }
}
