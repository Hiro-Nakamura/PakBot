using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace PakTestWin.Config;

public class PakConfigActor
{
    [JsonInclude]
    public String? Username;

    [JsonInclude]
    public String? Password;

    [JsonInclude]
    public String? Realm;

    [JsonInclude]
    public String? Character;
}
