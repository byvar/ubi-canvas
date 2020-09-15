using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class ObjectPath : CSerializable {
		public CList<ObjectPath.Level> levels;
		public string id;
		public bool absolute;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				levels = s.SerializeObject<CList<ObjectPath.Level>>(levels, name: "levels");
				id = s.Serialize<string>(id, name: "id");
				absolute = s.Serialize<bool>(absolute, name: "absolute");
			} else {
				id = s.Serialize<string>(id, name: "id");
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class Level : CSerializable {
			public string name;
			public bool parent;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				name = s.Serialize<string>(name, name: "name");
				parent = s.Serialize<bool>(parent, name: "parent");
			}
		}
	}
}

