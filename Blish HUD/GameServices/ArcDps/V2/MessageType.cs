using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blish_HUD.GameServices.ArcDps.V2 {
    public enum MessageType {
        // ArcDPS
        ImGui = 1,
        CombatEventArea = 2,
        CombatEventLocal = 3,
        // Unofficial Extras
        UserInfo = 4,
        ChatMessage = 5,
    }
}
