using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class RO2_EventLoadMap : Event {
		public PathRef map;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				map = (PathRef)s.SerializeObject<Path>((Path)map, name: "map");
			} else {
				map = s.SerializeObject<PathRef>(map, name: "map");
			}
		}
		public override uint? ClassCRC => 0xA4A0B6EB;
	}
}

