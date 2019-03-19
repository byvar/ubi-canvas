using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameGlobalsComplexCondition : GameGlobalsCondition {
		[Serialize("conditions")] public CArray<Generic<GameGlobalsCondition>> conditions;
		[Serialize("needAll"   )] public bool needAll;
		[Serialize("priority"  )] public uint priority;
		[Serialize("hotReload" )] public bool hotReload;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(conditions));
			SerializeField(s, nameof(needAll));
			SerializeField(s, nameof(priority));
			SerializeField(s, nameof(hotReload));
		}
		public override uint? ClassCRC => 0x6345EF2B;
	}
}

