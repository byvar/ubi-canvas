using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class Creature_Food : CSerializable {
		[Serialize("type"       )] public Creature_Food type;
		[Serialize("actor2DPath")] public Path actor2DPath;
		[Serialize("actor3DPath")] public Path actor3DPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(type));
			SerializeField(s, nameof(actor2DPath));
			SerializeField(s, nameof(actor3DPath));
		}
		public enum Creature_Food {
			[Serialize("Creature_Food::cookie" )] cookie = 0,
			[Serialize("Creature_Food::pizza"  )] pizza = 1,
			[Serialize("Creature_Food::plum"   )] plum = 2,
			[Serialize("Creature_Food::donut"  )] donut = 3,
			[Serialize("Creature_Food::pancake")] pancake = 4,
		}
	}
}

