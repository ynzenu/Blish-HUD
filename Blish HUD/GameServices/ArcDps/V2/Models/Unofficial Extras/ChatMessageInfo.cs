using System;

namespace Blish_HUD.GameServices.ArcDps.Models.UnofficialExtras {
    public struct ChatMessageInfo {
        public uint ChannelId { get; set; }

        public ChannelType ChannelType { get; set; }

        public byte Subgroup { get; set; }

        public bool IsBroadcast { get; set; }

        public DateTime TimeStamp { get; set; }

        public string AccountName { get; set; }

        public string CharacterName { get; set; }

        public string Text { get; set; }
    }
}
