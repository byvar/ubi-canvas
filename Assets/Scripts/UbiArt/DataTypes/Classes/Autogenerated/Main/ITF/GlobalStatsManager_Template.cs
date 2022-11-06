using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class GlobalStatsManager_Template : TemplateObj {
		public CArrayO<Generic<StatHandler>> Handlers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Handlers = s.SerializeObject<CArrayO<Generic<StatHandler>>>(Handlers, name: "Handlers");
		}
		public override uint? ClassCRC => 0xF6D0FAF9;
	}
}

