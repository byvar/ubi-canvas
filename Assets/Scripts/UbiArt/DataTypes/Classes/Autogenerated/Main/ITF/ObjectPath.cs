using System.Text;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class ObjectPath : CSerializable {
		public CListO<ObjectPath.Level> levels;
		public string id;
		public bool absolute;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				levels = s.SerializeObject<CListO<ObjectPath.Level>>(levels, name: "levels");
				id = s.Serialize<string>(id, name: "id");
				absolute = s.Serialize<bool>(absolute, name: "absolute");
			} else {
				id = s.Serialize<string>(id, name: "id");
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class Level : CSerializable {
			public string name;
			public bool parent;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				name = s.Serialize<string>(name, name: "name");
				parent = s.Serialize<bool>(parent, name: "parent");
			}
		}

		public override string ToString() {
			StringBuilder b = new();
			b.Append("ObjectPath(");
			if (levels != null) {
				foreach (var l in levels) {
					if (l.parent) {
						b.Append("../");
					} else {
						b.Append(l.name);
						b.Append('/');
					}
				}
			}
			if (id != null) {
				b.Append(id);
			}
			b.Append(", ");
			b.Append(absolute);
			b.Append(')');
			return b.ToString();
		}
	}
}

