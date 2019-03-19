using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GlobalStatsManager_Template : TemplateObj {
		[Serialize("Handlers")] public CArray<Generic<StatHandler>> Handlers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Handlers));
		}
		public override uint? ClassCRC => 0xF6D0FAF9;
	}
}

