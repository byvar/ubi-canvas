using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class ActorSpawnBank_Template : CSerializable {
		public CListO<ActorSpawnBank_Template.ActorSpawnData> list;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			list = s.SerializeObject<CListO<ActorSpawnBank_Template.ActorSpawnData>>(list, name: "list");
		}
		[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.VH | GameFlags.RA)]
		public partial class ActorSpawnData : CSerializable {
			public StringID id;
			public Path path;
			public bool recycle;
			public bool scale;
			public bool flip;
			public int userData;
			public Generic<Event> onSpawnEvent;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				id = s.SerializeObject<StringID>(id, name: "id");
				path = s.SerializeObject<Path>(path, name: "path");
				recycle = s.Serialize<bool>(recycle, name: "recycle");
				scale = s.Serialize<bool>(scale, name: "scale");
				flip = s.Serialize<bool>(flip, name: "flip");
				userData = s.Serialize<int>(userData, name: "userData");
				onSpawnEvent = s.SerializeObject<Generic<Event>>(onSpawnEvent, name: "onSpawnEvent");
			}
		}
	}
}

