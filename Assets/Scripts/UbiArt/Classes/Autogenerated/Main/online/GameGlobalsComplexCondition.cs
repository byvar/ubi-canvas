using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameGlobalsComplexCondition : GameGlobalsCondition {
		public CArrayO<Generic<GameGlobalsCondition>> conditions;
		public bool needAll;
		public uint priority;
		public bool hotReload;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			conditions = s.SerializeObject<CArrayO<Generic<GameGlobalsCondition>>>(conditions, name: "conditions");
			needAll = s.Serialize<bool>(needAll, name: "needAll");
			priority = s.Serialize<uint>(priority, name: "priority");
			hotReload = s.Serialize<bool>(hotReload, name: "hotReload");
		}
		public override uint? ClassCRC => 0x6345EF2B;
	}
}

