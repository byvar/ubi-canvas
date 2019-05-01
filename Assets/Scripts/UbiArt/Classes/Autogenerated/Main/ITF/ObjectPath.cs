using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class ObjectPath : CSerializable {
		[Serialize("levels"  )] public CList<ObjectPath.Level> levels;
		[Serialize("id"      )] public string id;
		[Serialize("absolute")] public bool absolute;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				SerializeField(s, nameof(levels));
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(absolute));
			} else {
				SerializeField(s, nameof(id));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class Level : CSerializable {
			[Serialize("name"  )] public string name;
			[Serialize("parent")] public bool parent;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(parent));
			}
		}
	}
}

