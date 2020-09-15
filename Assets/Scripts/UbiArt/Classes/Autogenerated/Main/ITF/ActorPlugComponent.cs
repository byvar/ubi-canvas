using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class ActorPlugComponent : ActorComponent {
		public CArray<Generic<ActorPlugBaseController>> controllers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					controllers = s.SerializeObject<CArray<Generic<ActorPlugBaseController>>>(controllers, name: "controllers");
				}
			}
		}
		public override uint? ClassCRC => 0x6616AC1F;
	}
}

